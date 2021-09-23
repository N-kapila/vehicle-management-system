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
    public partial class emp_search_model : Form
    {
        public emp_search_model()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\NK\Vehicle and Employee Management System\Vehicle and Emaployee Management System\vehicleandemployeemanagement.mdf;Integrated Security=True");
        SqlCommand com;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select scs_no,model,release_year,external_color from  vehicle where model= '" + textBox1.Text + "'";

                com = new SqlCommand(sql, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "select scs_no,model,release_year,external_color from vehicle";
                com = new SqlCommand(sql, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
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
            Emp_Interface frm6 = new Emp_Interface();
            frm6.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }
    }
}
