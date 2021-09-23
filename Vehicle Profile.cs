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
using System.IO;

namespace Vehicle_and_Emaployee_Management_System
{
    public partial class Vehicle_Profile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\NK\Vehicle and Employee Management System\Vehicle and Emaployee Management System\vehicleandemployeemanagement.mdf;Integrated Security=True");
        string imgLocation = "";
        SqlCommand com;
        public Vehicle_Profile()
        {
            InitializeComponent();
        }
        
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string sqlQuery = "select model,release_year,transmission,condition,milage,fuel_type,registration_no,selling_price,external_color,engine_size,image from vehicle where scs_no='" + textBox2.Text + "'";
                com = new SqlCommand(sqlQuery, con);
                SqlDataReader dr = com.ExecuteReader();
                dr.Read();
                if(dr.HasRows)
                {
                    textBox1.Text = dr[0].ToString();
                    textBox3.Text = dr[1].ToString();
                    comboBox1.Text = dr[2].ToString();
                    comboBox2.Text = dr[3].ToString();
                    textBox4.Text = dr[4].ToString();
                    comboBox3.Text = dr[5].ToString();
                    textBox5.Text = dr[6].ToString();
                    textBox6.Text = dr[7].ToString();
                    textBox7.Text = dr[8].ToString();
                    textBox8.Text = dr[9].ToString();
                    byte[] image = (byte[])dr[10];

                    if(image == null)
                    {
                        pictureBox1.Image = null;

                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(image);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                   

                }
                else
                {
                    MessageBox.Show("Please Check the SCS No and Try Again","error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
                catch(Exception err)
            {
                    MessageBox.Show(err.Message);
                
                }
            finally
            {

                con.Close();
            }

            }

        private void button4_Click(object sender, EventArgs e)
        {
             try
            {
                con.Open();
                string sqlupdate = "update vehicle set model='" + textBox1.Text + "',release_year='" + textBox3.Text + "',transmission='" + comboBox1.Text + "',condition='" + comboBox2.Text + "',milage='" + textBox4.Text + "',fuel_type='" + comboBox3.Text + "',registration_no='" + textBox5.Text + "',selling_price='" + textBox6.Text + "',external_color='" + textBox7.Text + "',engine_size='" + textBox8.Text + "' where scs_no = '"+textBox2.Text+"'";

                com = new SqlCommand(sqlupdate, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Vehicle Data updated","Update Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
               
               
                textBox2.Focus();

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                con.Close();
            }
             textBox1.Clear();
             textBox2.Clear();
             textBox3.Clear();
             textBox4.Clear();
             textBox5.Clear();
             textBox6.Clear();
             textBox7.Clear();
             textBox8.Clear();
             comboBox1.Text = "";
             comboBox2.Text = "";
             comboBox3.Text = "";
             textBox2.Focus();
             pictureBox1.Image = null;
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
        OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK) ;
            {
                imgLocation = opf.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
            {
                con.Open();
                string sqldelete = "delete from vehicle where scs_no='" + textBox2.Text + "'";
                com = new SqlCommand(sqldelete, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Vehicle Data Deleted","Delete successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                pictureBox1.Image = null;

                textBox2.Clear();
                textBox2.Focus();


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                con.Close();
            }
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vehicle_Profile_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
            
            
           
        }
    /*
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
        }*/
    }


