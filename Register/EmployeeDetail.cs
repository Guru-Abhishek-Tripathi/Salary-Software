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
    public partial class EmployeeDetail : Form
    {
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            SetActivePanel(employeeDetailControl1);
        }

        private void employeeDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(employeeDetailControl1);
        }

        private void dependentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetActivePanel(dependentsControl1);
        }







        public void SetActivePanel(UserControl control)
        {
            //set visible false for all
            employeeDetailControl1.Visible = false;
            dependentsControl1.Visible = false;
            employeeSalarySlipControl1.Visible = false;

            //set given control's visible true
            control.Visible = true;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SetActivePanel(employeeSalarySlipControl1);
        }
    }
}
