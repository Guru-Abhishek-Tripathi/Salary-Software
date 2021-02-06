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
using Spire.Xls;
using System.Collections;

namespace Register
{
    public partial class AttendanceControl : UserControl
    {
        static string companyID = "";

        public AttendanceControl()
        {
            InitializeComponent();
        }

        private void AttendanceControl_Load(object sender, EventArgs e)
        {
            try
            {
                companyID = HomeControl.companyID;
                dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
                loadData();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string monthName = dateTimePicker1.Value.ToString("MMMM");
            string yearName = dateTimePicker1.Value.ToString("yyyy");
            string path = @"C:\data\detail\" + companyID + @"\" + companyID + @"_attendance\" + companyID + "_" + yearName + ".xls";
            if (!(File.Exists(path)))
            {
                createSpreadSheet(path);
            }

            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = "Attendance Sheet",
                    CheckFileExists = true,
                    CheckPathExists = true,
                    Filter = "Excel File(*.xls;*.xlsx)|*.xls;*.xlsx;",
                    FilterIndex = 1,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // need to call our deleteMultipleReceipt(string month) to delete all already added receipts for given month

                    deleteMultipleReceipt(monthName);

                    string fileName = openFileDialog.FileName;
                    System.Data.DataTable dtExcel = new System.Data.DataTable();
                    dtExcel.TableName = "ExcelData";
                    string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + fileName + "';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";

                    using (OleDbConnection con = new OleDbConnection(sourceConstr))
                    {
                        con.Open();
                        string workSheetName = getWorkSheet(con);
                        Console.WriteLine("WorkSheetName : " + workSheetName);
                        string query = "select * from [" + workSheetName + "]";
                        OleDbDataAdapter data = new OleDbDataAdapter(query, con);
                        data.Fill(dtExcel);
                        con.Close();

                        for (int i = 0; i < dtExcel.Rows.Count; i++)
                        {
                            DataRow dRow = dtExcel.Rows[i];
                                string addSource = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                                using (OleDbConnection cn = new OleDbConnection(addSource))
                                {
                                    cn.Open();

                                    //validate worksheet name.
                                    string worksheetName = getWorkSheet(cn);
                                    string receiptID = (DateTime.Now).ToString("yyyyMMddHHmmssffff");
                                    String sql = "INSERT INTO [" + worksheetName + "] ([RECEIPT ID],[EMPLOYEE ID],[EMPLOYEE NAME],[FATHER'S/HUSBAND'S NAME],[GROSS WAGES],[BASIC],[TOTAL DAYS IN MONTH],[TOTAL PRESENT DAY],[BASIC SALARY],[HRA],[CONVEYANCE],[OVER TIME],[INCENTIVE],[EARNED GROSS SALARY],[EMPLOYEE PF],[PMPRY/ABRY BENEFITS],[EMPLOYEE ESIC],[WELFARE],[TDS],[ADVANCE],[OTHER DEDUCTION],[TOTAL DEDUCTION],[NET SALARY],[EMPLOYER PF],[EMPLOYER ESIC],[EMPLOYER WELFARE],[CTC],[MONTH]) values('" + receiptID + "','" + dRow["EMPLOYEE ID"] + "','" + dRow["EMPLOYEE NAME"] + "','" + dRow["FATHER'S/HUSBAND'S NAME"] + "','" + dRow["GROSS WAGES"] + "','" + dRow["BASIC"] + "','" + dRow["TOTAL DAYS IN MONTH"] + "','" + dRow["TOTAL PRESENT DAY"] + "','" + dRow["BASIC SALARY"] + "','" + dRow["HRA"] + "','" + dRow["CONVEYANCE"] + "','" + dRow["OVER TIME"] + "','" + dRow["INCENTIVE"] + "','" + dRow["EARNED GROSS SALARY"] + "','" + dRow["EMPLOYEE PF"] + "','" + dRow["PMPRY/ABRY BENEFITS"] + "','" + dRow["EMPLOYEE ESIC"] + "','" + dRow["WELFARE"] + "','" + dRow["TDS"] + "','" + dRow["ADVANCE"] + "','" + dRow["OTHER DEDUCTION"] + "','" + dRow["TOTAL DEDUCTION"] + "','" + dRow["NET SALARY"] + "','" + dRow["EMPLOYER PF"] + "','" + dRow["EMPLOYER ESIC"] + "','" + dRow["EMPLOYER WELFARE"] + "','" + dRow["CTC"] + "','" + monthName + "');";
                                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                                    cmd1.ExecuteNonQuery();
                                    cn.Close();
                                }
                        }
                        MessageBox.Show("Added Sccessfully.");
                        loadData();
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }




        public void loadData()
        {
            string fileName = DateTime.Now.ToString("yyyy");
            string path = @"C:\data\detail\" + companyID + @"\" + companyID + @"_attendance\" + companyID + "_" + fileName + ".xls";
            if (File.Exists(path))
            {
                if (dataGridView1.Columns.Count > 27)
                {
                    dataGridView1.Columns.RemoveAt(27);
                    dataGridView1.Columns.RemoveAt(27);
                }
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                System.Data.DataTable dtExcel = new System.Data.DataTable();
                dtExcel.TableName = "ExcelData";
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
                OleDbConnection con = new OleDbConnection(sourceConstr);
                string currentMonth = DateTime.Now.ToString("MMMM");
                string query = "select * from [attendance$] where [MONTH]='" + currentMonth + "';";
                OleDbDataAdapter data = new OleDbDataAdapter(query, con);
                data.Fill(dtExcel);
                con.Close();

                string[] row;

                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    DataRow dRow = dtExcel.Rows[i];
                    row = new string[] {
                    dRow["RECEIPT ID"].ToString(),
                    dRow["EMPLOYEE ID"].ToString(),
                    dRow["EMPLOYEE NAME"].ToString(),
                    dRow["FATHER'S/HUSBAND'S NAME"].ToString(),
                    dRow["GROSS WAGES"].ToString(),
                    dRow["BASIC"].ToString(),
                    dRow["TOTAL DAYS IN MONTH"].ToString(),
                    dRow["TOTAL PRESENT DAY"].ToString(),
                    dRow["BASIC SALARY"].ToString(),
                    dRow["HRA"].ToString(),
                    dRow["CONVEYANCE"].ToString(),
                    dRow["OVER TIME"].ToString(),
                    dRow["INCENTIVE"].ToString(),
                    dRow["EARNED GROSS SALARY"].ToString(),
                    dRow["EMPLOYEE PF"].ToString(),
                    dRow["PMPRY/ABRY BENEFITS"].ToString(),
                    dRow["EMPLOYEE ESIC"].ToString(),
                    dRow["WELFARE"].ToString(),
                    dRow["TDS"].ToString(),
                    dRow["ADVANCE"].ToString(),
                    dRow["OTHER DEDUCTION"].ToString(),
                    dRow["TOTAL DEDUCTION"].ToString(),
                    dRow["NET SALARY"].ToString(),
                    dRow["EMPLOYER PF"].ToString(),
                    dRow["EMPLOYER ESIC"].ToString(),
                    dRow["EMPLOYER WELFARE"].ToString(),
                    dRow["CTC"].ToString()
                };
                    dataGridView1.Rows.Add(row);
                }
                DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn1);
                btn1.HeaderText = "Action";
                btn1.Text = "Update";
                btn1.Name = "btn";
                btn1.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(btn2);
                btn2.HeaderText = "Action";
                btn2.Text = "Delete";
                btn2.Name = "btn";

                btn2.UseColumnTextForButtonValue = true;
            }
            else
            {
                createSpreadSheet(path);

            }
        }


