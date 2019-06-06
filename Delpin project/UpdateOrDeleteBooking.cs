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
    public partial class UpdateOrDeleteBooking : UserControl
    {
        private int booking_id = 0;
        public UpdateOrDeleteBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridView();
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid kunde ID");
            }
            
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    booking_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Deletebtn.Enabled = true;
                    Editebtn.Enabled = true;
                    StartDate.Enabled = true;
                    EndDate.Enabled = true;
                    PickUpCheckbox.Enabled = true;
                    DeliveryCheckbox.Enabled = true;
                    deliveryaddresstxtbox.Enabled = true;
                    AccessoryComboBox.Enabled = true;
                    accessoryStartDate.Enabled = true;
                    accessoryEndDate.Enabled = true;
                }
                AccessoryComboBox.DataSource = DataBaseManager.dbmanager.GetAllAccrssories();
                AccessoryComboBox.DisplayMember = "GetName";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", booking_id);
                DataBaseManager.dbmanager.DeleteBooking(param);
                FillDataGridView();
                MessageBox.Show("Booking deleted successfuly", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void Clear()
        {
            StartDate.Enabled = false;
            StartDate.Value = DateTime.Now;
            EndDate.Enabled = false;
            EndDate.Value = DateTime.Now;
            accessoryStartDate.Enabled = false;
            accessoryStartDate.Value = DateTime.Now;
            accessoryEndDate.Enabled = false;
            accessoryEndDate.Value = DateTime.Now;
            AccessoryComboBox.Enabled = false;
            AccessoryComboBox.Text = "";
            DeliveryCheckbox.Enabled = false;
            DeliveryCheckbox.Checked = false;
            PickUpCheckbox.Enabled = false;
            PickUpCheckbox.Checked = false;
            deliveryaddresstxtbox.Visible = false;
            deleviryaddressLable.Visible = false;
            Deletebtn.Enabled = false;
            Editebtn.Enabled = false;
        }

        void FillDataGridView()
        {
            if (SearchtxtBox.Text != "")
            {
                dataGridView1.DataSource = DataBaseManager.dbmanager.ViewAllBooking(SearchtxtBox.Text);
            }
            else
            {

                dataGridView1.DataSource = DataBaseManager.dbmanager.GetAllBooking();
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void DeliveryCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PickUpCheckbox.Checked = false;
            deleviryaddressLable.Visible = true;
            deliveryaddresstxtbox.Visible = true;
        }

        private void PickUpCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (PickUpCheckbox.Checked == true)
            {
                DeliveryCheckbox.Checked = false;
            }
            deleviryaddressLable.Visible = false;
            deliveryaddresstxtbox.Visible = false;
        }

        private void Editebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check())
                {
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@id", booking_id);
                    param.Add("@product_start_date", StartDate.Value);
                    param.Add("@product_end_date", EndDate.Value);
                    if (PickUpCheckbox.Checked == true)
                    {
                        param.Add("@pick_up", "Y");
                    }
                    else
                    {
                        param.Add("@pick_up", "N");
                    }
                    if (DeliveryCheckbox.Checked == true)
                    {
                        param.Add("@delivery","Y");
                    }
                    else
                    {
                        param.Add("@delivery", "N");
                        
                    }
                    param.Add("@delivery_address", deliveryaddresstxtbox.Text.Trim());
                    if (AccessoryComboBox.Text != "")
                    {
                        param.Add("@accessory_id", DataBaseManager.dbmanager.GetAccessoryID(AccessoryComboBox.Text));
                        param.Add("@accessory_start_date", accessoryStartDate.Value);
                        param.Add("@accessory_end_date", accessoryEndDate.Value);
                    }
                    else
                    {
                        param.Add("@accessory_id",null);
                        param.Add("@accessory_start_date",null);
                        param.Add("@accessory_end_date", null);
                    }
                    DataBaseManager.dbmanager.UpdateBooking(param);
                    MessageBox.Show("Booking info has been updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillDataGridView();
                    Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private bool Check()
        {
            List<Booking> bookings = DataBaseManager.dbmanager.GetBookingbyResourceId(booking_id);
            if (bookings.Count == 0)
            {
                return true;
            }
            if (bookings.Count == 1)
            {
                if (StartDate.Value > bookings[0].END_DATE && EndDate.Value > bookings[0].END_DATE
                        || StartDate.Value < bookings[0].START_DATE && EndDate.Value < bookings[0].START_DATE)
                {
                    return true;
                }
            }
            else if (bookings.Count >= 2)
            {
                for (int i = 0; i < bookings.Count; i++)
                {
                    if (bookings[i].END_DATE < StartDate.Value && EndDate.Value < bookings[i + 1].START_DATE || bookings[i].END_DATE < StartDate.Value && bookings[i].END_DATE < EndDate.Value)
                    {
                        return true;
                    }
                }
            }
            MessageBox.Show("the Resource is booked in that period!", "Information Center");
            return false;
        }
    }
}
