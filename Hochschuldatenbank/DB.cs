using Microsoft.Data.SqlClient;
using System.Data;

namespace Hochschuldatenbank
{
    internal class DB
    {
        public SqlConnection DataBaseConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patri\OneDrive\Dokumente\VaWi\C_Sharp\Hochschuldatenbank\Datenbank\Personendatenbank.mdf;Integrated Security=True;Connect Timeout=30");
            return connection;
        }

        public DataSet DataBaseShowData(string query, SqlConnection connection)
        {
            // try-catch neccessary, if there get something wrong with connection
            try
            {
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);
                // open and close DB-Connection automatically
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
