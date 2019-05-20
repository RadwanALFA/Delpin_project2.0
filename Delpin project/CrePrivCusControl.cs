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

namespace Delpin_project
{ 
    public partial class CrePrivCusControl : UserControl
    {
        DataBaseManager DBManager = new DataBaseManager();
        public CrePrivCusControl()
        {
            InitializeComponent();
            FillCombos();   
        }

        private void FillCombos()
        {
            BranchCombobox.Items.AddRange(DBManager.FillCombo());
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
                DynamicParameters param = new DynamicParameters();
                param.Add("@FNAME", nametxtbox.Text.Trim());
                param.Add("@LNAME", Lnametxtbox.Text.Trim());
                param.Add("@USERNAME", usernametxrbox.Text.Trim());
                param.Add("@PASSWARD", passtxtbox.Text.Trim());
                param.Add("@EMAIL", Emailtxtbox.Text.Trim());
                param.Add("@TELEF", teleftxtbox.Text.Trim());
                param.Add("@ADDRESS", addresstxtbox.Text.Trim());
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

                DBManager.CreatePrivateCustomer(param);
                MessageBox.Show("operation completed successfully","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

