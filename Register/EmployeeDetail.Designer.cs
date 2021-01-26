
namespace Register
{
    partial class EmployeeDetail
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dependentsControl1 = new Register.DependentsControl();
            this.employeeDetailControl1 = new Register.EmployeeDetailControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeDetailToolStripMenuItem,
            this.dependentsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeDetailToolStripMenuItem
            // 
            this.employeeDetailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.employeeDetailToolStripMenuItem.Name = "employeeDetailToolStripMenuItem";
            this.employeeDetailToolStripMenuItem.Size = new System.Drawing.Size(148, 25);
            this.employeeDetailToolStripMenuItem.Text = "Employee Detail";
            this.employeeDetailToolStripMenuItem.Click += new System.EventHandler(this.employeeDetailToolStripMenuItem_Click);
            // 
            // dependentsToolStripMenuItem1
            // 
            this.dependentsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.dependentsToolStripMenuItem1.Name = "dependentsToolStripMenuItem1";
            this.dependentsToolStripMenuItem1.Size = new System.Drawing.Size(114, 25);
            this.dependentsToolStripMenuItem1.Text = "Dependents";
            this.dependentsToolStripMenuItem1.Click += new System.EventHandler(this.dependentsToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dependentsControl1);
            this.panel1.Controls.Add(this.employeeDetailControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 421);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // dependentsControl1
            // 
            this.dependentsControl1.AutoScroll = true;
            this.dependentsControl1.AutoSize = true;
            this.dependentsControl1.BackColor = System.Drawing.Color.Transparent;
            this.dependentsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dependentsControl1.ForeColor = System.Drawing.SystemColors.Window;
            this.dependentsControl1.Location = new System.Drawing.Point(0, 0);
            this.dependentsControl1.Name = "dependentsControl1";
            this.dependentsControl1.Size = new System.Drawing.Size(800, 421);
            this.dependentsControl1.TabIndex = 1;
            // 
            // employeeDetailControl1
            // 
            this.employeeDetailControl1.AutoScroll = true;
            this.employeeDetailControl1.AutoSize = true;
            this.employeeDetailControl1.BackColor = System.Drawing.Color.Transparent;
            this.employeeDetailControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeDetailControl1.Location = new System.Drawing.Point(0, 0);
            this.employeeDetailControl1.Name = "employeeDetailControl1";
            this.employeeDetailControl1.Size = new System.Drawing.Size(800, 421);
            this.employeeDetailControl1.TabIndex = 0;
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Register.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "EmployeeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeDetailToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private EmployeeDetailControl employeeDetailControl1;
        private System.Windows.Forms.ToolStripMenuItem dependentsToolStripMenuItem1;
        private DependentsControl dependentsControl1;
    }
}