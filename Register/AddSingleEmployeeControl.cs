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
    public partial class AddSingleEmployeeControl : UserControl
    {
        static string companyID = "";
        static string empID = "";

        public AddSingleEmployeeControl()
        {
            InitializeComponent();
            companyID = HomeControl.companyID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Equals("") || textBox2.Text.ToString().Equals("") || textBox3.Text.ToString().Equals("") || textBox4.Text.ToString().Equals("") || textBox5.Text.ToString().Equals("") || textBox6.Text.ToString().Equals("") || textBox7.Text.ToString().Equals("") || dateTimePicker1.Text.ToString().Equals("") || dateTimePicker2.Text.ToString().Equals("") || textBox12.Text.ToString().Equals("") || textBox13.Text.ToString().Equals("") || textBox14.Text.ToString().Equals("") || textBox15.Text.ToString().Equals("") || textBox16.Text.ToString().Equals("") || textBox15.Text.ToString().Equals("") || textBox16.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else if (alreadyRegistered(textBox1.Text.ToString(), companyID))
            {
                MessageBox.Show("Employee ID already registered.");

            }
            else
            {
                try
                {
                    // Connection String // Here i am using HDR = YES which means excel first row consider as header  
                    //string con = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0;READONLY=FALSE'", filename);
                    string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\"+companyID+@"\"+companyID+"_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                    using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                    {
                        cn.Open();

                        //validate worksheet name.
                        string worksheetName = getWorkSheet(cn);

                        String sql = "INSERT INTO [" + worksheetName + "] ([Employee ID],[Name],[Father's/Husband's Name],[Department],[Location],[Permanent Address],[Employee Contact Number],[DOB],[DOJ],[Aadhaar Number],[Pan Number],[PF Registration Number],[ESI Registration Number],[Bank Name],[Bank Account Number],[IFSC],[Aadhaar Attachment],[Pan Attachment],[Security Cheque Attachment],[ESI card Attachment],[Status]) values('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + textBox6.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + dateTimePicker1.Text.ToString() + "', '" + dateTimePicker2.Text.ToString() + "', '" + textBox12.Text.ToString() + "', '" + textBox13.Text.ToString() + "', '" + textBox14.Text.ToString() + "', '" + textBox15.Text.ToString() + "', '" + textBox16.Text.ToString() + "', '" + textBox15.Text.ToString() + "', '" + textBox16.Text.ToString() + "', 'NA', 'NA', 'NA' ,'NA', 'Active');";
                        OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();
                    }

                    MessageBox.Show("Added Sccessfully.");
                    clearTextArea();
                    this.Visible = false;
                    CompanyDetail.activeEmployeeControl1.Visible = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show(ex.ToString());
                }

            }


        }

            private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CompanyDetail.activeEmployeeControl1.Visible = true;
        }

        public Boolean alreadyRegistered(String empId,String companyId)
        {
            Boolean result = false;
            try
            {
                System.Data.DataTable dtExcel = new System.Data.DataTable();
                dtExcel.TableName = "ExcelData";
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyId + @"\" + companyId + "_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
                OleDbConnection con = new OleDbConnection(sourceConstr);
                con.Open();
                String worksheet = getWorkSheet(con);
                string query = "select * from [" + worksheet + "]";
                OleDbDataAdapter data = new OleDbDataAdapter(query, con);
                data.Fill(dtExcel);
                con.Close();

                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    DataRow dRow = dtExcel.Rows[i];
                    if (dRow.RowState != DataRowState.Deleted && dRow["Employee ID"].ToString().Equals(empId))
                    {
                        result = true;
                        break;
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }
            return result;
        }



        public String getWorkSheet(OleDbConnection cn)
        {
            DataTable activityDataTable = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            String worksheetName = null;
            if (activityDataTable != null)
            {
                for (int cnt = 0; cnt < 1; cnt++)
                {
                    worksheetName = activityDataTable.Rows[cnt]["TABLE_NAME"].ToString();
                    Console.WriteLine("Sheet Name: " + worksheetName);
                    if (worksheetName.Contains('\''))
                    {
                        worksheetName = worksheetName.Replace('\'', ' ').Trim();
                    }
                }
            }

            return worksheetName;
        }



        public void clearTextArea()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearTextArea();
        }
    }
}
