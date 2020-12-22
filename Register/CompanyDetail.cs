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
    public partial class CompanyDetail : Form
    {
        public CompanyDetail()
        {
            InitializeComponent();
        }

        private void CompanyDetail_Load(object sender, EventArgs e)
        {
            SetActivePanel(companyDetailControl1);
        }

        private void companyDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(companyDetailControl1);
        }


        public void SetActivePanel(UserControl control)
        {
            //set visible false for all
            companyDetailControl1.Visible = false;
            activeEmployeeControl1.Visible = false;
            resignedEmployeesControl1.Visible = false;
            addSingleEmployeeControl1.Visible = false;

            //set given control's visible true
            control.Visible = true;

        }

        private void activeEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(activeEmployeeControl1);
        }

        private void resignedEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(resignedEmployeesControl1);
        }

        private void singleEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(addSingleEmployeeControl1);
        }
    }
}
