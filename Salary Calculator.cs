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
    
    public partial class Salary_Calculator : Form
    {
        public Salary_Calculator()
        {
            InitializeComponent();
        }
       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
           int value1,value2,value3,otall,tot,all ;
           float epf, etf, net ;
        private void button1_Click(object sender, EventArgs e)
        {
            

            value1 = int.Parse(textBox2.Text);
            value2 = int.Parse(textBox3.Text);

            otall = value2 * 250;
            tot = otall + value1;
            textBox4.Text = "Rs."+otall.ToString()+"/=";

             if(checkBox1.Checked == true && checkBox2.Checked==true)
             {
                 all = tot + 15000;
             }
                if(checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    all = tot + 0;
                }
                if (checkBox1.Checked == true && checkBox2.Checked == false)
                {
                    all = tot + 10000;
                }
                if (checkBox1.Checked == false && checkBox2.Checked == true)
                {
                    all = tot + 5000;
                }
                epf = all * 8 / 100;
                textBox5.Text = "Rs."+ epf.ToString()+ "/=" ;
                etf = all * 3 / 100;
                textBox6.Text = "Rs."+ etf.ToString()+"/=";

            
                net = all - epf - etf;
                textBox7.Text = "Rs."+ net.ToString()+ "/=";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox6.Clear();
            textBox7.Clear();





            checkBox1.Checked = false;
            checkBox2.Checked = false;
             


            textBox1.Focus();

        }
    }
}
