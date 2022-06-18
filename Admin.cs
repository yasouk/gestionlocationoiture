using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gestionlocationoiture
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=(LocalDB)/MSSQLLocalDB;AttachDbFilename=C: /Users/Yassin/Desktop/glv/car rent project/CarRentalDB/CarRentalCsDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from AdminTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            managerDGV.DataSource = ds.Tables[0];
            Con.Close();

        }
       
        //button1_click refers to add in admin page
        private void button1_Click(object sender, EventArgs e)
        {
            if(MId.Text =="" || ManId.Text == "" || ManPwd.Text == "") 
             {
                MessageBox.Show("missing information");
             }
            else 
             {
                try
                {
                    Con.Open();
                    string query = "insert into ManagerTbl values(" + MId.Text + ",'" + ManId.Text + "','" + ManPwd.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("manager successfully added.");
                    Con.Close();
                    populate();


                }
                catch(Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }

             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
