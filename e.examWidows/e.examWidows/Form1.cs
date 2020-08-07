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

namespace e.examWidows
{
     
    public partial class Form1 : Form
    {
        SqlConnection con1 = new SqlConnection();
        SqlCommand com1 = new SqlCommand();
        public Form1()
        {
            InitializeComponent();
            con1.ConnectionString = @"Data Source=DESKTOP-07O4ILP\CLIENT;Initial Catalog=e_exam;Integrated Security=True";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //con1.Open();
            //com1.Connection = con1;
            //com1.CommandText = " select*from prof ";
            //SqlDataReader dr1 = com1.ExecuteReader();
            //if (dr1.Read())
            //{
                if (textBox1.Text.Equals("111".ToString()) && textBox2.Text.Equals("111".ToString()))
                {

                    MessageBox.Show("login succsesfuly ");
                    this.Hide();
                    Form4 frm4 = new Form4();
                    frm4.Show();
                }
                else
                {
                    MessageBox.Show("incorrect data try again ");

                }

            //}



            //con1.Close();

        }
    }
}
