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
using System.IO;

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
                // Declare the File name    
                string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\company.xls";
                // Connection String // Here i am using HDR = YES which means excel first row consider as header  
                //string con = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0;READONLY=FALSE'", filename);
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\अजय़\source\repos\Register\Register\Resources\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                {
                    cn.Open();

                    DataTable activityDataTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                    //validate worksheet name.
                    string worksheetName=null;
                    if (activityDataTable != null)
                    {
                        for (int cnt = 0; cnt <1; cnt++)
                        {
                            worksheetName = activityDataTable.Rows[cnt]["TABLE_NAME"].ToString();
                            Console.WriteLine("Sheet Name: " + worksheetName);
                            if (worksheetName.Contains('\''))
                            {
                                worksheetName = worksheetName.Replace('\'', ' ').Trim();
                            }
                        }
                    }

                    Console.WriteLine("Date: " + dateTimePicker1.Text);
                    String sql = "INSERT INTO [" + worksheetName + "] ([Employer ID],[Name of Firm],[Address],[Contact],[Email ID],[Date of Registration in PF ESI],[GST Number],[EPF Number],[EPFO Password],[ESI Number],[ESI Password],[Welfare Number],[Welfare Password],[ESI Registration Number],[Bank Name],[Bank Account Number],[IFSC],[GST Attachment],[ESI Certificate],[PF Certificate],[Letter Head],[Specimen Signature],[PAN Card],[Aadhaar Card],[Company Registration],[Status]) values('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + dateTimePicker1.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + textBox8.Text.ToString() + "', '" + textBox9.Text.ToString() + "', '" + textBox10.Text.ToString() + "', '" + textBox11.Text.ToString() + "', '" + textBox12.Text.ToString() + "', '" + textBox13.Text.ToString() + "', '" + textBox14.Text.ToString() + "', '" + textBox15.Text.ToString() + "', '" + textBox16.Text.ToString() + "', '" + textBox17.Text.ToString() + "', 'GST Attachment', 'ESI Certificate', 'PF Certificate', 'Letter Head', 'Specimen Signature', 'PAN Card', 'Aadhaar Card', 'Company Registration', 'Active')";
                    Console.WriteLine("Query: " + sql);
                    
                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                    cmd1.ExecuteNonQuery();
                }

                MessageBox.Show("Done");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
//String sql = "INSERT INTO [au-500$] ([Employer ID],[Name of Firm],[Address],[Contact],[Email ID],[Date of Registration in PF ESI],[GST Number],[EPF Number],[EPFO Password],[ESI Number],[ESI Password],[Welfare Number],[Welfare Password],[ESI Registration Number],[Bank Name],[Bank Account Number],[IFSC],[GST Attachment],[ESI Certificate],[PF Certificate],[Letter Head],[Specimen Signature],[PAN Card],[Aadhaar Card],[Company Registration],[Status]) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+dateTimePicker1.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+ "','"+textBox10.Text+"','"+textBox11.Text+ "','"+textBox12.Text+ "','"+textBox13.Text+ "','"+textBox14.Text+ "','"+textBox15.Text+ "','"+textBox16.Text+ "','"+textBox17.Text+ "','GST Attachment','ESI Certificate','PF Certificate','Letter Head','Specimen Signature','PAN Card','Aadhaar Card','Company Registration','Active');";
