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
using System.Windows.Forms.VisualStyles;
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
        private int lastSelectedPersNr = 0;

        /// <summary>
        /// This is the constructor of this class
        /// </summary>
        public Hochschulverwaltung() 
        {
            DataBase = new DB();
            connection = DataBase.DataBaseConnection();
            InitializeComponent();
            InitializeCombobox();
            // fill comboBoxes with data
            FillComboData();
            // Show DatGridView
            ShowVerwaltung();

        }

        /// <summary>
        /// This method initialize method comboBox KursBezeichnung.
        /// If content in comboBox changes through user, method will
        /// call
        /// </summary>
        void InitializeCombobox()
        {
            comboBoxVerwaltungKursBez.SelectedText += comboBoxVerwaltungKursBez_SelectedIndexChanged;

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
            if (comboBoxVerwaltungKursBez.Text == string.Empty ||
                txtBoxVerwaltungKursID.Text == string.Empty ||
                comboBoxVerwaltungMatrNr.Text == string.Empty ||
                comboBoxVerwaltungPersNr.Text == string.Empty ||
                comboBoxVerwaltungSemester.Text == string.Empty)
            {
                MessageBox.Show("Bitte Wähle alle Felder aus, um eine eindeutige Zuordnung zu gewährleisten!");
                return;
            }

            // Parse Text (string) explicitly to integer
            int verwaltungKursID = int.Parse(txtBoxVerwaltungKursID.Text);
            int verwaltungMatrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            int verwaltungPersNr = int.Parse(comboBoxVerwaltungPersNr.Text);
            int verwaltungSemester = int.Parse(comboBoxVerwaltungSemester.Text);
            // parsing not necessary for text data
            string verwaltungKursBez = comboBoxVerwaltungKursBez.Text;

            // SQL-Query: fill data in table Dozenten
            string query = string.Format("INSERT INTO KursTeilnahmen VALUES('{0}', '{1}', '{2}', '{3}', '{4}');",
                verwaltungKursID, verwaltungKursBez, verwaltungMatrNr, verwaltungSemester, verwaltungPersNr);

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
                lastSelectedSemester != 0 &&
                lastSelectedPersNr != 0)
            {
                // SQL-Query: delete data in SQL database in tbale KursTeilnahmen
                string query = string.Format("DELETE FROM KursTeilnahmen WHERE KursID = {0}" +
                                             "AND Matrikelnummer = {1}" +
                                             "AND Semester = {2} AND Personalnummer = {3};",
                                             lastSelectedKursID, lastSelectedMatrNr, 
                                             lastSelectedSemester, lastSelectedPersNr);

                // Execute query
                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte zuerst eine Zeile aus der Datenbank auswählen!");
                return;
            }

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
            comboBoxVerwaltungKursBez.Text = GridViewVerwaltung.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxVerwaltungKursID.Text = GridViewVerwaltung.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxVerwaltungMatrNr.Text = GridViewVerwaltung.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxVerwaltungSemester.Text = GridViewVerwaltung.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxVerwaltungPersNr.Text = GridViewVerwaltung.SelectedRows[0].Cells[4].Value.ToString();

            // Parse text data (string) into integer
            lastSelectedKursID = int.Parse(txtBoxVerwaltungKursID.Text);
            lastSelectedMatrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            lastSelectedSemester = int.Parse(comboBoxVerwaltungSemester.Text);
            lastSelectedPersNr = int.Parse(comboBoxVerwaltungPersNr.Text);
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
            var comboDataPersonalnummer = new List<string>();
            var comboDataKursBezeichnung = new List<string>();
            var comboDataMatrikelnummer = new List<string>();
            var comboDataSemester = new List<string>();

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
                                // write data from table Kurse, column Semester in appropriate List if not in List (no doubled entrees)
                                if (!comboDataSemester.Contains(row["Semester"].ToString()))
                                {
                                    comboDataSemester.Add(row["Semester"].ToString());
                                }
                                // write data from table Kurse, column Kursbezeichnung in appropriate List if not in List (no doubled entrees)
                                if (!comboDataKursBezeichnung.Contains(row["Kursbezeichnung"].ToString()))
                                {
                                    comboDataKursBezeichnung.Add(row["Kursbezeichnung"].ToString());
                                }
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
            comboBoxVerwaltungKursBez.DataSource = comboDataKursBezeichnung;
            comboBoxVerwaltungPersNr.DataSource = comboDataPersonalnummer;
            comboBoxVerwaltungSemester.DataSource = comboDataSemester;
            comboBoxVerwaltungMatrNr.DataSource = comboDataMatrikelnummer;
        }

        /// <summary>
        /// This method deletes all Text information in ComboBoxes on Screen.
        /// Currently not used!
        /// </summary>

        /// <summary>
        /// This method provides updating data in database.
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void btnVerwaltungBearbeiten_Click(object sender, EventArgs e)
        {
            // Parse Text data from ComboBoxes to integer values
            int kursId = int.Parse(txtBoxVerwaltungKursID.Text);
            int matrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            int semester = int.Parse(comboBoxVerwaltungSemester.Text);
            int persNr = int.Parse(comboBoxVerwaltungPersNr.Text);
            
            // Parsing Text data in textfield not necessary
            string kursBez = comboBoxVerwaltungKursBez.Text;

            // SQL-Query for Updating data in database
            string query = string.Format("UPDATE KursTeilnahmen SET KursID='{0}'," +
                                         "Kursbezeichnung='{1}', Matrikelnummer='{2}', " +
                                         "Semester='{3}', Personalnummer='{4}'" +
                                         "WHERE KursID = {5} AND Matrikelnummer = {6};",
                                         kursId, kursBez, matrNr, semester, persNr,
                                         lastSelectedKursID, lastSelectedMatrNr);

            // Execute SQL-Query
            DataBase.DataBaseExecuteQuery(query, connection);
            // Show actual data
            ShowVerwaltung();
        }

        /// <summary>
        /// This method is for textfield KursID and should change content,
        /// if user changes comboBox Kursbezeichnung
        /// </summary>
        /// <param name="sender">source of incoming data/event</param>
        /// <param name="e">Eventhandler</param>
        private void comboBoxVerwaltungKursBez_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKursBez = comboBoxVerwaltungKursBez.Text;
            // SQL-Query
            string query = string.Format("SELECT * FROM Kurse WHERE Kursbezeichnung = '{0}';", selectedKursBez);
            // Execute SQL-Query
            var dataTable = DataBase.DataBaseShowData(query, connection).Tables[0];

            if (dataTable.Rows.Count > 0)
            {
                // Annahme: Die Ergebnisse befinden sich in der ersten Zeile der Tabelle
                string kursID = dataTable.Rows[0]["KursID"].ToString();
                // Show result in textfield Kursbezeichnung on Screen
                txtBoxVerwaltungKursID.Text = kursID;
            }

            // Show actual data
            ShowVerwaltung();
        }
    }
}
