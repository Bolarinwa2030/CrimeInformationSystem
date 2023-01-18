using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_Management_System
{
    public partial class View_Criminal_List : Form
    {
        public View_Criminal_List()
        {
            InitializeComponent();
        }

        private void View_Criminal_List_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-T50G6VD\\BGSKILLZ;Initial Catalog=dineroproject;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from dinero";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            guna2DataGridView1.DataSource = Ds.Tables[0];
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-T50G6VD\\BGSKILLZ;Initial Catalog=dineroproject;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from dinero where surname ='" + guna2TextBox1 + "'";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                con.Close();
                MessageBox.Show("Delete Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-T50G6VD\\BGSKILLZ;Initial Catalog=dineroproject;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from dinero where surname = '" + guna2TextBox1.Text + "'";
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                con.Close();
               
                }
                else
                {
                    MessageBox.Show("No criminal with Name : " + guna2TextBox1.Text + " exist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }