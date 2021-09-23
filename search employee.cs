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
    public partial class search_employee : Form
    {

        public search_employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\NK\Vehicle and Employee Management System\Vehicle and Emaployee Management System\vehicleandemployeemanagement.mdf;Integrated Security=True");
        SqlCommand com;
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                con.Open();
                string sqlselect = "select * from employee where emp_id = '" + textBox1.Text + "'";
                com = new SqlCommand(sqlselect, con);
                SqlDataReader dr;
                dr = com.ExecuteReader() ;
                dr.Read();
                textBox2.Text = dr["nic"].ToString();
                textBox3.Text = dr["name"].ToString();
                maskedTextBox1.Text = dr["date_of_birth"].ToString();
                textBox5.Text = dr["e_mail"].ToString();
                textBox6.Text = dr["permenant_address"].ToString();
                maskedTextBox2.Text = dr["home"].ToString();
                maskedTextBox3.Text = dr["mobile"].ToString();

            }
            catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
                finally
            {
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqlupdate = "update employee set nic='" + textBox2.Text + "',name='" + textBox3.Text + "',date_of_birth='" + maskedTextBox1.Text + "',e_mail='" + textBox5.Text + "',permenant_address='" + textBox6.Text + "',home='" + maskedTextBox2.Text + "',mobile='" + maskedTextBox3.Text + "' where emp_id='" + textBox1.Text + "'";
                com = new SqlCommand(sqlupdate, con);
                com.ExecuteNonQuery();
               textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                textBox6.Clear();
                maskedTextBox2.Clear();
                maskedTextBox3.Clear();
                textBox1.Focus();
                MessageBox.Show("Employee Data updated", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                             






                   
            }
            catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            finally
            {
                con.Close(); 
            }

               
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sqldelete = "delete from employee where emp_id='" + textBox1.Text + "'";
                    com=new SqlCommand(sqldelete,con);
                com.ExecuteNonQuery();
                MessageBox.Show("Employee Data Deleted","Delete Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            finally
            {
                con.Close();
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
