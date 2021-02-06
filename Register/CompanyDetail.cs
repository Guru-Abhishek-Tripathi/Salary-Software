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
    public partial class CompanyDetail : Form
    {
        public static string companyID = "";

        public CompanyDetail()
        {
            InitializeComponent();
        }

        private void CompanyDetail_Load(object sender, EventArgs e)
        {
            SetActivePanel(companyDetailControl1);
            companyID = HomeControl.companyID;
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
            attendanceControl1.Visible = false;
            companySalarySlipControl1.Visible = false;
            companyRegistersControl1.Visible = false;


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

        private void singleEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SetActivePanel(addSingleEmployeeControl1);
        }

        private void addAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetActivePanel(attendanceControl1);
        }

        private void listEmployeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Employee List",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Excel File(*.xls;*.xlsx)|*.xls;*.xlsx;",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
            };

            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
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
                            if (alreadyRegistered(dRow["Employee ID"].ToString(), companyID))
                            {
                                MessageBox.Show("Employee with ID "+dRow["Employee ID"] +" already registered.");
                            }
                            else
                            {
                                string addSource = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                                using (OleDbConnection cn = new OleDbConnection(addSource))
                                {
                                    cn.Open();

                                    //validate worksheet name.
                                    string worksheetName = getWorkSheet(cn);
                                    String sql = "INSERT INTO [" + worksheetName + "] ([Employee ID],[Name],[Father's/Husband's Name],[Department],[Location],[Permanent Address],[Employee Contact Number],[DOB],[DOJ],[Aadhaar Number],[Pan Number],[PF Registration Number],[ESI Registration Number],[Bank Name],[Bank Account Number],[IFSC],[Appointment Letter],[Joining Letter],[ESI Declaration],[PF Number],[ESI Certificate],[Aadhaar Card],[PAN Card],[Bank Cheque],[Nominee Detail],[Family Undertaking],[Nominee Name],[Nominee Relation],[Nominee Contact],[Status]) values('" + dRow["Employee ID"] + "', '" + dRow["Name"] + "', '" + dRow["Father's/Husband's Name"] + "', '" + dRow["Department"] + "', '" + dRow["Location"] + "', '" + dRow["Permanent Address"] + "', '" + dRow["Employee Contact Number"] + "', '" + dRow["DOB"] + "', '" + dRow["DOJ"] + "', '" + dRow["Aadhaar Number"] + "', '" + dRow["Pan Number"] + "', '" + dRow["PF Registration Number"] + "', '" + dRow["ESI Registration Number"] + "', '" + dRow["Bank Name"] + "', '" + dRow["Bank Account Number"] + "', '" + dRow["IFSC"] + "', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', 'NA', '" + dRow["Nominee Name"] + "', '" + dRow["Nominee's Relation"] + "', '" + dRow["Nominee's Contact"] + "', 'Active');";

                                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                                    cmd1.ExecuteNonQuery();
                                    cn.Close();
                                }
                                CompanyDetail.activeEmployeeControl1.Visible = true;
                            }
                        }
                        MessageBox.Show("Added Sccessfully.");
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


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


        public Boolean alreadyRegistered(String empId, String companyId)
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SetActivePanel(companySalarySlipControl1);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SetActivePanel(companyRegistersControl1);
        }
    }
}
