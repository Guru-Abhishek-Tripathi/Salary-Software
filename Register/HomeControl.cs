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
    public partial class HomeControl : UserControl
    {
        public static string firstName = "";
        public static string lastName = "";
        public static string companyName = "";

        public HomeControl()
        {
            InitializeComponent();
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            System.Data.DataTable dtExcel = new System.Data.DataTable();
            dtExcel.TableName = "ExcelData";
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\अजय़\source\repos\Register\Register\Resources\excel-spreadsheet-examples-for-students.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=1'";
            OleDbConnection con = new OleDbConnection(sourceConstr);
            string query = "select * from [au-500$]";
            OleDbDataAdapter data = new OleDbDataAdapter(query, con);
            data.Fill(dtExcel);
            listView1.Columns.Add("First Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Last Name", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Company Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Address", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("City", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("State", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Phone No", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", 250, HorizontalAlignment.Left);
            listView1.Columns.Add("Web", 300, HorizontalAlignment.Left);

            listView1.Items.Clear();
            for(int i = 0; i < dtExcel.Rows.Count; i++)
            {
                DataRow dRow = dtExcel.Rows[i];
                if(dRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dRow["First Name"].ToString());
                    lvi.SubItems.Add(dRow["Last Name"].ToString());
                    lvi.SubItems.Add(dRow["Company Name"].ToString());
                    lvi.SubItems.Add(dRow["Address"].ToString());
                    lvi.SubItems.Add(dRow["City"].ToString());
                    lvi.SubItems.Add(dRow["State"].ToString());
                    lvi.SubItems.Add(dRow["Phone No"].ToString());
                    lvi.SubItems.Add(dRow["Email"].ToString());
                    lvi.SubItems.Add(dRow["Web"].ToString());
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                firstName = item.SubItems[0].Text;
                lastName = item.SubItems[1].Text;
                companyName = item.SubItems[2].Text;

                CompanyDetail companyDetail = new CompanyDetail();
                companyDetail.Show();
            }
        }
    }
}
