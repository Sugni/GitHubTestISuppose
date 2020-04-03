using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubTestISuppose
{
    public partial class TestingGitHub : Form
    {

        Random rand = new Random();

        public TestingGitHub()
        {
            InitializeComponent();
        }

        private void butnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't mind me. I'm just a button to test adding changes to projects in github.");
        }

        private void butnThatIsBetter_Click(object sender, EventArgs e)
        {
            butnThatIsBetter.BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
        }
    }
}
