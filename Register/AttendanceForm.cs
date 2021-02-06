using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace Register
{
    public partial class AttendanceForm : Form
    {
        string receiptID = "";
        string companyID = "";
        ArrayList dataList ;
        public AttendanceForm( string companyid, ArrayList arrayList)
        {
            InitializeComponent();
            this.companyID = companyid;
            this.receiptID = (string)arrayList[0];
            this.dataList = arrayList;
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            setTextBoxs(this.dataList);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            string fileName = DateTime.Now.ToString("yyyy");
            string path = @"C:\data\detail\" + companyID + @"\" + companyID + @"_attendance\" + companyID + "_" + fileName + ".xls";

            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + path + "';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

            try
            {
                using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                {
                    cn.Open();

                    String sql = "UPDATE [attendance$] SET [RECEIPT ID]='" + textBox1.Text.ToString() + "', [EMPLOYEE ID]='" + textBox2.Text.ToString() + "', [EMPLOYEE NAME]='" + textBox3.Text.ToString() + "', [FATHER'S/HUSBAND'S NAME]='" + textBox4.Text.ToString() + "', [GROSS WAGES]='" + textBox5.Text.ToString() + "', [BASIC]='" + textBox6.Text.ToString() + "', [TOTAL DAYS IN MONTH]='" + textBox7.Text.ToString() + "', [TOTAL PRESENT DAY]='" + textBox8.Text.ToString() + "', [BASIC SALARY]='" + textBox9.Text.ToString() + "', [HRA]='" + textBox10.Text.ToString() + "', [CONVEYANCE]='" + textBox11.Text.ToString() + "', [OVER TIME]='" + textBox12.Text.ToString() + "', [INCENTIVE]='" + textBox13.Text.ToString() + "', [EARNED GROSS SALARY]='" + textBox14.Text.ToString() + "', [EMPLOYEE PF]='" + textBox15.Text.ToString() + "', [PMPRY/ABRY BENEFITS]='" + textBox16.Text.ToString() + "',[EMPLOYEE ESIC]='" + textBox17.Text.ToString() + "',[WELFARE]='" + textBox18.Text.ToString() + "',[TDS]='" + textBox19.Text.ToString() + "',[ADVANCE]='" + textBox20.Text.ToString() + "',[OTHER DEDUCTION]='" + textBox21.Text.ToString() + "',[TOTAL DEDUCTION]='" + textBox22.Text.ToString() + "',[NET SALARY]='" + textBox23.Text.ToString() + "',[EMPLOYER PF]='" + textBox24.Text.ToString() + "',[EMPLOYER ESIC]='" + textBox25.Text.ToString() + "',[EMPLOYER WELFARE]='" + textBox26.Text.ToString() + "',[CTC]='" + textBox27.Text.ToString() + "' WHERE [RECEIPT ID]='" + textBox1.Text.ToString() + "';";

                    Console.WriteLine("SQL :: " + sql);

                    OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                    cmd1.ExecuteNonQuery();
                    cn.Close();

                }

                MessageBox.Show("Deatils Updated.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.Close();
        }

        public void setTextBoxs(ArrayList array)
        {
            textBox1.Text = (string)array[0];
            textBox2.Text = (string)array[1];
            textBox3.Text = (string)array[2];
            textBox4.Text = (string)array[3];
            textBox5.Text = (string)array[4];
            textBox6.Text = (string)array[5];
            textBox7.Text = (string)array[6];
            textBox8.Text = (string)array[7];
            textBox9.Text = (string)array[8];
            textBox10.Text = (string)array[9];
            textBox11.Text = (string)array[10];
            textBox12.Text = (string)array[11];
            textBox13.Text = (string)array[12];
            textBox14.Text = (string)array[13];
            textBox15.Text = (string)array[14];
            textBox16.Text = (string)array[15];
            textBox17.Text = (string)array[16];
            textBox18.Text = (string)array[17];
            textBox19.Text = (string)array[18];
            textBox20.Text = (string)array[19];
            textBox21.Text = (string)array[20];
            textBox22.Text = (string)array[21];
            textBox23.Text = (string)array[22];
            textBox24.Text = (string)array[23];
            textBox25.Text = (string)array[24];
            textBox26.Text = (string)array[25];
            textBox27.Text = (string)array[26];

        }




    }
}
