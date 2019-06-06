using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delpin_project
{
    public partial class ProductOverView : UserControl
    {
        public ProductOverView()
        {
            InitializeComponent();
        }
        private void FIllCombos()
        {
            MaincomboBox.Items.AddRange(DataBaseManager.dbmanager.FillMainCombo());
            
        }

        private void MaincomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CatagorycomboBox.DataSource = DataBaseManager.dbmanager.GetAllCatagory(MaincomboBox.SelectedIndex + 1);
            CatagorycomboBox.DisplayMember = "GetName";
        }

        private void CatagorycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductcomboBox.DataSource = DataBaseManager.dbmanager.GetAllProductByCatagory(DataBaseManager.dbmanager.GetCatagoryID(CatagorycomboBox.Text));
            ProductcomboBox.DisplayMember = "Name";
        }

        private void ProductOverView_Load(object sender, EventArgs e)
        {
            FIllCombos();
        }

        private void ProductcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = DataBaseManager.dbmanager.GetBookingbyResourceId(DataBaseManager.dbmanager.GetProductId(ProductcomboBox.Text.Trim()));
            
            listBox1.DisplayMember = "GetFullInfo";
        }
    }
}
