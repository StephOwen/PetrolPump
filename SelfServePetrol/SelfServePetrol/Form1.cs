using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelfServePetrol
{
    public partial class frmSelfServe : Form
    {
        public frmSelfServe()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((txtCardNo.Text == "") || (txtExp.Text == "") || (txtLimit.Text == "")) //|| (cboPetrol.SelectedIndex == 0))
            {
                MessageBox.Show("Please ensure all fields are inputted.");
            }
            else
            {
                txtCardNo.ReadOnly = true;
                txtExp.ReadOnly = true;
                txtLimit.ReadOnly = true;
                btnStop.Visible = true;
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

                int limit = int.Parse(txtLimit.Text);
 
                int incLimit = int.Parse(lblLimit.Text);
                int newValue = incLimit++;
                lblLimit.Text = incLimit.ToString();
               
                if (newValue == limit)
                {
                    lblLimit.Text = limit.ToString();
                    timer1.Enabled = false;
                    btnStop.Visible = false;
                    btnFinish.Visible = true;
                }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnContinue.Visible = true;
            btnStop.Visible = false;
            btnFinish.Visible = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnStop.Visible = true;
            btnContinue.Visible = false;
            btnFinish.Visible = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string limit = lblLimit.Text;
            btnFinish.Visible = false;
            label1.Visible = true;
            lblFinished.Text = "£" + limit + " of petrol has been dispensed.";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password" && txtUser.Text == "Manager")
            {
                btnRAll.Visible = true;
                btnRCard.Visible = true;
                btnRLimit.Visible = true;
                lblUser.Visible = false;
                txtUser.Visible = false;
                lblPassword.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;
                btnLogout.Visible = true;
            }
            else
            {
                MessageBox.Show("Your username or password was incorrect. Please try again.");
            }
        }

        private void btnRLimit_Click(object sender, EventArgs e)
        {
            txtLimit.ReadOnly = false;
            txtLimit.Text = "";
        }

        private void btnRCard_Click(object sender, EventArgs e)
        {
            txtCardNo.ReadOnly = false;
            txtCardNo.Text = "";
            txtExp.ReadOnly = false;
            txtExp.Text = "";
        }

        private void btnRAll_Click(object sender, EventArgs e)
        {
            txtExp.ReadOnly = false;
            txtCardNo.ReadOnly = false;
            txtLimit.ReadOnly = false;
            txtExp.Text = "";
            txtCardNo.Text = "";
            txtLimit.Text = "";
            lblLimit.Text = "0";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtUser.Visible = true;
            txtPassword.Visible = true;
            lblUser.Visible = true;
            lblPassword.Visible = true;
            btnRAll.Visible = false;
            btnRCard.Visible = false;
            btnRLimit.Visible = false;
            btnLogout.Visible = false;
            btnLogin.Visible = true;
            txtPassword.Text = "";
            txtUser.Text = "";
        }
    }
}
