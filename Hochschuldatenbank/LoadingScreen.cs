namespace Hochschuldatenbank
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingBarTimer.Start();
        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 1;
            LoadingBar.Value = loadingBarValue;
            LblLoadingValue.Text = String.Format("{0}%", loadingBarValue);

            if (loadingBarValue >= 100)
            {
                LoadingBarTimer.Stop();
            }
        }

        private void LoadingBar_Click(object sender, EventArgs e)
        {

        }

        private void LblLoadingValue_Click(object sender, EventArgs e)
        {
            
        }
    }
}
