using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public partial class AppointmentInspector : Form
    {
        private bool _isUpdate;
        private int _appointmentID;

        //  New appointment constructor.
        public AppointmentInspector()
        {
            InitializeComponent();
            _isUpdate = false;
        }

        //  Existing appointment constructor.
        public AppointmentInspector(int id)
        {
            InitializeComponent();
            _isUpdate = true;
            _appointmentID = id;
        }
        
        private bool CheckInspectorFields()
        {
            if (TitleField.Text.Length > 0 && DescriptionField.Text.Length > 0 && URLField.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        //  Prevent the entry of empty fields into the database
        private void ToggleOkButton()
        {
            if (CheckInspectorFields())
            {
                OkButton.Enabled = true;
            }
            else
            {
                OkButton.Enabled = false;
            }
        }

        private DateTime ToNext30(DateTime date)
        {
            DateTime next30;
            if (date.Minute > 30)
            {
                date = date.AddHours(1);
                next30 = new DateTime(date.Year, date.Month, date.Day, date.Hour, 0, 0);
            }
            else
            {
                next30 = new DateTime(date.Year, date.Month, date.Day, date.Hour, 30, 0);
            }
            return next30;
        }

        private void OperationHoursAlert()
        {
            string[] message =
            {
                "The selected date and time for this appointment is not during your office's business hours.",
                "La fecha y hora escogida no son durantes las horas de trabajo en su oficina para esta cita."
            };
            string[] title =
            {
                "Warning",
                "Aviso"
            };
            MessageBox.Show(message[Global.Language], title[Global.Language], MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void SchedulingConflictAlert()
        {
            string[] message =
            {
                "The selected date and time for this appointment conflicts with another of your appointments. Please, choose another date or time.",
                "La fecha y hora escogida para esta cita conflictan con otra cita tuya. Por favor, escogió otra fecha o hora."
            };
            string[] title =
            {
                "Warning",
                "Aviso"
            };
            MessageBox.Show(message[Global.Language], title[Global.Language], MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private Appointment BuildAppointment(DateTime timestamp)
        {
            Appointment appointment;

            if (_isUpdate)
            {
                appointment = Appointments.GetAppointmentBy(a => a.ID == Convert.ToInt32(AppointmentIDField.Text));
                //  We do not update the create date or creat by.
                appointment.UpdateTimestamp = timestamp;
                appointment.UpdateBy = Users.CurrentUser;
            }
            else
            {
                appointment = new Appointment(Appointments.GetNextID());
                appointment.CreateDate = timestamp;
                appointment.CreateBy = Users.CurrentUser;
                appointment.UpdateTimestamp = timestamp;
                appointment.UpdateBy = Users.CurrentUser;
            }
            appointment.Customer = Customers.GetCustomerBy(c => c.ID == Convert.ToInt32(CustomerDropList.SelectedValue));
            appointment.User = Users.GetUserBy(u => u.ID == Convert.ToInt32(UserDropList.SelectedValue));
            appointment.Title = TitleField.Text;
            appointment.Description = DescriptionField.Text;
            appointment.Location = Convert.ToString(LocationDropList.SelectedValue);
            appointment.Contact = ContactField.Text;
            appointment.Type = Convert.ToString(TypeDropList.SelectedValue);
            appointment.URL = URLField.Text;
            appointment.StartDate = Convert.ToDateTime(StartDatePicker.Value.ToString("yyyy-MM-dd") + " " + StartTimePicker.Value.ToString("HH:mm:ss"));
            appointment.EndDate = Convert.ToDateTime(EndDatePicker.Value.ToString("yyyy-MM-dd") + " " + EndTimePicker.Value.ToString("HH:mm:ss"));

            return appointment;
        }

        private void AppointmentInspector_Load(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                Appointment appointment = Appointments.GetAppointmentBy(a => a.ID == _appointmentID);
                AppointmentIDField.Text = Convert.ToString(appointment.ID);
                CustomerDropList.DataSource = Customers.AllCustomersList;
                CustomerDropList.ValueMember = "ID";
                CustomerDropList.DisplayMember = "Name";
                CustomerDropList.SelectedItem = appointment.Customer;
                UserDropList.DataSource = Users.AllUserLists;
                UserDropList.ValueMember = "ID";
                UserDropList.DisplayMember = "Name";
                UserDropList.SelectedItem = appointment.User;
                TitleField.Text = appointment.Title;
                DescriptionField.Text = appointment.Description;
                URLField.Text = appointment.URL;
                ContactField.Text = appointment.Contact;
                TypeDropList.DataSource = Appointments.TypeArray;
                TypeDropList.SelectedIndex = Array.IndexOf(Appointments.TypeArray, appointment.Type);
                LocationDropList.DataSource = Appointments.LocationArray;
                LocationDropList.SelectedIndex = Array.IndexOf(Appointments.LocationArray, appointment.Location);
                StartDatePicker.Value = appointment.StartDate;
                StartTimePicker.Value = appointment.StartDate;
                EndDatePicker.Value = appointment.EndDate;
                EndTimePicker.Value = appointment.EndDate;
                DateCreatedField.Text = appointment.CreateDate.Date.ToString("MM/dd/yyyy"); ;
                CreatedByField.Text = appointment.CreateBy.Name;
                DateUpdatedField.Text = appointment.UpdateTimestamp.ToString("MM/dd/yyyy HH:mm:ss");
                UpdatedByField.Text = appointment.UpdateBy.Name;
            }
            else
            {
                CustomerDropList.DataSource = Customers.AllCustomersList;
                CustomerDropList.ValueMember = "ID";
                CustomerDropList.DisplayMember = "Name";
                CustomerDropList.SelectedIndex = 0;
                UserDropList.DataSource = Users.AllUserLists;
                UserDropList.ValueMember = "ID";
                UserDropList.DisplayMember = "Name";
                UserDropList.SelectedItem = Users.CurrentUser;
                ContactField.Text = Customers.GetCustomerBy(c => c.ID == Convert.ToInt32(CustomerDropList.SelectedValue)).Address.Phone;
                TypeDropList.DataSource = Appointments.TypeArray;
                TypeDropList.SelectedIndex = 0;
                LocationDropList.DataSource = Appointments.LocationArray;
                LocationDropList.SelectedIndex = 0;
                StartDatePicker.Value = ToNext30(DateTime.Now);
                StartTimePicker.Value = ToNext30(DateTime.Now);
                DateCreatedField.Visible = false;
                DateCreatedLabel.Visible = false;
                CreatedByField.Visible = false;
                CreatedByLabel.Visible = false;
                DateUpdatedField.Visible = false;
                DateUpdatedLabel.Visible = false;
                UpdatedByField.Visible = false;
                UpdatedByLabel.Visible = false;
            }

            CustomerDropList.SelectedIndexChanged += CustomerDropList_SelectedIndexChanged;
            ToggleOkButton();
        }

        private void EditableFields_TextChange(object sender, EventArgs e)
        {
            ToggleOkButton();
        }

        //  Update the phone number when a different customer is selected.
        private void CustomerDropList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContactField.Text = Customers.GetCustomerBy(c => c.ID == Convert.ToInt32(CustomerDropList.SelectedValue)).Address.Phone;
        }

        //  Update the end date and time's minimums and values.
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDatePicker.MinDate = StartDatePicker.Value.AddMinutes(1);
            EndDatePicker.Value = StartDatePicker.Value.AddMinutes(30);
        }

        private void StartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndTimePicker.MinDate = StartTimePicker.Value.AddMinutes(1);
            EndTimePicker.Value = StartTimePicker.Value.AddMinutes(30);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DateTime start = Convert.ToDateTime(StartDatePicker.Value.ToString("yyyy-MM-dd") + " " + StartTimePicker.Value.ToString("HH:mm:ss"));
            DateTime end = Convert.ToDateTime(EndDatePicker.Value.ToString("yyyy-MM-dd") + " " + EndTimePicker.Value.ToString("HH:mm:ss"));
            //  Check if the appointment's start and end dates are
            //  within business hours.
            if (start.TimeOfDay.Ticks < Global.OperationHours[0] || end.TimeOfDay.Ticks > Global.OperationHours[1])
            {
                OperationHoursAlert();
            }
            else
            {
                //  Check if the appointment's start and end dates do not conflict with
                //  other appointments by the user.
                if (Appointments.Conflict(Users.GetUserBy(u => u.ID == Convert.ToInt32(UserDropList.SelectedValue)), start, end))
                {
                    SchedulingConflictAlert();
                }
                else
                {
                    if (_isUpdate)
                    {
                        Appointments.Update(BuildAppointment(DateTime.Now));
                    }
                    else
                    {
                        Appointments.Insert(BuildAppointment(DateTime.Now));
                    }
                    Close();
                }
            }
        }

        private void CustomerInspectorCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
