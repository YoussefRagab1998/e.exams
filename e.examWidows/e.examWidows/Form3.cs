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
    public partial class Form3 : Form

    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-07O4ILP\CLIENT;Initial Catalog=e_exam;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = " select*from studnt_professor ";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read()) {
                if (textBox1.Text.Equals(dr["student_id"].ToString()) && textBox2.Text.Equals(dr["pass"].ToString()))
                {

                    MessageBox.Show("login succsesfuly ");
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else {
                    MessageBox.Show("incorrect data try again ");

                }
            
            }



            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }
    }
}
