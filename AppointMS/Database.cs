using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace c969_Fickenscher
{
    public class DatabaseException : Exception
    {
        public DatabaseException()
        {

        }

        public DatabaseException(string message)
            : base(message)
        {

        }

        public DatabaseException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }

    public static class Database
    {
        // Connection String and Get accessor.
        private static string ConnectionString { get; } = "SERVER=52.206.157.109;DATABASE=U05L3V;Uid=U05L3V;Pwd=53688533236;SslMode=None;Convert Zero Datetime=True";

        //  Return a connection string to the database.
        public static MySqlConnection Connection(MySqlCommand command)
        {
            string[] message =
            {
                "There is an error connecting to the database.",
                "Hay un error con la conexión al database."
            };
            try
            {
                if (command.Connection == null)
                {
                    MySqlConnection connection = new MySqlConnection(ConnectionString);
                    connection.Open();
                    command.Connection = connection;
                    return connection;
                }
            }
            catch
            {
                MessageBox.Show(message[Global.Language], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return command.Connection;
        }

        //  Execute a database query
        public static int ExecuteQuery(MySqlCommand command)
        {
            MySqlConnection connection = Connection(command);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //  Execute a database scalar query. (returns a single value in a single row)
        public static object ExecuteScalar(MySqlCommand command)
        {
            MySqlConnection connection = Connection(command);
            try
            {
                return command.ExecuteScalar();
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        //  Return a datatable object from an SQL command.
        public static DataTable GetDataTable(MySqlCommand command)
        {
            MySqlConnection connection = Connection(command);
            try
            {
                DataTable result = new DataTable();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(result);
                }
                return result;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
