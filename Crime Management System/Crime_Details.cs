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
    public partial class Crime_Details : Form
    {
        public Crime_Details()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-T50G6VD\\BGSKILLZ;Initial Catalog=dineroproject;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from dinero where id ="+guna2TextBox1.Text+"";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            if (Ds.Tables[0].Rows.Count !=0)
            {
                label14.Text = Ds.Tables[0].Rows[0][1].ToString();
                label17.Text = Ds.Tables[0].Rows[0][2].ToString();
                label18.Text = Ds.Tables[0].Rows[0][3].ToString();
                label19.Text = Ds.Tables[0].Rows[0][4].ToString();
                label20.Text = Ds.Tables[0].Rows[0][5].ToString();
                label21.Text = Ds.Tables[0].Rows[0][6].ToString();
                label22.Text = Ds.Tables[0].Rows[0][7].ToString();
                label23.Text = Ds.Tables[0].Rows[0][8].ToString();
                label24.Text = Ds.Tables[0].Rows[0][9].ToString();
                label25.Text = Ds.Tables[0].Rows[0][10].ToString();
                label26.Text = Ds.Tables[0].Rows[0][11].ToString();
                label27.Text = Ds.Tables[0].Rows[0][12].ToString();
            }
        }
    }
}
