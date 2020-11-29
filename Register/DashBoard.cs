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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            Load += DashBoard_Load;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            SetActivePanel(homeControl1);
        }

        private void logout_option_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void home_option_Click(object sender, EventArgs e)
        {
            SetActivePanel(homeControl1);
        }

        //Set visible active for given control
        public void SetActivePanel(UserControl control)
        {
            //Disable all controls
            homeControl1.Visible = false;
            declinedControl1.Visible = false;
            addCompanyControl1.Visible = false;

            //Set visible for given control
            control.Visible = true;
        }

        private void declined_option_Click(object sender, EventArgs e)
        {
            SetActivePanel(declinedControl1);
        }

        private void add_company_option_Click(object sender, EventArgs e)
        {
            SetActivePanel(addCompanyControl1);
        }
    }
}
