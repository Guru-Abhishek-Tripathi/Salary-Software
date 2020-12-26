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
using OfficeOpenXml;

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
            if (textBox1.Text.ToString().Equals("") || textBox2.Text.ToString().Equals("") || textBox3.Text.ToString().Equals("") || textBox4.Text.ToString().Equals("") || textBox5.Text.ToString().Equals("") || dateTimePicker1.Text.ToString().Equals("") || textBox7.Text.ToString().Equals("") || textBox8.Text.ToString().Equals("") || textBox9.Text.ToString().Equals("") || textBox10.Text.ToString().Equals("") || textBox11.Text.ToString().Equals("") || textBox12.Text.ToString().Equals("") || textBox13.Text.ToString().Equals("") || textBox14.Text.ToString().Equals("") || textBox15.Text.ToString().Equals("") || textBox16.Text.ToString().Equals("") || textBox17.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill all the fields.");
            } else if (alreadyRegistered(textBox1.Text.ToString()))
            {
                MessageBox.Show("Company already registered.");
            }else {

                try {
                    // Declare the File name    
                    string filename = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\company.xls";
                    // Connection String // Here i am using HDR = YES which means excel first row consider as header  
                    //string con = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0;READONLY=FALSE'", filename);
                    string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                    using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                    {
                        cn.Open();
                        //First create the folder and file structure for new company
                        createCompanyFolderStructure(textBox1.Text.ToString());

                        //validate worksheet name.
                        string worksheetName = getWorkSheet(cn);

                        String sql = "INSERT INTO [" + worksheetName + "] ([Employer ID],[Name of Firm],[Address],[Contact],[Email ID],[Date of Registration in PF ESI],[GST Number],[EPF Number],[EPFO Password],[ESI Number],[ESI Password],[Welfare Number],[Welfare Password],[ESI Registration Number],[Bank Name],[Bank Account Number],[IFSC],[GST Attachment],[ESI Certificate],[PF Certificate],[Letter Head],[Specimen Signature],[PAN Card],[Aadhaar Card],[Company Registration],[Status]) values('" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + textBox3.Text.ToString() + "', '" + textBox4.Text.ToString() + "', '" + textBox5.Text.ToString() + "', '" + dateTimePicker1.Text.ToString() + "', '" + textBox7.Text.ToString() + "', '" + textBox8.Text.ToString() + "', '" + textBox9.Text.ToString() + "', '" + textBox10.Text.ToString() + "', '" + textBox11.Text.ToString() + "', '" + textBox12.Text.ToString() + "', '" + textBox13.Text.ToString() + "', '" + textBox14.Text.ToString() + "', '" + textBox15.Text.ToString() + "', '" + textBox16.Text.ToString() + "', '" + textBox17.Text.ToString() + "', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'Active')";

                        OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();
                    }

                    MessageBox.Show("Added Sccessfully.");
                    clearTextArea();
                    DashBoard.homeControl1.loadData();
                    this.Visible = false;
                    DashBoard.homeControl1.Visible = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public Boolean alreadyRegistered(String id)
        {
            Boolean result = false;
            try
            {
                System.Data.DataTable dtExcel = new System.Data.DataTable();
                dtExcel.TableName = "ExcelData";
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
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
                    if (dRow.RowState != DataRowState.Deleted && dRow["Employer ID"].ToString().Equals(id))
                    {
                        result = true;
                        break;
                    }
                }
                con.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

                return result;
        }


        public void clearTextArea()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
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


        public void createCompanyFolderStructure(String folderName)
        {
            string directoryName = @"C:\data\detail";
            string pathString = System.IO.Path.Combine(directoryName, folderName);
            System.IO.Directory.CreateDirectory(pathString);

            string employeePath = System.IO.Path.Combine(pathString, folderName + "_employee.xls");
            createSpreadSheet(employeePath);

            string aadhaarCard = System.IO.Path.Combine(pathString, folderName + "_aadhaar_card");
            System.IO.Directory.CreateDirectory(aadhaarCard);

            string panCard = System.IO.Path.Combine(pathString, folderName + "_pan_card");
            System.IO.Directory.CreateDirectory(panCard);

            string securityCheque = System.IO.Path.Combine(pathString, folderName + "_security_cheque");
            System.IO.Directory.CreateDirectory(securityCheque);

            string esiCard = System.IO.Path.Combine(pathString, folderName + "_esi_card");
            System.IO.Directory.CreateDirectory(esiCard);

        }

        public void createSpreadSheet(string spreadSheetPath)
        {
            //string spreadSheetPath = @"C:\data\detail\test.xls";

            File.Delete(spreadSheetPath);
            FileInfo spreadSheetInfo = new FileInfo(spreadSheetPath);

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(spreadSheetInfo);
            var workSheet = package.Workbook.Worksheets.Add("employee_detail");

            workSheet.Cells["A1"].Value = "Employee ID";
            workSheet.Cells["B1"].Value = "Name";
            workSheet.Cells["C1"].Value = "Father's/Husband's Name";
            workSheet.Cells["D1"].Value = "Department";
            workSheet.Cells["E1"].Value = "Location";
            workSheet.Cells["F1"].Value = "Permanent Address";
            workSheet.Cells["G1"].Value = "Employee Contact Number";
            workSheet.Cells["H1"].Value = "DOB";
            workSheet.Cells["I1"].Value = "DOJ";
            workSheet.Cells["J1"].Value = "Aadhaar Number";
            workSheet.Cells["K1"].Value = "Pan Number";
            workSheet.Cells["L1"].Value = "PF Registration Number";
            workSheet.Cells["M1"].Value = "ESI Registration Number";
            workSheet.Cells["N1"].Value = "Bank Name";
            workSheet.Cells["O1"].Value = "Bank Account Number";
            workSheet.Cells["P1"].Value = "IFSC";
            workSheet.Cells["Q1"].Value = "Aadhaar Attachment";
            workSheet.Cells["R1"].Value = "Pan Attachment";
            workSheet.Cells["S1"].Value = "Security Cheque Attachment";
            workSheet.Cells["T1"].Value = "ESI Card Attachment";
            workSheet.Cells["U1"].Value = "Status";

            workSheet.Cells["A1:U1"].Style.Font.Bold = true;
            workSheet.Cells["A1:U1"].Style.Fill.SetBackground(System.Drawing.Color.Yellow);

            workSheet.View.FreezePanes(2, 1);

            package.Save();
        }
    }


}
//String sql = "INSERT INTO [au-500$] ([Employer ID],[Name of Firm],[Address],[Contact],[Email ID],[Date of Registration in PF ESI],[GST Number],[EPF Number],[EPFO Password],[ESI Number],[ESI Password],[Welfare Number],[Welfare Password],[ESI Registration Number],[Bank Name],[Bank Account Number],[IFSC],[GST Attachment],[ESI Certificate],[PF Certificate],[Letter Head],[Specimen Signature],[PAN Card],[Aadhaar Card],[Company Registration],[Status]) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+dateTimePicker1.Text+"','"+textBox7.Text+"','"+textBox8.Text+"','"+textBox9.Text+ "','"+textBox10.Text+"','"+textBox11.Text+ "','"+textBox12.Text+ "','"+textBox13.Text+ "','"+textBox14.Text+ "','"+textBox15.Text+ "','"+textBox16.Text+ "','"+textBox17.Text+ "','GST Attachment','ESI Certificate','PF Certificate','Letter Head','Specimen Signature','PAN Card','Aadhaar Card','Company Registration','Active');";
