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
    public partial class ActiveEmployeeControl : UserControl
    {
        public static string companyID = "";
        public static string employeeID = "";

        List<ListViewItem> masterlist;

        public ActiveEmployeeControl()
        {
            InitializeComponent();
            masterlist = new List<ListViewItem>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }



        public void loadData()
        {
            listView1.Clear();
            masterlist = new List<ListViewItem>();
            System.Data.DataTable dtExcel = new System.Data.DataTable();
            dtExcel.TableName = "ExcelData";
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\" + companyID + @"\" + companyID + "_employee.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0'";
            OleDbConnection con = new OleDbConnection(sourceConstr);
            string query = "select * from [employee_detail$]";
            OleDbDataAdapter data = new OleDbDataAdapter(query, con);
            data.Fill(dtExcel);
            con.Close();
            listView1.Columns.Add("Employee ID", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 500, HorizontalAlignment.Left);
            listView1.Columns.Add("Department", 400, HorizontalAlignment.Left);
            listView1.Columns.Add("Contact", 220, HorizontalAlignment.Left);

            listView1.Items.Clear();
            for (int i = 0; i < dtExcel.Rows.Count; i++)
            {
                DataRow dRow = dtExcel.Rows[i];
                if (dRow.RowState != DataRowState.Deleted && dRow["Status"].Equals("Active"))
                {
                    ListViewItem lvi = new ListViewItem(dRow["Employee ID"].ToString());
                    lvi.SubItems.Add(dRow["Name"].ToString());
                    lvi.SubItems.Add(dRow["Department"].ToString());
                    lvi.SubItems.Add(dRow["Employee Contact number"].ToString());
                    listView1.Items.Add(lvi);
                    masterlist.Add(lvi);
                }
            }

            listView1.Columns[listView1.Columns.Count - 1].Width = -2;
        }

        private void ActiveEmployeeControl_Load_1(object sender, EventArgs e)
        {
            companyID = HomeControl.companyID;
            loadData();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            // This filters and adds your filtered items to listView1
            foreach (ListViewItem item in masterlist.Where(lvi => lvi.Text.ToLower().Contains(textBox1.Text.ToLower().Trim())))
            {
                listView1.Items.Add(item);
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            //prevent flickering
            listView1.BeginUpdate();

            listView1.Items.Clear();

            string search = maskedTextBox1.Text;
            for (int i = 0; i < masterlist.Count; i++)
            {
                ListViewItem item = masterlist[i];
                if (ItemMatches(item, search))
                {
                    listView1.Items.Add(item);
                }
            }

            listView1.EndUpdate();
        }

        private bool ItemMatches(ListViewItem item, string text)
        {
            return item.SubItems[1].Text.ToLower().Contains(text.ToLower());
        }

        private void listView1_ItemActivate_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                employeeID = item.SubItems[0].Text;

                EmployeeDetail employeeDetail = new EmployeeDetail();
                employeeDetail.Show();
            }
        }

    }
}
