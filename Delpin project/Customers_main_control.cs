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
        DataBaseManager DBManager = new DataBaseManager();
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
            CustomersDataGridView.DataSource = DBManager.ViewAllOrSearchCustomers(param);
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
    }
}
