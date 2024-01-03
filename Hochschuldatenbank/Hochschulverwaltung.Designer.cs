using System.Windows.Forms;

namespace Hochschuldatenbank
{
    partial class Hochschulverwaltung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hochschulverwaltung));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnStudentenMainMenue = new Button();
            btnDozentenMainMenue = new Button();
            btnKurseMainMenue = new Button();
            lblVerwaltungAllgemein = new Label();
            GridViewVerwaltung = new DataGridView();
            btnVerwaltungBearbeiten = new Button();
            btnVerwaltungLoeschen = new Button();
            btnVerwaltungSpeichern = new Button();
            lblVerwaltungPersonalnummer = new Label();
            lblVerwaltungSemester = new Label();
            lblVerwaltungMatrikelnummer = new Label();
            lblVerwaltungKursBez = new Label();
            comboBoxVerwaltungPersNr = new ComboBox();
            comboBoxVerwaltungKursBez = new ComboBox();
            comboBoxVerwaltungMatrNr = new ComboBox();
            comboBoxVerwaltungSemester = new ComboBox();
            labelVerwaltungZuordnungKurse = new Label();
            txtLabelVerwaltungKursID = new Label();
            txtBoxVerwaltungKursID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)GridViewVerwaltung).BeginInit();
            SuspendLayout();
            // 
            // btnStudentenMainMenue
            // 
            btnStudentenMainMenue.Anchor = AnchorStyles.Top;
            btnStudentenMainMenue.BackgroundImage = (Image)resources.GetObject("btnStudentenMainMenue.BackgroundImage");
            btnStudentenMainMenue.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnStudentenMainMenue.FlatAppearance.BorderSize = 2;
            btnStudentenMainMenue.FlatAppearance.MouseOverBackColor = Color.White;
            btnStudentenMainMenue.FlatStyle = FlatStyle.Popup;
            btnStudentenMainMenue.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentenMainMenue.ForeColor = Color.Black;
            btnStudentenMainMenue.Location = new Point(44, 80);
            btnStudentenMainMenue.Name = "btnStudentenMainMenue";
            btnStudentenMainMenue.Size = new Size(373, 225);
            btnStudentenMainMenue.TabIndex = 0;
            btnStudentenMainMenue.Text = "Studenten";
            btnStudentenMainMenue.UseVisualStyleBackColor = true;
            btnStudentenMainMenue.Click += btnStudenten_Click;
            // 
            // btnDozentenMainMenue
            // 
            btnDozentenMainMenue.Anchor = AnchorStyles.Top;
            btnDozentenMainMenue.BackgroundImage = (Image)resources.GetObject("btnDozentenMainMenue.BackgroundImage");
            btnDozentenMainMenue.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnDozentenMainMenue.FlatAppearance.BorderSize = 2;
            btnDozentenMainMenue.FlatAppearance.MouseOverBackColor = Color.White;
            btnDozentenMainMenue.FlatStyle = FlatStyle.Popup;
            btnDozentenMainMenue.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozentenMainMenue.ForeColor = Color.White;
            btnDozentenMainMenue.Location = new Point(461, 78);
            btnDozentenMainMenue.Name = "btnDozentenMainMenue";
            btnDozentenMainMenue.Size = new Size(369, 227);
            btnDozentenMainMenue.TabIndex = 1;
            btnDozentenMainMenue.Text = "Dozenten";
            btnDozentenMainMenue.UseVisualStyleBackColor = true;
            btnDozentenMainMenue.Click += btnDozenten_Click;
            // 
            // btnKurseMainMenue
            // 
            btnKurseMainMenue.Anchor = AnchorStyles.Top;
            btnKurseMainMenue.BackgroundImage = (Image)resources.GetObject("btnKurseMainMenue.BackgroundImage");
            btnKurseMainMenue.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnKurseMainMenue.FlatAppearance.BorderSize = 2;
            btnKurseMainMenue.FlatAppearance.MouseOverBackColor = Color.White;
            btnKurseMainMenue.FlatStyle = FlatStyle.Popup;
            btnKurseMainMenue.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKurseMainMenue.ForeColor = Color.Black;
            btnKurseMainMenue.Location = new Point(870, 80);
            btnKurseMainMenue.Name = "btnKurseMainMenue";
            btnKurseMainMenue.Size = new Size(343, 227);
            btnKurseMainMenue.TabIndex = 2;
            btnKurseMainMenue.Text = "Kurse";
            btnKurseMainMenue.UseVisualStyleBackColor = true;
            btnKurseMainMenue.Click += btnKurseMainMenue_Click;
            // 
            // lblVerwaltungAllgemein
            // 
            lblVerwaltungAllgemein.Anchor = AnchorStyles.Top;
            lblVerwaltungAllgemein.AutoSize = true;
            lblVerwaltungAllgemein.BackColor = Color.Transparent;
            lblVerwaltungAllgemein.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerwaltungAllgemein.ForeColor = Color.White;
            lblVerwaltungAllgemein.Location = new Point(44, 30);
            lblVerwaltungAllgemein.Name = "lblVerwaltungAllgemein";
            lblVerwaltungAllgemein.Size = new Size(572, 30);
            lblVerwaltungAllgemein.TabIndex = 5;
            lblVerwaltungAllgemein.Text = "CRUD-Operations für Studenten, Dozenten und Kurse:";
            // 
            // GridViewVerwaltung
            // 
            GridViewVerwaltung.AllowUserToAddRows = false;
            GridViewVerwaltung.AllowUserToDeleteRows = false;
            GridViewVerwaltung.AllowUserToResizeColumns = false;
            GridViewVerwaltung.AllowUserToResizeRows = false;
            GridViewVerwaltung.Anchor = AnchorStyles.Bottom;
            GridViewVerwaltung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewVerwaltung.BackgroundColor = Color.FromArgb(30, 30, 30);
            GridViewVerwaltung.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridViewVerwaltung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridViewVerwaltung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewVerwaltung.GridColor = Color.White;
            GridViewVerwaltung.Location = new Point(44, 747);
            GridViewVerwaltung.MultiSelect = false;
            GridViewVerwaltung.Name = "GridViewVerwaltung";
            GridViewVerwaltung.ReadOnly = true;
            GridViewVerwaltung.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            GridViewVerwaltung.RowHeadersVisible = false;
            GridViewVerwaltung.RowHeadersWidth = 62;
            GridViewVerwaltung.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GridViewVerwaltung.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            GridViewVerwaltung.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            GridViewVerwaltung.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            GridViewVerwaltung.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewVerwaltung.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewVerwaltung.Size = new Size(1169, 379);
            GridViewVerwaltung.TabIndex = 39;
            GridViewVerwaltung.CellContentClick += GridViewVerwaltung_CellContentClick;
            // 
            // btnVerwaltungBearbeiten
            // 
            btnVerwaltungBearbeiten.BackColor = Color.FromArgb(30, 30, 30);
            btnVerwaltungBearbeiten.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnVerwaltungBearbeiten.FlatAppearance.BorderSize = 2;
            btnVerwaltungBearbeiten.FlatStyle = FlatStyle.Flat;
            btnVerwaltungBearbeiten.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerwaltungBearbeiten.ForeColor = Color.White;
            btnVerwaltungBearbeiten.Location = new Point(461, 669);
            btnVerwaltungBearbeiten.Name = "btnVerwaltungBearbeiten";
            btnVerwaltungBearbeiten.Size = new Size(162, 42);
            btnVerwaltungBearbeiten.TabIndex = 46;
            btnVerwaltungBearbeiten.Text = "Bearbeiten";
            btnVerwaltungBearbeiten.UseVisualStyleBackColor = false;
            btnVerwaltungBearbeiten.Click += btnVerwaltungBearbeiten_Click;
            // 
            // btnVerwaltungLoeschen
            // 
            btnVerwaltungLoeschen.BackColor = Color.FromArgb(30, 30, 30);
            btnVerwaltungLoeschen.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnVerwaltungLoeschen.FlatAppearance.BorderSize = 2;
            btnVerwaltungLoeschen.FlatStyle = FlatStyle.Flat;
            btnVerwaltungLoeschen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerwaltungLoeschen.ForeColor = Color.White;
            btnVerwaltungLoeschen.Location = new Point(668, 669);
            btnVerwaltungLoeschen.Name = "btnVerwaltungLoeschen";
            btnVerwaltungLoeschen.Size = new Size(162, 42);
            btnVerwaltungLoeschen.TabIndex = 45;
            btnVerwaltungLoeschen.Text = "Löschen";
            btnVerwaltungLoeschen.TextImageRelation = TextImageRelation.ImageAboveText;
            btnVerwaltungLoeschen.UseVisualStyleBackColor = false;
            btnVerwaltungLoeschen.Click += btnVerwaltungLoeschen_Click;
            // 
            // btnVerwaltungSpeichern
            // 
            btnVerwaltungSpeichern.BackColor = Color.FromArgb(30, 30, 30);
            btnVerwaltungSpeichern.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnVerwaltungSpeichern.FlatAppearance.BorderSize = 2;
            btnVerwaltungSpeichern.FlatStyle = FlatStyle.Flat;
            btnVerwaltungSpeichern.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerwaltungSpeichern.ForeColor = Color.White;
            btnVerwaltungSpeichern.Location = new Point(258, 669);
            btnVerwaltungSpeichern.Name = "btnVerwaltungSpeichern";
            btnVerwaltungSpeichern.Size = new Size(162, 42);
            btnVerwaltungSpeichern.TabIndex = 44;
            btnVerwaltungSpeichern.Text = "Speichern";
            btnVerwaltungSpeichern.UseVisualStyleBackColor = false;
            btnVerwaltungSpeichern.Click += btnVerwaltungSpeichern_Click;
            // 
            // lblVerwaltungPersonalnummer
            // 
            lblVerwaltungPersonalnummer.AutoSize = true;
            lblVerwaltungPersonalnummer.BackColor = Color.Transparent;
            lblVerwaltungPersonalnummer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerwaltungPersonalnummer.ForeColor = Color.White;
            lblVerwaltungPersonalnummer.Location = new Point(44, 609);
            lblVerwaltungPersonalnummer.Name = "lblVerwaltungPersonalnummer";
            lblVerwaltungPersonalnummer.Size = new Size(98, 30);
            lblVerwaltungPersonalnummer.TabIndex = 51;
            lblVerwaltungPersonalnummer.Text = "Pers.-Nr";
            // 
            // lblVerwaltungSemester
            // 
            lblVerwaltungSemester.AutoSize = true;
            lblVerwaltungSemester.BackColor = Color.Transparent;
            lblVerwaltungSemester.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerwaltungSemester.ForeColor = Color.White;
            lblVerwaltungSemester.Location = new Point(44, 557);
            lblVerwaltungSemester.Name = "lblVerwaltungSemester";
            lblVerwaltungSemester.Size = new Size(109, 30);
            lblVerwaltungSemester.TabIndex = 50;
            lblVerwaltungSemester.Text = "Semester";
            // 
            // lblVerwaltungMatrikelnummer
            // 
            lblVerwaltungMatrikelnummer.AutoSize = true;
            lblVerwaltungMatrikelnummer.BackColor = Color.Transparent;
            lblVerwaltungMatrikelnummer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerwaltungMatrikelnummer.ForeColor = Color.White;
            lblVerwaltungMatrikelnummer.Location = new Point(44, 504);
            lblVerwaltungMatrikelnummer.Name = "lblVerwaltungMatrikelnummer";
            lblVerwaltungMatrikelnummer.Size = new Size(145, 30);
            lblVerwaltungMatrikelnummer.TabIndex = 49;
            lblVerwaltungMatrikelnummer.Text = "Matrikel.-Nr.";
            // 
            // lblVerwaltungKursBez
            // 
            lblVerwaltungKursBez.AutoSize = true;
            lblVerwaltungKursBez.BackColor = Color.Transparent;
            lblVerwaltungKursBez.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerwaltungKursBez.ForeColor = Color.White;
            lblVerwaltungKursBez.Location = new Point(44, 394);
            lblVerwaltungKursBez.Name = "lblVerwaltungKursBez";
            lblVerwaltungKursBez.Size = new Size(191, 30);
            lblVerwaltungKursBez.TabIndex = 48;
            lblVerwaltungKursBez.Text = "Kursbezeichnung";
            // 
            // comboBoxVerwaltungPersNr
            // 
            comboBoxVerwaltungPersNr.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxVerwaltungPersNr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVerwaltungPersNr.FlatStyle = FlatStyle.Flat;
            comboBoxVerwaltungPersNr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxVerwaltungPersNr.ForeColor = Color.White;
            comboBoxVerwaltungPersNr.FormattingEnabled = true;
            comboBoxVerwaltungPersNr.Location = new Point(258, 601);
            comboBoxVerwaltungPersNr.Name = "comboBoxVerwaltungPersNr";
            comboBoxVerwaltungPersNr.Size = new Size(256, 38);
            comboBoxVerwaltungPersNr.TabIndex = 52;
            // 
            // comboBoxVerwaltungKursBez
            // 
            comboBoxVerwaltungKursBez.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxVerwaltungKursBez.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVerwaltungKursBez.FlatStyle = FlatStyle.Flat;
            comboBoxVerwaltungKursBez.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxVerwaltungKursBez.ForeColor = Color.White;
            comboBoxVerwaltungKursBez.FormattingEnabled = true;
            comboBoxVerwaltungKursBez.Location = new Point(258, 386);
            comboBoxVerwaltungKursBez.Name = "comboBoxVerwaltungKursBez";
            comboBoxVerwaltungKursBez.Size = new Size(256, 38);
            comboBoxVerwaltungKursBez.TabIndex = 53;
            comboBoxVerwaltungKursBez.SelectedIndexChanged += comboBoxVerwaltungKursBez_SelectedIndexChanged;
            // 
            // comboBoxVerwaltungMatrNr
            // 
            comboBoxVerwaltungMatrNr.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxVerwaltungMatrNr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVerwaltungMatrNr.FlatStyle = FlatStyle.Flat;
            comboBoxVerwaltungMatrNr.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxVerwaltungMatrNr.ForeColor = Color.White;
            comboBoxVerwaltungMatrNr.FormattingEnabled = true;
            comboBoxVerwaltungMatrNr.Location = new Point(258, 496);
            comboBoxVerwaltungMatrNr.Name = "comboBoxVerwaltungMatrNr";
            comboBoxVerwaltungMatrNr.Size = new Size(256, 38);
            comboBoxVerwaltungMatrNr.TabIndex = 54;
            // 
            // comboBoxVerwaltungSemester
            // 
            comboBoxVerwaltungSemester.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxVerwaltungSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVerwaltungSemester.FlatStyle = FlatStyle.Flat;
            comboBoxVerwaltungSemester.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxVerwaltungSemester.ForeColor = Color.White;
            comboBoxVerwaltungSemester.FormattingEnabled = true;
            comboBoxVerwaltungSemester.Location = new Point(258, 549);
            comboBoxVerwaltungSemester.Name = "comboBoxVerwaltungSemester";
            comboBoxVerwaltungSemester.Size = new Size(256, 38);
            comboBoxVerwaltungSemester.TabIndex = 55;
            // 
            // labelVerwaltungZuordnungKurse
            // 
            labelVerwaltungZuordnungKurse.Anchor = AnchorStyles.Top;
            labelVerwaltungZuordnungKurse.AutoSize = true;
            labelVerwaltungZuordnungKurse.BackColor = Color.Transparent;
            labelVerwaltungZuordnungKurse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVerwaltungZuordnungKurse.ForeColor = Color.White;
            labelVerwaltungZuordnungKurse.Location = new Point(44, 330);
            labelVerwaltungZuordnungKurse.Name = "labelVerwaltungZuordnungKurse";
            labelVerwaltungZuordnungKurse.Size = new Size(548, 30);
            labelVerwaltungZuordnungKurse.TabIndex = 56;
            labelVerwaltungZuordnungKurse.Text = "Zuordnung von Studenten und Dozenten zu Kursen:";
            // 
            // txtLabelVerwaltungKursID
            // 
            txtLabelVerwaltungKursID.AutoSize = true;
            txtLabelVerwaltungKursID.BackColor = Color.Transparent;
            txtLabelVerwaltungKursID.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLabelVerwaltungKursID.ForeColor = Color.White;
            txtLabelVerwaltungKursID.Location = new Point(44, 443);
            txtLabelVerwaltungKursID.Name = "txtLabelVerwaltungKursID";
            txtLabelVerwaltungKursID.Size = new Size(82, 30);
            txtLabelVerwaltungKursID.TabIndex = 57;
            txtLabelVerwaltungKursID.Text = "KursID";
            // 
            // txtBoxVerwaltungKursID
            // 
            txtBoxVerwaltungKursID.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxVerwaltungKursID.Enabled = false;
            txtBoxVerwaltungKursID.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxVerwaltungKursID.ForeColor = Color.White;
            txtBoxVerwaltungKursID.Location = new Point(258, 443);
            txtBoxVerwaltungKursID.Name = "txtBoxVerwaltungKursID";
            txtBoxVerwaltungKursID.Size = new Size(256, 37);
            txtBoxVerwaltungKursID.TabIndex = 58;
            // 
            // Hochschulverwaltung
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1259, 1171);
            ControlBox = false;
            Controls.Add(txtBoxVerwaltungKursID);
            Controls.Add(txtLabelVerwaltungKursID);
            Controls.Add(labelVerwaltungZuordnungKurse);
            Controls.Add(comboBoxVerwaltungSemester);
            Controls.Add(comboBoxVerwaltungMatrNr);
            Controls.Add(comboBoxVerwaltungKursBez);
            Controls.Add(comboBoxVerwaltungPersNr);
            Controls.Add(lblVerwaltungPersonalnummer);
            Controls.Add(lblVerwaltungSemester);
            Controls.Add(lblVerwaltungMatrikelnummer);
            Controls.Add(lblVerwaltungKursBez);
            Controls.Add(btnVerwaltungBearbeiten);
            Controls.Add(btnVerwaltungLoeschen);
            Controls.Add(btnVerwaltungSpeichern);
            Controls.Add(GridViewVerwaltung);
            Controls.Add(lblVerwaltungAllgemein);
            Controls.Add(btnKurseMainMenue);
            Controls.Add(btnDozentenMainMenue);
            Controls.Add(btnStudentenMainMenue);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Hochschulverwaltung";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hochschulverwaltung (Hauptmenü)";
            ((System.ComponentModel.ISupportInitialize)GridViewVerwaltung).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentenMainMenue;
        private Button btnDozentenMainMenue;
        private Button btnKurseMainMenue;
        private Label lblVerwaltungAllgemein;
        private DataGridView GridViewVerwaltung;
        private Button btnVerwaltungBearbeiten;
        private Button btnVerwaltungLoeschen;
        private Button btnVerwaltungSpeichern;
        private Label lblVerwaltungPersonalnummer;
        private Label lblVerwaltungSemester;
        private Label lblVerwaltungMatrikelnummer;
        private Label lblVerwaltungKursBez;
        private ComboBox comboBoxVerwaltungPersNr;
        private ComboBox comboBoxVerwaltungKursBez;
        private ComboBox comboBoxVerwaltungMatrNr;
        private ComboBox comboBoxVerwaltungSemester;
        private Label labelVerwaltungZuordnungKurse;
        private Label txtLabelVerwaltungKursID;
        private TextBox txtBoxVerwaltungKursID;
    }
}