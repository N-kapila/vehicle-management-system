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

namespace Vehicle_and_Emaployee_Management_System
{
    public partial class enter_employee_data : Form
    {
        public enter_employee_data()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\NK\Vehicle and Employee Management System\Vehicle and Emaployee Management System\vehicleandemployeemanagement.mdf;Integrated Security=True");
        SqlCommand com;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            textBox5.Clear();
            textBox6.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            textBox1.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlinsert= "insert into employee(emp_id,nic,name,date_of_birth,e_mail,permenant_address,home,mobile)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "')";

                com = new SqlCommand(sqlinsert, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Employee Data inserted Successfully","Enter Data",MessageBoxButtons.OK,MessageBoxIcon.Information);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox5.Clear();
                textBox6.Clear();
                maskedTextBox1.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                textBox1.Focus();


            }
            catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            finally
            {
                con.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

