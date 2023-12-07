namespace Hochschuldatenbank
{
    partial class StudentenScreen
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentenScreen));
            btnStudentSpeichern = new Button();
            btnStudentLoeschen = new Button();
            btnStudentBearbeiten = new Button();
            txtBoxStudentVorname = new TextBox();
            lblStudentVorname = new Label();
            lblStudentNachname = new Label();
            txtBoxStudentNachname = new TextBox();
            lblStudentGeschlecht = new Label();
            radioBtnStudentMaennlich = new RadioButton();
            radioBtnStudentWeiblich = new RadioButton();
            lblStudentGeburtsdatum = new Label();
            lblStudentAdresse = new Label();
            txtBoxStudentAdresse = new TextBox();
            lblStudentStudienfach = new Label();
            comboBoxStudentStudienfach = new ComboBox();
            btnStudentFelderLeeren = new Button();
            GridViewStudent = new DataGridView();
            btnBackToMainMenue = new Button();
            dtPickerStudent = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)GridViewStudent).BeginInit();
            SuspendLayout();
            // 
            // btnStudentSpeichern
            // 
            btnStudentSpeichern.BackColor = Color.FromArgb(30, 30, 30);
            btnStudentSpeichern.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnStudentSpeichern.FlatAppearance.BorderSize = 2;
            btnStudentSpeichern.FlatStyle = FlatStyle.Flat;
            btnStudentSpeichern.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentSpeichern.ForeColor = Color.White;
            btnStudentSpeichern.Location = new Point(206, 405);
            btnStudentSpeichern.Name = "btnStudentSpeichern";
            btnStudentSpeichern.Size = new Size(162, 42);
            btnStudentSpeichern.TabIndex = 0;
            btnStudentSpeichern.Text = "Speichern";
            btnStudentSpeichern.UseVisualStyleBackColor = false;
            btnStudentSpeichern.Click += btnStudentSpeichern_Click;
            // 
            // btnStudentLoeschen
            // 
            btnStudentLoeschen.BackColor = Color.FromArgb(30, 30, 30);
            btnStudentLoeschen.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnStudentLoeschen.FlatAppearance.BorderSize = 2;
            btnStudentLoeschen.FlatStyle = FlatStyle.Flat;
            btnStudentLoeschen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentLoeschen.ForeColor = Color.White;
            btnStudentLoeschen.Location = new Point(594, 405);
            btnStudentLoeschen.Name = "btnStudentLoeschen";
            btnStudentLoeschen.Size = new Size(162, 42);
            btnStudentLoeschen.TabIndex = 1;
            btnStudentLoeschen.Text = "Löschen";
            btnStudentLoeschen.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStudentLoeschen.UseVisualStyleBackColor = false;
            btnStudentLoeschen.Click += btnStudentLoeschen_Click;
            // 
            // btnStudentBearbeiten
            // 
            btnStudentBearbeiten.BackColor = Color.FromArgb(30, 30, 30);
            btnStudentBearbeiten.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnStudentBearbeiten.FlatAppearance.BorderSize = 2;
            btnStudentBearbeiten.FlatStyle = FlatStyle.Flat;
            btnStudentBearbeiten.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentBearbeiten.ForeColor = Color.White;
            btnStudentBearbeiten.Location = new Point(398, 405);
            btnStudentBearbeiten.Name = "btnStudentBearbeiten";
            btnStudentBearbeiten.Size = new Size(162, 42);
            btnStudentBearbeiten.TabIndex = 2;
            btnStudentBearbeiten.Text = "Bearbeiten";
            btnStudentBearbeiten.UseVisualStyleBackColor = false;
            btnStudentBearbeiten.Click += btnStudentBearbeiten_Click;
            // 
            // txtBoxStudentVorname
            // 
            txtBoxStudentVorname.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxStudentVorname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxStudentVorname.ForeColor = Color.White;
            txtBoxStudentVorname.Location = new Point(206, 67);
            txtBoxStudentVorname.Name = "txtBoxStudentVorname";
            txtBoxStudentVorname.Size = new Size(256, 37);
            txtBoxStudentVorname.TabIndex = 3;
            txtBoxStudentVorname.TextChanged += txtBoxStudentVorname_TextChanged;
            // 
            // lblStudentVorname
            // 
            lblStudentVorname.AutoSize = true;
            lblStudentVorname.BackColor = Color.Transparent;
            lblStudentVorname.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentVorname.ForeColor = Color.White;
            lblStudentVorname.Location = new Point(30, 74);
            lblStudentVorname.Name = "lblStudentVorname";
            lblStudentVorname.Size = new Size(106, 30);
            lblStudentVorname.TabIndex = 4;
            lblStudentVorname.Text = "Vorname";
            // 
            // lblStudentNachname
            // 
            lblStudentNachname.AutoSize = true;
            lblStudentNachname.BackColor = Color.Transparent;
            lblStudentNachname.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentNachname.ForeColor = Color.White;
            lblStudentNachname.Location = new Point(30, 126);
            lblStudentNachname.Name = "lblStudentNachname";
            lblStudentNachname.Size = new Size(123, 30);
            lblStudentNachname.TabIndex = 5;
            lblStudentNachname.Text = "Nachname";
            // 
            // txtBoxStudentNachname
            // 
            txtBoxStudentNachname.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxStudentNachname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxStudentNachname.ForeColor = Color.White;
            txtBoxStudentNachname.Location = new Point(206, 119);
            txtBoxStudentNachname.Name = "txtBoxStudentNachname";
            txtBoxStudentNachname.Size = new Size(256, 37);
            txtBoxStudentNachname.TabIndex = 6;
            // 
            // lblStudentGeschlecht
            // 
            lblStudentGeschlecht.AutoSize = true;
            lblStudentGeschlecht.BackColor = Color.Transparent;
            lblStudentGeschlecht.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentGeschlecht.ForeColor = Color.White;
            lblStudentGeschlecht.Location = new Point(30, 179);
            lblStudentGeschlecht.Name = "lblStudentGeschlecht";
            lblStudentGeschlecht.Size = new Size(126, 30);
            lblStudentGeschlecht.TabIndex = 7;
            lblStudentGeschlecht.Text = "Geschlecht";
            // 
            // radioBtnStudentMaennlich
            // 
            radioBtnStudentMaennlich.AutoSize = true;
            radioBtnStudentMaennlich.BackColor = Color.Transparent;
            radioBtnStudentMaennlich.Checked = true;
            radioBtnStudentMaennlich.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnStudentMaennlich.ForeColor = Color.White;
            radioBtnStudentMaennlich.Location = new Point(206, 179);
            radioBtnStudentMaennlich.Name = "radioBtnStudentMaennlich";
            radioBtnStudentMaennlich.Size = new Size(129, 34);
            radioBtnStudentMaennlich.TabIndex = 8;
            radioBtnStudentMaennlich.TabStop = true;
            radioBtnStudentMaennlich.Text = "männlich";
            radioBtnStudentMaennlich.UseVisualStyleBackColor = false;
            // 
            // radioBtnStudentWeiblich
            // 
            radioBtnStudentWeiblich.AutoSize = true;
            radioBtnStudentWeiblich.BackColor = Color.Transparent;
            radioBtnStudentWeiblich.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnStudentWeiblich.ForeColor = Color.White;
            radioBtnStudentWeiblich.Location = new Point(341, 179);
            radioBtnStudentWeiblich.Name = "radioBtnStudentWeiblich";
            radioBtnStudentWeiblich.Size = new Size(121, 34);
            radioBtnStudentWeiblich.TabIndex = 9;
            radioBtnStudentWeiblich.Text = "weiblich";
            radioBtnStudentWeiblich.UseVisualStyleBackColor = false;
            // 
            // lblStudentGeburtsdatum
            // 
            lblStudentGeburtsdatum.AutoSize = true;
            lblStudentGeburtsdatum.BackColor = Color.Transparent;
            lblStudentGeburtsdatum.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentGeburtsdatum.ForeColor = Color.White;
            lblStudentGeburtsdatum.Location = new Point(30, 231);
            lblStudentGeburtsdatum.Name = "lblStudentGeburtsdatum";
            lblStudentGeburtsdatum.Size = new Size(140, 30);
            lblStudentGeburtsdatum.TabIndex = 10;
            lblStudentGeburtsdatum.Text = "Geb.-Datum";
            // 
            // lblStudentAdresse
            // 
            lblStudentAdresse.AutoSize = true;
            lblStudentAdresse.BackColor = Color.Transparent;
            lblStudentAdresse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentAdresse.ForeColor = Color.White;
            lblStudentAdresse.Location = new Point(30, 281);
            lblStudentAdresse.Name = "lblStudentAdresse";
            lblStudentAdresse.Size = new Size(95, 30);
            lblStudentAdresse.TabIndex = 11;
            lblStudentAdresse.Text = "Adresse";
            // 
            // txtBoxStudentAdresse
            // 
            txtBoxStudentAdresse.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxStudentAdresse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxStudentAdresse.ForeColor = Color.White;
            txtBoxStudentAdresse.Location = new Point(206, 274);
            txtBoxStudentAdresse.Name = "txtBoxStudentAdresse";
            txtBoxStudentAdresse.Size = new Size(256, 37);
            txtBoxStudentAdresse.TabIndex = 12;
            // 
            // lblStudentStudienfach
            // 
            lblStudentStudienfach.AutoSize = true;
            lblStudentStudienfach.BackColor = Color.Transparent;
            lblStudentStudienfach.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentStudienfach.ForeColor = Color.White;
            lblStudentStudienfach.Location = new Point(30, 336);
            lblStudentStudienfach.Name = "lblStudentStudienfach";
            lblStudentStudienfach.Size = new Size(135, 30);
            lblStudentStudienfach.TabIndex = 13;
            lblStudentStudienfach.Text = "Studienfach";
            // 
            // comboBoxStudentStudienfach
            // 
            comboBoxStudentStudienfach.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxStudentStudienfach.FlatStyle = FlatStyle.Flat;
            comboBoxStudentStudienfach.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxStudentStudienfach.ForeColor = Color.White;
            comboBoxStudentStudienfach.FormattingEnabled = true;
            comboBoxStudentStudienfach.Items.AddRange(new object[] { "Informatik", "Wirtschaftsinformatik", "Softwareentwicklung", "Bio-Informatik", "Medieninformatik", "Mathematik", "Maschinenbau", "Elektrotechnik", "Mechatronik", "Fahrzeugtechnik", "Elektromobilität", "Flugzeugtechnik", "Raumfahrt", "Systems Engineering", "Betriebswirtschaft", "Philosiphie", "Tourismus", "Biologie", "Physik", "Sportwissenschaften", "Wirtschaftswissenschaften" });
            comboBoxStudentStudienfach.Location = new Point(206, 328);
            comboBoxStudentStudienfach.Name = "comboBoxStudentStudienfach";
            comboBoxStudentStudienfach.Size = new Size(256, 38);
            comboBoxStudentStudienfach.TabIndex = 14;
            // 
            // btnStudentFelderLeeren
            // 
            btnStudentFelderLeeren.BackColor = Color.FromArgb(30, 30, 30);
            btnStudentFelderLeeren.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnStudentFelderLeeren.FlatAppearance.BorderSize = 2;
            btnStudentFelderLeeren.FlatStyle = FlatStyle.Flat;
            btnStudentFelderLeeren.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentFelderLeeren.ForeColor = Color.White;
            btnStudentFelderLeeren.Location = new Point(791, 405);
            btnStudentFelderLeeren.Name = "btnStudentFelderLeeren";
            btnStudentFelderLeeren.Size = new Size(162, 42);
            btnStudentFelderLeeren.TabIndex = 15;
            btnStudentFelderLeeren.Text = "Felder leeren";
            btnStudentFelderLeeren.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStudentFelderLeeren.UseVisualStyleBackColor = false;
            btnStudentFelderLeeren.Click += btnStudentFelderLeeren_Click;
            // 
            // GridViewStudent
            // 
            GridViewStudent.AllowUserToAddRows = false;
            GridViewStudent.AllowUserToDeleteRows = false;
            GridViewStudent.AllowUserToResizeColumns = false;
            GridViewStudent.AllowUserToResizeRows = false;
            GridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewStudent.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridViewStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewStudent.Location = new Point(30, 480);
            GridViewStudent.MultiSelect = false;
            GridViewStudent.Name = "GridViewStudent";
            GridViewStudent.ReadOnly = true;
            GridViewStudent.RowHeadersVisible = false;
            GridViewStudent.RowHeadersWidth = 62;
            GridViewStudent.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GridViewStudent.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            GridViewStudent.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            GridViewStudent.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            GridViewStudent.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewStudent.Size = new Size(1129, 382);
            GridViewStudent.TabIndex = 16;
            GridViewStudent.CellContentClick += GridViewStudent_CellContentClick;
            // 
            // btnBackToMainMenue
            // 
            btnBackToMainMenue.BackColor = Color.FromArgb(30, 30, 30);
            btnBackToMainMenue.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnBackToMainMenue.FlatAppearance.BorderSize = 2;
            btnBackToMainMenue.FlatStyle = FlatStyle.Flat;
            btnBackToMainMenue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMainMenue.ForeColor = Color.White;
            btnBackToMainMenue.Location = new Point(995, 405);
            btnBackToMainMenue.Name = "btnBackToMainMenue";
            btnBackToMainMenue.Size = new Size(164, 42);
            btnBackToMainMenue.TabIndex = 22;
            btnBackToMainMenue.Text = "Hauptmenü";
            btnBackToMainMenue.UseVisualStyleBackColor = false;
            btnBackToMainMenue.Click += btnBackToMainMenue_Click;
            // 
            // dtPickerStudent
            // 
            dtPickerStudent.CalendarForeColor = Color.White;
            dtPickerStudent.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            dtPickerStudent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerStudent.Format = DateTimePickerFormat.Short;
            dtPickerStudent.Location = new Point(206, 219);
            dtPickerStudent.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickerStudent.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPickerStudent.Name = "dtPickerStudent";
            dtPickerStudent.Size = new Size(256, 37);
            dtPickerStudent.TabIndex = 23;
            dtPickerStudent.Value = new DateTime(2023, 12, 7, 17, 19, 58, 0);
            // 
            // StudentenScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 892);
            ControlBox = false;
            Controls.Add(dtPickerStudent);
            Controls.Add(btnBackToMainMenue);
            Controls.Add(GridViewStudent);
            Controls.Add(btnStudentFelderLeeren);
            Controls.Add(comboBoxStudentStudienfach);
            Controls.Add(lblStudentStudienfach);
            Controls.Add(txtBoxStudentAdresse);
            Controls.Add(lblStudentAdresse);
            Controls.Add(lblStudentGeburtsdatum);
            Controls.Add(radioBtnStudentWeiblich);
            Controls.Add(radioBtnStudentMaennlich);
            Controls.Add(lblStudentGeschlecht);
            Controls.Add(txtBoxStudentNachname);
            Controls.Add(lblStudentNachname);
            Controls.Add(lblStudentVorname);
            Controls.Add(txtBoxStudentVorname);
            Controls.Add(btnStudentBearbeiten);
            Controls.Add(btnStudentLoeschen);
            Controls.Add(btnStudentSpeichern);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StudentenScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Studentendatenbank";
            Load += StudentenScreen_Load;
            ((System.ComponentModel.ISupportInitialize)GridViewStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentSpeichern;
        private Button btnStudentLoeschen;
        private Button btnStudentBearbeiten;
        private TextBox txtBoxStudentVorname;
        private Label lblStudentVorname;
        private Label lblStudentNachname;
        private TextBox txtBoxStudentNachname;
        private Label lblStudentGeschlecht;
        private RadioButton radioBtnStudentMaennlich;
        private RadioButton radioBtnStudentWeiblich;
        private Label lblStudentGeburtsdatum;
        private Label lblStudentAdresse;
        private TextBox txtBoxStudentAdresse;
        private Label lblStudentStudienfach;
        private ComboBox comboBoxStudentStudienfach;
        private Button btnStudentFelderLeeren;
        private DataGridView GridViewStudent;
        private Button btnBackToMainMenue;
        private DateTimePicker dtPickerStudent;
    }
}