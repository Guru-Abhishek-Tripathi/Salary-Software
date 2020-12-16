using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Register
{
    public partial class AddCompanyControl : UserControl
    {
        public AddCompanyControl()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DashBoard.homeControl1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                System.Data.OleDb.OleDbConnection oleDbConnection;
                System.Data.OleDb.OleDbCommand oleDbCommand = new System.Data.OleDb.OleDbCommand();
                String sql = "Insert into [au-500$] ('Employer ID','Name of Firm','Address','Contact','Email ID','Date of Registration in PF ESI','GST Number','EPF Number','EPFO Password','ESI Number','ESI Password','Welfare Number','Welfare Password','ESI Registration Number','Bank Name','Bank Account Number','IFSC','GST Attachment','ESI Certificate','PF Certificate','Letter Head','Specimen Signature','PAN Card','Aadhaar Card','Company Registration','Status') values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+dateTimePicker1.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+ "','"+textBox10.Text+"','"+textBox11.Text+ "','"+textBox12.Text+ "','"+textBox13.Text+ "','"+textBox14.Text+ "','"+textBox15.Text+ "','"+textBox16.Text+ "','"+textBox17.Text+ "','GST Attachment','ESI Certificate','PF Certificate','Letter Head','Specimen Signature','PAN Card','Aadhaar Card','Company Registration','Active');";

                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='S:\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=1'";
                MessageBox.Show("SQL: " + sql);
                oleDbConnection = new System.Data.OleDb.OleDbConnection(sourceConstr);
                oleDbConnection.Open();
                oleDbCommand.Connection = oleDbConnection;
                oleDbCommand.CommandText = sql;
                oleDbCommand.ExecuteNonQuery();
                oleDbConnection.Close();
                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
