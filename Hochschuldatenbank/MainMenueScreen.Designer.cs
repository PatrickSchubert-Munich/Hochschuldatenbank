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
            btnStudentenMainMenue = new Button();
            btnDozentenMainMenue = new Button();
            SuspendLayout();
            // 
            // btnStudentenMainMenue
            // 
            btnStudentenMainMenue.BackgroundImage = (Image)resources.GetObject("btnStudentenMainMenue.BackgroundImage");
            btnStudentenMainMenue.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnStudentenMainMenue.FlatAppearance.BorderSize = 2;
            btnStudentenMainMenue.FlatAppearance.MouseOverBackColor = Color.White;
            btnStudentenMainMenue.FlatStyle = FlatStyle.Popup;
            btnStudentenMainMenue.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentenMainMenue.ForeColor = Color.Black;
            btnStudentenMainMenue.Location = new Point(53, 51);
            btnStudentenMainMenue.Name = "btnStudentenMainMenue";
            btnStudentenMainMenue.Size = new Size(401, 225);
            btnStudentenMainMenue.TabIndex = 0;
            btnStudentenMainMenue.Text = "Studenten";
            btnStudentenMainMenue.UseVisualStyleBackColor = true;
            btnStudentenMainMenue.Click += btnStudenten_Click;
            // 
            // btnDozentenMainMenue
            // 
            btnDozentenMainMenue.BackgroundImage = (Image)resources.GetObject("btnDozentenMainMenue.BackgroundImage");
            btnDozentenMainMenue.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnDozentenMainMenue.FlatAppearance.BorderSize = 2;
            btnDozentenMainMenue.FlatAppearance.MouseOverBackColor = Color.White;
            btnDozentenMainMenue.FlatStyle = FlatStyle.Popup;
            btnDozentenMainMenue.Font = new Font("Arial", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDozentenMainMenue.ForeColor = Color.White;
            btnDozentenMainMenue.Location = new Point(493, 51);
            btnDozentenMainMenue.Name = "btnDozentenMainMenue";
            btnDozentenMainMenue.Size = new Size(400, 227);
            btnDozentenMainMenue.TabIndex = 1;
            btnDozentenMainMenue.Text = "Dozenten";
            btnDozentenMainMenue.UseVisualStyleBackColor = true;
            btnDozentenMainMenue.Click += btnDozenten_Click;
            // 
            // MainMenueScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(956, 338);
            ControlBox = false;
            Controls.Add(btnDozentenMainMenue);
            Controls.Add(btnStudentenMainMenue);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenueScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hauptmenü";
            Load += MainMenueScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStudentenMainMenue;
        private Button btnDozentenMainMenue;
    }
}