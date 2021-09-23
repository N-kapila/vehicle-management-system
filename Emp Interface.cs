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
    public partial class Emp_Interface : Form
    {
        public Emp_Interface()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection(@" Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\NK\Vehicle and Employee Management System\Vehicle and Emaployee Management System\vehicleandemployeemanagement.mdf;Integrated Security=True");
         string imgLocation = "";
           SqlCommand com;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

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


                if (dr.HasRows)
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

                    if (image == null)
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
                    MessageBox.Show("This SCS_No. Does not Exist. Please try again","Search error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                } 


            }
            catch (Exception ex)
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
             {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK) ;
            {
                imgLocation = opf.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
            emp_search_model frm = new emp_search_model();

            frm.Show();
            this.Hide();

        }
        }

    }

