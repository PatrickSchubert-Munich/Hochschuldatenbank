using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hochschuldatenbank
{
    internal class DB
    {
        public SqlConnection SqlConnection()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patri\OneDrive\Dokumente\VaWi\C_Sharp\Hochschuldatenbank\Datenbank\Personendatenbank.mdf;Integrated Security=True;Connect Timeout=30");
            return connection;
        }
    }
}
