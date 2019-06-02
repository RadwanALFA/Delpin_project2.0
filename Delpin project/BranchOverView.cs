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
    public partial class BranchOverView : UserControl
    {
        public BranchOverView()
        {
            InitializeComponent();
            FillCombo();
        }
        private void FillCombo()
        {
            comboBox1.DataSource = DataBaseManager.dbmanager.FillCombo();
            comboBox1.DisplayMember = "GetName";
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = DataBaseManager.dbmanager.GetAllProductsByBranchId(comboBox1.SelectedIndex + 1);
            listBox1.DisplayMember = "GetFullInfo";
        }
    }
}
