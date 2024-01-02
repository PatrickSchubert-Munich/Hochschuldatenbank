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
    public partial class Hochschulverwaltung : Form
    {
        private DB DataBase { get; }
        private SqlConnection connection { get; }
        private int lastSelectedKursID = 0;
        private int lastSelectedMatrNr = 0;
        private int lastSelectedSemester = 0;

        public Hochschulverwaltung()
        {
            DataBase = new DB();
            connection = DataBase.DataBaseConnection();
            InitializeComponent();
            FillComboData();
            ShowVerwaltung();
        }

        private void btnStudenten_Click(object sender, EventArgs e)
        {
            StudentenScreen studentenScreen = new StudentenScreen();
            studentenScreen.Show();
            this.Hide();
        }

        private void btnDozenten_Click(object sender, EventArgs e)
        {
            DozentenScreen dozentenScreen = new DozentenScreen();
            dozentenScreen.Show();
            this.Hide();
        }

        private void btnKurseMainMenue_Click(object sender, EventArgs e)
        {
            KurseScreen kurseScreen = new KurseScreen();
            kurseScreen.Show();
            this.Hide();
        }

        private void btnVerwaltungFelderLeeren_Click(object sender, EventArgs e)
        {
            ClearAllFieldsVerwaltung();
        }

        private void btnVerwaltungSpeichern_Click(object sender, EventArgs e)
        {

            if (comboBoxVerwaltungKursID.Text == string.Empty ||
                comboBoxVerwaltungMatrNr.Text == string.Empty ||
                comboBoxVerwaltungPersNr.Text == string.Empty ||
                comboBoxVerwaltungSemester.Text == string.Empty)
            {
                MessageBox.Show("Bitte Wähle alle Felder aus, um eine eindeutige Zuordnung zu gewährleisten!");
                return;
            }

            int verwaltungKursID = int.Parse(comboBoxVerwaltungKursID.Text);
            int verwaltungMatrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            int verwaltungPersNr = int.Parse(comboBoxVerwaltungPersNr.Text);
            int verwaltungSemester = int.Parse(comboBoxVerwaltungSemester.Text);

            // SQL-Query: befülle Tabelle Dozenten
            string query = string.Format("INSERT INTO KursTeilnahmen VALUES('{0}', '{1}', '{2}', '{3}');",
                verwaltungKursID, verwaltungMatrNr, verwaltungSemester, verwaltungPersNr);

            DataBase.DataBaseExecuteQuery(query, connection);
            ClearAllFieldsVerwaltung();
            ShowVerwaltung();
        }

        private void btnVerwaltungLoeschen_Click(object sender, EventArgs e)
        {
            if (lastSelectedKursID != 0 &&
                lastSelectedMatrNr != 0 &&
                lastSelectedSemester != 0)
            {
                string query = string.Format("DELETE FROM KursTeilnahmen WHERE KursID = {0}" +
                                             "AND Matrikelnummer = {1}" +
                                             "AND Semester = {2};",
                                             lastSelectedKursID, lastSelectedMatrNr, lastSelectedSemester);

                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte zuerst eine Zeile aus der Datenbank auswählen!");
                return;
            }

            ClearAllFieldsVerwaltung();
            ShowVerwaltung();
        }


        private void GridViewVerwaltung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxVerwaltungKursID.Text = GridViewVerwaltung.SelectedRows[0].Cells[0].Value.ToString();
            comboBoxVerwaltungMatrNr.Text = GridViewVerwaltung.SelectedRows[0].Cells[1].Value.ToString();
            comboBoxVerwaltungSemester.Text = GridViewVerwaltung.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxVerwaltungPersNr.Text = GridViewVerwaltung.SelectedRows[0].Cells[3].Value.ToString();

            lastSelectedKursID = int.Parse(comboBoxVerwaltungKursID.Text);
            lastSelectedMatrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            lastSelectedSemester = int.Parse(comboBoxVerwaltungSemester.Text);
        }

        void ShowVerwaltung()
        {
            string query = "SELECT * FROM KursTeilnahmen;";
            var dataset = DataBase.DataBaseShowData(query, connection);
            GridViewVerwaltung.DataSource = dataset.Tables[0];
            GridViewVerwaltung.Columns[0].Visible = true;
        }


        void FillComboData()
        {
            // Params
            var tableNames = new List<string> { "Dozenten", "Kurse", "Studierende" };
            List<string> comboDataPersonalnummer = new List<string>();
            List<string> comboDataKursID = new List<string>();
            List<string> comboDataMatrikelnummer = new List<string>();
            List<string> comboDataSemester = new List<string>();

            foreach (var tableName in tableNames)
            {
                string query = $"SELECT * FROM {tableName}";
                var dataTable = DataBase.DataBaseShowData(query, connection).Tables[0];

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        switch (tableName)
                        {
                            case "Dozenten":
                                comboDataPersonalnummer.Add(row["Personalnummer"].ToString());
                                break;
                            case "Kurse":
                                comboDataKursID.Add(row["KursID"].ToString());
                                comboDataSemester.Add(row["Semester"].ToString());
                                break;
                            case "Studierende":
                                comboDataMatrikelnummer.Add(row["Matrikelnummer"].ToString());

                                break;
                            default:
                                Console.WriteLine("There is no match!");
                                break;
                        }
                    }
                }
            }
            // Fülle Liste mit den aktuellen Werten der Spalten
            comboBoxVerwaltungPersNr.DataSource = comboDataPersonalnummer;
            comboBoxVerwaltungKursID.DataSource = comboDataKursID;
            comboBoxVerwaltungSemester.DataSource = comboDataSemester;
            comboBoxVerwaltungMatrNr.DataSource = comboDataMatrikelnummer;
        }

        private void ClearAllFieldsVerwaltung()
        {
            comboBoxVerwaltungKursID.Text = string.Empty;
            comboBoxVerwaltungMatrNr.Text = string.Empty;
            comboBoxVerwaltungSemester.Text = string.Empty;
            comboBoxVerwaltungPersNr.Text = string.Empty;
        }

        private void btnVerwaltungBearbeiten_Click(object sender, EventArgs e)
        {
            int kursId = int.Parse(comboBoxVerwaltungKursID.Text);
            int matrNr = int.Parse(comboBoxVerwaltungMatrNr.Text);
            int semester = int.Parse(comboBoxVerwaltungSemester.Text);
            int persNr = int.Parse(comboBoxVerwaltungPersNr.Text);
            string query = string.Format("UPDATE KursTeilnahmen SET KursID='{0}'," +
                                         "Matrikelnummer='{1}', Semester='{2}'," +
                                         "Personalnummer='{3}' WHERE KursID = {4}" + 
                                         "AND Matrikelnummer = {5};", 
                                         kursId, matrNr, semester, persNr, 
                                         lastSelectedKursID, lastSelectedMatrNr);

            DataBase.DataBaseExecuteQuery(query, connection);
            ShowVerwaltung();
        }
    }
}
