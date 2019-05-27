using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace Delpin_project
{
    public partial class BookingSystemForm : Form
    {
        static BookingSystemForm _obj;
        public static BookingSystemForm Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new BookingSystemForm();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return ContainerPanel; }
            set { ContainerPanel = value; }
        }

        public PictureBox BackPic
        {
            get { return pictureBox2; }
            set { pictureBox2 = value; }
        }
        public BookingSystemForm()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            CreateBooking2 cb = new CreateBooking2();
            cb.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            Customers_main_control Cmc = new Customers_main_control();
            Cmc.Dock = DockStyle.Fill;
            ContainerPanel.Controls.Add(Cmc);
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ContainerPanel.Controls["Customers_main_control"].BringToFront();
        }

        private void BookingSystemForm_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            _obj = this;
        }
    }
}
