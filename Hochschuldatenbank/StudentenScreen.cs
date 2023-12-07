using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hochschuldatenbank
{
    public partial class StudentenScreen : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patri\OneDrive\Dokumente\Personendatenbank.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True"); 
        
        public StudentenScreen()
        {
            InitializeComponent();
            connection.Open();

            string query = "select * from Studierende";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);

            DataSet dataset = new DataSet();
            sqlAdapter.Fill(dataset);

            GridViewStudent.DataSource = dataset.Tables[0];
            GridViewStudent.Columns[0].Visible = false;

            connection.Close();
        }

        private void btnBackToMainMenue_Click(object sender, EventArgs e)
        {
            MainMenueScreen mainMenueScreen = new MainMenueScreen();
            mainMenueScreen.Show();
            this.Hide();
        }

        private void txtBoxStudentVorname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
