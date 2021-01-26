using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Aspose.Words;
using System.Windows.Controls;

namespace Register
{
    public partial class companyDetailControl : UserControl
    {
        bool edit = false;
        string companyID = "";
        string downloadAttachment = "Default";

        public companyDetailControl()
        {
            InitializeComponent();
        }

        private void companyDetailControl_Load(object sender, EventArgs e)
        {
            setColor(System.Drawing.Color.MistyRose);
            companyID = HomeControl.companyID;
            setTextBoxData();
        }


        public void makeEnableOrDisable(bool toggle)
        {
            textBox2.Enabled = toggle;
            textBox3.Enabled = toggle;
            textBox4.Enabled = toggle;
            textBox5.Enabled = toggle;
            dateTimePicker1.Enabled = toggle;
            textBox7.Enabled = toggle;
            textBox8.Enabled = toggle;
            textBox9.Enabled = toggle;
            textBox10.Enabled = toggle;
            textBox11.Enabled = toggle;
            textBox12.Enabled = toggle;
            textBox13.Enabled = toggle;
            textBox14.Enabled = toggle;
            textBox15.Enabled = toggle;
            textBox16.Enabled = toggle;
            textBox17.Enabled = toggle;
        }


        public void setColor(Color color)
        {
            textBox2.BackColor = color;
            textBox3.BackColor = color;
            textBox4.BackColor = color;
            textBox5.BackColor = color;
            dateTimePicker1.BackColor = color;
            textBox7.BackColor = color;
            textBox8.BackColor = color;
            textBox9.BackColor = color;
            textBox10.BackColor = color;
            textBox11.BackColor = color;
            textBox12.BackColor = color;
            textBox13.BackColor = color;
            textBox14.BackColor = color;
            textBox15.BackColor = color;
            textBox16.BackColor = color;
            textBox17.BackColor = color;
        }


