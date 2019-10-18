using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class LogInException : Exception
    {
        public LogInException()
        {

        }

        public LogInException(string message)
            : base(message)
        {

        }

        public LogInException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            GreetingMessage();
        }

        //  Set up the initial greeting message.
        private void GreetingMessage()
        {
            string[] message = {
                        "Please, Enter your log in information.",
                        "Por favor, entra su información de log in."
                    };
            ResponseLabel.Text = message[Global.Language];
            ResponseLabel.ForeColor = Color.Blue;

            //  !!! FOR PORTFOLIO PURPOSES ONLY
            UserNameField.Text = "Ryan Fickenscher";
            PasswordField.Text = "test";
        }

        //  Check the log in information text fields to make sure that they are full.
        private bool checkFields()
        {
            if (UserNameField.Text.Length > 0 && PasswordField.Text.Length > 0)
            {
                return true;
            }
            return false;
        }

        //  Load all users from the database.
        //  NOTE:   Who ever made the SQL database reversed the CreateBy and
        //          CreateDate columns.
        private void LoadUsers()
        {
            DataTable usersTable = Database.GetDataTable(new MySqlCommand("SELECT * FROM user WHERE userId <> 1;"));
            foreach (DataRow field in usersTable.Rows)
            {
                User user = new User(Convert.ToInt32(field[0]));
                user.Name = Convert.ToString(field[1]);
                user.Password = Convert.ToString(field[2]);
                user.Active = Convert.ToBoolean(field[3]);
                user.CreateDate = Convert.ToDateTime(field[5]).ToLocalTime();
                user.CreateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[4]));
                user.UpdateTimestamp = Convert.ToDateTime(field[6]).ToLocalTime();
                user.UpdateBy = Users.GetUserBy(u => u.Name == Convert.ToString(field[7]));
                Users.AllUserLists.Add(user);

                
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            LoadUsers();
            GreetingMessage();
        }
        
        //  Prevent the user from being able to log in without entering
        //  log in information.
        private void LogInFields_TextChanged(object sender, EventArgs e)
        {
            if (checkFields())
            {
                LogInButton.Enabled = true;
            }
            else
            {
                LogInButton.Enabled = false;
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  Check for a matching password and user name.
                if (Users.SearchBy(u => u.Name == UserNameField.Text) && PasswordField.Text == Users.GetUserBy(u => u.Name == UserNameField.Text).Password)
                {
                    Users.CurrentUser = Users.GetUserBy(u => u.Name == UserNameField.Text);

                    Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + Convert.ToString(Users.CurrentUser.ID).PadRight(5) + "LGN".PadRight(5) + "PSW".PadRight(5) + Users.CurrentUser.ObscurePassword().PadRight(30));
                    
                    Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    Close();
                }
                else
                {
                    string[] message = {
                        "Incorrect log in information.",
                        "La información de log in está incorrecta"
                    };
                    Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "LGN".PadRight(5) + "FLD".PadRight(5));
                    throw new LogInException(message[Global.Language]);
                }
            }
            catch (LogInException ex)
            {
                ResponseLabel.Text = ex.Message;
                ResponseLabel.ForeColor = Color.Red;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Report.UserActivity(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ffff").PadRight(30) + "USR".PadRight(5) + "CNL".PadRight(5));

            Close();
            Application.Exit();
        }
    }
}
