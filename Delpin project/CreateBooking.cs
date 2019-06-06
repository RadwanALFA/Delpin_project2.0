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
    /// <summary>
    /// This class is responsible for creating a booking of a resource with or without an accessory,
    /// each booking has a start date and an end date for both the resource and the accessory.
    /// </summary>
    public partial class CreateBooking : UserControl
    {
        public CreateBooking()
        {
            InitializeComponent();
        }
        // fills the main combobox with main catagories names
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
        // saving data from the interface to the parameter and then creating a booking
        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    DynamicParameters param = new DynamicParameters();
                    if (CPR_textBox.Text.Length != 0)
                    {
                        param.Add("@customer_id", DataBaseManager.dbmanager.GetCustomerId(CPR_textBox.Text.Trim()));
                    }
                    else
                    {
                        if (CVRtextbox.Text.Length != 0)
                        {
                            param.Add("@customer_id", DataBaseManager.dbmanager.GetCustomerId2(CVRtextbox.Text.Trim()));
                        }
                    }

                    if (ProductComboBox.Text != "")
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
                    if (AccessComboBox.Text != "")
                    {

                        param.Add("@accessory_id", DataBaseManager.dbmanager.GetAccessoryID(AccessComboBox.Text));
                        param.Add("@accessory_start_date", AccessStartDate.Value);
                        param.Add("@accessory_end_date", AccessEndDate.Value);
                    }
                    else
                    {
                        param.Add("@accessory_id", null);
                        param.Add("@accessory_start_date", null);
                        param.Add("@accessory_end_date", null);
                    }
                    DataBaseManager.dbmanager.CreateBooking(param);
                    MessageBox.Show("Operation Compleated Successfuly", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Incorrect information entery", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                throw;
                //MessageBox.Show(ex.Message);
            }
        }

        // fill catagories and accessories comboboxes with data
        private void MainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatagoryComboBox.DataSource = DataBaseManager.dbmanager.GetAllCatagory(MainComboBox.SelectedIndex + 1);
            CatagoryComboBox.DisplayMember = "GetName";
            AccessComboBox.DataSource = DataBaseManager.dbmanager.GetProductAccrssories(DataBaseManager.dbmanager.GetMainID(MainComboBox.Text));
            AccessComboBox.DisplayMember = "GetNmae";
        }

        // fill products combobox with data
        private void CatagoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductComboBox.DataSource = DataBaseManager.dbmanager.GetAllProductByCatagory(DataBaseManager.dbmanager.GetCatagoryID(CatagoryComboBox.Text));
            ProductComboBox.DisplayMember = "Name";
        }

        private void CreateBooking_Enter(object sender, EventArgs e)
        {
            FIllCombos();
        }
        // Checks for messing data and makes sure there's no double booking
        private bool Check()
        {
            if (CPR_textBox.Text != "" && ProductComboBox.Text != "" && productStartDate.Value != DateTime.Now & productEndDate.Value != DateTime.Now && productStartDate.Value < productEndDate.Value
                || CVRtextbox.Text != "" && ProductComboBox.Text != "" && productStartDate.Value != DateTime.Now & productEndDate.Value != DateTime.Now && productStartDate.Value < productEndDate.Value)
            {
                List<Booking> bookings = DataBaseManager.dbmanager.GetBookingbyResourceId(DataBaseManager.dbmanager.GetProductId(ProductComboBox.Text));
                if (bookings.Count == 0)
                {
                    return true;
                }
                if (bookings.Count == 1)
                {
                    if (productStartDate.Value > bookings[0].END_DATE && productEndDate.Value > bookings[0].END_DATE
                        || productStartDate.Value < bookings[0].START_DATE && productEndDate.Value < bookings[0].START_DATE)
                    {
                        return true;
                    }
                }
                else
               if (bookings.Count >= 2)
                {
                    bookings = Sort(bookings);
                    for (int i = 0; i < bookings.Count; i++)
                    {
                        if (productEndDate.Value < bookings[i].START_DATE || productStartDate.Value > bookings[bookings.Count].END_DATE )
                        {
                            return true;
                        }
                        if (productEndDate.Value < bookings[i].START_DATE)
                        {
                            if (productStartDate.Value> bookings[i-1].END_DATE && productEndDate.Value < bookings[i].START_DATE)
                            {
                                return true;
                            }
                        }
                    }
                }
                MessageBox.Show("the Resource is booked in that period!", "Information Center");
                return false;
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
        // reset the create booking form
        void Clear()
        {
            CPR_textBox.Text = "";
            CVRtextbox.Text = "";
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
            Errorlabel1.Visible = false;
            Errorlabel2.Visible = false;
            Errorlabel3.Visible = false;
            Errorlabel4.Visible = false;
            MainComboBox.Enabled = false;
            CatagoryComboBox.Enabled = false;
            ProductComboBox.Enabled = false;
            AccessComboBox.Enabled = false;
            pickUpcheckBox.Enabled = false;
            delevCheckBox.Enabled = false;
            productStartDate.Enabled = false;
            productEndDate.Enabled = false;
            AccessStartDate.Enabled = false;
            AccessEndDate.Enabled = false;
            Savebtn.Enabled = false;
            Cancelbtn.Enabled = false;
        }

        private void pickUpcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            delevCheckBox.Checked = false;
        }

        private void CreateBooking_Leave(object sender, EventArgs e)
        {
            MainComboBox.Items.Clear();
            Clear();
        }

        // error lable logic
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

        // error lable logic
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

        // error lable logic
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

        // error lable logic
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

        // checks if he enterd CPR number is a vaild
        private void CPRtextBox_Leave(object sender, EventArgs e)
        {
            List<String> cpr_mumbers = DataBaseManager.dbmanager.GetAllCprNumbers();
            if (CPR_textBox.Text != "")
            {
                if (!cpr_mumbers.Contains(CPR_textBox.Text))
                {
                    ErrorLabel5.Visible = true;
                }
                else
                {
                    ErrorLabel5.Visible = false;
                    Check2();
                }
            }
        }

        void Check2()
        {
            MainComboBox.Enabled = true;
            CatagoryComboBox.Enabled = true;
            ProductComboBox.Enabled = true;
            AccessComboBox.Enabled = true;
            pickUpcheckBox.Enabled = true;
            delevCheckBox.Enabled = true;
            productStartDate.Enabled = true;
            productEndDate.Enabled = true;
            AccessStartDate.Enabled = true;
            AccessEndDate.Enabled = true;
            Savebtn.Enabled = true;
            Cancelbtn.Enabled = true;
        }
        // checks if he enterd CVR number is a vaild
        private void CVRtextbox_Leave_1(object sender, EventArgs e)
        {
            if (CVRtextbox.Text != "")
            {
                List<String> cvr_mumbers = DataBaseManager.dbmanager.GetAllCvrNumbers();
                if (!cvr_mumbers.Contains(CVRtextbox.Text))
                {
                    ErrorLabel6.Visible = true;
                }
                else
                {
                    ErrorLabel6.Visible = false;
                    Check2();
                }
            }
        }
        private List<Booking> Sort(List<Booking> bookings)
        {
            Booking temp;
            for (int i = 0; i < bookings.Count; i++)
            {
                if (bookings[i].END_DATE > bookings[i + 1].END_DATE)
                {
                     temp = bookings[i + 1];
                     bookings[i + 1] = bookings[i];
                     bookings[i] = temp;
                }
            }
            return bookings;
            
        }
    }
}
