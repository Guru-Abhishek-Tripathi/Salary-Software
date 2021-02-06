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
using Spire.Xls;

namespace Register
{
    public partial class DependentsControl : UserControl
    {
        string companyID = "";
        string employeeID = "";

        public DependentsControl()
        {
            InitializeComponent();
        }

        private void DependentsControl_Load(object sender, EventArgs e)
        {
            try
            {
                this.companyID = ActiveEmployeeControl.companyID;
                this.employeeID = ActiveEmployeeControl.employeeID;
                loadData();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDependent();
        }



        public void clearText()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Text = "";
        }

        public void loadData()
        {
            if (dataGridView1.Columns.Count > 4)
            {
                dataGridView1.Columns.RemoveAt(4);
                dataGridView1.Columns.RemoveAt(4);
            }
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            System.Data.DataTable dtExcel = new System.Data.DataTable();
            dtExcel.TableName = "ExcelData";
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_dependent.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
            OleDbConnection con = new OleDbConnection(sourceConstr);
            string query = "select * from [dependent_detail$] WHERE [Employee ID]='" + employeeID + "';";
            OleDbDataAdapter data = new OleDbDataAdapter(query, con);
            data.Fill(dtExcel);
            con.Close();

            string[] row;

            for (int i = 0; i < dtExcel.Rows.Count; i++)
            {
                DataRow dRow = dtExcel.Rows[i];
                row = new string[] { dRow["Dependent ID"].ToString(), dRow["Dependent Name"].ToString(), dRow["Relation"].ToString(), dRow["DOB"].ToString()  };
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 4)
                {
                    string selectedDependentID = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    textBox1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                    textBox2.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                    dateTimePicker1.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                    deleteDependent(selectedDependentID, false);
                }
                else if (e.ColumnIndex == 5)
                {
                    string selectedDependentID = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                    deleteDependent(selectedDependentID, true);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }

        }

        public void deleteDependent(string dependentId, bool flag)
        {
            try
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(@"C:\data\detail\" + companyID + @"\" + companyID + "_dependent.xls");

                Worksheet worksheet = workbook.Worksheets[0];

                long rowCount = worksheet.Rows.LongCount<CellRange>();
                long cellCount = worksheet.Columns.LongCount<CellRange>();

                Console.WriteLine("Row Count: " + rowCount);
                Console.WriteLine("Column Count: "+cellCount);

                for (var ri = 2; ri <= rowCount; ri++ )
                {
                    var val = worksheet.Range[ri, 2].Value;
                    if (val.Equals(dependentId))
                        worksheet.DeleteRow(ri);
                }
                workbook.Save();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.WriteLine(ex.ToString());
            }

            if(flag)
            MessageBox.Show("Dependent Deleted.");
            loadData();
        }


        public void addDependent()
        {
            if (textBox1.Text.ToString().Equals("") || textBox2.Text.ToString().Equals("") || dateTimePicker1.Text.ToString().Equals(""))
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_dependent.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";
                Console.WriteLine("Path: " + sourceConstr);
                try
                {
                    using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                    {
                        cn.Open();

                        string dependentID = (DateTime.Now).ToString("yyyyMMddHHmmssffff");

                        String sql = "INSERT INTO [dependent_detail$] ([Employee ID],[Dependent ID],[Dependent Name],[Relation],[DOB]) values('" + employeeID + "', '" + dependentID + "', '" + textBox1.Text.ToString() + "', '" + textBox2.Text.ToString() + "', '" + dateTimePicker1.Text.ToString() + "');";

                        Console.WriteLine("SQL :: " + sql);

                        OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();

                    }

                    clearText();
                    MessageBox.Show("Submitted Successfully.");
                    loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}
