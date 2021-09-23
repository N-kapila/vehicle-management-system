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
    public partial class Admin_Interface : Form
    {
        public Admin_Interface()
        {
            InitializeComponent();
        }

        private void enterDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enter_vehicle_details frm1 = new Enter_vehicle_details();
            frm1.MdiParent = this;
            frm1.Show();
           


        }

        private void enterDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            enter_employee_data frm2 = new enter_employee_data();
            frm2.MdiParent= this;
            frm2.Show();
        }

        private void salaryCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_Calculator frm3 = new Salary_Calculator();
            frm3.MdiParent = this;
            frm3.Show();
        }

        private void manageDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_employee frm4 = new search_employee();
            frm4.MdiParent = this;
            frm4.Show();

        }

        private void manageDeailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_vehicle_details frm5 = new search_vehicle_details();
            frm5.MdiParent = this ;
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void Admin_Interface_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void employeeManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vehicleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
