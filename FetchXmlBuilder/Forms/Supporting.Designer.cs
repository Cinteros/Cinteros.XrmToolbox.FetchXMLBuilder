﻿namespace Rappen.XTB
{
    partial class Supporting
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supporting));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.rbCompany = new System.Windows.Forms.RadioButton();
            this.panCorp = new System.Windows.Forms.Panel();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblInvoiceemail = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtIFirst = new System.Windows.Forms.TextBox();
            this.txtILast = new System.Windows.Forms.TextBox();
            this.lblLater = new System.Windows.Forms.Label();
            this.lblAlready = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pics = new System.Windows.Forms.ImageList(this.components);
            this.rbPersonalContribute = new System.Windows.Forms.RadioButton();
            this.rbPersonalMonetary = new System.Windows.Forms.RadioButton();
            this.txtICountry = new System.Windows.Forms.TextBox();
            this.txtIEmail = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.laterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neverWillBeSupportingThisToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panPersonal = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblICountry = new System.Windows.Forms.Label();
            this.lblIEmail = new System.Windows.Forms.Label();
            this.lblIName = new System.Windows.Forms.Label();
            this.panInfo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInfoClose = new System.Windows.Forms.Button();
            this.helpLink = new System.Windows.Forms.LinkLabel();
            this.helpText = new System.Windows.Forms.TextBox();
            this.helpTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panCorp.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panPersonal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Berlin Sans FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Yellow;
            this.lblHeader.Location = new System.Drawing.Point(48, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(421, 38);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "[tool name]";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(16, 19);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(72, 18);
            this.lblCompany.TabIndex = 1;
            this.lblCompany.Text = "Company";
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtCompany.ForeColor = System.Drawing.Color.Yellow;
            this.txtCompany.Location = new System.Drawing.Point(148, 16);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(292, 25);
            this.txtCompany.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCompany, "Name of your company");
            this.txtCompany.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Supporting";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPersonal);
            this.panel1.Controls.Add(this.rbCompany);
            this.panel1.Location = new System.Drawing.Point(169, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 24);
            this.panel1.TabIndex = 1;
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.ForeColor = System.Drawing.Color.Tan;
            this.rbPersonal.Location = new System.Drawing.Point(145, 2);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(82, 22);
            this.rbPersonal.TabIndex = 1;
            this.rbPersonal.Text = "Personal";
            this.toolTip1.SetToolTip(this.rbPersonal, "My company may not understand this,\r\nbut I want to support it!");
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            this.rbPersonal.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.rbPersonal.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // rbCompany
            // 
            this.rbCompany.AutoSize = true;
            this.rbCompany.Checked = true;
            this.rbCompany.Location = new System.Drawing.Point(12, 2);
            this.rbCompany.Name = "rbCompany";
            this.rbCompany.Size = new System.Drawing.Size(92, 22);
            this.rbCompany.TabIndex = 0;
            this.rbCompany.TabStop = true;
            this.rbCompany.Text = "Corporate";
            this.toolTip1.SetToolTip(this.rbCompany, "Our company wants to support the developers,\r\nthe sharing, all improvement - just" +
        " doing more!");
            this.rbCompany.UseVisualStyleBackColor = true;
            this.rbCompany.CheckedChanged += new System.EventHandler(this.rbType_CheckedChanged);
            this.rbCompany.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.rbCompany.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // panCorp
            // 
            this.panCorp.Controls.Add(this.txtCountry);
            this.panCorp.Controls.Add(this.lblCountry);
            this.panCorp.Controls.Add(this.cmbSize);
            this.panCorp.Controls.Add(this.lblSize);
            this.panCorp.Controls.Add(this.txtEmail);
            this.panCorp.Controls.Add(this.lblInvoiceemail);
            this.panCorp.Controls.Add(this.lblCompany);
            this.panCorp.Controls.Add(this.txtCompany);
            this.panCorp.Location = new System.Drawing.Point(30, 132);
            this.panCorp.Name = "panCorp";
            this.panCorp.Size = new System.Drawing.Size(456, 148);
            this.panCorp.TabIndex = 2;
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtCountry.ForeColor = System.Drawing.Color.Yellow;
            this.txtCountry.Location = new System.Drawing.Point(148, 78);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(292, 25);
            this.txtCountry.TabIndex = 3;
            this.txtCountry.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(16, 81);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(59, 18);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSize.ForeColor = System.Drawing.Color.Yellow;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Items.AddRange(new object[] {
            "",
            "1",
            "2-10",
            "11-50",
            "51-100",
            "101+"});
            this.cmbSize.Location = new System.Drawing.Point(148, 109);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(292, 26);
            this.cmbSize.TabIndex = 4;
            this.cmbSize.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(16, 112);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(73, 18);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Tool Users";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtEmail.ForeColor = System.Drawing.Color.Yellow;
            this.txtEmail.Location = new System.Drawing.Point(148, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 25);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // lblInvoiceemail
            // 
            this.lblInvoiceemail.AutoSize = true;
            this.lblInvoiceemail.Location = new System.Drawing.Point(16, 50);
            this.lblInvoiceemail.Name = "lblInvoiceemail";
            this.lblInvoiceemail.Size = new System.Drawing.Size(45, 18);
            this.lblInvoiceemail.TabIndex = 3;
            this.lblInvoiceemail.Text = "Email";
            // 
            // txtIFirst
            // 
            this.txtIFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtIFirst.ForeColor = System.Drawing.Color.Yellow;
            this.txtIFirst.Location = new System.Drawing.Point(148, 16);
            this.txtIFirst.Name = "txtIFirst";
            this.txtIFirst.Size = new System.Drawing.Size(141, 25);
            this.txtIFirst.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtIFirst, "First Name");
            this.txtIFirst.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // txtILast
            // 
            this.txtILast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtILast.ForeColor = System.Drawing.Color.Yellow;
            this.txtILast.Location = new System.Drawing.Point(295, 16);
            this.txtILast.Name = "txtILast";
            this.txtILast.Size = new System.Drawing.Size(145, 25);
            this.txtILast.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtILast, "Last Name");
            this.txtILast.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // lblLater
            // 
            this.lblLater.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLater.AutoSize = true;
            this.lblLater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLater.ForeColor = System.Drawing.Color.Tan;
            this.lblLater.Location = new System.Drawing.Point(463, 379);
            this.lblLater.Name = "lblLater";
            this.lblLater.Size = new System.Drawing.Size(41, 18);
            this.lblLater.TabIndex = 101;
            this.lblLater.Text = "Close";
            this.lblLater.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lblLater, "Close this window.\r\nYou will get a new chance to support later!");
            this.lblLater.Click += new System.EventHandler(this.lblLater_Click);
            this.lblLater.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lblLater.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // lblAlready
            // 
            this.lblAlready.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlready.ForeColor = System.Drawing.Color.Tan;
            this.lblAlready.Location = new System.Drawing.Point(12, 333);
            this.lblAlready.Name = "lblAlready";
            this.lblAlready.Size = new System.Drawing.Size(160, 77);
            this.lblAlready.TabIndex = 102;
            this.lblAlready.Text = "I\'m already\r\nsupporting\r\n{tool}!";
            this.toolTip1.SetToolTip(this.lblAlready, "I have already supported in one way!");
            this.lblAlready.Visible = false;
            this.lblAlready.Click += new System.EventHandler(this.lblAlready_Click);
            this.lblAlready.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.lblAlready.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ImageIndex = 0;
            this.btnSubmit.ImageList = this.pics;
            this.btnSubmit.Location = new System.Drawing.Point(178, 330);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(8);
            this.btnSubmit.Size = new System.Drawing.Size(210, 68);
            this.btnSubmit.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnSubmit, "Click to forward you to the supporting form on JonasR.app.\r\nSubmitting will bring" +
        " the information here into the following step online.");
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pics
            // 
            this.pics.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("pics.ImageStream")));
            this.pics.TransparentColor = System.Drawing.Color.Transparent;
            this.pics.Images.SetKeyName(0, "Corporate Supports Tools 2 narrow 200.png");
            this.pics.Images.SetKeyName(1, "I Support Tools narrow 200.png");
            this.pics.Images.SetKeyName(2, "I Contribute Tools narrow 200.png");
            // 
            // rbPersonalContribute
            // 
            this.rbPersonalContribute.AutoSize = true;
            this.rbPersonalContribute.ForeColor = System.Drawing.Color.Tan;
            this.rbPersonalContribute.Location = new System.Drawing.Point(145, 2);
            this.rbPersonalContribute.Name = "rbPersonalContribute";
            this.rbPersonalContribute.Size = new System.Drawing.Size(105, 22);
            this.rbPersonalContribute.TabIndex = 1;
            this.rbPersonalContribute.Text = "Contribution";
            this.toolTip1.SetToolTip(this.rbPersonalContribute, "If you don\'t want to do any proper support, you can help Jonas\r\nwith development," +
        " fixing bugs, having new ideas, documentation, etc.");
            this.rbPersonalContribute.UseVisualStyleBackColor = true;
            this.rbPersonalContribute.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.rbPersonalContribute.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // rbPersonalMonetary
            // 
            this.rbPersonalMonetary.AutoSize = true;
            this.rbPersonalMonetary.Checked = true;
            this.rbPersonalMonetary.Location = new System.Drawing.Point(12, 2);
            this.rbPersonalMonetary.Name = "rbPersonalMonetary";
            this.rbPersonalMonetary.Size = new System.Drawing.Size(96, 22);
            this.rbPersonalMonetary.TabIndex = 0;
            this.rbPersonalMonetary.TabStop = true;
            this.rbPersonalMonetary.Text = "Supporting";
            this.toolTip1.SetToolTip(this.rbPersonalMonetary, "Sharing is Caring ❤️\r\nHere, you can pay it forward!");
            this.rbPersonalMonetary.UseVisualStyleBackColor = true;
            this.rbPersonalMonetary.CheckedChanged += new System.EventHandler(this.rbPersonalMonetary_CheckedChanged);
            this.rbPersonalMonetary.MouseEnter += new System.EventHandler(this.lbl_MouseEnter);
            this.rbPersonalMonetary.MouseLeave += new System.EventHandler(this.lbl_MouseLeave);
            // 
            // txtICountry
            // 
            this.txtICountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtICountry.ForeColor = System.Drawing.Color.Yellow;
            this.txtICountry.Location = new System.Drawing.Point(148, 78);
            this.txtICountry.Name = "txtICountry";
            this.txtICountry.Size = new System.Drawing.Size(292, 25);
            this.txtICountry.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtICountry, "Where are you from? Name or contry code.");
            this.txtICountry.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // txtIEmail
            // 
            this.txtIEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.txtIEmail.ForeColor = System.Drawing.Color.Yellow;
            this.txtIEmail.Location = new System.Drawing.Point(148, 47);
            this.txtIEmail.Name = "txtIEmail";
            this.txtIEmail.Size = new System.Drawing.Size(292, 25);
            this.txtIEmail.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtIEmail, "Email for any contact");
            this.txtIEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ctrl_Validating);
            // 
            // btnInfo
            // 
            this.btnInfo.ContextMenuStrip = this.contextMenuStrip1;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(12, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(30, 30);
            this.btnInfo.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnInfo, "Information about Why we should ");
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laterToolStripMenuItem,
            this.neverWillBeSupportingThisToolToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(250, 48);
            // 
            // laterToolStripMenuItem
            // 
            this.laterToolStripMenuItem.Name = "laterToolStripMenuItem";
            this.laterToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.laterToolStripMenuItem.Text = "Later";
            this.laterToolStripMenuItem.Click += new System.EventHandler(this.laterToolStripMenuItem_Click);
            // 
            // neverWillBeSupportingThisToolToolStripMenuItem
            // 
            this.neverWillBeSupportingThisToolToolStripMenuItem.Name = "neverWillBeSupportingThisToolToolStripMenuItem";
            this.neverWillBeSupportingThisToolToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.neverWillBeSupportingThisToolToolStripMenuItem.Text = "Never will be supporting this tool";
            this.neverWillBeSupportingThisToolToolStripMenuItem.Click += new System.EventHandler(this.neverWillBeSupportingThisToolToolStripMenuItem_Click);
            // 
            // panPersonal
            // 
            this.panPersonal.Controls.Add(this.panel3);
            this.panPersonal.Controls.Add(this.txtILast);
            this.panPersonal.Controls.Add(this.txtICountry);
            this.panPersonal.Controls.Add(this.lblICountry);
            this.panPersonal.Controls.Add(this.txtIEmail);
            this.panPersonal.Controls.Add(this.lblIEmail);
            this.panPersonal.Controls.Add(this.lblIName);
            this.panPersonal.Controls.Add(this.txtIFirst);
            this.panPersonal.Location = new System.Drawing.Point(30, 492);
            this.panPersonal.Name = "panPersonal";
            this.panPersonal.Size = new System.Drawing.Size(456, 148);
            this.panPersonal.TabIndex = 3;
            this.panPersonal.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbPersonalContribute);
            this.panel3.Controls.Add(this.rbPersonalMonetary);
            this.panel3.Location = new System.Drawing.Point(139, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 26);
            this.panel3.TabIndex = 8;
            // 
            // lblICountry
            // 
            this.lblICountry.AutoSize = true;
            this.lblICountry.Location = new System.Drawing.Point(16, 81);
            this.lblICountry.Name = "lblICountry";
            this.lblICountry.Size = new System.Drawing.Size(59, 18);
            this.lblICountry.TabIndex = 7;
            this.lblICountry.Text = "Country";
            // 
            // lblIEmail
            // 
            this.lblIEmail.AutoSize = true;
            this.lblIEmail.Location = new System.Drawing.Point(16, 50);
            this.lblIEmail.Name = "lblIEmail";
            this.lblIEmail.Size = new System.Drawing.Size(45, 18);
            this.lblIEmail.TabIndex = 3;
            this.lblIEmail.Text = "Email";
            // 
            // lblIName
            // 
            this.lblIName.AutoSize = true;
            this.lblIName.Location = new System.Drawing.Point(16, 19);
            this.lblIName.Name = "lblIName";
            this.lblIName.Size = new System.Drawing.Size(123, 18);
            this.lblIName.TabIndex = 1;
            this.lblIName.Text = "Name (first / last)";
            // 
            // panInfo
            // 
            this.panInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.panInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panInfo.Controls.Add(this.panel2);
            this.panInfo.Location = new System.Drawing.Point(30, 678);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(456, 390);
            this.panInfo.TabIndex = 11;
            this.panInfo.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(173)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInfoClose);
            this.panel2.Controls.Add(this.helpLink);
            this.panel2.Controls.Add(this.helpText);
            this.panel2.Controls.Add(this.helpTitle);
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 378);
            this.panel2.TabIndex = 0;
            // 
            // btnInfoClose
            // 
            this.btnInfoClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnInfoClose.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoClose.Image")));
            this.btnInfoClose.Location = new System.Drawing.Point(409, 3);
            this.btnInfoClose.Name = "btnInfoClose";
            this.btnInfoClose.Size = new System.Drawing.Size(30, 30);
            this.btnInfoClose.TabIndex = 13;
            this.btnInfoClose.UseVisualStyleBackColor = true;
            this.btnInfoClose.Click += new System.EventHandler(this.btnInfoClose_Click);
            // 
            // helpLink
            // 
            this.helpLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.helpLink.LinkColor = System.Drawing.Color.Yellow;
            this.helpLink.Location = new System.Drawing.Point(16, 348);
            this.helpLink.Name = "helpLink";
            this.helpLink.Size = new System.Drawing.Size(363, 18);
            this.helpLink.TabIndex = 2;
            this.helpLink.TabStop = true;
            this.helpLink.Tag = "https://jonasr.app/helping/";
            this.helpLink.Text = "https://jonasr.app/helping/";
            this.helpLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.helpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelping_LinkClicked);
            // 
            // helpText
            // 
            this.helpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(173)))));
            this.helpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpText.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpText.ForeColor = System.Drawing.Color.Yellow;
            this.helpText.Location = new System.Drawing.Point(16, 53);
            this.helpText.Multiline = true;
            this.helpText.Name = "helpText";
            this.helpText.ReadOnly = true;
            this.helpText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.helpText.Size = new System.Drawing.Size(410, 290);
            this.helpText.TabIndex = 1;
            this.helpText.Text = resources.GetString("helpText.Text");
            // 
            // helpTitle
            // 
            this.helpTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpTitle.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTitle.Location = new System.Drawing.Point(12, 10);
            this.helpTitle.Name = "helpTitle";
            this.helpTitle.Size = new System.Drawing.Size(430, 35);
            this.helpTitle.TabIndex = 0;
            this.helpTitle.Text = "How and Why do we support?";
            this.helpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 30);
            this.label1.TabIndex = 103;
            this.label1.Text = "Click the button below to proceed your support!\r\nNote: You have to submit it at t" +
    "he next step to finalize.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(48, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 38);
            this.label2.TabIndex = 104;
            this.label2.Text = "We Support";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Supporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(173)))));
            this.ClientSize = new System.Drawing.Size(516, 421);
            this.ControlBox = false;
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.panPersonal);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panCorp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblLater);
            this.Controls.Add(this.lblAlready);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Supporting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "We Support Tools";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Supporting_FormClosing);
            this.Shown += new System.EventHandler(this.Supporting_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panCorp.ResumeLayout(false);
            this.panCorp.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panPersonal.ResumeLayout(false);
            this.panPersonal.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.RadioButton rbCompany;
        private System.Windows.Forms.Panel panCorp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblInvoiceemail;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panPersonal;
        private System.Windows.Forms.TextBox txtILast;
        private System.Windows.Forms.TextBox txtICountry;
        private System.Windows.Forms.Label lblICountry;
        private System.Windows.Forms.TextBox txtIEmail;
        private System.Windows.Forms.Label lblIEmail;
        private System.Windows.Forms.Label lblIName;
        private System.Windows.Forms.TextBox txtIFirst;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel helpLink;
        private System.Windows.Forms.TextBox helpText;
        private System.Windows.Forms.Label helpTitle;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnInfoClose;
        private System.Windows.Forms.Label lblLater;
        private System.Windows.Forms.Label lblAlready;
        private System.Windows.Forms.ImageList pics;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbPersonalContribute;
        private System.Windows.Forms.RadioButton rbPersonalMonetary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neverWillBeSupportingThisToolToolStripMenuItem;
        private System.Windows.Forms.Label label2;
    }
}