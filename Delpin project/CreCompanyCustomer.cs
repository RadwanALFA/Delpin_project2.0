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
    public partial class CreCompanyCustomer : UserControl
    {
        DynamicParameters param = new DynamicParameters();
        public CreCompanyCustomer()
        {
            InitializeComponent();
           Branch_idcomboBox.Items.AddRange(DataBaseManager.dbmanager.FillCombo());
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {

            try
            {
                param.Add("@Company_Name", CompanyNametxtBox.Text.Trim());
                param.Add("@USERNAME", UsernametxtBox.Text.Trim());
                param.Add("@PASSWARD", PasswardtxtBox.Text.Trim());
                param.Add("@EMAIL", EmailtxtBox.Text.Trim().ToLower());
                param.Add("@TELEF", TeleftxtBox.Text.Trim());
                param.Add("@ADDRESS", addresstxtBox.Text.Trim());
                param.Add("@CVR_NO", CVRtxtBox.Text.Trim());
                param.Add("@BRANCH_ID", Branch_idcomboBox.SelectedIndex + 1);
                param.Add("@REG_DATE", Reg_date.Value);

                DataBaseManager.dbmanager.CreateCompanyCustomer(param);
                MessageBox.Show("operation completed successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
