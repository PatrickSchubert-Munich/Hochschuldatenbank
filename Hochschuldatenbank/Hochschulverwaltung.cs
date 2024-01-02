using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accessibility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hochschuldatenbank
{
    /// <summary>
    /// These class manage the Hochschulverwaltung Screen
    /// </summary>
    public partial class Hochschulverwaltung : Form
    {
        // Properties and Fields
        private DB DataBase { get; } 
        private SqlConnection connection { get; }
        private int lastSelectedKursID = 0;
        private int lastSelectedMatrNr = 0;
        private int lastSelectedSemester = 0;

        public Hochschulverwaltung() // constructor
        {
            DataBase = new DB();
            connection = DataBase.DataBaseConnection();
            InitializeComponent();
            // fill comboBoxes with data
            FillComboData();
            // ClearAllFieldsVerwaltung();
            // Show DatGridView
            ShowVerwaltung();
        }

        /// <summary>
        /// This function is for changing Screen to StudentenScreen()
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnStudenten_Click(object sender, EventArgs e)
        {
            StudentenScreen studentenScreen = new StudentenScreen();
            studentenScreen.Show();
            this.Hide();
        }

        /// <summary>
        /// This function is for changing Screen to DozentenScreen()
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnDozenten_Click(object sender, EventArgs e)
        {
            DozentenScreen dozentenScreen = new DozentenScreen();
            dozentenScreen.Show();
            this.Hide();
        }

        /// <summary>
        /// This function is for changing Screen to KurseScreen()
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnKurseMainMenue_Click(object sender, EventArgs e)
        {
            KurseScreen kurseScreen = new KurseScreen();
            kurseScreen.Show();
            this.Hide();
        }

        /// <summary>
        /// This method saves data into database.
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnVerwaltungSpeichern_Click(object sender, EventArgs e)
        {
            // check, if there is data in comboBoxes on Screen
            if (comboBoxVerwaltungKursID.Text == string.Empty ||
                comboBoxVerwaltungMatrNr.Text == string.Empty ||
                comboBoxVerwaltungPersNr.Text == string.Empty ||
                comboBoxVerwaltungSemester.Text == string.Empty)
            {
                MessageBox.Show("Bitte Wähle alle Felder aus, um eine eindeutige Zuordnung zu gewährleisten!");
                return;
            }

            // Parse Text (string) explicitly to integer
            int verwaltungKursID = int.Parse(comboBoxVerwaltungKursID.Text);
            int verwaltungMatrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            int verwaltungPersNr = int.Parse(comboBoxVerwaltungPersNr.Text);
            int verwaltungSemester = int.Parse(comboBoxVerwaltungSemester.Text);

            // SQL-Query: fill data in table Dozenten
            string query = string.Format("INSERT INTO KursTeilnahmen VALUES('{0}', '{1}', '{2}', '{3}');",
                verwaltungKursID, verwaltungMatrNr, verwaltungSemester, verwaltungPersNr);

            // Ececute Query
            DataBase.DataBaseExecuteQuery(query, connection);
            
            //ClearAllFieldsVerwaltung();
            
            // Show actual data
            ShowVerwaltung();
        }

        /// <summary>
        /// This method deletes data from database.
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnVerwaltungLoeschen_Click(object sender, EventArgs e)
        {
            // check, if there is row selected on Screen in DataGridView
            if (lastSelectedKursID != 0 &&
                lastSelectedMatrNr != 0 &&
                lastSelectedSemester != 0)
            {
                // SQL-Query: delete data in SQL database in tbale KursTeilnahmen
                string query = string.Format("DELETE FROM KursTeilnahmen WHERE KursID = {0}" +
                                             "AND Matrikelnummer = {1}" +
                                             "AND Semester = {2};",
                                             lastSelectedKursID, lastSelectedMatrNr, lastSelectedSemester);
                
                // Execute query
                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte zuerst eine Zeile aus der Datenbank auswählen!");
                return;
            }

            // ClearAllFieldsVerwaltung();
            
            // Show actual data
            ShowVerwaltung();
        }

        /// <summary>
        /// This method should choose actual data which is clicked by user (row).
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void GridViewVerwaltung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // choose row in DataGridView and display these data as text in GridView
            comboBoxVerwaltungKursID.Text = GridViewVerwaltung.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxVerwaltungMatrNr.Text = GridViewVerwaltung.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxVerwaltungSemester.Text = GridViewVerwaltung.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxVerwaltungPersNr.Text = GridViewVerwaltung.SelectedRows[0].Cells[3].Value.ToString();

            // Parse text data (string) into integer
            lastSelectedKursID = int.Parse(comboBoxVerwaltungKursID.Text);
            lastSelectedMatrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            lastSelectedSemester = int.Parse(comboBoxVerwaltungSemester.Text);
        }

        /// <summary>
        /// This method makes possible to show all data from database in table KursTeilnahmen.
        /// </summary>
        void ShowVerwaltung()
        {
            string query = "SELECT * FROM KursTeilnahmen;";
            var dataset = DataBase.DataBaseShowData(query, connection);
            GridViewVerwaltung.DataSource = dataset.Tables[0];
            GridViewVerwaltung.Columns[0].Visible = true;
        }

        /// <summary>
        /// This method should fill ComboBoxes with actual data from database.
        /// </summary>
        void FillComboData()
        {
            // initialize List with tables and empty Lists to fill with appropriate data
            var tableNames = new List<string> { "Dozenten", "Kurse", "Studierende" };
            List<string> comboDataPersonalnummer = new List<string>();
            List<string> comboDataKursID = new List<string>();
            List<string> comboDataMatrikelnummer = new List<string>();
            List<string> comboDataSemester = new List<string>();

            foreach (var tableName in tableNames)
            {
                // SQL-Query 
                string query = $"SELECT * FROM {tableName}";
                // data from database as DataTable
                var dataTable = DataBase.DataBaseShowData(query, connection).Tables[0];

                // check, if there is data in table
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // check which table is currently in loop
                        switch (tableName)
                        {   
                            // table Dozenten
                            case "Dozenten":
                                // write data from table Dozenten, column Personalnummer in appropriate List
                                comboDataPersonalnummer.Add(row["Personalnummer"].ToString());
                                break;
                            // table Kurse
                            case "Kurse":
                                // write data from table Kurse, column KursID in appropriate List
                                comboDataKursID.Add(row["KursID"].ToString());
                                // write data from table Kurse, column Semester in appropriate List
                                comboDataSemester.Add(row["Semester"].ToString());
                                break;
                            // table Studierende
                            case "Studierende":
                                // write data from table Studierende, column Matrikelnummer in appropriate List
                                comboDataMatrikelnummer.Add(row["Matrikelnummer"].ToString());
                                break;
                            // default case
                            default:
                                Console.WriteLine("There is no match!");
                                break;
                        }
                    }
                }
            }
            // fill actual data from lists in appropriate ComboBoxes
            comboBoxVerwaltungPersNr.DataSource = comboDataPersonalnummer;
            comboBoxVerwaltungKursID.DataSource = comboDataKursID;
            comboBoxVerwaltungSemester.DataSource = comboDataSemester;
            comboBoxVerwaltungMatrNr.DataSource = comboDataMatrikelnummer;
        }

        /// <summary>
        /// This method deletes all Text information in ComboBoxes on Screen.
        /// Currently not used!
        /// </summary>
        private void ClearAllFieldsVerwaltung()
        {   
            // write an empty string into ComboBoxes
            comboBoxVerwaltungKursID.Text = string.Empty;
            comboBoxVerwaltungMatrNr.Text = string.Empty;
            comboBoxVerwaltungSemester.Text = string.Empty;
            comboBoxVerwaltungPersNr.Text = string.Empty;
        }

        /// <summary>
        /// This method provides updating data in database.
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnVerwaltungBearbeiten_Click(object sender, EventArgs e)
        {
            // Parse Text data from ComboBoxes to integer values
            int kursId = int.Parse(comboBoxVerwaltungKursID.Text);
            int matrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            int semester = int.Parse(comboBoxVerwaltungSemester.Text);
            int persNr = int.Parse(comboBoxVerwaltungPersNr.Text);

            // SQL-Query for Updating data in database
            string query = string.Format("UPDATE KursTeilnahmen SET KursID='{0}'," +
                                         "Matrikelnummer='{1}', Semester='{2}'," +
                                         "Personalnummer='{3}' WHERE KursID = {4}" +
                                         "AND Matrikelnummer = {5};",
                                         kursId, matrNr, semester, persNr,
                                         lastSelectedKursID, lastSelectedMatrNr);

            // Execute SQL-Query
            DataBase.DataBaseExecuteQuery(query, connection);
            // Show actual data
            ShowVerwaltung();
        }
    }
}
