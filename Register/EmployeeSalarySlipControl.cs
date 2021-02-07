using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using iTextSharp.text;
using System.Collections.Generic;
using iTextSharp.text.pdf;
using iText.Layout.Font;

namespace Register
{
    public partial class EmployeeSalarySlipControl : UserControl
    {
        string companyID = "";
        string employeeID = "";
        Dictionary<string, string> employeeSlipDetails = new Dictionary<string, string>();

        public EmployeeSalarySlipControl()
        {
            InitializeComponent();
        }

        private void EmployeeSalarySlipControl_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, 1);
            this.companyID = ActiveEmployeeControl.companyID;
            this.employeeID = ActiveEmployeeControl.employeeID;
        }

        public static iTextSharp.text.Font GetTahoma()
        {
            var fontName = "Tahoma";
            if (!FontFactory.IsRegistered(fontName))
            {
                var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\addins\\Courier.ttf";
                FontFactory.Register(fontPath);
            }
            return FontFactory.GetFont(fontName, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dtp = (DateTimePicker)sender;
            dtp.Value = new DateTime(dtp.Value.Year, dtp.Value.Month, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paySlipHeader.Text = "Pay Slip for the month of " + dateTimePicker1.Value.ToString("MMMM") + " " + dateTimePicker1.Value.ToString("yyyy");
            fetchData();
            setText();
        }

        public void fetchData()
        {
            string monthName = dateTimePicker1.Value.ToString("MMMM");
            string yearName = dateTimePicker1.Value.ToString("yyyy");
            string path = @"C:\data\detail\" + companyID + @"\" + companyID + @"_attendance\" + companyID + "_" + yearName + ".xls";
            string employeePath = @"C:\data\detail\" + companyID + @"\" + companyID + @"_employee.xls";

            if (!(File.Exists(path)))
            {
                MessageBox.Show("Sorry we don't have any data for year " + yearName);
            }
            else
            {
                try
                {
                    System.Data.DataTable dtExcel = new System.Data.DataTable();
                    dtExcel.TableName = "ExcelData";
                    string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
                    OleDbConnection con = new OleDbConnection(sourceConstr);
                    string currentMonth = DateTime.Now.ToString("MMMM");
                    string query = "select * from [attendance$] where [MONTH]='" + monthName + "' and [EMPLOYEE ID]='" + employeeID + "';";
                    OleDbDataAdapter data = new OleDbDataAdapter(query, con);
                    data.Fill(dtExcel);
                    con.Close();

                    if (dtExcel.Rows.Count == 0)
                        MessageBox.Show("Sorry we don't have any data for month " + monthName);
                    else
                    {
                        employeeSlipDetails.Clear();

                        employeeSlipDetails.Add("RECEIPT ID", dtExcel.Rows[0]["RECEIPT ID"].ToString());
                        employeeSlipDetails.Add("EMPLOYEE ID", dtExcel.Rows[0]["EMPLOYEE ID"].ToString());
                        employeeSlipDetails.Add("EMPLOYEE NAME", dtExcel.Rows[0]["EMPLOYEE NAME"].ToString());
                        employeeSlipDetails.Add("FATHER'S//HUSBAND'S NAME", dtExcel.Rows[0]["FATHER'S/HUSBAND'S NAME"].ToString());
                        employeeSlipDetails.Add("GROSS WAGES", dtExcel.Rows[0]["GROSS WAGES"].ToString());
                        employeeSlipDetails.Add("BASIC", dtExcel.Rows[0]["BASIC"].ToString());
                        employeeSlipDetails.Add("TOTAL DAYS IN MONTH", dtExcel.Rows[0]["TOTAL DAYS IN MONTH"].ToString());
                        employeeSlipDetails.Add("TOTAL PRESENT DAY", dtExcel.Rows[0]["TOTAL PRESENT DAY"].ToString());
                        employeeSlipDetails.Add("BASIC SALARY", dtExcel.Rows[0]["BASIC SALARY"].ToString());
                        employeeSlipDetails.Add("HRA", dtExcel.Rows[0]["HRA"].ToString());
                        employeeSlipDetails.Add("CONVEYANCE", dtExcel.Rows[0]["CONVEYANCE"].ToString());
                        employeeSlipDetails.Add("OVER TIME", dtExcel.Rows[0]["OVER TIME"].ToString());
                        employeeSlipDetails.Add("INCENTIVE", dtExcel.Rows[0]["INCENTIVE"].ToString());
                        employeeSlipDetails.Add("EARNED GROSS SALARY", dtExcel.Rows[0]["EARNED GROSS SALARY"].ToString());
                        employeeSlipDetails.Add("EMPLOYEE PF", dtExcel.Rows[0]["EMPLOYEE PF"].ToString());
                        employeeSlipDetails.Add("PMPRY/ABRY BENEFITS", dtExcel.Rows[0]["PMPRY/ABRY BENEFITS"].ToString());
                        employeeSlipDetails.Add("EMPLOYEE ESIC", dtExcel.Rows[0]["EMPLOYEE ESIC"].ToString());
                        employeeSlipDetails.Add("WELFARE", dtExcel.Rows[0]["WELFARE"].ToString());
                        employeeSlipDetails.Add("TDS", dtExcel.Rows[0]["TDS"].ToString());
                        employeeSlipDetails.Add("ADVANCE", dtExcel.Rows[0]["ADVANCE"].ToString());
                        employeeSlipDetails.Add("OTHER DEDUCTION", dtExcel.Rows[0]["OTHER DEDUCTION"].ToString());
                        employeeSlipDetails.Add("TOTAL DEDUCTION", dtExcel.Rows[0]["TOTAL DEDUCTION"].ToString());
                        employeeSlipDetails.Add("NET SALARY", dtExcel.Rows[0]["NET SALARY"].ToString());
                        employeeSlipDetails.Add("EMPLOYER PF", dtExcel.Rows[0]["EMPLOYER PF"].ToString());
                        employeeSlipDetails.Add("EMPLOYER ESIC", dtExcel.Rows[0]["EMPLOYER ESIC"].ToString());
                        employeeSlipDetails.Add("EMPLOYER WELFARE", dtExcel.Rows[0]["EMPLOYER WELFARE"].ToString());
                        employeeSlipDetails.Add("CTC", dtExcel.Rows[0]["CTC"].ToString());
                        employeeSlipDetails.Add("MONTH", dtExcel.Rows[0]["MONTH"].ToString());
                    }

                    System.Data.DataTable employeeExcel = new System.Data.DataTable();
                    employeeExcel.TableName = "ExcelData";
                    string employeeStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + employeePath + "';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
                    OleDbConnection employeeCon = new OleDbConnection(employeeStr);
                    string sqlQuery = "select * from [employee_detail$] where [Employee ID]='" + employeeID + "';";
                    OleDbDataAdapter employeeData = new OleDbDataAdapter(sqlQuery, employeeCon);
                    employeeData.Fill(employeeExcel);
                    employeeCon.Close();
                    employeeSlipDetails.Add("DOJ", employeeExcel.Rows[0]["DOJ"].ToString());
                    employeeSlipDetails.Add("PF NUMBER", employeeExcel.Rows[0]["PF Registration Number"].ToString());
                    employeeSlipDetails.Add("ESI NUMBER", employeeExcel.Rows[0]["ESI Registration Number"].ToString());
                    employeeSlipDetails.Add("PAN NUMBER", employeeExcel.Rows[0]["Pan Number"].ToString());
                    employeeSlipDetails.Add("BANK ACCOUNT NUMBER", employeeExcel.Rows[0]["Bank Account Number"].ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



        public void setText()
        {
            txtemployeeID.Text = employeeSlipDetails["EMPLOYEE ID"];
            txtemployeeName.Text = employeeSlipDetails["EMPLOYEE NAME"];
            txtPFNumber.Text = employeeSlipDetails["PF NUMBER"];
            txtTotalDaysInMonth.Text = employeeSlipDetails["TOTAL DAYS IN MONTH"];
            txtTotalPresentDays.Text = employeeSlipDetails["TOTAL PRESENT DAY"];
            txtDateOfJoining.Text = employeeSlipDetails["DOJ"];
            txtBankAccountNumber.Text = employeeSlipDetails["BANK ACCOUNT NUMBER"];
            txtPANNumber.Text = employeeSlipDetails["PAN NUMBER"];
            txtESINumber.Text = employeeSlipDetails["ESI NUMBER"];
            txtBasicSalary.Text = employeeSlipDetails["BASIC SALARY"];
            txtHRA.Text = employeeSlipDetails["HRA"];
            txtWelfare.Text = employeeSlipDetails["WELFARE"];
            txtConveyance.Text = employeeSlipDetails["CONVEYANCE"];
            txtAdvance.Text = employeeSlipDetails["ADVANCE"];
            txtTDS.Text = employeeSlipDetails["TDS"];
        }


        public void printFile()
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Salary Slip";
            sfd.Filter = "(*.pdf)|*.pdf";
            sfd.InitialDirectory = @"C:\";

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Panel pnlPrintControl = new Panel();

                Document doc = new Document(PageSize.A4, 36f, 36f, 36f, 36f);//36f, 36f, 90f, 100f);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph("  "));
                Paragraph title = new Paragraph();
                title.Add(new Chunk("Pay Slip for the month of " + dateTimePicker1.Value.ToString("MMMM") + " " + dateTimePicker1.Value.ToString("yyyy"), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, BaseColor.BLACK)));
                title.Alignment = 1;
                doc.Add(title);
                doc.Add(new Paragraph("  "));
                PdfPTable table1 = new PdfPTable(4);
                int[] columnwidth = { 20, 25, 20, 25 };
                table1.SetWidths(columnwidth);
                table1.WidthPercentage = 100;
                table1.HorizontalAlignment = 0;
                //adding employee detail 
                PdfPCell cellColumnName;
                PdfPCell cellColumnValue;
                string columnName;
                string columnValue;

                columnName = "Employee ID";
                columnValue = employeeSlipDetails["EMPLOYEE ID"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "Employee Name";
                columnValue = employeeSlipDetails["EMPLOYEE NAME"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "PF Number";
                columnValue = employeeSlipDetails["PF NUMBER"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "Total Days in Month";
                columnValue = employeeSlipDetails["TOTAL DAYS IN MONTH"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "Total Present Days";
                columnValue = employeeSlipDetails["TOTAL PRESENT DAY"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "Date of Joining";
                columnValue = employeeSlipDetails["DOJ"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "Bank Account Number";
                columnValue = employeeSlipDetails["BANK ACCOUNT NUMBER"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "PAN Number";
                columnValue = employeeSlipDetails["PAN NUMBER"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "Mode Of Pay";
                columnValue = "NA";
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                columnName = "ESI Number";
                columnValue = employeeSlipDetails["ESI NUMBER"];
                cellColumnName = new PdfPCell(new Phrase(columnName, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) };
                cellColumnName.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                        //Cellcolumnname.Border = 15;
                table1.AddCell(cellColumnName);
                cellColumnValue = new PdfPCell(new Phrase(columnValue, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnValue.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                                                         //cellcolumnvalue.Border = 15;
                table1.AddCell(cellColumnValue);

                //employee detail ends here
                doc.Add(table1);
                doc.Add(new Paragraph("  "));
                PdfPTable mainTable = new PdfPTable(4); //earnedTable1.TotalWidth = 500f;//earnedTable1.LockedWidth = true;
                int[] columnwidth1 = { 30, 20, 30, 20 }; //23, 20, 25, 32 };
                mainTable.SetWidths(columnwidth1);
                mainTable.WidthPercentage = 100;
                mainTable.HorizontalAlignment = 0;
                mainTable.AddCell(new PdfPCell(new Phrase("EARNINGS", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) }); //{ HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) };;
                mainTable.AddCell(new PdfPCell(new Phrase("RUPEES", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) }); //{ HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) };;
                mainTable.AddCell(new PdfPCell(new Phrase("DEDUCTIONS", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) }); //{ HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) };;
                mainTable.AddCell(new PdfPCell(new Phrase("RUPEES", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) }); //{ HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5, BackgroundColor = new BaseColor(System.Drawing.Color.Silver) };;
                                                                                                                                                                                                                                                                     // b. creating earning table with 2 columns [left side]
                PdfPTable earning = new PdfPTable(2);
                int[] columnwidth3 = { 30, 20 };
                earning.SetWidths(columnwidth3);
                earning.WidthPercentage = 80;
                earning.HorizontalAlignment = 0;
                //adding earnings starts here

                string columnName1;
                string columnValue1;
                PdfPCell cellColumnName1;
                PdfPCell cellColumnValue1;

                columnName1 = "Basic Salary";
                columnValue1 = employeeSlipDetails["BASIC SALARY"];
                ; cellColumnName1 = new PdfPCell(new Phrase(columnName1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName1.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                earning.AddCell(cellColumnName1);
                cellColumnValue1 = new PdfPCell(new Phrase(AppendComma(columnValue1), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                earning.AddCell(cellColumnValue1);
                columnName1 = "Arear";
                columnValue1 = "NA";
                cellColumnName1 = new PdfPCell(new Phrase(columnName1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName1.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                earning.AddCell(cellColumnName1);
                cellColumnValue1 = new PdfPCell(new Phrase(columnValue1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                earning.AddCell(cellColumnValue1);
                columnName1 = "H.R.A.";
                columnValue1 = employeeSlipDetails["HRA"];
                cellColumnName1 = new PdfPCell(new Phrase(columnName1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName1.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                earning.AddCell(cellColumnName1);
                cellColumnValue1 = new PdfPCell(new Phrase(AppendComma(columnValue1), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                earning.AddCell(cellColumnValue1);
                columnName1 = "Conveyance";
                columnValue1 = employeeSlipDetails["CONVEYANCE"];
                cellColumnName1 = new PdfPCell(new Phrase(columnName1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName1.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                earning.AddCell(cellColumnName1);
                cellColumnValue1 = new PdfPCell(new Phrase(AppendComma(columnValue1), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                earning.AddCell(cellColumnValue1);
                columnName1 = "Allowance";
                columnValue1 = "NA";
                cellColumnName1 = new PdfPCell(new Phrase(columnName1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName1.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                earning.AddCell(cellColumnName1);
                cellColumnValue1 = new PdfPCell(new Phrase(columnValue1, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                earning.AddCell(cellColumnValue1);

                //earnings end here

                PdfPTable deduction = new PdfPTable(2);
                int[] columnwidth4 = { 30, 20 };
                deduction.SetWidths(columnwidth3);
                deduction.WidthPercentage = 80;
                deduction.HorizontalAlignment = 0;
                //adding deduction starts here

                string columnName2;
                string columnValue2;
                PdfPCell cellColumnName2;
                PdfPCell cellColumnValue2;

                columnName2 = "E.P.F.";
                columnValue2 = "NA";
                cellColumnName2 = new PdfPCell(new Phrase(columnName2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName2.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                deduction.AddCell(cellColumnName2);
                cellColumnValue2 = new PdfPCell(new Phrase(columnValue2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                deduction.AddCell(cellColumnValue2);

                columnName2 = "E.S.I.";
                columnValue2 = "NA";
                cellColumnName2 = new PdfPCell(new Phrase(columnName2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName2.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                deduction.AddCell(cellColumnName2);
                cellColumnValue2 = new PdfPCell(new Phrase(columnValue2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                deduction.AddCell(cellColumnValue2);

                columnName2 = "Welfare";
                columnValue2 = employeeSlipDetails["WELFARE"];
                cellColumnName2 = new PdfPCell(new Phrase(columnName2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName2.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                deduction.AddCell(cellColumnName2);
                cellColumnValue2 = new PdfPCell(new Phrase(AppendComma(columnValue2), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                deduction.AddCell(cellColumnValue2);
                
                columnName2 = "Advance";
                columnValue2 = employeeSlipDetails["ADVANCE"];
                cellColumnName2 = new PdfPCell(new Phrase(columnName2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName2.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                deduction.AddCell(cellColumnName2);
                cellColumnValue2 = new PdfPCell(new Phrase(AppendComma(columnValue2), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                deduction.AddCell(cellColumnValue2);

                columnName2 = "T.D.S.";
                columnValue2 = employeeSlipDetails["TDS"];
                cellColumnName2 = new PdfPCell(new Phrase(columnName2, new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111))));
                cellColumnName2.HorizontalAlignment = 0; //0=Left, 1=Centre, 2=Right
                deduction.AddCell(cellColumnName2);
                cellColumnValue2 = new PdfPCell(new Phrase(AppendComma(columnValue2), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT };
                deduction.AddCell(cellColumnValue2);

                //deduction ends here

                PdfPCell cell1 = new PdfPCell(earning);
                cell1.Colspan = 2;
                mainTable.AddCell(cell1);
                PdfPCell cell2 = new PdfPCell(deduction);
                cell2.Colspan = 2;
                mainTable.AddCell(cell2);
                mainTable.AddCell(new PdfPCell(new Phrase("Gross Earning", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_LEFT, BackgroundColor = new BaseColor(236, 236, 236) });
                mainTable.AddCell(new PdfPCell(new Phrase(AppendComma("7"), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                mainTable.AddCell(new PdfPCell(new Phrase("Gross Deductions", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new BaseColor(236, 236, 236) });
                mainTable.AddCell(new PdfPCell(new Phrase(AppendComma("8"), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 });
                PdfPCell netEarning = new PdfPCell(new Phrase("Net Salary", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_LEFT, BackgroundColor = new BaseColor(236, 236, 236) };
                mainTable.AddCell(netEarning);
                string NetSalary = (Convert.ToDecimal("89") - Convert.ToDecimal("98")).ToString();
                PdfPCell netSalary = new PdfPCell(new Phrase(AppendComma(NetSalary), new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, new BaseColor(50, 50, 111)))) { HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 };
                mainTable.AddCell(netSalary);
                PdfPCell blankCell = new PdfPCell();
                blankCell.Colspan = 2;
                mainTable.AddCell(blankCell);
                doc.Add(mainTable);
                Paragraph Note = new Paragraph();
                Note.Add(new Chunk("This is computer generated payslip and does not require signature or company seal.", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, BaseColor.BLACK)));
                Note.Alignment = 1;
                doc.Add(Note);
                Paragraph address = new Paragraph();
                address.Add(new Chunk(@"(ABC Infotech Pvt Ltd.)
            Address: 1st Floor, Steet Name, Bullding Number, Mumbai - 400001", new iTextSharp.text.Font(GetTahoma().BaseFont, 10, 1, BaseColor.BLACK)));
                address.Alignment = 1;
                doc.Add(address);
                doc.Close();
            }




        }


        private string AppendComma(string value)
        {
            return String.Format("{0:#,0.00}", Convert.ToDecimal(value));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fetchData();
            printFile();
        }
    }
}
