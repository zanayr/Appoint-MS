using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace c969_Fickenscher
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //  Set Application location.
            IPLocation.Set();

            //  Attempt to start probgram.
            try
            {
                DataTable userTable = Database.GetDataTable(new MySqlCommand("SELECT * FROM user WHERE userId = 1;"));
                
                if (userTable.Rows.Count < 1)
                {
                    string[] message = {
                        "Database is missing the originating user, ID: 1",
                        "El base de data se falta el usario originario, ID: 1"
                    };
                    throw new DatabaseException(message[Global.Language]);
                }
                else
                {
                    User user = new User(Convert.ToInt32(userTable.Rows[0][0]));
                    user.Name = Convert.ToString(userTable.Rows[0][1]);
                    user.Password = Convert.ToString(userTable.Rows[0][2]);
                    user.Active = Convert.ToBoolean(userTable.Rows[0][3]);
                    user.CreateDate = Convert.ToDateTime(userTable.Rows[0][5]).Date;
                    user.CreateBy = user;
                    user.UpdateTimestamp = Convert.ToDateTime(userTable.Rows[0][6]);
                    user.UpdateBy = user;
                    Users.AllUserLists.Add(user);

                    LogIn login = new LogIn();
                    login.Show();
                    Application.Run();
                }
            }
            catch (DatabaseException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
