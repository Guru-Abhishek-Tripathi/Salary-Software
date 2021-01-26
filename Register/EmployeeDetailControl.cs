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
    public partial class EmployeeDetailControl : UserControl
    {
        bool edit = false;
        string companyID = "";
        string employeeID = "";
        string downloadAttachment = "Default";


        public EmployeeDetailControl()
        {
            InitializeComponent();
        }

        private void EmployeeDetailControl_Load(object sender, EventArgs e)
        {
            this.companyID = ActiveEmployeeControl22.companyID;
            this.employeeID = ActiveEmployeeControl22.employeeID;
            setTextBoxData();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            edit = !edit;
            makeEnableOrDisable(edit);
            if (edit)
                setColor(System.Drawing.Color.Gainsboro);
            else
                setColor(System.Drawing.Color.MistyRose);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                MessageBox.Show("Please edit before submit.");
            }
            else if (textBox1.Text.ToString().Equals("") || textBox2.Text.ToString().Equals("") || textBox3.Text.ToString().Equals("") || textBox4.Text.ToString().Equals("") || textBox5.Text.ToString().Equals("") || textBox6.Text.ToString().Equals("") || textBox7.Text.ToString().Equals("") || dateTimePicker1.Text.ToString().Equals("") || dateTimePicker2.Text.ToString().Equals("") || textBox10.Text.ToString().Equals("") || textBox11.Text.ToString().Equals("") || textBox12.Text.ToString().Equals("") || textBox13.Text.ToString().Equals("") || textBox14.Text.ToString().Equals("") || textBox15.Text.ToString().Equals("") || textBox16.Text.ToString().Equals("") || textBox17.Text.ToString().Equals("") || textBox18.Text.ToString().Equals("") || textBox19.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                try
                {
                    using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                    {
                        cn.Open();

                        String sql = "UPDATE [employee_detail$] SET [Name]='" + textBox2.Text.ToString() + "', [Father/Husband Name]='" + textBox3.Text.ToString() + "', [Department]='" + textBox4.Text.ToString() + "',[Location]='" + textBox5.Text.ToString() + "',[Permanent Address]='" + textBox6.Text.ToString() + "', [Employee Contact Number]='" + textBox7.Text.ToString() + "', [DOB]='" + dateTimePicker1.Text.ToString() + "', [DOJ]='" + dateTimePicker2.Text.ToString() + "', [Aadhaar Number]='" + textBox10.Text.ToString() + "', [Pan Number]='" + textBox11.Text.ToString() + "', [PF Registration Number]='" + textBox12.Text.ToString() + "', [ESI Registration Number]='" + textBox13.Text.ToString() + "', [Bank Name]='" + textBox14.Text.ToString() + "', [Bank Account Number]='" + textBox15.Text.ToString() + "', [IFSC]='" + textBox16.Text.ToString() + "', [Nominee Name]='" + textBox17.Text.ToString() + "', [Nominee Relation]='" + textBox18.Text.ToString() + "', [Nominee Contact]='" + textBox19.Text.ToString() + "' WHERE [Employee ID]='" + textBox1.Text.ToString() + "';";

                        Console.WriteLine("SQL :: " + sql);

                        OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();

                    }
                    edit = !edit;
                    makeEnableOrDisable(edit);
                    if (edit)
                        setColor(System.Drawing.Color.Gainsboro);
                    else
                        setColor(System.Drawing.Color.MistyRose);

                    MessageBox.Show("Deatils Updated.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

            try
            {
                using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                {
                    cn.Open();

                    String sql = "UPDATE [employee_detail$] SET [Status]='Inactive' WHERE [Employee ID]='" + textBox1.Text.ToString() + "';";

                    Console.WriteLine("SQL :: " + sql);

                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                    cmd1.ExecuteNonQuery();
                    cn.Close();

                }

                MessageBox.Show("Services for this employee are closed from now onwards.");
                CompanyDetail.activeEmployeeControl1.loadData();
                CompanyDetail.resignedEmployeesControl1.loadData();
                CompanyDetail.activeEmployeeControl1.Visible = true;
                ((Form)this.TopLevelControl).Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }






        public void setTextBoxData()
        {
            try
            {
                System.Data.DataTable dtExcel = new System.Data.DataTable();
                dtExcel.TableName = "ExcelData";
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + @"_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
                OleDbConnection con = new OleDbConnection(sourceConstr);
                string query = "select * from [employee_detail$] WHERE [Employee ID]='" + employeeID + "';";
                OleDbDataAdapter data = new OleDbDataAdapter(query, con);
                data.Fill(dtExcel);
                con.Close();

                DataRow companyData = dtExcel.Rows[0];

                textBox1.Text = companyData["Employee ID"].ToString();
                textBox2.Text = companyData["Name"].ToString();
                textBox3.Text = companyData["Father/Husband Name"].ToString();
                textBox4.Text = companyData["Department"].ToString();
                textBox5.Text = companyData["Location"].ToString();
                textBox6.Text = companyData["Permanent Address"].ToString();
                textBox7.Text = companyData["Employee Contact Number"].ToString();
                dateTimePicker1.Text = companyData["DOB"].ToString();
                dateTimePicker1.Text = companyData["DOJ"].ToString();
                textBox10.Text = companyData["Aadhaar Number"].ToString();
                textBox11.Text = companyData["Pan Number"].ToString();
                textBox12.Text = companyData["PF Registration Number"].ToString();
                textBox13.Text = companyData["ESI Registration Number"].ToString();
                textBox14.Text = companyData["Bank Name"].ToString();
                textBox15.Text = companyData["Bank Account Number"].ToString();
                textBox16.Text = companyData["IFSC"].ToString();
                textBox17.Text = companyData["Nominee Name"].ToString();
                textBox18.Text = companyData["Nominee Relation"].ToString();
                textBox19.Text = companyData["Nominee Contact"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void makeEnableOrDisable(bool toggle)
        {
            textBox2.Enabled = toggle;
            textBox3.Enabled = toggle;
            textBox4.Enabled = toggle;
            textBox5.Enabled = toggle;
            textBox6.Enabled = toggle;
            textBox7.Enabled = toggle;
            dateTimePicker1.Enabled = toggle;
            dateTimePicker2.Enabled = toggle;
            textBox10.Enabled = toggle;
            textBox11.Enabled = toggle;
            textBox12.Enabled = toggle;
            textBox13.Enabled = toggle;
            textBox14.Enabled = toggle;
            textBox15.Enabled = toggle;
            textBox16.Enabled = toggle;
            textBox17.Enabled = toggle;
            textBox18.Enabled = toggle;
            textBox19.Enabled = toggle;
        }

        public void setColor(Color color)
        {
            textBox2.BackColor = color;
            textBox3.BackColor = color;
            textBox4.BackColor = color;
            textBox5.BackColor = color;
            textBox6.BackColor = color;
            textBox7.BackColor = color;
            dateTimePicker1.BackColor = color;
            dateTimePicker2.BackColor = color;
            textBox10.BackColor = color;
            textBox11.BackColor = color;
            textBox12.BackColor = color;
            textBox13.BackColor = color;
            textBox14.BackColor = color;
            textBox15.BackColor = color;
            textBox16.BackColor = color;
            textBox17.BackColor = color;
            textBox18.BackColor = color;
            textBox19.BackColor = color;
        }

        public void saveAttachment(string location, string attachmentName)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Employee's Attachment",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "PDF File(*pdf;)|*.pdf;",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.Combine(@"C:\data\detail\", companyID + @"\" + companyID + "_" + location + @"\" + employeeID + "_" + location + ".pdf");
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                {
                    cn.Open();


                    String sql = "UPDATE [employee_detail$] SET [" + attachmentName + "]='" + filePath + "' WHERE [Employee ID]='" + employeeID + "';";

                    Console.WriteLine("SQL :: " + sql);

                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                    cmd1.ExecuteNonQuery();
                    cn.Close();

                }

                File.Copy(openFileDialog.FileName, filePath, true);
                MessageBox.Show("Uploaded");
            }

        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("appointment_letter", "Appointment Letter");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("joining_letter", "Joining Letter");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("esi_declaration", "ESI Declaration");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("pf_number", "PF Number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("esi_certificate", "ESI Certificate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("aadhaar_card", "Aadhaar Card");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("pan_card", "PAN Card");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("bank_cheque", "Bank Cheque");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("nominee_detail", "Nominee Detail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment("family_undertaking", "Family Undertaking");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            this.downloadAttachment = cmb.SelectedItem.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string location = "select";
                switch (this.downloadAttachment)
                {
                    case "Appointment Letter":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_appointment_letter" + @"\" + employeeID + "_appointment_letter.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_appointment_letter" + @"\" + employeeID + "_appointment_letter.pdf";
                        else
                            location = "NA";
                        break;
                    case "Joining Letter":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_joining_letter" + @"\" + employeeID + "_joining_letter.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_joining_letter" + @"\" + employeeID + "_joining_letter.pdf";
                        else
                            location = "NA";
                        break;
                    case "ESI Declaration":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_esi_declaration" + @"\" + employeeID + "_esi_declaration.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_esi_declaration" + @"\" + employeeID + "_esi_declaration.pdf";
                        else
                            location = "NA";
                        break;
                    case "PF Number":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_pf_number" + @"\" + employeeID + "_pf_number.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_pf_number" + @"\" + employeeID + "_pf_number.pdf";
                        else
                            location = "NA";
                        break;
                    case "ESI Certificate":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_esi_certificate" + @"\" + employeeID + "_esi_certificate.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_esi_certificate" + @"\" + employeeID + "_esi_certificate.pdf";
                        else
                            location = "NA";
                        break;
                    case "Aadhaar Card":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_aadhaar_card" + @"\" + employeeID + "_aadhaar_card.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_aadhaar_card" + @"\" + employeeID + "_aadhaar_card.pdf";
                        else
                            location = "NA";
                        break;
                    case "PAN Card":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_pan_card" + @"\" + employeeID + "_pan_card.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_pan_card" + @"\" + employeeID + "_pan_card.pdf";
                        else
                            location = "NA";
                        break;
                    case "Bank Cheque":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_bank_cheque" + @"\" + employeeID + "_bank_cheque.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_bank_cheque" + @"\" + employeeID + "_bank_cheque.pdf";
                        else
                            location = "NA";
                        break;
                    case "Nominee Detail":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_nominee_detail" + @"\" + employeeID + "_nominee_detail.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_nominee_detail" + @"\" + employeeID + "_nominee_detail.pdf";
                        else
                            location = "NA";
                        break;
                    case "Family Undertaking":
                        if (File.Exists(@"C:\data\detail\" + companyID + @"\" + companyID + "_family_undertaking" + @"\" + employeeID + "_family_undertaking.pdf"))
                            location = @"C:\data\detail\" + companyID + @"\" + companyID + "_family_undertaking" + @"\" + employeeID + "_family_undertaking.pdf";
                        else
                            location = "NA";
                        break;
                }

                if (location.Equals("select"))
                    MessageBox.Show("Please select a document.");
                else if (location.Equals("NA"))
                    MessageBox.Show("Please upload document first.");
                else
                    System.Diagnostics.Process.Start(location);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
 }
