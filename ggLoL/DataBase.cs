using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ggLoL
{
    class DataBase
    {
        private SqlConnection connection;

        public DataBase()
        {
            connection = new SqlConnection(
                "Data Source=db.jcases.iessv.es, 1433;" +
                "Initial Catalog = jcases_gglol;" +
                "User ID = jcases_sign;" +
                "Password = v4RYJ4b3rSYnCWA8;" +
                "Connect Timeout=5;");
        }
        ~DataBase() { }

        private void TryConnection(string command)
        {
            int users = 0;

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(command, connection);
                users = cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exp) { MessageBox.Show(exp.Message); }

            if (users > 0)
                MessageBox.Show("Connection ok.");
            else
                MessageBox.Show("Error connecting to the database");
        }
        public void SignIn(string username, string password, string email )
        {
            string command = "INSERT INTO users VALUES "+
               "('" + username + "','"+
               password + "','"+
               email + "');";

            TryConnection(command);
        }

        public void Login(string username, string password)
        {
            string command = "SELECT * FROM users "+ 
                "WHERE username = '" + username + "'" + 
                "AND password = '" + password + "';";

            TryConnection(command);
        }
    }
}
