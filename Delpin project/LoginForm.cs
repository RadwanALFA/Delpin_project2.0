using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Delpin_project;

namespace Delpin_project
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            passwordtxtbox.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordCheckBox.Checked)
            {
                passwordtxtbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtxtbox.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordtxtbox.Text.Length == 0 || username_txtbox.Text.Length == 0)
                {
                    MessageBox.Show("Enter User name and Passward", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                if (passwordtxtbox.Text.Equals(DataBaseManager.dbmanager.GetPassword(username_txtbox.Text.ToString())))
                {
                    this.Hide();
                    BookingSystemForm bookingSystem = new BookingSystemForm();
                    bookingSystem.ShowDialog();
                }
                else
                {
                    MessageBox.Show("User name or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
