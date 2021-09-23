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
    public partial class Enter_vehicle_details : Form
    {
      
        public Enter_vehicle_details()
        {
             
    
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\NK\Vehicle and Employee Management System\Vehicle and Emaployee Management System\vehicleandemployeemanagement.mdf;Integrated Security=True");
        string imgLocation = "";
        SqlCommand com;
        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] image = null;
            FileStream stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            image=brs.ReadBytes((int)stream.Length);
            
            
            con.Open();
            string sqlQuery = "insert into vehicle(scs_no,model,release_year,transmission,condition,milage,fuel_type,registration_no,selling_price,external_color,engine_size,image)values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + comboBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "',@image)";
            com= new SqlCommand(sqlQuery,con);
            com.Parameters.Add(new SqlParameter("@image",image));
            int N = com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(N.ToString()+"Vehicle data inserted successfully","Insert Data",MessageBoxButtons.OK,MessageBoxIcon.Information);


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
            textBox2.Clear();
            pictureBox1.Image = null;
            textBox2.Focus();
            }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK);
            {
              imgLocation= opf.FileName.ToString();
                pictureBox1.ImageLocation=imgLocation;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

