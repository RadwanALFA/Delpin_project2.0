using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delpin_project
{
    public partial class CreateBooking2 : Form
    {
        public CreateBooking2()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label6.Visible = true;
            textBox_levadresse.Visible = true;
            if (checkBox2.Checked == false)
            {
                label6.Visible = false;
                textBox_levadresse.Visible = false;
            }
        }

        private void CreateBooking2_Load(object sender, EventArgs e)
        {
            Check();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_levadresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void Check()
        {
            if(textBox_navn.Text.Length == 0 && textBox_adr.Text.Length == 0 && textBox_knr.Text.Length == 0 && comboBox1.Text.Length == 0)
            {
                button_save.Enabled = false;
            }
        }
    }
}
