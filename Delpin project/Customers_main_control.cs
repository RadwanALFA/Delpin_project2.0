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
    public partial class Customers_main_control : UserControl
    {
        public static int customer_id = 0;
       
        public Customers_main_control()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!BookingSystemForm.Instance.PnlContainer.Controls.ContainsKey("CrePrivCusControl"))
            {
                CrePrivCusControl cpcc = new CrePrivCusControl();
                cpcc.Dock = DockStyle.Fill;
                BookingSystemForm.Instance.PnlContainer.Controls.Add(cpcc);
            }
            BookingSystemForm.Instance.PnlContainer.Controls["CrePrivCusControl"].BringToFront();
            BookingSystemForm.Instance.BackPic.Visible = true;
        }

        void FillDataGridView()
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@SearchText", SearchtextBox.Text.Trim());
            dgvCustomers.DataSource = DataBaseManager.dbmanager.ViewAllOrSearchCustomers(param);
            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Columns[14].Visible = false;
            dgvCustomers.Columns[15].Visible = false;

        }
        private void Answer_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                int lenghtOfAnswer = textBox.Text.Length;
                textBox.Select(0, lenghtOfAnswer);
            }
        }

        private void dgvCustomers_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvCustomers.CurrentRow.Index != -1)
                {
                    customer_id = Convert.ToInt32(dgvCustomers.CurrentRow.Cells[0].Value.ToString());
                    Deletebtn.Enabled = true;
                    Editebtn.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@ID", customer_id);
            DataBaseManager.dbmanager.DeleteCustomer(param);
            FillDataGridView();
            MessageBox.Show("Customer deleted successfuly", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrePrivCusControl cpcc = new CrePrivCusControl();
            cpcc.Dock = DockStyle.Fill;
            BookingSystemForm.Instance.PnlContainer.Controls.Add(cpcc);
            cpcc.SetCustomerId(customer_id);
            BookingSystemForm.Instance.PnlContainer.Controls["CrePrivCusControl"].BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!BookingSystemForm.Instance.PnlContainer.Controls.ContainsKey("CreCompanyCustomer"))
            {
                CreCompanyCustomer ccc = new CreCompanyCustomer();
                ccc.Dock = DockStyle.Fill;
                BookingSystemForm.Instance.PnlContainer.Controls.Add(ccc);
            }
            BookingSystemForm.Instance.PnlContainer.Controls["CreCompanyCustomer"].BringToFront();
            BookingSystemForm.Instance.BackPic.Visible = true;
        }
    }
}
