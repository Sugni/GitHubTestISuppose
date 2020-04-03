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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Don't mind me. I'm just a button to test adding changes to projects in github.");
        }
    }
}
