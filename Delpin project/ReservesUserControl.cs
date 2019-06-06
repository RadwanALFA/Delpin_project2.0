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
    public partial class ReservesUserControl : UserControl
    {
        int id = 0;
        public ReservesUserControl()
        {
            InitializeComponent();
            FillDataGridView();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    Deletebtn.Enabled = true;
                    Editebtn.Enabled = true;
                    
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void Editebtn_Click(object sender, EventArgs e)
        {
            editeTolabel.Visible = true;
            EditeDate.Visible = true;
            EditeTocomboBox.Visible = true;
            EditeSavebtn.Visible = true;
            Cancelbtn.Visible = true;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?","Delete transfer",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataBaseManager.dbmanager.DeleteTransfer(id);
                FillDataGridView();
                MessageBox.Show("Record Deleted successfuly", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@resource_id", int.Parse(ResourceIdtxtbox.Text));
                param.Add("@FROM_ID", FromcomboBox.SelectedIndex + 1);
                param.Add("@TO_ID", TocomboBox.SelectedIndex + 1);
                param.Add("@DATE", CreateDate.Value);
                DataBaseManager.dbmanager.CreateTransfer(param);
                MessageBox.Show("Operation completed successfuly","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                FillDataGridView();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void EditeSavebtn_Click(object sender, EventArgs e)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@ID", id);
                param.Add("@TO_ID", EditeTocomboBox.SelectedIndex + 1);
                param.Add("@DATE", EditeDate.Value);
                DataBaseManager.dbmanager.EditeTransfer(param);
                FillDataGridView();
                MessageBox.Show("Record updated successfuly", "Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                editeTolabel.Visible = false;
                EditeDate.Visible = false;
                EditeTocomboBox.Visible = false;
                EditeSavebtn.Visible = false;
                Cancelbtn.Visible = false;
                EditeDate.Value = DateTime.Now;
                EditeTocomboBox.Text = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FromcomboBox_Click(object sender, EventArgs e)
        {
            FromcomboBox.DataSource = DataBaseManager.dbmanager.FillCombo();
        }

        private void TocomboBox_Click(object sender, EventArgs e)
        {
            TocomboBox.DataSource = DataBaseManager.dbmanager.FillCombo();
        }
        void FillDataGridView()
        {
            dataGridView1.DataSource = DataBaseManager.dbmanager.GetALLTransfers();
            dataGridView1.Columns[0].Visible = false;
        }

        private void EditeTocomboBox_Click(object sender, EventArgs e)
        {
            EditeTocomboBox.DataSource= DataBaseManager.dbmanager.FillCombo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editeTolabel.Visible = false;
            EditeDate.Visible = false;
            EditeTocomboBox.Visible = false;
            EditeSavebtn.Visible = false;
            Cancelbtn.Visible = false;
            EditeDate.Value = DateTime.Now;
            EditeTocomboBox.Text = "";
        }

        private void ReservesUserControl_Leave(object sender, EventArgs e)
        {
            FromcomboBox.Text = "";
            TocomboBox.Text = "";
            CreateDate.Value = DateTime.Now;
        }

        private void ResourceIdtxtbox_Leave(object sender, EventArgs e)
        {
            List<int> productsIds = DataBaseManager.dbmanager.GetAllProductsIDs();
            if (!productsIds.Contains( int.Parse(ResourceIdtxtbox.Text)))
            {
                ErrorLabel1.Visible = true;
            }
            else
            {
                ErrorLabel1.Visible = false;
            }
        }
    }
}
