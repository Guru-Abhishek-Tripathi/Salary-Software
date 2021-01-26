
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
            activeEmployeeControl1 = new Register.ActiveEmployeeControl();
            this.companyDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activeEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resignedEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.singleEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            companyDetailControl1 = new Register.companyDetailControl();
            resignedEmployeesControl1 = new Register.ResignedEmployeesControl();
            addSingleEmployeeControl1 = new Register.AddSingleEmployeeControl();
            attendanceControl1 = new Register.AttendanceControl();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(attendanceControl1);
            this.panel1.Controls.Add(addSingleEmployeeControl1);
            this.panel1.Controls.Add(resignedEmployeesControl1);
            this.panel1.Controls.Add(companyDetailControl1);
            this.panel1.Controls.Add(activeEmployeeControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 421);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // activeEmployeeControl1
            // 
            activeEmployeeControl1.BackColor = System.Drawing.Color.Transparent;
            activeEmployeeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            activeEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            activeEmployeeControl1.Name = "activeEmployeeControl1";
            activeEmployeeControl1.Size = new System.Drawing.Size(800, 421);
            .activeEmployeeControl1.TabIndex = 0;
            // 
            // companyDetailToolStripMenuItem
            // 
            this.companyDetailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.companyDetailToolStripMenuItem.Name = "companyDetailToolStripMenuItem";
            this.companyDetailToolStripMenuItem.Size = new System.Drawing.Size(145, 25);
            this.companyDetailToolStripMenuItem.Text = "Comapny Detail";
            this.companyDetailToolStripMenuItem.Click += new System.EventHandler(this.companyDetailToolStripMenuItem_Click);
            // 
            // activeEmployeesToolStripMenuItem
            // 
            this.activeEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.activeEmployeesToolStripMenuItem.Name = "activeEmployeesToolStripMenuItem";
            this.activeEmployeesToolStripMenuItem.Size = new System.Drawing.Size(157, 25);
            this.activeEmployeesToolStripMenuItem.Text = "Active Employees";
            this.activeEmployeesToolStripMenuItem.Click += new System.EventHandler(this.activeEmployeesToolStripMenuItem_Click);
            // 
            // resignedEmployeesToolStripMenuItem
            // 
            this.resignedEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.resignedEmployeesToolStripMenuItem.Name = "resignedEmployeesToolStripMenuItem";
            this.resignedEmployeesToolStripMenuItem.Size = new System.Drawing.Size(179, 25);
            this.resignedEmployeesToolStripMenuItem.Text = "Resigned Employees";
            this.resignedEmployeesToolStripMenuItem.Click += new System.EventHandler(this.resignedEmployeesToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDetailToolStripMenuItem,
            this.activeEmployeesToolStripMenuItem,
            this.resignedEmployeesToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addAttendanceToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleEmployeeToolStripMenuItem,
            this.listEmployeeToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 25);
            this.toolStripMenuItem1.Text = "Add Employees";
            // 
            // singleEmployeeToolStripMenuItem
            // 
            this.singleEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.singleEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.singleEmployeeToolStripMenuItem.Name = "singleEmployeeToolStripMenuItem";
            this.singleEmployeeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.singleEmployeeToolStripMenuItem.Text = "Single Employee";
            this.singleEmployeeToolStripMenuItem.Click += new System.EventHandler(this.singleEmployeeToolStripMenuItem_Click_1);
            // 
            // listEmployeeToolStripMenuItem
            // 
            this.listEmployeeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.listEmployeeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.listEmployeeToolStripMenuItem.Name = "listEmployeeToolStripMenuItem";
            this.listEmployeeToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.listEmployeeToolStripMenuItem.Text = "List Employee";
            this.listEmployeeToolStripMenuItem.Click += new System.EventHandler(this.listEmployeeToolStripMenuItem_Click_1);
            // 
            // addAttendanceToolStripMenuItem
            // 
            this.addAttendanceToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.addAttendanceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addAttendanceToolStripMenuItem.Name = "addAttendanceToolStripMenuItem";
            this.addAttendanceToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.addAttendanceToolStripMenuItem.Text = "Attendance";
            this.addAttendanceToolStripMenuItem.Click += new System.EventHandler(this.addAttendanceToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(110, 25);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // companyDetailControl2
            // 
            companyDetailControl1.AutoScroll = true;
            companyDetailControl1.AutoSize = true;
            companyDetailControl1.BackColor = System.Drawing.Color.Transparent;
            companyDetailControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            companyDetailControl1.Location = new System.Drawing.Point(0, 0);
            companyDetailControl1.Name = "companyDetailControl2";
            companyDetailControl1.Size = new System.Drawing.Size(800, 421);
            companyDetailControl1.TabIndex = 1;
            // 
            // resignedEmployeesControl2
            // 
            resignedEmployeesControl1.AutoScroll = true;
            resignedEmployeesControl1.AutoSize = true;
            resignedEmployeesControl1.BackColor = System.Drawing.Color.Transparent;
            resignedEmployeesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            resignedEmployeesControl1.Location = new System.Drawing.Point(0, 0);
            resignedEmployeesControl1.Name = "resignedEmployeesControl2";
            resignedEmployeesControl1.Size = new System.Drawing.Size(800, 421);
            resignedEmployeesControl1.TabIndex = 2;
            // 
            // addSingleEmployeeControl2
            // 
            addSingleEmployeeControl1.BackColor = System.Drawing.Color.Transparent;
            addSingleEmployeeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            addSingleEmployeeControl1.ForeColor = System.Drawing.SystemColors.Window;
            addSingleEmployeeControl1.Location = new System.Drawing.Point(0, 0);
            addSingleEmployeeControl1.Name = "addSingleEmployeeControl2";
            addSingleEmployeeControl1.Size = new System.Drawing.Size(800, 421);
            addSingleEmployeeControl1.TabIndex = 3;
            // 
            // attendanceControl2
            // 
            attendanceControl1.AutoScroll = true;
            attendanceControl1.AutoSize = true;
            attendanceControl1.BackColor = System.Drawing.Color.Transparent;
            attendanceControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            attendanceControl1.ForeColor = System.Drawing.SystemColors.Window;
            attendanceControl1.Location = new System.Drawing.Point(0, 0);
            attendanceControl1.Name = "attendanceControl2";
            attendanceControl1.Size = new System.Drawing.Size(800, 421);
            attendanceControl1.TabIndex = 4;
            // 
            // CompanyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
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
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem companyDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activeEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resignedEmployeesToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addAttendanceToolStripMenuItem;
        private static companyDetailControl companyDetailControl1;
        private static AddSingleEmployeeControl addSingleEmployeeControl1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem singleEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmployeeToolStripMenuItem;
        public static AttendanceControl attendanceControl1;
        public static ResignedEmployeesControl resignedEmployeesControl1;
        public static ActiveEmployeeControl activeEmployeeControl1;
    }
}