        public void createSpreadSheet(string filePath)
        {
            FileInfo spreadSheetInfo = new FileInfo(filePath);

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(spreadSheetInfo);
            var workSheet = package.Workbook.Worksheets.Add("attendance");


            workSheet.Cells["A1"].Value = "RECEIPT ID";
            workSheet.Cells["B1"].Value = "EMPLOYEE ID";
            workSheet.Cells["C1"].Value = "EMPLOYEE NAME";
            workSheet.Cells["D1"].Value = "FATHER'S/HUSBAND'S NAME";
            workSheet.Cells["E1"].Value = "GROSS WAGES";
            workSheet.Cells["F1"].Value = "BASIC";
            workSheet.Cells["G1"].Value = "TOTAL DAYS IN MONTH";
            workSheet.Cells["H1"].Value = "TOTAL PRESENT DAY";
            workSheet.Cells["I1"].Value = "BASIC SALARY";
            workSheet.Cells["J1"].Value = "HRA";
            workSheet.Cells["K1"].Value = "CONVEYANCE";
            workSheet.Cells["L1"].Value = "OVER TIME";
            workSheet.Cells["M1"].Value = "INCENTIVE";
            workSheet.Cells["N1"].Value = "EARNED GROSS SALARY";
            workSheet.Cells["O1"].Value = "EMPLOYEE PF";
            workSheet.Cells["P1"].Value = "PMPRY/ABRY BENEFITS";
            workSheet.Cells["Q1"].Value = "EMPLOYEE ESIC";
            workSheet.Cells["R1"].Value = "WELFARE";
            workSheet.Cells["S1"].Value = "TDS";
            workSheet.Cells["T1"].Value = "ADVANCE";
            workSheet.Cells["U1"].Value = "OTHER DEDUCTION";
            workSheet.Cells["V1"].Value = "TOTAL DEDUCTION";
            workSheet.Cells["W1"].Value = "NET SALARY";
            workSheet.Cells["X1"].Value = "EMPLOYER PF";
            workSheet.Cells["Y1"].Value = "EMPLOYER ESIC";
            workSheet.Cells["Z1"].Value = "EMPLOYER WELFARE";
            workSheet.Cells["AA1"].Value = "CTC";
            workSheet.Cells["AB1"].Value = "MONTH";

            workSheet.Cells["A1:AB1"].Style.Font.Bold = true;
            workSheet.Cells["A1:AB1"].Style.Fill.SetBackground(System.Drawing.Color.Yellow);

            workSheet.View.FreezePanes(2, 1);

            package.Save();
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
                    if (worksheetName.Contains('\''))
                    {
                        worksheetName = worksheetName.Replace('\'', ' ').Trim();
                    }
                }
            }

