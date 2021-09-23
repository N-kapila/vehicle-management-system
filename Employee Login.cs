using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_and_Emaployee_Management_System
{
    public partial class Employee_Login : Form
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="emp@supercarsales" && textBox2.Text=="emp@123")
            { emp_search_model emp = new emp_search_model();
              emp.Show();
              this.Hide();
            }
            else
            {
                MessageBox.Show("User name or Password Incorrect. Please try again", "Login Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
         }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();

        }

        private void Employee_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
