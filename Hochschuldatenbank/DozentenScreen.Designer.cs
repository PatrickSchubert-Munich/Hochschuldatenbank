using System.Windows.Forms;

namespace Hochschuldatenbank
{
    partial class DozentenScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DozentenScreen));
            btnDozentSpeichern = new Button();
            btnDozentLoeschen = new Button();
            btnDozentBearbeiten = new Button();
            txtBoxDozentVorname = new TextBox();
            lblDozentVorname = new Label();
            lblDozentNachname = new Label();
            txtBoxDozentNachname = new TextBox();
            lblDozentGeschlecht = new Label();
            radioBtnDozentMaennlich = new RadioButton();
            radioBtnDozentWeiblich = new RadioButton();
            lblDozentGeburtsdatum = new Label();
            lblDozentAdresse = new Label();
            txtBoxDozentAdresse = new TextBox();
            lblDozentAbschluss = new Label();
            comboBoxDozentAbschluss = new ComboBox();
            btnDozentFelderLeeren = new Button();
            GridViewDozent = new DataGridView();
            lblDozentFakultaet = new Label();
            comboBoxDozentFakultaet = new ComboBox();
            lblDozentDienstzimmer = new Label();
            txtBoxDozentDienstzimmer = new TextBox();
            btnBackToMainMenue = new Button();
            dtPickerDozent = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)GridViewDozent).BeginInit();
            SuspendLayout();
            // 
            // btnDozentSpeichern
            // 
            btnDozentSpeichern.BackColor = Color.FromArgb(30, 30, 30);
            btnDozentSpeichern.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnDozentSpeichern.FlatAppearance.BorderSize = 2;
            btnDozentSpeichern.FlatStyle = FlatStyle.Flat;
            btnDozentSpeichern.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozentSpeichern.ForeColor = Color.White;
            btnDozentSpeichern.Location = new Point(192, 405);
            btnDozentSpeichern.Name = "btnDozentSpeichern";
            btnDozentSpeichern.Size = new Size(162, 42);
            btnDozentSpeichern.TabIndex = 0;
            btnDozentSpeichern.Text = "Speichern";
            btnDozentSpeichern.UseVisualStyleBackColor = false;
            btnDozentSpeichern.Click += btnDozentSpeichern_Click;
            // 
            // btnDozentLoeschen
            // 
            btnDozentLoeschen.BackColor = Color.FromArgb(30, 30, 30);
            btnDozentLoeschen.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnDozentLoeschen.FlatAppearance.BorderSize = 2;
            btnDozentLoeschen.FlatStyle = FlatStyle.Flat;
            btnDozentLoeschen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozentLoeschen.ForeColor = Color.White;
            btnDozentLoeschen.Location = new Point(629, 405);
            btnDozentLoeschen.Name = "btnDozentLoeschen";
            btnDozentLoeschen.Size = new Size(162, 42);
            btnDozentLoeschen.TabIndex = 1;
            btnDozentLoeschen.Text = "Löschen";
            btnDozentLoeschen.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDozentLoeschen.UseVisualStyleBackColor = false;
            btnDozentLoeschen.Click += btnDozentLoeschen_Click;
            // 
            // btnDozentBearbeiten
            // 
            btnDozentBearbeiten.BackColor = Color.FromArgb(30, 30, 30);
            btnDozentBearbeiten.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnDozentBearbeiten.FlatAppearance.BorderSize = 2;
            btnDozentBearbeiten.FlatStyle = FlatStyle.Flat;
            btnDozentBearbeiten.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozentBearbeiten.ForeColor = Color.White;
            btnDozentBearbeiten.Location = new Point(410, 405);
            btnDozentBearbeiten.Name = "btnDozentBearbeiten";
            btnDozentBearbeiten.Size = new Size(162, 42);
            btnDozentBearbeiten.TabIndex = 2;
            btnDozentBearbeiten.Text = "Bearbeiten";
            btnDozentBearbeiten.UseVisualStyleBackColor = false;
            btnDozentBearbeiten.Click += btnDozentBearbeiten_Click;
            // 
            // txtBoxDozentVorname
            // 
            txtBoxDozentVorname.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxDozentVorname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDozentVorname.ForeColor = Color.White;
            txtBoxDozentVorname.Location = new Point(192, 67);
            txtBoxDozentVorname.Name = "txtBoxDozentVorname";
            txtBoxDozentVorname.Size = new Size(256, 37);
            txtBoxDozentVorname.TabIndex = 3;
            // 
            // lblDozentVorname
            // 
            lblDozentVorname.AutoSize = true;
            lblDozentVorname.BackColor = Color.Transparent;
            lblDozentVorname.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentVorname.ForeColor = Color.White;
            lblDozentVorname.Location = new Point(30, 74);
            lblDozentVorname.Name = "lblDozentVorname";
            lblDozentVorname.Size = new Size(106, 30);
            lblDozentVorname.TabIndex = 4;
            lblDozentVorname.Text = "Vorname";
            // 
            // lblDozentNachname
            // 
            lblDozentNachname.AutoSize = true;
            lblDozentNachname.BackColor = Color.Transparent;
            lblDozentNachname.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentNachname.ForeColor = Color.White;
            lblDozentNachname.Location = new Point(30, 126);
            lblDozentNachname.Name = "lblDozentNachname";
            lblDozentNachname.Size = new Size(123, 30);
            lblDozentNachname.TabIndex = 5;
            lblDozentNachname.Text = "Nachname";
            // 
            // txtBoxDozentNachname
            // 
            txtBoxDozentNachname.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxDozentNachname.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDozentNachname.ForeColor = Color.White;
            txtBoxDozentNachname.Location = new Point(192, 119);
            txtBoxDozentNachname.Name = "txtBoxDozentNachname";
            txtBoxDozentNachname.Size = new Size(256, 37);
            txtBoxDozentNachname.TabIndex = 6;
            // 
            // lblDozentGeschlecht
            // 
            lblDozentGeschlecht.AutoSize = true;
            lblDozentGeschlecht.BackColor = Color.Transparent;
            lblDozentGeschlecht.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentGeschlecht.ForeColor = Color.White;
            lblDozentGeschlecht.Location = new Point(30, 179);
            lblDozentGeschlecht.Name = "lblDozentGeschlecht";
            lblDozentGeschlecht.Size = new Size(126, 30);
            lblDozentGeschlecht.TabIndex = 7;
            lblDozentGeschlecht.Text = "Geschlecht";
            // 
            // radioBtnDozentMaennlich
            // 
            radioBtnDozentMaennlich.AutoSize = true;
            radioBtnDozentMaennlich.BackColor = Color.Transparent;
            radioBtnDozentMaennlich.Checked = true;
            radioBtnDozentMaennlich.FlatAppearance.BorderColor = Color.DimGray;
            radioBtnDozentMaennlich.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnDozentMaennlich.ForeColor = Color.White;
            radioBtnDozentMaennlich.Location = new Point(192, 179);
            radioBtnDozentMaennlich.Name = "radioBtnDozentMaennlich";
            radioBtnDozentMaennlich.Size = new Size(129, 34);
            radioBtnDozentMaennlich.TabIndex = 8;
            radioBtnDozentMaennlich.TabStop = true;
            radioBtnDozentMaennlich.Text = "männlich";
            radioBtnDozentMaennlich.UseVisualStyleBackColor = false;
            // 
            // radioBtnDozentWeiblich
            // 
            radioBtnDozentWeiblich.AutoSize = true;
            radioBtnDozentWeiblich.BackColor = Color.Transparent;
            radioBtnDozentWeiblich.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnDozentWeiblich.ForeColor = Color.White;
            radioBtnDozentWeiblich.Location = new Point(327, 179);
            radioBtnDozentWeiblich.Name = "radioBtnDozentWeiblich";
            radioBtnDozentWeiblich.Size = new Size(121, 34);
            radioBtnDozentWeiblich.TabIndex = 9;
            radioBtnDozentWeiblich.Text = "weiblich";
            radioBtnDozentWeiblich.UseVisualStyleBackColor = false;
            // 
            // lblDozentGeburtsdatum
            // 
            lblDozentGeburtsdatum.AutoSize = true;
            lblDozentGeburtsdatum.BackColor = Color.Transparent;
            lblDozentGeburtsdatum.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentGeburtsdatum.ForeColor = Color.White;
            lblDozentGeburtsdatum.Location = new Point(30, 231);
            lblDozentGeburtsdatum.Name = "lblDozentGeburtsdatum";
            lblDozentGeburtsdatum.Size = new Size(140, 30);
            lblDozentGeburtsdatum.TabIndex = 10;
            lblDozentGeburtsdatum.Text = "Geb.-Datum";
            // 
            // lblDozentAdresse
            // 
            lblDozentAdresse.AutoSize = true;
            lblDozentAdresse.BackColor = Color.Transparent;
            lblDozentAdresse.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentAdresse.ForeColor = Color.White;
            lblDozentAdresse.Location = new Point(30, 281);
            lblDozentAdresse.Name = "lblDozentAdresse";
            lblDozentAdresse.Size = new Size(95, 30);
            lblDozentAdresse.TabIndex = 11;
            lblDozentAdresse.Text = "Adresse";
            // 
            // txtBoxDozentAdresse
            // 
            txtBoxDozentAdresse.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxDozentAdresse.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDozentAdresse.ForeColor = Color.White;
            txtBoxDozentAdresse.Location = new Point(192, 274);
            txtBoxDozentAdresse.Name = "txtBoxDozentAdresse";
            txtBoxDozentAdresse.Size = new Size(256, 37);
            txtBoxDozentAdresse.TabIndex = 12;
            // 
            // lblDozentAbschluss
            // 
            lblDozentAbschluss.AutoSize = true;
            lblDozentAbschluss.BackColor = Color.Transparent;
            lblDozentAbschluss.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentAbschluss.ForeColor = Color.White;
            lblDozentAbschluss.Location = new Point(30, 336);
            lblDozentAbschluss.Name = "lblDozentAbschluss";
            lblDozentAbschluss.Size = new Size(115, 30);
            lblDozentAbschluss.TabIndex = 13;
            lblDozentAbschluss.Text = "Abschluss";
            // 
            // comboBoxDozentAbschluss
            // 
            comboBoxDozentAbschluss.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxDozentAbschluss.FlatStyle = FlatStyle.Flat;
            comboBoxDozentAbschluss.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDozentAbschluss.ForeColor = Color.White;
            comboBoxDozentAbschluss.FormattingEnabled = true;
            comboBoxDozentAbschluss.Items.AddRange(new object[] { "Dr.", "Dr. Dr.", "Dr. Prof.", "Dr. Dr. Prof.", "Dr. Prof. Hab.", "Dr. Dr. Prof. Hab." });
            comboBoxDozentAbschluss.Location = new Point(192, 328);
            comboBoxDozentAbschluss.Name = "comboBoxDozentAbschluss";
            comboBoxDozentAbschluss.Size = new Size(256, 38);
            comboBoxDozentAbschluss.TabIndex = 14;
            // 
            // btnDozentFelderLeeren
            // 
            btnDozentFelderLeeren.BackColor = Color.FromArgb(30, 30, 30);
            btnDozentFelderLeeren.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnDozentFelderLeeren.FlatAppearance.BorderSize = 2;
            btnDozentFelderLeeren.FlatStyle = FlatStyle.Flat;
            btnDozentFelderLeeren.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozentFelderLeeren.ForeColor = Color.White;
            btnDozentFelderLeeren.Location = new Point(846, 405);
            btnDozentFelderLeeren.Name = "btnDozentFelderLeeren";
            btnDozentFelderLeeren.Size = new Size(162, 42);
            btnDozentFelderLeeren.TabIndex = 15;
            btnDozentFelderLeeren.Text = "Felder leeren";
            btnDozentFelderLeeren.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDozentFelderLeeren.UseVisualStyleBackColor = false;
            btnDozentFelderLeeren.Click += btnDozentFelderLeeren_Click;
            // 
            // GridViewDozent
            // 
            GridViewDozent.AllowUserToAddRows = false;
            GridViewDozent.AllowUserToDeleteRows = false;
            GridViewDozent.AllowUserToResizeColumns = false;
            GridViewDozent.AllowUserToResizeRows = false;
            GridViewDozent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridViewDozent.BackgroundColor = Color.FromArgb(30, 30, 30);
            GridViewDozent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GridViewDozent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GridViewDozent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewDozent.GridColor = Color.White;
            GridViewDozent.Location = new Point(30, 480);
            GridViewDozent.MultiSelect = false;
            GridViewDozent.Name = "GridViewDozent";
            GridViewDozent.ReadOnly = true;
            GridViewDozent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            GridViewDozent.RowHeadersVisible = false;
            GridViewDozent.RowHeadersWidth = 62;
            GridViewDozent.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            GridViewDozent.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
            GridViewDozent.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            GridViewDozent.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DimGray;
            GridViewDozent.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            GridViewDozent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridViewDozent.Size = new Size(1209, 382);
            GridViewDozent.TabIndex = 16;
            GridViewDozent.CellContentClick += GridViewDozent_CellContentClick;
            // 
            // lblDozentFakultaet
            // 
            lblDozentFakultaet.AutoSize = true;
            lblDozentFakultaet.BackColor = Color.Transparent;
            lblDozentFakultaet.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentFakultaet.ForeColor = Color.White;
            lblDozentFakultaet.Location = new Point(508, 74);
            lblDozentFakultaet.Name = "lblDozentFakultaet";
            lblDozentFakultaet.Size = new Size(96, 30);
            lblDozentFakultaet.TabIndex = 17;
            lblDozentFakultaet.Text = "Fakultät";
            // 
            // comboBoxDozentFakultaet
            // 
            comboBoxDozentFakultaet.BackColor = Color.FromArgb(30, 30, 30);
            comboBoxDozentFakultaet.FlatStyle = FlatStyle.Flat;
            comboBoxDozentFakultaet.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxDozentFakultaet.ForeColor = Color.White;
            comboBoxDozentFakultaet.FormattingEnabled = true;
            comboBoxDozentFakultaet.Items.AddRange(new object[] { "FK01", "FK02", "FK03", "FK04", "FK05", "FK06", "FK07", "FK08", "FK09", "FK10", "FK11", "FK12" });
            comboBoxDozentFakultaet.Location = new Point(701, 66);
            comboBoxDozentFakultaet.Name = "comboBoxDozentFakultaet";
            comboBoxDozentFakultaet.Size = new Size(256, 38);
            comboBoxDozentFakultaet.TabIndex = 18;
            // 
            // lblDozentDienstzimmer
            // 
            lblDozentDienstzimmer.AutoSize = true;
            lblDozentDienstzimmer.BackColor = Color.Transparent;
            lblDozentDienstzimmer.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDozentDienstzimmer.ForeColor = Color.White;
            lblDozentDienstzimmer.Location = new Point(508, 126);
            lblDozentDienstzimmer.Name = "lblDozentDienstzimmer";
            lblDozentDienstzimmer.Size = new Size(157, 30);
            lblDozentDienstzimmer.TabIndex = 19;
            lblDozentDienstzimmer.Text = "Dienstzimmer";
            // 
            // txtBoxDozentDienstzimmer
            // 
            txtBoxDozentDienstzimmer.BackColor = Color.FromArgb(30, 30, 30);
            txtBoxDozentDienstzimmer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxDozentDienstzimmer.ForeColor = Color.White;
            txtBoxDozentDienstzimmer.Location = new Point(701, 119);
            txtBoxDozentDienstzimmer.Name = "txtBoxDozentDienstzimmer";
            txtBoxDozentDienstzimmer.Size = new Size(256, 37);
            txtBoxDozentDienstzimmer.TabIndex = 20;
            // 
            // btnBackToMainMenue
            // 
            btnBackToMainMenue.BackColor = Color.FromArgb(30, 30, 30);
            btnBackToMainMenue.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            btnBackToMainMenue.FlatAppearance.BorderSize = 2;
            btnBackToMainMenue.FlatStyle = FlatStyle.Flat;
            btnBackToMainMenue.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToMainMenue.ForeColor = Color.White;
            btnBackToMainMenue.Location = new Point(1075, 405);
            btnBackToMainMenue.Name = "btnBackToMainMenue";
            btnBackToMainMenue.Size = new Size(164, 42);
            btnBackToMainMenue.TabIndex = 21;
            btnBackToMainMenue.Text = "Hauptmenü";
            btnBackToMainMenue.UseVisualStyleBackColor = false;
            btnBackToMainMenue.Click += btnBackToMainMenue_Click;
            // 
            // dtPickerDozent
            // 
            dtPickerDozent.CalendarForeColor = Color.White;
            dtPickerDozent.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            dtPickerDozent.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPickerDozent.Format = DateTimePickerFormat.Short;
            dtPickerDozent.Location = new Point(192, 219);
            dtPickerDozent.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtPickerDozent.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtPickerDozent.Name = "dtPickerDozent";
            dtPickerDozent.Size = new Size(256, 37);
            dtPickerDozent.TabIndex = 24;
            dtPickerDozent.Value = new DateTime(2023, 12, 7, 17, 19, 58, 0);
            // 
            // DozentenScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1274, 892);
            ControlBox = false;
            Controls.Add(dtPickerDozent);
            Controls.Add(btnBackToMainMenue);
            Controls.Add(txtBoxDozentDienstzimmer);
            Controls.Add(lblDozentDienstzimmer);
            Controls.Add(comboBoxDozentFakultaet);
            Controls.Add(lblDozentFakultaet);
            Controls.Add(GridViewDozent);
            Controls.Add(btnDozentFelderLeeren);
            Controls.Add(comboBoxDozentAbschluss);
            Controls.Add(lblDozentAbschluss);
            Controls.Add(txtBoxDozentAdresse);
            Controls.Add(lblDozentAdresse);
            Controls.Add(lblDozentGeburtsdatum);
            Controls.Add(radioBtnDozentWeiblich);
            Controls.Add(radioBtnDozentMaennlich);
            Controls.Add(lblDozentGeschlecht);
            Controls.Add(txtBoxDozentNachname);
            Controls.Add(lblDozentNachname);
            Controls.Add(lblDozentVorname);
            Controls.Add(txtBoxDozentVorname);
            Controls.Add(btnDozentBearbeiten);
            Controls.Add(btnDozentLoeschen);
            Controls.Add(btnDozentSpeichern);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DozentenScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dozentendatenbank";
            ((System.ComponentModel.ISupportInitialize)GridViewDozent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDozentSpeichern;
        private Button btnDozentLoeschen;
        private Button btnDozentBearbeiten;
        private TextBox txtBoxDozentVorname;
        private Label lblDozentVorname;
        private Label lblDozentNachname;
        private TextBox txtBoxDozentNachname;
        private Label lblDozentGeschlecht;
        private RadioButton radioBtnDozentMaennlich;
        private RadioButton radioBtnDozentWeiblich;
        private Label lblDozentGeburtsdatum;
        private Label lblDozentAdresse;
        private TextBox txtBoxDozentAdresse;
        private Label lblDozentAbschluss;
        private ComboBox comboBoxDozentAbschluss;
        private Button btnDozentFelderLeeren;
        private DataGridView GridViewDozent;
        private Label lblDozentFakultaet;
        private ComboBox comboBoxDozentFakultaet;
        private Label lblDozentDienstzimmer;
        private TextBox txtBoxDozentDienstzimmer;
        private Button btnBackToMainMenue;
        private DateTimePicker dtPickerDozent;
    }
}