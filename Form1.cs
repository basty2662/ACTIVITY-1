using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace activityy1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = txtFirstName.Text;
            lblMiddleName.Text = txtMiddleName.Text;
            lblLastName.Text = txtLastName.Text;
            lblCourse.Text = cbCourse.SelectedItem?.ToString();
            lblContactNo.Text = txtContactNo.Text;
            lblEmailAddress.Text = txtEmailAddress.Text;
            lblAddress.Text = txtAddress.Text;
            if (rbMale.Checked)

                lblGender.Text = "Male";
            else if (rbFemale.Checked)
                lblGender.Text = "Female";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();

            txtMiddleName.Clear();

            txtLastName.Clear();

            txtContactNo.Clear();

            txtEmailAddress.Clear();

            txtAddress.Clear();

            cbCourse.SelectedIndex = -1;

            rbMale.Checked = false;

            rbFemale.Checked = false;

            lblFirstName.Text = "";

            lblMiddleName.Text = "";

            lblLastName.Text = "";

            lblCourse.Text = "";

            lblContactNo.Text = "";

            lblEmailAddress.Text = "";

            lblAddress.Text = "";

            lblGender.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
