namespace Hochschuldatenbank
{
    partial class LoadingScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingScreen));
            LblLoading = new Label();
            LoadingBar = new ProgressBar();
            LblLoadingValue = new Label();
            LoadingBarTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LblLoading
            // 
            LblLoading.Anchor = AnchorStyles.Bottom;
            LblLoading.AutoSize = true;
            LblLoading.BackColor = Color.Transparent;
            LblLoading.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblLoading.ForeColor = Color.White;
            LblLoading.Location = new Point(530, 635);
            LblLoading.Name = "LblLoading";
            LblLoading.Size = new Size(92, 28);
            LblLoading.TabIndex = 0;
            LblLoading.Text = "Loading:";
            // 
            // LoadingBar
            // 
            LoadingBar.Anchor = AnchorStyles.Bottom;
            LoadingBar.Location = new Point(26, 666);
            LoadingBar.Name = "LoadingBar";
            LoadingBar.Size = new Size(1170, 34);
            LoadingBar.TabIndex = 1;
            LoadingBar.Click += LoadingBar_Click;
            // 
            // LblLoadingValue
            // 
            LblLoadingValue.Anchor = AnchorStyles.Bottom;
            LblLoadingValue.AutoSize = true;
            LblLoadingValue.BackColor = Color.Transparent;
            LblLoadingValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            LblLoadingValue.ForeColor = Color.White;
            LblLoadingValue.Location = new Point(616, 635);
            LblLoadingValue.Name = "LblLoadingValue";
            LblLoadingValue.Size = new Size(41, 28);
            LblLoadingValue.TabIndex = 2;
            LblLoadingValue.Text = "0%";
            LblLoadingValue.Click += LblLoadingValue_Click;
            // 
            // LoadingBarTimer
            // 
            LoadingBarTimer.Tick += LoadingBarTimer_Tick;
            // 
            // LoadingScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1222, 736);
            ControlBox = false;
            Controls.Add(LblLoadingValue);
            Controls.Add(LoadingBar);
            Controls.Add(LblLoading);
            ForeColor = Color.Transparent;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingScreen";
            Load += LoadingScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblLoading;
        private ProgressBar LoadingBar;
        private Label LblLoadingValue;
        private System.Windows.Forms.Timer LoadingBarTimer;
    }
}
