namespace Hochschuldatenbank
{
    partial class KurseScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KurseScreen));
            GridViewKurs = new DataGridView();
            lblKursBezeichnung = new Label();
            txtBoxKursBezeichnung = new TextBox();
            lblKursSemester = new Label();
            comboBoxKursSemester = new ComboBox();
            lblKursHörsaal = new Label();
            textBoxKursHörsaal = new TextBox();
            lblKursBeschreibung = new Label();
            textBoxKursBeschreibung = new TextBox();
            dtPickerKursStartdatum = new DateTimePicker();
            lblKursStartDatum = new Label();
            dtPickerKursEnddatum = new DateTimePicker();
            lblKursEndDatum = new Label();
            btnBackToMainMenue = new Button();
            btnKursFelderLeeren = new Button();
            btnKursBearbeiten = new Button();
            btnKursLoeschen = new Button();
            btnKursSpeichern = new Button();
            ((System.ComponentModel.ISupportInitialize)GridViewKurs).BeginInit();
            SuspendLayout();
            // 
            // GridViewKurs
            // 
            GridViewKurs.AllowUserToAddRows = false;
            GridViewKurs.AllowUserToDeleteRows = false;
            GridViewKurs.AllowUserToResizeColumns = false;
            GridViewKurs.AllowUserToResizeRows = false;
            GridViewKurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewKurs.BackgroundColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridViewKurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridViewKurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewKurs.Location = new Point(36, 505);
            GridViewKurs.MultiSelect = false;
            GridViewKurs.Name = "GridViewKurs";
            GridViewKurs.ReadOnly = true;
            GridViewKurs.RowHeadersVisible = false;
            GridViewKurs.RowHeadersWidth = 62;
            GridViewKurs.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GridViewKurs.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            GridViewKurs.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            GridViewKurs.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            GridViewKurs.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewKurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewKurs.Size = new Size(1194, 382);
            GridViewKurs.TabIndex = 17;
            // 
            // lblKursBezeichnung
            // 
            lblKursBezeichnung.AutoSize = true;
            lblKursBezeichnung.BackColor = Color.Transparent;
            lblKursBezeichnung.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursBezeichnung.ForeColor = Color.White;
            lblKursBezeichnung.Location = new Point(36, 60);
            lblKursBezeichnung.Name = "lblKursBezeichnung";
            lblKursBezeichnung.Size = new Size(191, 30);
            lblKursBezeichnung.TabIndex = 19;
            lblKursBezeichnung.Text = "Kursbezeichnung";
            // 
            // txtBoxKursBezeichnung
            // 
            txtBoxKursBezeichnung.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxKursBezeichnung.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxKursBezeichnung.ForeColor = Color.White;
            txtBoxKursBezeichnung.Location = new Point(277, 53);
            txtBoxKursBezeichnung.Name = "txtBoxKursBezeichnung";
            txtBoxKursBezeichnung.Size = new Size(256, 37);
            txtBoxKursBezeichnung.TabIndex = 18;
            // 
            // lblKursSemester
            // 
            lblKursSemester.AutoSize = true;
            lblKursSemester.BackColor = Color.Transparent;
            lblKursSemester.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursSemester.ForeColor = Color.White;
            lblKursSemester.Location = new Point(36, 177);
            lblKursSemester.Name = "lblKursSemester";
            lblKursSemester.Size = new Size(109, 30);
            lblKursSemester.TabIndex = 21;
            lblKursSemester.Text = "Semester";
            // 
            // comboBoxKursSemester
            // 
            comboBoxKursSemester.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxKursSemester.FlatStyle = FlatStyle.Flat;
            comboBoxKursSemester.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxKursSemester.ForeColor = Color.White;
            comboBoxKursSemester.FormattingEnabled = true;
            comboBoxKursSemester.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "Urlaubssemseter 1", "Urlaubssemseter 2" });
            comboBoxKursSemester.Location = new Point(277, 169);
            comboBoxKursSemester.Name = "comboBoxKursSemester";
            comboBoxKursSemester.Size = new Size(256, 38);
            comboBoxKursSemester.TabIndex = 22;
            // 
            // lblKursHörsaal
            // 
            lblKursHörsaal.AutoSize = true;
            lblKursHörsaal.BackColor = Color.Transparent;
            lblKursHörsaal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursHörsaal.ForeColor = Color.White;
            lblKursHörsaal.Location = new Point(36, 235);
            lblKursHörsaal.Name = "lblKursHörsaal";
            lblKursHörsaal.Size = new Size(92, 30);
            lblKursHörsaal.TabIndex = 24;
            lblKursHörsaal.Text = "Hörsaal";
            // 
            // textBoxKursHörsaal
            // 
            textBoxKursHörsaal.BackColor = Color.FromArgb(30, 30, 30);
            textBoxKursHörsaal.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxKursHörsaal.ForeColor = Color.White;
            textBoxKursHörsaal.Location = new Point(277, 228);
            textBoxKursHörsaal.Name = "textBoxKursHörsaal";
            textBoxKursHörsaal.Size = new Size(256, 37);
            textBoxKursHörsaal.TabIndex = 23;
            // 
            // lblKursBeschreibung
            // 
            lblKursBeschreibung.AutoSize = true;
            lblKursBeschreibung.BackColor = Color.Transparent;
            lblKursBeschreibung.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursBeschreibung.ForeColor = Color.White;
            lblKursBeschreibung.Location = new Point(36, 116);
            lblKursBeschreibung.Name = "lblKursBeschreibung";
            lblKursBeschreibung.Size = new Size(200, 30);
            lblKursBeschreibung.TabIndex = 26;
            lblKursBeschreibung.Text = "Kursbeschreibung";
            // 
            // textBoxKursBeschreibung
            // 
            textBoxKursBeschreibung.BackColor = Color.FromArgb(30, 30, 30);
            textBoxKursBeschreibung.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxKursBeschreibung.ForeColor = Color.White;
            textBoxKursBeschreibung.Location = new Point(277, 109);
            textBoxKursBeschreibung.Name = "textBoxKursBeschreibung";
            textBoxKursBeschreibung.Size = new Size(256, 37);
            textBoxKursBeschreibung.TabIndex = 25;
            // 
            // dtPickerKursStartdatum
            // 
            dtPickerKursStartdatum.CalendarForeColor = Color.White;
            dtPickerKursStartdatum.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            dtPickerKursStartdatum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerKursStartdatum.Format = DateTimePickerFormat.Short;
            dtPickerKursStartdatum.Location = new Point(277, 289);
            dtPickerKursStartdatum.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickerKursStartdatum.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPickerKursStartdatum.Name = "dtPickerKursStartdatum";
            dtPickerKursStartdatum.Size = new Size(256, 37);
            dtPickerKursStartdatum.TabIndex = 28;
            dtPickerKursStartdatum.Value = new DateTime(2023, 12, 7, 17, 19, 58, 0);
            // 
            // lblKursStartDatum
            // 
            lblKursStartDatum.AutoSize = true;
            lblKursStartDatum.BackColor = Color.Transparent;
            lblKursStartDatum.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursStartDatum.ForeColor = Color.White;
            lblKursStartDatum.Location = new Point(36, 296);
            lblKursStartDatum.Name = "lblKursStartDatum";
            lblKursStartDatum.Size = new Size(194, 30);
            lblKursStartDatum.TabIndex = 27;
            lblKursStartDatum.Text = "Kurs Start-Datum";
            // 
            // dtPickerKursEnddatum
            // 
            dtPickerKursEnddatum.CalendarForeColor = Color.White;
            dtPickerKursEnddatum.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            dtPickerKursEnddatum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerKursEnddatum.Format = DateTimePickerFormat.Short;
            dtPickerKursEnddatum.Location = new Point(277, 343);
            dtPickerKursEnddatum.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickerKursEnddatum.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPickerKursEnddatum.Name = "dtPickerKursEnddatum";
            dtPickerKursEnddatum.Size = new Size(256, 37);
            dtPickerKursEnddatum.TabIndex = 30;
            dtPickerKursEnddatum.Value = new DateTime(2023, 12, 7, 17, 19, 58, 0);
            // 
            // lblKursEndDatum
            // 
            lblKursEndDatum.AutoSize = true;
            lblKursEndDatum.BackColor = Color.Transparent;
            lblKursEndDatum.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKursEndDatum.ForeColor = Color.White;
            lblKursEndDatum.Location = new Point(36, 350);
            lblKursEndDatum.Name = "lblKursEndDatum";
            lblKursEndDatum.Size = new Size(183, 30);
            lblKursEndDatum.TabIndex = 29;
            lblKursEndDatum.Text = "Kurs End-Datum";
            // 
            // btnBackToMainMenue
            // 
            btnBackToMainMenue.BackColor = Color.FromArgb(30, 30, 30);
            btnBackToMainMenue.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnBackToMainMenue.FlatAppearance.BorderSize = 2;
            btnBackToMainMenue.FlatStyle = FlatStyle.Flat;
            btnBackToMainMenue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMainMenue.ForeColor = Color.White;
            btnBackToMainMenue.Location = new Point(1066, 423);
            btnBackToMainMenue.Name = "btnBackToMainMenue";
            btnBackToMainMenue.Size = new Size(164, 42);
            btnBackToMainMenue.TabIndex = 35;
            btnBackToMainMenue.Text = "Hauptmenü";
            btnBackToMainMenue.UseVisualStyleBackColor = false;
            btnBackToMainMenue.Click += btnBackToMainMenue_Click;
            // 
            // btnKursFelderLeeren
            // 
            btnKursFelderLeeren.BackColor = Color.FromArgb(30, 30, 30);
            btnKursFelderLeeren.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnKursFelderLeeren.FlatAppearance.BorderSize = 2;
            btnKursFelderLeeren.FlatStyle = FlatStyle.Flat;
            btnKursFelderLeeren.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKursFelderLeeren.ForeColor = Color.White;
            btnKursFelderLeeren.Location = new Point(862, 423);
            btnKursFelderLeeren.Name = "btnKursFelderLeeren";
            btnKursFelderLeeren.Size = new Size(162, 42);
            btnKursFelderLeeren.TabIndex = 34;
            btnKursFelderLeeren.Text = "Felder leeren";
            btnKursFelderLeeren.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKursFelderLeeren.UseVisualStyleBackColor = false;
            // 
            // btnKursBearbeiten
            // 
            btnKursBearbeiten.BackColor = Color.FromArgb(30, 30, 30);
            btnKursBearbeiten.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnKursBearbeiten.FlatAppearance.BorderSize = 2;
            btnKursBearbeiten.FlatStyle = FlatStyle.Flat;
            btnKursBearbeiten.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKursBearbeiten.ForeColor = Color.White;
            btnKursBearbeiten.Location = new Point(469, 423);
            btnKursBearbeiten.Name = "btnKursBearbeiten";
            btnKursBearbeiten.Size = new Size(162, 42);
            btnKursBearbeiten.TabIndex = 33;
            btnKursBearbeiten.Text = "Bearbeiten";
            btnKursBearbeiten.UseVisualStyleBackColor = false;
            // 
            // btnKursLoeschen
            // 
            btnKursLoeschen.BackColor = Color.FromArgb(30, 30, 30);
            btnKursLoeschen.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnKursLoeschen.FlatAppearance.BorderSize = 2;
            btnKursLoeschen.FlatStyle = FlatStyle.Flat;
            btnKursLoeschen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKursLoeschen.ForeColor = Color.White;
            btnKursLoeschen.Location = new Point(665, 423);
            btnKursLoeschen.Name = "btnKursLoeschen";
            btnKursLoeschen.Size = new Size(162, 42);
            btnKursLoeschen.TabIndex = 32;
            btnKursLoeschen.Text = "Löschen";
            btnKursLoeschen.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKursLoeschen.UseVisualStyleBackColor = false;
            // 
            // btnKursSpeichern
            // 
            btnKursSpeichern.BackColor = Color.FromArgb(30, 30, 30);
            btnKursSpeichern.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnKursSpeichern.FlatAppearance.BorderSize = 2;
            btnKursSpeichern.FlatStyle = FlatStyle.Flat;
            btnKursSpeichern.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKursSpeichern.ForeColor = Color.White;
            btnKursSpeichern.Location = new Point(277, 423);
            btnKursSpeichern.Name = "btnKursSpeichern";
            btnKursSpeichern.Size = new Size(162, 42);
            btnKursSpeichern.TabIndex = 31;
            btnKursSpeichern.Text = "Speichern";
            btnKursSpeichern.UseVisualStyleBackColor = false;
            // 
            // KurseScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1265, 923);
            ControlBox = false;
            Controls.Add(btnBackToMainMenue);
            Controls.Add(btnKursFelderLeeren);
            Controls.Add(btnKursBearbeiten);
            Controls.Add(btnKursLoeschen);
            Controls.Add(btnKursSpeichern);
            Controls.Add(dtPickerKursEnddatum);
            Controls.Add(lblKursEndDatum);
            Controls.Add(dtPickerKursStartdatum);
            Controls.Add(lblKursStartDatum);
            Controls.Add(lblKursBeschreibung);
            Controls.Add(textBoxKursBeschreibung);
            Controls.Add(lblKursHörsaal);
            Controls.Add(textBoxKursHörsaal);
            Controls.Add(comboBoxKursSemester);
            Controls.Add(lblKursSemester);
            Controls.Add(lblKursBezeichnung);
            Controls.Add(txtBoxKursBezeichnung);
            Controls.Add(GridViewKurs);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "KurseScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kursdatenbank";
            ((System.ComponentModel.ISupportInitialize)GridViewKurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridViewKurs;
        private Label lblKursBezeichnung;
        private TextBox txtBoxKursBezeichnung;
        private Label lblKursSemester;
        private ComboBox comboBoxKursSemester;
        private Label lblKursHörsaal;
        private TextBox textBoxKursHörsaal;
        private Label lblKursBeschreibung;
        private TextBox textBoxKursBeschreibung;
        private DateTimePicker dtPickerKursStartdatum;
        private Label lblKursStartDatum;
        private DateTimePicker dtPickerKursEnddatum;
        private Label lblKursEndDatum;
        private Button btnBackToMainMenue;
        private Button btnKursFelderLeeren;
        private Button btnKursBearbeiten;
        private Button btnKursLoeschen;
        private Button btnKursSpeichern;
    }
}