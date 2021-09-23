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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_login frm = new Admin_login();
            frm.Show();
            this.Hide();
              
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Login emp = new Employee_Login();
            emp.Show();
            this.Hide();
        }
    }
}
