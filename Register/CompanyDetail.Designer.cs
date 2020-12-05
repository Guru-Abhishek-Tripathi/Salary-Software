
namespace Register
{
    partial class CompanyDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.activeEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resignedEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.activeEmployeeControl1 = new Register.ActiveEmployeeControl();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.activeEmployeeControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 421);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // activeEmployeesToolStripMenuItem
            // 
            this.activeEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.activeEmployeesToolStripMenuItem.Name = "activeEmployeesToolStripMenuItem";
            this.activeEmployeesToolStripMenuItem.Size = new System.Drawing.Size(157, 25);
            this.activeEmployeesToolStripMenuItem.Text = "Active Employees";
            // 
            // resignedEmployeesToolStripMenuItem
            // 
            this.resignedEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.resignedEmployeesToolStripMenuItem.Name = "resignedEmployeesToolStripMenuItem";
            this.resignedEmployeesToolStripMenuItem.Size = new System.Drawing.Size(179, 25);
            this.resignedEmployeesToolStripMenuItem.Text = "Resigned Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleEmployeeToolStripMenuItem,
            this.listOfEmployeeToolStripMenuItem});
            this.addEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(133, 25);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // singleEmployeeToolStripMenuItem
            // 
            this.singleEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.singleEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.singleEmployeeToolStripMenuItem.Name = "singleEmployeeToolStripMenuItem";
            this.singleEmployeeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.singleEmployeeToolStripMenuItem.Text = "Single Employee";
            // 
            // listOfEmployeeToolStripMenuItem
            // 
            this.listOfEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.listOfEmployeeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.listOfEmployeeToolStripMenuItem.Name = "listOfEmployeeToolStripMenuItem";
            this.listOfEmployeeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.listOfEmployeeToolStripMenuItem.Text = "List Of Employee";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activeEmployeesToolStripMenuItem,
            this.resignedEmployeesToolStripMenuItem,
            this.addEmployeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // activeEmployeeControl1
            // 
            this.activeEmployeeControl1.BackColor = System.Drawing.Color.Transparent;
            this.activeEmployeeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeEmployeeControl1.ForeColor = System.Drawing.SystemColors.Window;
            this.activeEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            this.activeEmployeeControl1.Name = "activeEmployeeControl1";
            this.activeEmployeeControl1.Size = new System.Drawing.Size(800, 421);
            this.activeEmployeeControl1.TabIndex = 0;
            // 
            // CompanyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Register.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CompanyDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyDetail_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem activeEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resignedEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfEmployeeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ActiveEmployeeControl activeEmployeeControl1;
    }
}