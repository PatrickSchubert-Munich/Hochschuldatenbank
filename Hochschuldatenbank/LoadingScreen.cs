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

            LblLoadingValue.Text = String.Format("{0}%", loadingBarValue);
            LoadingBar.Value = loadingBarValue;

            if (loadingBarValue >= LoadingBar.Maximum)
            {
                LoadingBarTimer.Stop();
                Thread.Sleep(2000);

                // Hide LoadingScreen (this - Object)
                this.Hide();

                // Loading MainMenueScreen
                Hochschulverwaltung mainManueScreen = new Hochschulverwaltung();
                mainManueScreen.Show();
            }
            
            // Finish Loading

        }
    }
}
