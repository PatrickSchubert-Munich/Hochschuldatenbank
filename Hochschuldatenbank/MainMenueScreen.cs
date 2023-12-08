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
    public partial class MainMenueScreen : Form
    {
        public MainMenueScreen()
        {
            InitializeComponent();
        }

        private void btnStudenten_Click(object sender, EventArgs e)
        {
            StudentenScreen studentenScreen = new StudentenScreen();
            studentenScreen.Show();
            this.Hide();
        }

        private void btnDozenten_Click(object sender, EventArgs e)
        {
            DozentenScreen dozentenScreen = new DozentenScreen();
            dozentenScreen.Show();
            this.Hide();
        }

        private void btnKurseMainMenue_Click(object sender, EventArgs e)
        {
            KurseScreen kurseScreen = new KurseScreen();
            kurseScreen.Show();
            this.Hide();
        }
    }
}
