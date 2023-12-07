﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hochschuldatenbank
{
    public partial class StudentenScreen : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Patri\OneDrive\Dokumente\Personendatenbank.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True");
        string studentGeschlecht = "";
        int lastSelectedMatrNr = 0;

        public StudentenScreen()
        {
            InitializeComponent();
            ShowStudierende();

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

        private void StudentenScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnStudentFelderLeeren_Click(object sender, EventArgs e)
        {
            ClearAllFieldsStudierende();
        }

        private void ClearAllFieldsStudierende()
        {
            txtBoxStudentVorname.Text = String.Empty;
            txtBoxStudentNachname.Text = String.Empty;
            txtBoxStudentAdresse.Text = String.Empty;
            comboBoxStudentStudienfach.Text = String.Empty;
            radioBtnStudentMaennlich.Checked = true;
            radioBtnStudentWeiblich.Checked = false;
            dtPickerStudent.Value = DateTime.Today;
        }

        private void ShowStudierende()
        {
            connection.Open();

            string query = "SELECT * FROM Studierende;";
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(query, connection);

            DataSet dataset = new DataSet();
            sqlAdapter.Fill(dataset);

            GridViewStudent.DataSource = dataset.Tables[0];
            GridViewStudent.Columns[0].Visible = false;

            connection.Close();
        }

        private void btnStudentSpeichern_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentVorname.Text == String.Empty ||
                txtBoxStudentNachname.Text == String.Empty ||
                txtBoxStudentAdresse.Text == String.Empty ||
                comboBoxStudentStudienfach.Text == String.Empty)
            {
                MessageBox.Show("Bitte alle Felder ausfüllen.");
                return;
            }

            string studentVorname = txtBoxStudentVorname.Text;
            string studentNachname = txtBoxStudentNachname.Text;
            string studentAdresse = txtBoxStudentAdresse.Text;
            string studentStudienfach = comboBoxStudentStudienfach.Text;
            var studentGebDatum = dtPickerStudent.Value.Date.ToShortDateString();

            if (radioBtnStudentMaennlich.Checked == true)
            {
                studentGeschlecht = "m";
            }
            else if (radioBtnStudentWeiblich.Checked == true)
            {
                studentGeschlecht = "w";
            }

            string query = String.Format("INSERT INTO Studierende VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                                            studentVorname, studentNachname, studentGeschlecht, studentGebDatum,
                                            studentAdresse, studentStudienfach);
            ExecuteQuery(query);

            ClearAllFieldsStudierende();
            ShowStudierende();
        }

        private void GridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastSelectedMatrNr = (int)GridViewStudent.SelectedRows[0].Cells[0].Value;
            txtBoxStudentVorname.Text = GridViewStudent.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxStudentNachname.Text = GridViewStudent.SelectedRows[0].Cells[2].Value.ToString();

            if (GridViewStudent.SelectedRows[0].Cells[3].Value.ToString() == "m")
            {
                radioBtnStudentMaennlich.Checked = true;
            }
            else radioBtnStudentWeiblich.Checked = true;

            dtPickerStudent.Value = DateTime.Parse(GridViewStudent.SelectedRows[0].Cells[4].Value.ToString()!);
            txtBoxStudentAdresse.Text = GridViewStudent.SelectedRows[0].Cells[5].Value.ToString();
            comboBoxStudentStudienfach.Text = GridViewStudent.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnStudentLoeschen_Click(object sender, EventArgs e)
        {
            if (lastSelectedMatrNr != 0)
            {
                string query = String.Format("DELETE FROM Studierende WHERE Matrikelnummer = {0};", lastSelectedMatrNr);
                ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Bitte zuerst einen Studenten in der Datenbank auswählen.");
                return;
            }

            ClearAllFieldsStudierende();
            ShowStudierende();
        }

        private void ExecuteQuery(string query)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void btnStudentBearbeiten_Click(object sender, EventArgs e)
        {
            if (lastSelectedMatrNr != 0)
            {
                string studentVorname = txtBoxStudentVorname.Text;
                string studentNachname = txtBoxStudentNachname.Text;
                string studentAdresse = txtBoxStudentAdresse.Text;
                string studentStudienfach = comboBoxStudentStudienfach.Text;
                var studentGebDatum = dtPickerStudent.Value.Date.ToShortDateString();

                if (radioBtnStudentMaennlich.Checked == true)
                {
                    studentGeschlecht = "m";
                }
                else if (radioBtnStudentWeiblich.Checked == true)
                {
                    studentGeschlecht = "w";
                }

                string query = String.Format("UPDATE Studierende SET Vorname='{0}'," +
                                             "Nachname='{1}', Geschlecht='{2}', Geburtsdatum='{3}'," +
                                             "Adresse='{4}', Studienfach='{5}';", studentVorname,
                                             studentNachname, studentGeschlecht, studentGebDatum, studentAdresse,
                                             studentAdresse, studentStudienfach, lastSelectedMatrNr);
                ExecuteQuery(query);
            }
            else
            {
                MessageBox.Show("Bitte wähle zuerst einen Dozenten in der Datenbank aus.");
                return;
            }

            ClearAllFieldsStudierende();
            ShowStudierende();
        }
    }
}