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
            btnStudenten = new Button();
            btnDozenten = new Button();
            SuspendLayout();
            // 
            // btnStudenten
            // 
            btnStudenten.Location = new Point(34, 31);
            btnStudenten.Name = "btnStudenten";
            btnStudenten.Size = new Size(324, 168);
            btnStudenten.TabIndex = 0;
            btnStudenten.Text = "Studenten";
            btnStudenten.UseVisualStyleBackColor = true;
            // 
            // btnDozenten
            // 
            btnDozenten.Location = new Point(396, 31);
            btnDozenten.Name = "btnDozenten";
            btnDozenten.Size = new Size(308, 168);
            btnDozenten.TabIndex = 1;
            btnDozenten.Text = "Dozenten";
            btnDozenten.UseVisualStyleBackColor = true;
            // 
            // MainMenueScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 237);
            ControlBox = false;
            Controls.Add(btnDozenten);
            Controls.Add(btnStudenten);
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