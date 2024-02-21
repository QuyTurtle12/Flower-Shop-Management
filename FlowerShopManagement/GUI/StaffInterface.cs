using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StaffInterface : Form
    {
        public StaffInterface()
        {
            InitializeComponent();
        }

        private void StaffInterface_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbFullNameData.Visible = false;
            lbPhoneNumberData.Visible = false;
            lbEmailData.Visible = false;
            lbGenderData.Visible = false;
            btnEdit.Visible = false;
            btnEdit.Enabled = false;
            btnSave.Visible = true;
            btnSave.Enabled = true;
            txtEmail.Enabled = true;
            cmbGender.Enabled = true;
            txtFullName.Enabled = t rue;
            txtPhoneNumber.Enabled = true;
            txtEmail.Visible = true;
            txtFullName.Visible = true;
            cmbGender.Visible = true;
            txtPhoneNumber.Visible = true;


            txtFullName.Text = lbFullNameData.Text;
            txtPhoneNumber.Text = lbPhoneNumberData.Text;
            txtEmail.Text = lbEmailData.Text;
            cmbGender.Text = lbGenderData.Text;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            lbFullNameData.Text = txtFullName.Text;
            lbPhoneNumberData.Text = txtPhoneNumber.Text;
            lbEmailData.Text = txtEmail.Text;
            lbGenderData.Text = cmbGender.Text;

            lbFullNameData.Visible = true;
            lbPhoneNumberData.Visible = true;
            lbEmailData.Visible = true;
            lbGenderData.Visible = true;
            btnEdit.Visible = true;
            btnEdit.Enabled = true;
            btnSave.Visible = false;
            btnSave.Enabled = false;
            txtEmail.Enabled = false;
            cmbGender.Enabled = false;
            txtFullName.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmail.Visible = false;
            txtFullName.Visible = false;
            cmbGender.Visible = false;
            txtPhoneNumber.Visible = false;
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbGender.Text = cmbGender.SelectedIndex.ToString();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void lbRoleData_Click(object sender, EventArgs e)
        {

        }
    }
}