            return worksheetName;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 27)
                {
                    var valueList = new ArrayList();
                    string selectedReceiptID = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    for (int i = 0; i < 27; i++)
                        valueList.Add((string)dataGridView1.Rows[e.RowIndex].Cells[i].Value);
                    AttendanceForm attendanceForm = new AttendanceForm(companyID,valueList);
                    attendanceForm.FormClosed += new FormClosedEventHandler(afterUpdate);
                    attendanceForm.ShowDialog();
                }
                else if (e.ColumnIndex == 28)
                {
                    string selectedReceiptID = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    deleteSingleReceipt(selectedReceiptID);
                    MessageBox.Show("Receipt deleted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        public void afterUpdate(object sender, FormClosedEventArgs e)
        {
            loadData();
        }

        public void deleteSingleReceipt(string selectedReceipt)
        {
            try
            {
                Workbook workbook = new Workbook();
                string fileName = DateTime.Now.ToString("yyyy");
                string path = @"C:\data\detail\" + companyID + @"\" + companyID + @"_attendance\" + companyID + "_" + fileName + ".xls";
                workbook.LoadFromFile(path);

                Worksheet worksheet = workbook.Worksheets[0];

                long rowCount = worksheet.Rows.LongCount<CellRange>();
                long cellCount = worksheet.Columns.LongCount<CellRange>();

                Console.WriteLine("Row Count: " + rowCount);
                Console.WriteLine("Column Count: " + cellCount);

                for (var ri = 2; ri <= rowCount; ri++)
                {
                    var val = worksheet.Range[ri, 1].Value;
                    if (val.Equals(selectedReceipt))
                    {
                        worksheet.DeleteRow(ri);
                        break;
                    }
                }
                workbook.Save();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }


        public void deleteMultipleReceipt(string month)
        {
            try
            {
                Workbook workbook = new Workbook();
                string fileName = DateTime.Now.ToString("yyyy");
                string path = @"C:\data\detail\" + companyID + @"\" + companyID + @"_attendance\" + companyID + "_" + fileName + ".xls";
                workbook.LoadFromFile(path);

                Worksheet worksheet = workbook.Worksheets[0];

                long rowCount = worksheet.Rows.LongCount<CellRange>();
                long cellCount = worksheet.Columns.LongCount<CellRange>();

                Console.WriteLine("Row Count: " + rowCount);
                Console.WriteLine("Column Count: " + cellCount);

                var deleteList = new ArrayList();

                for (var ri = 2; ri <= rowCount; ri++)
                {
                    var val = worksheet.Range[ri, 28].Value;
                    if (val.Equals(month))
                    {
                        deleteList.Add(ri);
                    }
                }

                int c = 0;

                foreach(int di in deleteList)
                {
                    worksheet.DeleteRow(di-c);
                    c++;
                }

                workbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            dtp.Value = new DateTime(dtp.Value.Year, dtp.Value.Month, 1);
        }
    }
}
