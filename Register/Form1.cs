using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if(username_textbox.Text == "" && password_textbox.Text == "")
            {
                this.Hide();
                DashBoard dashBoard = new DashBoard();
                dashBoard.Closed += (s, args) => this.Close();
                dashBoard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Invalid");
            }
        }
    }
}