        public void setTextBoxData()
        {
            try {
                System.Data.DataTable dtExcel = new System.Data.DataTable();
                dtExcel.TableName = "ExcelData";
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
                OleDbConnection con = new OleDbConnection(sourceConstr);
                string query = "select * from [au-500$] WHERE [Employer ID]='" + companyID + "';";
                OleDbDataAdapter data = new OleDbDataAdapter(query, con);
                data.Fill(dtExcel);
                con.Close();

                DataRow companyData = dtExcel.Rows[0];

                textBox1.Text = companyData["Employer ID"].ToString();
                textBox2.Text = companyData["Name of Firm"].ToString();
                textBox3.Text = companyData["Address"].ToString();
                textBox4.Text = companyData["Contact"].ToString();
                textBox5.Text = companyData["Email ID"].ToString();
                dateTimePicker1.Text = companyData["Date of Registration in PF ESI"].ToString();
                textBox7.Text = companyData["GST Number"].ToString();
                textBox8.Text = companyData["EPF Number"].ToString();
                textBox9.Text = companyData["EPFO Password"].ToString();
                textBox10.Text = companyData["ESI Number"].ToString();
                textBox11.Text = companyData["ESI Password"].ToString();
                textBox12.Text = companyData["Welfare Number"].ToString();
                textBox13.Text = companyData["Welfare Password"].ToString();
                textBox14.Text = companyData["ESI Registration Number"].ToString();
                textBox15.Text = companyData["Bank Name"].ToString();
                textBox16.Text = companyData["Bank Account Number"].ToString();
                textBox17.Text = companyData["IFSC"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            else if (textBox1.Text.ToString().Equals("") || textBox2.Text.ToString().Equals("") || textBox3.Text.ToString().Equals("") || textBox4.Text.ToString().Equals("") || textBox5.Text.ToString().Equals("") || dateTimePicker1.Text.ToString().Equals("") || textBox7.Text.ToString().Equals("") || textBox8.Text.ToString().Equals("") || textBox9.Text.ToString().Equals("") || textBox10.Text.ToString().Equals("") || textBox11.Text.ToString().Equals("") || textBox12.Text.ToString().Equals("") || textBox13.Text.ToString().Equals("") || textBox14.Text.ToString().Equals("") || textBox15.Text.ToString().Equals("") || textBox16.Text.ToString().Equals("") || textBox17.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                try
                {
                    using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                    {
                        cn.Open();

                        //validate worksheet name.
                        string worksheetName = getWorkSheet(cn);

                        String sql = "UPDATE [" + worksheetName + "] SET [Name of Firm]='" + textBox2.Text.ToString() +"', [Address]='" + textBox3.Text.ToString() +"', [Contact]='" + textBox4.Text.ToString() +"', [Email ID]='" + textBox5.Text.ToString() +"', [Date of Registration in PF ESI]='" + dateTimePicker1.Text.ToString() +"', [GST Number]='" + textBox7.Text.ToString() +"', [EPF Number]='" + textBox8.Text.ToString() +"', [EPFO Password]='" + textBox9.Text.ToString() +"', [ESI Number]='" + textBox10.Text.ToString() +"', [ESI Password]='" + textBox11.Text.ToString() +"', [Welfare Number]='" + textBox12.Text.ToString() +"', [Welfare Password]='" + textBox13.Text.ToString() +"', [ESI Registration Number]='" + textBox14.Text.ToString() +"', [Bank Name]='" + textBox15.Text.ToString() +"', [Bank Account Number]='" + textBox16.Text.ToString() +"', [IFSC]='" + textBox17.Text.ToString()+"' WHERE [Employer ID]='"+textBox1.Text.ToString()+"';";

                        Console.WriteLine("SQL :: "+sql);

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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }


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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment(companyID, "gst_number", "GST Attachment");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveAttachment(companyID, "esi_certificate", "ESI Certificate");
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
                saveAttachment(companyID, "pf_certificate", "PF Certificate");
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
                saveAttachment(companyID, "letter_head", "Letter Head");
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
                saveAttachment(companyID, "specimen_signature", "Specimen Signature");
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
                saveAttachment(companyID, "pan_card", "PAN Card");
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
                saveAttachment(companyID, "aadhaar_card", "Aadhaar Card");
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
                saveAttachment(companyID, "company_registration", "Company Registration");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



        public void saveAttachment(string companyId, string location, string attachmentName)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Company Attachments",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "PDF File(*pdf;)|*.pdf;",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = Path.Combine(@"C:\data\detail\company_attachments\", location + @"\" + companyId + "_" + location + ".pdf");
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                {
                    cn.Open();

                    //validate worksheet name.
                    string worksheetName = getWorkSheet(cn);

                    String sql = "UPDATE [" + worksheetName + "] SET ["+attachmentName+"]='" + filePath + "' WHERE [Employer ID]='"+companyId+"';";

                    Console.WriteLine("SQL :: " + sql);

                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                    cmd1.ExecuteNonQuery();
                    cn.Close();

                }

                File.Copy(openFileDialog.FileName, filePath, true);
                MessageBox.Show("Uploaded");
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string location = "select";
                switch (this.downloadAttachment)
                {
                    case "Aadhaar Card":
                        if (File.Exists(@"C:\data\detail\company_attachments\aadhaar_card\" + companyID + "_aadhaar_card.pdf"))
                            location = @"C:\data\detail\company_attachments\aadhaar_card\" + companyID + "_aadhaar_card.pdf";
                        else
                            location = "NA";
                        break;
                    case "Company Registration":
                        if (File.Exists(@"C:\data\detail\company_attachments\company_registration\" + companyID + "_company_registration.pdf"))
                            location = @"C:\data\detail\company_attachments\company_registration\" + companyID + "_company_registration.pdf";
                        else
                            location = "NA";
                        break;
                    case "ESI Certificate":
                        if (File.Exists(@"C:\data\detail\company_attachments\esi_certificate\" + companyID + "_esi_certificate.pdf"))
                            location = @"C:\data\detail\company_attachments\esi_certificate\" + companyID + "_esi_certificate.pdf";
                        else
                            location = "NA";
                        break;
                    case "GST Attachment":
                        if (File.Exists(@"C:\data\detail\company_attachments\gst_number\" + companyID + "_gst_number.pdf"))
                            location = @"C:\data\detail\company_attachments\gst_number\" + companyID + "_gst_number.pdf";
                        else
                            location = "NA";
                        break;
                    case "Letter Head":
                        if (File.Exists(@"C:\data\detail\company_attachments\letter_head\" + companyID + "_letter_head.pdf"))
                            location = @"C:\data\detail\company_attachments\letter_head\" + companyID + "_letter_head.pdf";
                        else
                            location = "NA";
                        break;
                    case "MSME Attachment":
                        if (File.Exists(@"C:\data\detail\company_attachments\msme_attachment\" + companyID + "_msme_attachment.pdf"))
                            location = @"C:\data\detail\company_attachments\msme_attachment\" + companyID + "_msme_attachment.pdf";
                        else
                            location = "NA";
                        break;
                    case "PAN Card":
                        if (File.Exists(@"C:\data\detail\company_attachments\pan_card\" + companyID + "_pan_card.pdf"))
                            location = @"C:\data\detail\company_attachments\pan_card\" + companyID + "_pan_card.pdf";
                        else
                            location = "NA";
                        break;
                    case "PF Certificate":
                        if (File.Exists(@"C:\data\detail\company_attachments\pf_certificate\" + companyID + "_pf_certificate.pdf"))
                        location = @"C:\data\detail\company_attachments\pf_certificate\" + companyID + "_pf_certificate.pdf";
                        else
                            location = "NA";
                        break;
                    case "Specimen Signature":
                        if (File.Exists(@"C:\data\detail\company_attachments\specimen_signature\" + companyID + "_specimen_signature.pdf"))
                            location = @"C:\data\detail\company_attachments\specimen_signature\" + companyID + "_specimen_signature.pdf";
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

            try
            {
                using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                {
                    cn.Open();

                    //validate worksheet name.
                    string worksheetName = getWorkSheet(cn);

                    String sql = "UPDATE [" + worksheetName + "] SET [Status]='Inactive' WHERE [Employer ID]='" + textBox1.Text.ToString() + "';";

                    Console.WriteLine("SQL :: " + sql);

                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                    cmd1.ExecuteNonQuery();
                    cn.Close();

                }

                MessageBox.Show("Services for this company are closed from now onwards.");
                DashBoard.homeControl1.loadData();
                DashBoard.declinedControl1.loadData();
                DashBoard.homeControl1.Visible = true;
                ((Form)this.TopLevelControl).Close();

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
                saveAttachment(companyID, "msme_attachment", "MSME");
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
    }
}
