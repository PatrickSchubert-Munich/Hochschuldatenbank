using Microsoft.Data.SqlClient;
using System.Data;

namespace Hochschuldatenbank
{
    internal class DB
    {
        /// <summary>
        /// This method should build a connection to SQL database
        /// </summary>
        /// <returns>The connection to the database</returns>
        public SqlConnection DataBaseConnection()
        {   
            // Connection to Database with help of Connection String
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patri\OneDrive\Dokumente\VaWi\C_Sharp\Hochschuldatenbank\Datenbank\Personendatenbank.mdf;Integrated Security=True;Connect Timeout=30");
            return connection;
        }

        /// <summary>
        /// This method should give data from SQL tables.
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="connection">connection string</param>
        /// <returns>The data of SQL table</returns>
        public DataSet DataBaseShowData(string query, SqlConnection connection)
        {
            // try-catch neccessary, if there get something wrong with connection
            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);
                // using - statement for open and close DB-Connection automatically
                using (sqlAdapter)
                {
                    DataSet dataset = new DataSet();
                    sqlAdapter.Fill(dataset);
                    return dataset;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return null!;
            }
        }

        /// <summary>
        /// This method should execute SQL command.
        /// </summary>
        /// <param name="query">SQL query</param>
        /// <param name="connection">connection string</param>
        public void DataBaseExecuteQuery(string query, SqlConnection connection)
        {
            // try-catch neccessary, if there get something wrong with connection
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
