using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);
            DataSet dataset = new DataSet();
            sqlAdapter.Fill(dataset);
            connection.Close();
            return dataset;
        }

        public void DataBaseExecuteQuery(string query, SqlConnection connection)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
