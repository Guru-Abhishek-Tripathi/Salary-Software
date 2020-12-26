
namespace Register
{
    partial class DashBoard
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
            this.home_option = new System.Windows.Forms.ToolStripMenuItem();
            this.add_company_option = new System.Windows.Forms.ToolStripMenuItem();
            this.declined_option = new System.Windows.Forms.ToolStripMenuItem();
            this.logout_option = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel = new System.Windows.Forms.Panel();
            this.addCompanyControl1 = new Register.AddCompanyControl();
            declinedControl1 = new Register.DeclinedControl();
            homeControl1 = new Register.HomeControl();
            this.menuStrip1.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home_option,
            this.add_company_option,
            this.declined_option,
            this.logout_option});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // home_option
            // 
            this.home_option.ForeColor = System.Drawing.SystemColors.Window;
            this.home_option.Name = "home_option";
            this.home_option.Size = new System.Drawing.Size(70, 25);
            this.home_option.Text = "HOME";
            this.home_option.Click += new System.EventHandler(this.home_option_Click);
            // 
            // add_company_option
            // 
            this.add_company_option.ForeColor = System.Drawing.SystemColors.Window;
            this.add_company_option.Name = "add_company_option";
            this.add_company_option.Size = new System.Drawing.Size(141, 25);
            this.add_company_option.Text = "ADD COMPANY";
            this.add_company_option.Click += new System.EventHandler(this.add_company_option_Click);
            // 
            // declined_option
            // 
            this.declined_option.ForeColor = System.Drawing.SystemColors.Window;
            this.declined_option.Name = "declined_option";
            this.declined_option.Size = new System.Drawing.Size(100, 25);
            this.declined_option.Text = "DECLINED";
            this.declined_option.Click += new System.EventHandler(this.declined_option_Click);
            // 
            // logout_option
            // 
            this.logout_option.ForeColor = System.Drawing.SystemColors.Window;
            this.logout_option.Name = "logout_option";
            this.logout_option.Size = new System.Drawing.Size(86, 25);
            this.logout_option.Text = "LOGOUT";
            this.logout_option.Click += new System.EventHandler(this.logout_option_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.SystemColors.Window;
            this.main_panel.BackgroundImage = global::Register.Properties.Resources.background;
            this.main_panel.Controls.Add(this.addCompanyControl1);
            this.main_panel.Controls.Add(declinedControl1);
            this.main_panel.Controls.Add(homeControl1);
            this.main_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 29);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(800, 421);
            this.main_panel.TabIndex = 1;
            // 
            // addCompanyControl1
            // 
            this.addCompanyControl1.BackColor = System.Drawing.Color.Transparent;
            this.addCompanyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCompanyControl1.Location = new System.Drawing.Point(0, 0);
            this.addCompanyControl1.Name = "addCompanyControl1";
            this.addCompanyControl1.Size = new System.Drawing.Size(800, 421);
            this.addCompanyControl1.TabIndex = 0;
            // 
            // declinedControl1
            // 
            declinedControl1.BackColor = System.Drawing.Color.Transparent;
            declinedControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            declinedControl1.Location = new System.Drawing.Point(0, 0);
            declinedControl1.Name = "declinedControl1";
            declinedControl1.Size = new System.Drawing.Size(800, 421);
            declinedControl1.TabIndex = 1;
            // 
            // homeControl1
            // 
            homeControl1.BackColor = System.Drawing.Color.Transparent;
            homeControl1.Cursor = System.Windows.Forms.Cursors.Default;
            homeControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            homeControl1.Location = new System.Drawing.Point(0, 0);
            homeControl1.Name = "homeControl1";
            homeControl1.Size = new System.Drawing.Size(800, 421);
            homeControl1.TabIndex = 2;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem home_option;
        private System.Windows.Forms.ToolStripMenuItem add_company_option;
        private System.Windows.Forms.ToolStripMenuItem declined_option;
        private System.Windows.Forms.ToolStripMenuItem logout_option;
        private System.Windows.Forms.Panel main_panel;
        public static DeclinedControl declinedControl1;
        public static HomeControl homeControl1;
        private AddCompanyControl addCompanyControl1;
    }
}