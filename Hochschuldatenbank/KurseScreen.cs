using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hochschuldatenbank
{
    public partial class KurseScreen : Form
    {
        public KurseScreen()
        {
            InitializeComponent();
        }

        private void btnBackToMainMenue_Click(object sender, EventArgs e)
        {
            MainMenueScreen mainMenueScreen = new MainMenueScreen();
            mainMenueScreen.Show();
            this.Hide();
        }
    }
}
