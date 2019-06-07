using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Text.RegularExpressions;

namespace Delpin_project
{ 
    public partial class CrePrivCusControl : UserControl
    {
        DynamicParameters param = new DynamicParameters();
        public static int customer_id = 0;
        public CrePrivCusControl()
        {
            InitializeComponent();
            BranchCombobox.Items.AddRange(DataBaseManager.dbmanager.FillCombo());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            picFileDialog.ShowDialog();
            pictureBox1.Load(picFileDialog.FileName);
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                param.Add("@ID", customer_id);
                param.Add("@FNAME", nametxtbox.Text.Trim());
                param.Add("@LNAME", Lnametxtbox.Text.Trim());
                param.Add("@USERNAME", usernametxtbox.Text.Trim());
                param.Add("@PASSWARD", passtxtbox.Text.Trim());
                param.Add("@EMAIL", Emailtxtbox.Text.Trim().ToLower());
                param.Add("@TELEF", teleftxtbox.Text.Trim());
                param.Add("@ADDRESS", addresstxtbox.Text.Trim());
                param.Add("@CPR_NUMM", CPRtxtBox.Text.Trim());

                if (driversLicencecheckBox.Checked)
                {
                    param.Add("@DRIVERSLICENCE", "Y");
                }
                else
                {
                    param.Add("@DRIVERSLICENCE", "N");
                }

                param.Add("@BRANCH_ID", BranchCombobox.SelectedIndex + 1);
                param.Add("@REG_DATE", regDateDatePicker.Value);

                DataBaseManager.dbmanager.CreatePrivateCustomer(param);
                MessageBox.Show("operation completed successfully","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void SetCustomerId(int x)
        {
            customer_id = x;
        }
        void Clear()
        {
            nametxtbox.Text = "";
            Lnametxtbox.Text = "";
            usernametxtbox.Text = "";
            passtxtbox.Text = "";
            Emailtxtbox.Text = "";
            teleftxtbox.Text = "";
            regDateDatePicker.Value = DateTime.Now;
            CPRtxtBox.Text = "";
            addresstxtbox.Text = "";
            driversLicencecheckBox.Checked = false;
            BranchCombobox.SelectedItem = null; ;
        }

        private void nametxtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (nametxtbox.Text == "" || System.Text.RegularExpressions.Regex.IsMatch(Lnametxtbox.Text, @"\d"))
                {
                    ErrorLabel1.Visible = true;
                }
                else
                {
                    ErrorLabel1.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Lnametxtbox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Lnametxtbox.Text == ""|| System.Text.RegularExpressions.Regex.IsMatch(Lnametxtbox.Text, @"\d"))
                {
                    ErrorLabel2.Visible = true;
                }
                else
                {
                    ErrorLabel2.Visible = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CPRtxtBox_Leave(object sender, EventArgs e)
        {
            if (CPRtxtBox.Text == ""|| Regex.IsMatch(CPRtxtBox.Text, @"^\d+$")== false)
            {
                ErrorLabel3.Visible = true;
            }
            else
            {
                ErrorLabel3.Visible = false;
            }
        }
    }
}

