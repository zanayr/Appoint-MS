using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public partial class Dashboard : Form
    {
        private string[] _reportsArray = { "Appointment Type by Month", "Appointments by Consultant", "Customers by Country" };
        private string[,] _responsesArray = {
            { "Error, report not created.", "Error, no creolo el informe." },
            { "Report of appointment type by month created: ","Creolo un informe de los tipos de citas por mes: " },
            { "Report of appointments per consultant created: ", "Creolo un informe de las citas por consultor: " },
            { "Report of customers per country created: ", "Creolo un informe de clientes por país: " },
            { "Deleted appointment: ", "Borrolo cita: " },
            { "Deleted customer: ", "Borrolo cliente: " },
            { "Error, no tab of that index exists.", "Error, tableta de eso índece no existe." }
        };
        private enum Responses
        {
            NO_REPORT = 0,
            APPOINTMENT_TYPE_REPORT,
            USER_APPOINTMENTS_REPORT,
            CUSTOMER_REPORT,
            DELETE_APPOINTMENT,
            DELETE_CUSTOMER,
            TAB_ERROR
        }
        
        public Dashboard()
        {
            InitializeComponent();
        }

        private void ToggleDashboard()
        {
            ReportButton.Enabled = !ReportButton.Enabled;
            ReportComboBox.SelectedIndex = 0;
            ReportComboBox.Enabled = !ReportComboBox.Enabled;
            CalendarButton.Enabled = !CalendarButton.Enabled;
            DashboardTabControl.Enabled = !DashboardTabControl.Enabled;
            DeleteButton.Enabled = !DeleteButton.Enabled;
            AddButton.Enabled = !AddButton.Enabled;
            InspectButton.Enabled = !InspectButton.Enabled;
        }
        
        private void AlertUserToNextAppointment(Appointment appointment)
        {
            string[] message =
            {
                "Your next appointment is at " + appointment.StartDate.ToString("h:mm tt") + ". Do you want to view the details? ",
                "Su proxima cita es a las " + appointment.StartDate.ToString("h:mm tt") + ". ¿Quieres ver las detalles?"
            };
            string[] title =
            {
                "Warning",
                "Aviso"
            };
            if (MessageBox.Show(message[Global.Language], title[Global.Language], MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "ACK".PadRight(5) + "APP".PadRight(5) + Convert.ToString(appointment.ID).PadRight(5));

                AppointmentInspector appointmentInspector = new AppointmentInspector(appointment.ID);
                appointmentInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
                appointmentInspector.Show();
                ToggleDashboard();
            }
            else
            {
                ToggleDashboard();
            }
        }

        //  Check for Appointments that are within 15 minutes of log in.
        private void CheckForImmediateAppointments()
        {
            Appointments.GetBy(a => a.User.ID == Users.CurrentUser.ID).ForEach(a =>
            {
                if (a.StartDate.Date == DateTime.Now.Date && a.StartDate <= DateTime.Now.AddMinutes(15))
                {
                    AlertUserToNextAppointment(a);
                }
            });
        }

        private void DeleteAppointment(int id)
        {
            string[] message =
            {
                "Are you sure want to delete appointment " + id + " from the database?",
                "¿Estás seguro que quieres borrar la cita " + id + " del database?"
            };
            string[] title =
            {
                "Warning",
                "Aviso"
            };
            if (MessageBox.Show(message[Global.Language], title[Global.Language], MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Appointments.Remove(Appointments.GetAppointmentBy(a => a.ID == id));
                ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.DELETE_APPOINTMENT), Global.Language] + Convert.ToString(id);
                
                ToggleDashboard();
            }
            else
            {
                ToggleDashboard();
            }

        }

        private void DeleteCustomer(int id)
        {
            string[] message =
            {
                "Are you sure want to delete customer " + id + " from the database?",
                "¿Estás seguro que quieres borrar el cliente " + id + " del database?"
            };
            string[] title =
            {
                "Warning",
                "Aviso"
            };
            if (MessageBox.Show(message[Global.Language], title[Global.Language], MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    Customers.Remove(Customers.GetCustomerBy(c => c.ID == id));
                }
                catch (UnableToDeleteCustomerException e)
                {
                    if (MessageBox.Show(e.Message, title[Global.Language], MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Appointments.GetBy(a => a.Customer.ID == id).ForEach(a =>
                        {
                            Appointments.Remove(Appointments.GetAppointmentBy(p => p.ID == a.ID));
                        });
                        Customers.Remove(Customers.GetCustomerBy(c => c.ID == id));
                        ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.DELETE_CUSTOMER), Global.Language] + Convert.ToString(id);
                    }
                }
                finally
                {
                    ToggleDashboard();
                }
            }
            else
            {
                ToggleDashboard();
            }
        }

        //  Load all information from the data base
        private void LoadData()
        {
            //  Get country information from the database.
            DataTable countryTable = Database.GetDataTable(new MySqlCommand("SELECT * FROM country;"));
            foreach (DataRow field in countryTable.Rows)
            {
                Country country = new Country(Convert.ToInt32(field[0]));
                country.Name = Convert.ToString(field[1]);
                country.CreateDate = Convert.ToDateTime(field[2]).ToLocalTime();
                country.CreateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[3]));
                country.UpdateTimestamp = Convert.ToDateTime(field[4]).ToLocalTime();
                country.UpdateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[5]));
                Countries.AllCountriesList.Add(country);
            }

            //  Get city information from the database.
            DataTable cityTable = Database.GetDataTable(new MySqlCommand("SELECT * FROM city;"));
            foreach (DataRow field in cityTable.Rows)
            {
                City city = new City(Convert.ToInt32(field[0]));
                city.Name = Convert.ToString(field[1]);
                city.Country = Countries.GetCountryBy(c => c.ID == Convert.ToInt32(field[2]));
                city.CreateDate = Convert.ToDateTime(field[3]).ToLocalTime();
                city.CreateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[4]));
                city.UpdateTimestamp = Convert.ToDateTime(field[5]).ToLocalTime();
                city.UpdateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[6]));
                Cities.AllCitiesList.Add(city);
            }

            //  Get address information from the database.
            DataTable addressTable = Database.GetDataTable(new MySqlCommand("SELECT * FROM address;"));
            foreach (DataRow field in addressTable.Rows)
            {
                Address address = new Address(Convert.ToInt32(field[0]));
                address.Address1 = Convert.ToString(field[1]);
                address.Address2 = Convert.ToString(field[2]);
                address.City = Cities.GetCityBy(c => c.ID == Convert.ToInt32(field[3]));
                address.PostalCode = Convert.ToString(field[4]);
                address.Phone = Convert.ToString(field[5]);
                address.CreateDate = Convert.ToDateTime(field[6]).ToLocalTime();
                address.CreateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[7]));
                address.UpdateTimestamp = Convert.ToDateTime(field[8]).ToLocalTime();
                address.UpdateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[9]));
                Addresses.AllAddressList.Add(address);
            }

            //  Get customer information from the database.
            //  NOTE:   Whomever set up the database, has made it so that records
            //          deleted from the customer table do not delete thier rows. So as
            //          a result, the customer table will return rows that are empty.
            //          To protect against this, we will need to include a check in the
            //          SQL command.
            DataTable CustomersTable = Database.GetDataTable(new MySqlCommand(("SELECT * FROM customer WHERE customerName IS NOT NULL;")));
            foreach (DataRow field in CustomersTable.Rows)
            {
                Customer customer = new Customer(Convert.ToInt32(field[0]));
                customer.Name = Convert.ToString(field[1]);
                customer.Address = Addresses.GetAddressBy(a => a.ID == Convert.ToInt32(field[2]));
                customer.CityName = customer.Address.City.Name;
                customer.CountryName = customer.Address.City.Country.Name;
                customer.Active = Convert.ToBoolean(field[3]);
                customer.CreateDate = Convert.ToDateTime(field[4]).ToLocalTime();
                customer.CreateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[5]));
                customer.UpdateTimestamp = Convert.ToDateTime(field[6]).ToLocalTime();
                customer.UpdateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[7]));
                Customers.AllCustomersList.Add(customer);
            }

            //  Get appointment information from the appointment table.
            DataTable AppointmentsTable = Database.GetDataTable(new MySqlCommand("SELECT * FROM appointment;"));
            foreach (DataRow field in AppointmentsTable.Rows)
            {
                Appointment appointment = new Appointment(Convert.ToInt32(field[0]));
                int foo = Convert.ToInt32(field[1]);
                appointment.Customer = Customers.GetCustomerBy(c => c.ID == Convert.ToInt32(field[1]));
                appointment.User = Users.GetUserBy(u => u.ID == Convert.ToInt32(field[2]));
                appointment.Title = Convert.ToString(field[3]);
                appointment.Description = Convert.ToString(field[4]);
                appointment.Location = Convert.ToString(field[5]);
                appointment.Contact = appointment.Customer.Address.Phone;
                appointment.Type = Convert.ToString(field[7]);
                appointment.URL = Convert.ToString(field[8]);
                appointment.StartDate = Convert.ToDateTime(field[9]).ToLocalTime();
                appointment.EndDate = Convert.ToDateTime(field[10]).ToLocalTime();
                appointment.CreateDate = Convert.ToDateTime(field[11]).ToLocalTime();
                appointment.CreateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[12]));
                appointment.UpdateTimestamp = Convert.ToDateTime(field[13]).ToLocalTime();
                appointment.UpdateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[14]));
                Appointments.AllAppointmentsList.Add(appointment);
            }
        }

        private void OpenInspector()
        {
            int id;
            switch (DashboardTabControl.SelectedIndex)
            {
                case 0:
                    id = Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value);

                    Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "INS".PadRight(5) + "APP".PadRight(5) + Convert.ToString(id).PadRight(5));

                    AppointmentInspector appointmentInspector = new AppointmentInspector(id);
                    appointmentInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
                    appointmentInspector.Show();
                    break;
                case 1:
                    id = Convert.ToInt32(CustomersDataGridView.CurrentRow.Cells[0].Value);

                    Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "INS".PadRight(5) + "CUS".PadRight(5) + Convert.ToString(id).PadRight(5));

                    CustomerInspector customerInspector = new CustomerInspector(id);
                    customerInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
                    customerInspector.Show();
                    break;
                default:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.TAB_ERROR), Global.Language];
                    break;
            }
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadData();

            //  Set up DataGridViews.
            AppointmentsDataGridView.DataSource = Appointments.AllAppointmentsList;
            CustomersDataGridView.DataSource = Customers.AllCustomersList;

            //  Set up the reports menu.
            ReportComboBox.DataSource = _reportsArray;
            ReportComboBox.SelectedIndex = 0;

            //  Set up the 15 minute reminder timer.
            App15Reminder.Tick += App15Reminder_Tick;
            App15Reminder.Start();

            //  Check for Appointments that are within 15 minutes of log in.
            CheckForImmediateAppointments();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "REP".PadRight(5) + Convert.ToString(ReportComboBox.SelectedIndex).PadRight(5));

            switch (ReportComboBox.SelectedIndex)
            {
                case 0:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.APPOINTMENT_TYPE_REPORT), Global.Language] + Report.AppointmentTypeByMonth();
                    break;
                case 1:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.USER_APPOINTMENTS_REPORT), Global.Language] + Report.AppointmentsByUser();
                    break;
                case 2:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.CUSTOMER_REPORT), Global.Language] + Report.CustomersByCountry();
                    break;
                default:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.NO_REPORT), Global.Language];
                    break;
            }
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            ToggleDashboard();
            CalendarInspector calendarInspector = new CalendarInspector();
            calendarInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
            calendarInspector.Show();
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ToggleDashboard();
            switch (DashboardTabControl.SelectedIndex)
            {
                case 0:
                    DeleteAppointment(Convert.ToInt32(AppointmentsDataGridView.CurrentRow.Cells[0].Value));
                    break;
                case 1:
                    DeleteCustomer(Convert.ToInt32(CustomersDataGridView.CurrentRow.Cells[0].Value));
                    break;
                default:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.TAB_ERROR), Global.Language];
                    break;
            }
        }

        private void Inspector_Closed(object sender, FormClosedEventArgs e)
        {
            ToggleDashboard();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ToggleDashboard();
            switch (DashboardTabControl.SelectedIndex)
            {
                case 0:
                    Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "NEW".PadRight(5) + "APP".PadRight(5));

                    AppointmentInspector appointmentInspector = new AppointmentInspector();
                    appointmentInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
                    appointmentInspector.Show();
                    break;
                case 1:
                    Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "NEW".PadRight(5) + "CUS".PadRight(5));

                    CustomerInspector customerInspector = new CustomerInspector();
                    customerInspector.FormClosed += new FormClosedEventHandler(Inspector_Closed);
                    customerInspector.Show();
                    break;
                default:
                    ResponseLabel.Text = _responsesArray[Convert.ToInt32(Responses.TAB_ERROR), Global.Language];
                    break;
            }
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            ToggleDashboard();
            OpenInspector();
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ToggleDashboard();
            OpenInspector();
        }

        private void App15Reminder_Tick(object sender, EventArgs e)
        {
            //  I'm using a double lambda function here! To replace the code below. vvv
            //  Look how hard that is to under stand what's going on!
            Appointments.GetBy(a => a.User.ID == Users.CurrentUser.ID).ForEach(a =>
            {
                if (a.StartDate.Date == DateTime.Now.Date && a.StartDate.Truncate(TimeSpan.TicksPerSecond) == DateTime.Now.Truncate(TimeSpan.TicksPerSecond))
                {
                    AlertUserToNextAppointment(a);
                }
            });
            /*
            foreach (Appointment appointment in Appointments.GetBy())
            {
                DateTime now = DateTime.Now;
                if (new DateTime(appointment.StartDate.Year, appointment.StartDate.Month, appointment.StartDate.Day, appointment.StartDate.Hour, appointment.StartDate.Minute, 0) == new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0).AddMinutes(15))
                {
                    NextAppointmentWarningMessage(appointment);
                }
            }
            */
        }

        private void Dashboard_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "OUT".PadRight(5));

                Application.Exit();
            }
        }
    }
}