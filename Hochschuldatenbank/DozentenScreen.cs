using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
    public partial class DozentenScreen : Form
    {
        private DB DataBase { get; }
        private SqlConnection connection { get; }
        string dozentGeschlecht = "";
        int lastSelectedPersNr = 0;
        

        public DozentenScreen()
        {
            DataBase = new DB();
            connection = DataBase.DataBaseConnection();
            InitializeComponent();
            ShowDozenten();
        }

        private void btnBackToMainMenue_Click(object sender, EventArgs e)
        {
            MainMenueScreen mainMenueScreen = new MainMenueScreen();
            mainMenueScreen.Show();
            this.Hide();
        }

        private void btnDozentFelderLeeren_Click(object sender, EventArgs e)
        {
            ClearAllFieldsDozenten();
        }

        private void btnDozentSpeichern_Click(object sender, EventArgs e)
        {
            if (txtBoxDozentVorname.Text == string.Empty ||
                txtBoxDozentNachname.Text == string.Empty ||
                txtBoxDozentAdresse.Text == string.Empty ||
                comboBoxDozentFakultaet.Text == string.Empty)
            {
                MessageBox.Show("Bitte Fülle weitere Felder aus. Bis auf den Abschluss und das Dienstzimmer " +
                    "sind alle anderen Felder sog. Pflichtfelder.");
                return;
            }

            string dozentVorname = txtBoxDozentVorname.Text;
            string dozentNachname = txtBoxDozentNachname.Text;
            string dozentAdresse = txtBoxDozentAdresse.Text;
            string dozentDienstzimmer = txtBoxDozentDienstzimmer.Text;
            string dozentAbschluss = comboBoxDozentAbschluss.Text;
            string dozentFakultaet = comboBoxDozentFakultaet.Text;
            var dozentGebDatum = dtPickerDozent.Value.Date.ToShortDateString();

            if (radioBtnDozentMaennlich.Checked == true)
            {
                dozentGeschlecht = "m";
            }
            else if (radioBtnDozentWeiblich.Checked == true)
            {
                dozentGeschlecht = "w";
            }

            connection.Open();
            string query = string.Format("INSERT INTO Dozenten VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                                            dozentVorname, dozentNachname, dozentGeschlecht, dozentGebDatum,
                                            dozentAdresse, dozentAbschluss, dozentFakultaet, dozentDienstzimmer);
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            ClearAllFieldsDozenten();
            ShowDozenten();
        }

        private void ClearAllFieldsDozenten()
        {
            txtBoxDozentVorname.Text = string.Empty;
            txtBoxDozentNachname.Text = string.Empty;
            txtBoxDozentAdresse.Text = string.Empty;
            txtBoxDozentDienstzimmer.Text = string.Empty;
            comboBoxDozentAbschluss.Text = string.Empty;
            comboBoxDozentFakultaet.Text = string.Empty;
            radioBtnDozentMaennlich.Checked = true;
            radioBtnDozentWeiblich.Checked = false;
            dtPickerDozent.Value = DateTime.Today;
        }

        private void ShowDozenten()
        {
            string query = "SELECT * FROM Dozenten;";
            var dataset = DataBase.DataBaseShowData(query, connection);
            GridViewDozent.DataSource = dataset.Tables[0];
            GridViewDozent.Columns[0].Visible = false;
        }

        private void GridViewDozent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelectedPersNr = (int)GridViewDozent.SelectedRows[0].Cells[0].Value;
            txtBoxDozentVorname.Text = GridViewDozent.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxDozentNachname.Text = GridViewDozent.SelectedRows[0].Cells[2].Value.ToString();

            if (GridViewDozent.SelectedRows[0].Cells[3].Value.ToString() == "m")
            {
                radioBtnDozentMaennlich.Checked = true;
            }
            else radioBtnDozentWeiblich.Checked = true;

            dtPickerDozent.Value = DateTime.Parse(GridViewDozent.SelectedRows[0].Cells[4].Value.ToString()!);
            txtBoxDozentAdresse.Text = GridViewDozent.SelectedRows[0].Cells[5].Value.ToString();
            comboBoxDozentAbschluss.Text = GridViewDozent.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxDozentFakultaet.Text = GridViewDozent.SelectedRows[0].Cells[7].Value.ToString();
            txtBoxDozentDienstzimmer.Text = GridViewDozent.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void btnDozentLoeschen_Click(object sender, EventArgs e)
        {
            if (lastSelectedPersNr != 0)
            {
                string query = string.Format("DELETE FROM Dozenten WHERE Personalnummer = {0};", lastSelectedPersNr);
                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte zuerst einen Dozenten in der Datenbank auswählen.");
                return;
            }

            ClearAllFieldsDozenten();
            ShowDozenten();
        }

        private void btnDozentBearbeiten_Click(object sender, EventArgs e)
        {
            if (lastSelectedPersNr != 0)
            {
                string dozentVorname = txtBoxDozentVorname.Text;
                string dozentNachname = txtBoxDozentNachname.Text;
                string dozentAdresse = txtBoxDozentAdresse.Text;
                string dozentDienstzimmer = txtBoxDozentDienstzimmer.Text;
                string dozentAbschluss = comboBoxDozentAbschluss.Text;
                string dozentFakultaet = comboBoxDozentFakultaet.Text;
                var dozentGebDatum = dtPickerDozent.Value.Date.ToShortDateString();

                if (radioBtnDozentMaennlich.Checked == true)
                {
                    dozentGeschlecht = "m";
                }
                else if (radioBtnDozentWeiblich.Checked == true)
                {
                    dozentGeschlecht = "w";
                }

                string query = string.Format("UPDATE Dozenten SET Vorname='{0}'," +
                                             "Nachname='{1}', Geschlecht='{2}', Geburtsdatum='{3}'," +
                                             "Adresse='{4}', Abschluss='{5}', Fakultät='{6}'," +
                                             "Dienstzimmer='{7}' WHERE Personalnummer={8};", dozentVorname, 
                                             dozentNachname, dozentGeschlecht, dozentGebDatum, dozentAdresse,
                                             dozentAbschluss, dozentFakultaet, dozentDienstzimmer, lastSelectedPersNr);
                
                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte wähle zuerst einen Dozenten in der Datenbank aus.");
                return;
            }

            ClearAllFieldsDozenten();
            ShowDozenten();
        }
    }
}