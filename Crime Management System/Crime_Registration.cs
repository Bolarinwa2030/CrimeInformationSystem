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
    public partial class Crime_Registration : Form
    {
        public Crime_Registration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String caseNo = txtCaseno.Text;
            String surname = txtSurname.Text;
            String othername = txtOthername.Text;
            String gender = "";
            bool IsChecked = checkedMale.Checked;
            if (IsChecked)
            {
                gender = checkedMale.Text;
            }
            else
            {
                gender = checkedFemale.Text;
            }
            String dob = txtDateofBirth.Text;
            Int64 telephone = Int64.Parse(txttelephone.Text);
            String email = txtEmail.Text;
            String ofaddress = txtOffAdd.Text;
            String witname = txtWitnessname.Text;
            String roa = txtReportdate.Text;
            String doa = txtdatearrstede.Text;
            String occup = txtoccupation.Text;
            Int64 witno = Int64.Parse(txtwitnessNO.Text);
            String witaddress = txtOffenderadd.Text;
            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-T50G6VD\\BGSKILLZ;Initial Catalog=dineroproject;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into dinero (caseNo, surname, othername, gender, dob, telephone, email, ofaddress, witname, roa, doa, occup, witno, witaddress) values ('"+caseNo+"', '"+surname+"', '"+othername+"', '"+gender+"', '"+dob+"', '"+telephone+"', '"+email+"', '"+ofaddress+"', '"+witname+"', '"+roa+"', '"+doa+"', '"+occup+"', '"+witno+"', '"+witaddress+"')";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            con.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();


        }

        private void Crime_Registration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-T50G6VD\\BGSKILLZ;Initial Catalog=dineroproject;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max (ID) from dinero";
            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);

            //Int64 abc = Convert.ToInt64(Ds.Tables[0].Rows[0][0]);
            //label14.Text = (abc + 1).ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtCaseno.Clear();
            txtSurname.Clear();
            txtOthername.Clear();
            checkedMale.ResetText();
            checkedFemale.ResetText();
            txttelephone.Clear();
            txtEmail.Clear();
            txtOffAdd.Clear();
            txtWitnessname.Clear();
            txtDateofBirth.ResetText();
            txtdatearrstede.ResetText();
            txtReportdate.ResetText();
            txtoccupation.Clear();
            txtwitnessNO.Clear();
            txtOffenderadd.Clear();
        }
    }
}