using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_App
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string name)
        {
            InitializeComponent();
            label1.Text = "Hello " + name;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
