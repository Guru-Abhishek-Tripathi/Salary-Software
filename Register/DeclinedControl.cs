﻿using System;
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
    public partial class DeclinedControl : UserControl
    {

        List<ListViewItem> masterlist;

        public DeclinedControl()
        {
            InitializeComponent();
            masterlist = new List<ListViewItem>();
        }

        private void DeclinedControl_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=1'";
            OleDbConnection con = new OleDbConnection(sourceConstr);
            string query = "select * from [au-500$]";
            OleDbDataAdapter data = new OleDbDataAdapter(query, con);
            data.Fill(dtExcel);
            listView1.Columns.Add("Company ID", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Company Name", 500, HorizontalAlignment.Left);
            listView1.Columns.Add("Email", 400, HorizontalAlignment.Left);
            listView1.Columns.Add("Contact", 220, HorizontalAlignment.Left);

            listView1.Items.Clear();
            for (int i = 0; i < dtExcel.Rows.Count; i++)
            {
                DataRow dRow = dtExcel.Rows[i];
                if (dRow.RowState != DataRowState.Deleted && dRow["Status"].Equals("Inactive"))
                {
                    ListViewItem lvi = new ListViewItem(dRow["Employer ID"].ToString());
                    lvi.SubItems.Add(dRow["Name of Firm"].ToString());
                    lvi.SubItems.Add(dRow["Email ID"].ToString());
                    lvi.SubItems.Add(dRow["Contact"].ToString());
                    listView1.Items.Add(lvi);
                    masterlist.Add(lvi);
                }
            }

            listView1.Columns[listView1.Columns.Count - 1].Width = -2;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                string companyID = item.SubItems[0].Text;

                string sourceConstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\data\detail\company.xls';Extended Properties='excel 8.0;HDR=Yes;IMEX=0;READONLY=FALSE'";

                try
                {
                    using (OleDbConnection cn = new OleDbConnection(sourceConstr))
                    {
                        cn.Open();

                        //validate worksheet name.
                        string worksheetName = "au-500$";

                        String sql = "UPDATE [" + worksheetName + "] SET [Status]='Active' WHERE [Employer ID]='" + companyID + "';";

                        Console.WriteLine("SQL :: " + sql);

                        OleDbCommand cmd1 = new OleDbCommand(sql, cn);
                        cmd1.ExecuteNonQuery();
                        cn.Close();

                    }

                    loadData();
                    MessageBox.Show("Services for company ID: "+companyID+" are resumed.");
                    DashBoard.homeControl1.loadData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }



    }
}
