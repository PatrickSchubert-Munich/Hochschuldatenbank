namespace Hochschuldatenbank
{
    partial class MainMenueScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenueScreen));
            btnStudenten = new Button();
            btnDozenten = new Button();
            SuspendLayout();
            // 
            // btnStudenten
            // 
            btnStudenten.BackgroundImage = (Image)resources.GetObject("btnStudenten.BackgroundImage");
            btnStudenten.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudenten.ForeColor = Color.MediumBlue;
            btnStudenten.Location = new Point(53, 51);
            btnStudenten.Name = "btnStudenten";
            btnStudenten.Size = new Size(401, 225);
            btnStudenten.TabIndex = 0;
            btnStudenten.Text = "Studenten";
            btnStudenten.UseVisualStyleBackColor = true;
            // 
            // btnDozenten
            // 
            btnDozenten.BackgroundImage = (Image)resources.GetObject("btnDozenten.BackgroundImage");
            btnDozenten.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozenten.ForeColor = Color.MediumBlue;
            btnDozenten.Location = new Point(493, 51);
            btnDozenten.Name = "btnDozenten";
            btnDozenten.Size = new Size(400, 227);
            btnDozenten.TabIndex = 1;
            btnDozenten.Text = "Dozenten";
            btnDozenten.UseVisualStyleBackColor = true;
            // 
            // MainMenueScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(956, 338);
            ControlBox = false;
            Controls.Add(btnDozenten);
            Controls.Add(btnStudenten);
            ForeColor = SystemColors.ControlText;
            Name = "MainMenueScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hauptmenü";
            Load += MainMenueScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudenten;
        private Button btnDozenten;
    }
}