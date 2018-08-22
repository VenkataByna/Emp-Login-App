using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_App
{
    public partial class LogIn : Form
    {
        
        public LogIn()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            label4.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("Data Source=MSEDGEWIN10;Initial Catalog=Employee;Integrated Security=True;Pooling=False");
            SqlCommand cmd = new SqlCommand("Select * from [Emp Login]", cn);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int empID=int.Parse(textBox1.Text);
                if((empID==reader.GetInt32(0)) && (textBox2.Text==reader.GetString(1)))
                {
                    string name = reader.GetString(2);
                    WelcomeForm WF = new WelcomeForm(name);
                    WF.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    label4.Text = "Invalid Username and Password";
                    label4.Show();
                }
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
