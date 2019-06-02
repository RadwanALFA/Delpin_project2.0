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
    public partial class CreateBooking : UserControl
    {
        public CreateBooking()
        {
            InitializeComponent();
        }

        private void FIllCombos()
        {
            MainComboBox.Items.AddRange(DataBaseManager.dbmanager.FillMainCombo());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            pickUpcheckBox.Checked = false;
            deleAddLabel.Visible = true;
            dele_addtextBox.Visible = true;

            if (delevCheckBox.Checked == false)
            {
                deleAddLabel.Visible = false;
                dele_addtextBox.Visible = false;
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    DynamicParameters param = new DynamicParameters();
                    DynamicParameters param2 = new DynamicParameters();
                    if (CPRtextBox.Text.Length !=0)
                    {
                        param.Add("@customer_id", DataBaseManager.dbmanager.GetCustomerId(CPRtextBox.Text.Trim()));
                    }
                    else
                    {
                        if (CVRtextBox.Text.Length != 0)
                        {
                            param.Add("@customer_id", DataBaseManager.dbmanager.GetCustomerId2(CVRtextBox.Text.Trim()));
                        }
                    }
                    
                    if (ProductComboBox.SelectedItem != null)
                    {
                        param.Add("@product_id", DataBaseManager.dbmanager.GetProductId(ProductComboBox.Text));
                        param.Add("@start_date", productStartDate.Value);
                        param.Add("@end_date", productEndDate.Value);
                    }

                    if (delevCheckBox.Checked)
                    {
                        param.Add("@delivery", "Y");
                        param.Add("@delivery_address", dele_addtextBox.Text.Trim());
                    }
                    else
                    {
                        param.Add("@delivery", "N");
                        param.Add("@delivery_address", "");
                    }
                    if (pickUpcheckBox.Checked)
                    {
                        param.Add("@pick_up", "Y");
                    }
                    else
                    {
                        param.Add("@pick_up", "N");
                    }
                    DataBaseManager.dbmanager.CreateBooking(param);

                    if (AccessComboBox.SelectedItem != null)
                    {
                        if (CPRtextBox.Text.Length != 0)
                        {
                            param2.Add("@customer_id", DataBaseManager.dbmanager.GetCustomerId(CPRtextBox.Text.Trim()));
                        }
                        else
                        {
                            if (CVRtextBox.Text.Length != 0)
                            {
                                param2.Add("@customer_id", DataBaseManager.dbmanager.GetCustomerId2(CVRtextBox.Text.Trim()));
                            }
                        }
                        if (ProductComboBox.SelectedItem != null)
                        {
                            param2.Add("@product_id", DataBaseManager.dbmanager.GetProductId(ProductComboBox.Text));
                            param2.Add("@start_date", productStartDate.Value);
                            param2.Add("@end_date", productEndDate.Value);
                        }
                        param2.Add("@accessory_id", DataBaseManager.dbmanager.GetAccessoryID(AccessComboBox.Text));
                        param2.Add("@accessory_start_date", AccessStartDate.Value);
                        param2.Add("@accessory_end_date", AccessEndDate.Value);
                        if (delevCheckBox.Checked)
                        {
                            param2.Add("@delivery", "Y");
                            param2.Add("@delivery_address", dele_addtextBox.Text.Trim());
                        }
                        else
                        {
                            param2.Add("@delivery", "N");
                            param2.Add("@delivery_address", "");
                        }
                        if (pickUpcheckBox.Checked)
                        {
                            param2.Add("@pick_up", "Y");
                        }
                        else
                        {
                            param2.Add("@pick_up", "N");
                        }
                        DataBaseManager.dbmanager.CreateBooking2(param2);
                    }
                    MessageBox.Show("Operation Compleated Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect information entery", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
        }

        private void MainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatagoryComboBox.DataSource = DataBaseManager.dbmanager.GetAllCatagory(MainComboBox.SelectedIndex + 1);
            CatagoryComboBox.DisplayMember = "GetName";
            AccessComboBox.DataSource = DataBaseManager.dbmanager.GetProductAccrssories(DataBaseManager.dbmanager.GetMainID(MainComboBox.Text));
            AccessComboBox.DisplayMember = "GetNmae";
        }

        private void CatagoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductComboBox.DataSource = DataBaseManager.dbmanager.GetAllProductByCatagory(DataBaseManager.dbmanager.GetCatagoryID(CatagoryComboBox.Text));
            ProductComboBox.DisplayMember = "Name";
        }

        private void CreateBooking_Enter(object sender, EventArgs e)
        {
            FIllCombos();
        }
        private bool Check()
        {
            if (CPRtextBox.Text != "" && ProductComboBox.Text != "" && productStartDate.Value != DateTime.Now & productEndDate.Value != DateTime.Now && productStartDate.Value < productEndDate.Value
                ||CVRtextBox.Text != "" && ProductComboBox.Text != "" && productStartDate.Value != DateTime.Now & productEndDate.Value != DateTime.Now && productStartDate.Value < productEndDate.Value)
            {
                List<Booking> bookings = DataBaseManager.dbmanager.GetAllBooking();
                foreach (var item in bookings)
                {
                    if (item.ID == DataBaseManager.dbmanager.GetProductId(ProductComboBox.Text))
                    {
                        if (productStartDate.Value > item.END_DATE && productEndDate.Value > item.END_DATE)
                        {
                            return true;
                        }
                        if (productStartDate.Value < item.START_DATE && productEndDate.Value < item.START_DATE)
                        {
                            return true;
                        }
                    }
                }
                return true; 
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            CPRtextBox.Text = "";
            CVRtextBox.Text = "";
            MainComboBox.Text = "";
            CatagoryComboBox.Text = "";
            ProductComboBox.Text = "";
            AccessComboBox.Text = "";
            pickUpcheckBox.Checked = false;
            delevCheckBox.Checked = false;
            dele_addtextBox.Text = "";
            productStartDate.Value = DateTime.Now;
            productEndDate.Value = DateTime.Now;
            AccessStartDate.Value = DateTime.Now;
            AccessEndDate.Value = DateTime.Now;
        }

        private void pickUpcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            delevCheckBox.Checked = false;
        }

        private void CreateBooking_Leave(object sender, EventArgs e)
        {
            MainComboBox.Items.Clear();
        }

        private void productStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (productStartDate.Value < DateTime.Now)
            {
                Errorlabel1.Visible = true;
            }
            else if (productStartDate.Value >= DateTime.Now)
            {
                Errorlabel1.Visible = false;
            }
        }

        private void productEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (productEndDate.Value > productStartDate.Value)
            {
                Errorlabel2.Visible = false;
            }
            else
            {
                Errorlabel2.Visible = true;
            }
        }

        private void AccessStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (AccessStartDate.Value < DateTime.Now)
            {
                Errorlabel3.Visible = true;
            }
            else if (AccessStartDate.Value >= DateTime.Now)
            {
                Errorlabel3.Visible = false;
            }
        }

        private void AccessEndDate_ValueChanged(object sender, EventArgs e)
        {
            if (AccessStartDate.Value > AccessEndDate.Value)
            {
                Errorlabel4.Visible = true;
            }
            else
            {
                Errorlabel4.Visible = false;
            }
        }
    }
}
