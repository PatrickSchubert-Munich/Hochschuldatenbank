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
        private DB DataBase { get; }
        private SqlConnection connection { get; }
        string studentGeschlecht = "";
        int lastSelectedMatrNr = 0;

        public StudentenScreen()
        {
            DataBase = new DB();
            connection = DataBase.DataBaseConnection();
            InitializeComponent();
            ShowStudierende();
        }

        private void btnBackToMainMenue_Click(object sender, EventArgs e)
        {
            Hochschulverwaltung mainMenueScreen = new Hochschulverwaltung();
            mainMenueScreen.Show();
            this.Hide();
        }

        private void btnStudentFelderLeeren_Click(object sender, EventArgs e)
        {
            ClearAllFieldsStudierende();
        }

        private void ClearAllFieldsStudierende()
        {
            txtBoxStudentVorname.Text = string.Empty;
            txtBoxStudentNachname.Text = string.Empty;
            txtBoxStudentAdresse.Text = string.Empty;
            comboBoxStudentStudienfach.Text = string.Empty;
            radioBtnStudentMaennlich.Checked = true;
            radioBtnStudentWeiblich.Checked = false;
            dtPickerStudent.Value = DateTime.Today;
        }

        private void ShowStudierende()
        {
            string query = "SELECT * FROM Studierende;";
            var dataset = DataBase.DataBaseShowData(query, connection);
            GridViewStudent.DataSource = dataset.Tables[0];
            GridViewStudent.Columns[0].Visible = false;
        }

        private void btnStudentSpeichern_Click(object sender, EventArgs e)
        {
            if (txtBoxStudentVorname.Text == string.Empty ||
                txtBoxStudentNachname.Text == string.Empty ||
                txtBoxStudentAdresse.Text == string.Empty ||
                comboBoxStudentStudienfach.Text == string.Empty)
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

            string query = string.Format("INSERT INTO Studierende VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                                            studentVorname, studentNachname, studentGeschlecht, studentGebDatum,
                                            studentAdresse, studentStudienfach);
            
            DataBase.DataBaseExecuteQuery(query, connection);
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
                string query = string.Format("DELETE FROM Studierende WHERE Matrikelnummer = {0};", lastSelectedMatrNr);
                DataBase.DataBaseExecuteQuery(query, connection);
            }
            else
            {
                MessageBox.Show("Bitte zuerst einen Studenten in der Datenbank auswählen.");
                return;
            }

            ClearAllFieldsStudierende();
            ShowStudierende();
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

                string query = string.Format("UPDATE Studierende SET Vorname='{0}'," +
                                             "Nachname='{1}', Geschlecht='{2}', Geburtsdatum='{3}'," +
                                             "Adresse='{4}', Studienfach='{5}' WHERE Matrikelnummer = {6};", studentVorname,
                                             studentNachname, studentGeschlecht, studentGebDatum, studentAdresse,
                                             studentStudienfach, lastSelectedMatrNr);
                
                DataBase.DataBaseExecuteQuery(query, connection);
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
