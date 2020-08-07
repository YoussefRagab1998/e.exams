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
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        public Form4()
        {
            InitializeComponent();
            
        
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = @"Data Source=DESKTOP-07O4ILP\CLIENT;Initial Catalog=e_exam;Integrated Security=True";
            da = new SqlDataAdapter("select *from student", cn);
            da.Fill(ds, "stu_info");
            dataGridView1.DataSource = ds.Tables["stu_info"];
        }
    }
}
