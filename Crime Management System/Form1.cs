using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crime_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void existingStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newCrimeRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crime_Registration me = new Crime_Registration();
            me.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Crime" && password == "12345")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
        }

        private void criminalListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Criminal_List me = new View_Criminal_List();
            me.Show();
        }

        private void openComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_Complaint me = new Open_Complaint();
            me.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 me = new Form1();
            me.Show();
            this.Hide();
        }

        private void criminalListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Crime_Details me = new Crime_Details();
            me.Show();
        }
    }
}
