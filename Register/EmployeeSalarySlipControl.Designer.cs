
namespace Register
{
    partial class EmployeeSalarySlipControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.paySlipHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtESINumber = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtModeOfPay = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPANNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBankAccountNumber = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDateOfJoining = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPresentDays = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPFNumber = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemployeeID = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemployeeName = new System.Windows.Forms.TextBox();
            this.txtTotalDaysInMonth = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTDS = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAllowance = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAdvance = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtConveyance = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtWelfare = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHRA = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtArear = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEPF = new System.Windows.Forms.TextBox();
            this.txtESI = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1007, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee Salary Slip";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DimGray;
            this.dateTimePicker1.CustomFormat = "MMMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 26);
            this.dateTimePicker1.TabIndex = 26;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(280, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 30;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(390, 101);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 26);
            this.button2.TabIndex = 31;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paySlipHeader
            // 
            this.paySlipHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paySlipHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paySlipHeader.ForeColor = System.Drawing.SystemColors.Window;
            this.paySlipHeader.Location = new System.Drawing.Point(0, 190);
            this.paySlipHeader.Name = "paySlipHeader";
            this.paySlipHeader.Size = new System.Drawing.Size(1007, 30);
            this.paySlipHeader.TabIndex = 32;
            this.paySlipHeader.Text = "Pay Slip for  the month of ";
            this.paySlipHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.txtESINumber, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtModeOfPay, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPANNumber, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtBankAccountNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtDateOfJoining, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalPresentDays, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPFNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtemployeeID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtemployeeName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalDaysInMonth, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(40, 230);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(878, 150);
            this.tableLayoutPanel1.TabIndex = 33;
            // 
            // txtESINumber
            // 
            this.txtESINumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtESINumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESINumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtESINumber.Location = new System.Drawing.Point(616, 123);
            this.txtESINumber.Name = "txtESINumber";
            this.txtESINumber.ReadOnly = true;
            this.txtESINumber.Size = new System.Drawing.Size(259, 22);
            this.txtESINumber.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(441, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 30);
            this.label12.TabIndex = 18;
            this.label12.Text = "ESI Number";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtModeOfPay
            // 
            this.txtModeOfPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtModeOfPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModeOfPay.ForeColor = System.Drawing.Color.DimGray;
            this.txtModeOfPay.Location = new System.Drawing.Point(178, 123);
            this.txtModeOfPay.Name = "txtModeOfPay";
            this.txtModeOfPay.ReadOnly = true;
            this.txtModeOfPay.Size = new System.Drawing.Size(257, 22);
            this.txtModeOfPay.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(3, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(169, 30);
            this.label11.TabIndex = 16;
            this.label11.Text = "Mode of Pay";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPANNumber
            // 
            this.txtPANNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPANNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPANNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtPANNumber.Location = new System.Drawing.Point(616, 93);
            this.txtPANNumber.Name = "txtPANNumber";
            this.txtPANNumber.ReadOnly = true;
            this.txtPANNumber.Size = new System.Drawing.Size(259, 22);
            this.txtPANNumber.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(441, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 30);
            this.label10.TabIndex = 14;
            this.label10.Text = "PAN Number";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBankAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankAccountNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtBankAccountNumber.Location = new System.Drawing.Point(178, 93);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.ReadOnly = true;
            this.txtBankAccountNumber.Size = new System.Drawing.Size(257, 22);
            this.txtBankAccountNumber.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(3, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 30);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bank Account Number";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDateOfJoining
            // 
            this.txtDateOfJoining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDateOfJoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOfJoining.ForeColor = System.Drawing.Color.DimGray;
            this.txtDateOfJoining.Location = new System.Drawing.Point(616, 63);
            this.txtDateOfJoining.Name = "txtDateOfJoining";
            this.txtDateOfJoining.ReadOnly = true;
            this.txtDateOfJoining.Size = new System.Drawing.Size(259, 22);
            this.txtDateOfJoining.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(441, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = "Date of Joining";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalPresentDays
            // 
            this.txtTotalPresentDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalPresentDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPresentDays.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotalPresentDays.Location = new System.Drawing.Point(178, 63);
            this.txtTotalPresentDays.Name = "txtTotalPresentDays";
            this.txtTotalPresentDays.ReadOnly = true;
            this.txtTotalPresentDays.Size = new System.Drawing.Size(257, 22);
            this.txtTotalPresentDays.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(3, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Present Days";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPFNumber
            // 
            this.txtPFNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPFNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPFNumber.ForeColor = System.Drawing.Color.DimGray;
            this.txtPFNumber.Location = new System.Drawing.Point(178, 33);
            this.txtPFNumber.Name = "txtPFNumber";
            this.txtPFNumber.ReadOnly = true;
            this.txtPFNumber.Size = new System.Drawing.Size(257, 22);
            this.txtPFNumber.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "PF Number";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtemployeeID
            // 
            this.txtemployeeID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtemployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtemployeeID.Location = new System.Drawing.Point(178, 3);
            this.txtemployeeID.Name = "txtemployeeID";
            this.txtemployeeID.ReadOnly = true;
            this.txtemployeeID.Size = new System.Drawing.Size(257, 22);
            this.txtemployeeID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee ID ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtemployeeName
            // 
            this.txtemployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtemployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemployeeName.ForeColor = System.Drawing.Color.DimGray;
            this.txtemployeeName.Location = new System.Drawing.Point(616, 3);
            this.txtemployeeName.Name = "txtemployeeName";
            this.txtemployeeName.ReadOnly = true;
            this.txtemployeeName.Size = new System.Drawing.Size(259, 22);
            this.txtemployeeName.TabIndex = 0;
            // 
            // txtTotalDaysInMonth
            // 
            this.txtTotalDaysInMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDaysInMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDaysInMonth.ForeColor = System.Drawing.Color.DimGray;
            this.txtTotalDaysInMonth.Location = new System.Drawing.Point(616, 33);
            this.txtTotalDaysInMonth.Name = "txtTotalDaysInMonth";
            this.txtTotalDaysInMonth.ReadOnly = true;
            this.txtTotalDaysInMonth.Size = new System.Drawing.Size(259, 22);
            this.txtTotalDaysInMonth.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(441, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(441, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Days in Month";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.txtTDS, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtAllowance, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtAdvance, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtConveyance, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtWelfare, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label17, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtHRA, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtArear, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtBasicSalary, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtEPF, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtESI, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label21, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label22, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(40, 415);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 150);
            this.tableLayoutPanel2.TabIndex = 34;
            // 
            // txtTDS
            // 
            this.txtTDS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDS.ForeColor = System.Drawing.Color.DimGray;
            this.txtTDS.Location = new System.Drawing.Point(616, 123);
            this.txtTDS.Name = "txtTDS";
            this.txtTDS.ReadOnly = true;
            this.txtTDS.Size = new System.Drawing.Size(259, 22);
            this.txtTDS.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(441, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 30);
            this.label13.TabIndex = 18;
            this.label13.Text = "T.D.S.";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAllowance
            // 
            this.txtAllowance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllowance.ForeColor = System.Drawing.Color.DimGray;
            this.txtAllowance.Location = new System.Drawing.Point(178, 123);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.ReadOnly = true;
            this.txtAllowance.Size = new System.Drawing.Size(257, 22);
            this.txtAllowance.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Window;
            this.label14.Location = new System.Drawing.Point(3, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 30);
            this.label14.TabIndex = 16;
            this.label14.Text = "Allowance";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdvance
            // 
            this.txtAdvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdvance.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdvance.Location = new System.Drawing.Point(616, 93);
            this.txtAdvance.Name = "txtAdvance";
            this.txtAdvance.ReadOnly = true;
            this.txtAdvance.Size = new System.Drawing.Size(259, 22);
            this.txtAdvance.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Window;
            this.label15.Location = new System.Drawing.Point(441, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 30);
            this.label15.TabIndex = 14;
            this.label15.Text = "Advance";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConveyance
            // 
            this.txtConveyance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConveyance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConveyance.ForeColor = System.Drawing.Color.DimGray;
            this.txtConveyance.Location = new System.Drawing.Point(178, 93);
            this.txtConveyance.Name = "txtConveyance";
            this.txtConveyance.ReadOnly = true;
            this.txtConveyance.Size = new System.Drawing.Size(257, 22);
            this.txtConveyance.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Window;
            this.label16.Location = new System.Drawing.Point(3, 90);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 30);
            this.label16.TabIndex = 12;
            this.label16.Text = "Conveyance";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWelfare
            // 
            this.txtWelfare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWelfare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWelfare.ForeColor = System.Drawing.Color.DimGray;
            this.txtWelfare.Location = new System.Drawing.Point(616, 63);
            this.txtWelfare.Name = "txtWelfare";
            this.txtWelfare.ReadOnly = true;
            this.txtWelfare.Size = new System.Drawing.Size(259, 22);
            this.txtWelfare.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Window;
            this.label17.Location = new System.Drawing.Point(441, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(169, 30);
            this.label17.TabIndex = 10;
            this.label17.Text = "Welfare";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHRA
            // 
            this.txtHRA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHRA.ForeColor = System.Drawing.Color.DimGray;
            this.txtHRA.Location = new System.Drawing.Point(178, 63);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.ReadOnly = true;
            this.txtHRA.Size = new System.Drawing.Size(257, 22);
            this.txtHRA.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(3, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(169, 30);
            this.label18.TabIndex = 8;
            this.label18.Text = "H.R.A.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArear
            // 
            this.txtArear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArear.ForeColor = System.Drawing.Color.DimGray;
            this.txtArear.Location = new System.Drawing.Point(178, 33);
            this.txtArear.Name = "txtArear";
            this.txtArear.ReadOnly = true;
            this.txtArear.Size = new System.Drawing.Size(257, 22);
            this.txtArear.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(3, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(169, 30);
            this.label19.TabIndex = 6;
            this.label19.Text = "Arear";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.ForeColor = System.Drawing.Color.DimGray;
            this.txtBasicSalary.Location = new System.Drawing.Point(178, 3);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.ReadOnly = true;
            this.txtBasicSalary.Size = new System.Drawing.Size(257, 22);
            this.txtBasicSalary.TabIndex = 5;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.Window;
            this.label20.Location = new System.Drawing.Point(3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 30);
            this.label20.TabIndex = 4;
            this.label20.Text = "Basic Salary";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEPF
            // 
            this.txtEPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEPF.ForeColor = System.Drawing.Color.DimGray;
            this.txtEPF.Location = new System.Drawing.Point(616, 3);
            this.txtEPF.Name = "txtEPF";
            this.txtEPF.ReadOnly = true;
            this.txtEPF.Size = new System.Drawing.Size(259, 22);
            this.txtEPF.TabIndex = 0;
            // 
            // txtESI
            // 
            this.txtESI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtESI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtESI.ForeColor = System.Drawing.Color.DimGray;
            this.txtESI.Location = new System.Drawing.Point(616, 33);
            this.txtESI.Name = "txtESI";
            this.txtESI.ReadOnly = true;
            this.txtESI.Size = new System.Drawing.Size(259, 22);
            this.txtESI.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.Window;
            this.label21.Location = new System.Drawing.Point(441, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(169, 30);
            this.label21.TabIndex = 2;
            this.label21.Text = "E.P.F.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Window;
            this.label22.Location = new System.Drawing.Point(441, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(169, 30);
            this.label22.TabIndex = 3;
            this.label22.Text = "E.S.I.";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EmployeeSalarySlipControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.paySlipHeader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "EmployeeSalarySlipControl";
            this.Size = new System.Drawing.Size(956, 565);
            this.Load += new System.EventHandler(this.EmployeeSalarySlipControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label paySlipHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtemployeeName;
        private System.Windows.Forms.MaskedTextBox txtTotalDaysInMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTotalPresentDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtPFNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtemployeeID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtESINumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtModeOfPay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtPANNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtBankAccountNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtDateOfJoining;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox txtTDS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtAllowance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtAdvance;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtConveyance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox txtWelfare;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtHRA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MaskedTextBox txtArear;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox txtBasicSalary;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtEPF;
        private System.Windows.Forms.MaskedTextBox txtESI;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}
