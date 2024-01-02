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
    public partial class KurseScreen : Form
    {
        private DB DataBase { get; }
        private SqlConnection connection { get; }
        int lastSelectedKursId = 0;

        public KurseScreen()
        {
            DataBase = new DB();
            connection = DataBase.DataBaseConnection();
            InitializeComponent();
            ShowKurse();
        }

        private void btnBackToMainMenue_Click(object sender, EventArgs e)
        {
            Hochschulverwaltung mainMenueScreen = new Hochschulverwaltung();
            mainMenueScreen.Show();
            this.Hide();
        }

        private void btnKursFelderLeeren_Click(object sender, EventArgs e)
        {
            ClearAllFieldsKurse();
        }

        private void ClearAllFieldsKurse()
        {
            comboBoxKursbezeichnung.Text = string.Empty;
            txtBoxKursbeschreibung.Text = string.Empty;
            comboBoxKursSemester.Text = string.Empty;
            txtBoxKursHoersaal.Text = string.Empty;
            dtPickerKursStartdatum.Value = DateTime.Today;
            dtPickerKursEnddatum.Value = DateTime.Today;
        }
        private void ShowKurse()
        {
            string query = "SELECT * FROM Kurse;";
            var dataset = DataBase.DataBaseShowData(query, connection);
            GridViewKurs.DataSource = dataset.Tables[0];
            GridViewKurs.Columns[0].Visible = false;
        }

        private void btnKursSpeichern_Click(object sender, EventArgs e)
        {
            string kursBezeichnung = comboBoxKursbezeichnung.Text;
            int? kursSemester = Convert.ToInt32(comboBoxKursSemester.Text);
            string kursStartDatum = dtPickerKursStartdatum.Value.Date.ToShortDateString();
            string kursEndDatum = dtPickerKursEnddatum.Value.Date.ToShortDateString();

            if (kursBezeichnung == string.Empty ||
                kursSemester == null ||
                kursStartDatum == null ||
                kursEndDatum == null)
            {
                MessageBox.Show("Bitte weitere Felder ausfüllen. " +
                    "Ausschließlich Hörsaal und Beschreibung sind optional.");
                return;
            }

            string kursBeschreibung = txtBoxKursbeschreibung.Text;
            string kursHoersaal = txtBoxKursHoersaal.Text;
            
            string query = string.Format("INSERT INTO Kurse VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                                            kursBezeichnung, kursBeschreibung, kursSemester, kursHoersaal,
                                            kursStartDatum, kursEndDatum);

            DataBase.DataBaseExecuteQuery(query, connection);
            ClearAllFieldsKurse();
            ShowKurse();
        }

        private void GridViewKurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelectedKursId = (int)GridViewKurs.SelectedRows[0].Cells[0].Value;
            comboBoxKursbezeichnung.Text = GridViewKurs.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxKursbeschreibung.Text = GridViewKurs.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxKursSemester.Text = GridViewKurs.SelectedRows[0].Cells[3].Value.ToString();
            txtBoxKursHoersaal.Text = GridViewKurs.SelectedRows[0].Cells[4].Value.ToString();
            dtPickerKursStartdatum.Value = DateTime.Parse(GridViewKurs.SelectedRows[0].Cells[5].Value.ToString()!);
            dtPickerKursEnddatum.Value = DateTime.Parse(GridViewKurs.SelectedRows[0].Cells[6].Value.ToString()!);
        }

        private void btnKursLoeschen_Click(object sender, EventArgs e)
        {
            if (lastSelectedKursId != 0)
            {
                string query = string.Format("DELETE FROM Kurse WHERE KursID = {0};", lastSelectedKursId);
                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte zuerst einen Kurs in der Datenbank auswählen.");
                return;
            }

            ClearAllFieldsKurse();
            ShowKurse();
        }

        private void btnKursBearbeiten_Click(object sender, EventArgs e)
        {
            if (lastSelectedKursId != 0)
            {
                string kursBezeichnung = comboBoxKursbezeichnung.Text;
                string kursBeschreibung = txtBoxKursbeschreibung.Text;
                int? kursSemester = Convert.ToInt32(comboBoxKursSemester.Text);
                string kursHoersaal = txtBoxKursHoersaal.Text;
                var kursStartDatum = dtPickerKursStartdatum.Value.Date.ToShortDateString();
                var kursEndDatum = dtPickerKursEnddatum.Value.Date.ToShortDateString();

                string query = string.Format("UPDATE Kurse SET Kursbezeichnung='{0}'," +
                                             "Beschreibung='{1}', Semester='{2}', Hörsaal='{3}'," +
                                             "StartDatum='{4}', EndDatum='{5}' WHERE KursID={6};", 
                                             kursBezeichnung, kursBeschreibung, kursSemester, 
                                             kursHoersaal, kursStartDatum, kursEndDatum, lastSelectedKursId);

                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte wähle zuerst einen Dozenten in der Datenbank aus.");
                return;
            }

            ClearAllFieldsKurse();
            ShowKurse();
        }
    }

}
