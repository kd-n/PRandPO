namespace BAG_PRandPO_UI.Purchase_Order
{
    partial class frmOrderDetails
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
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receivingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetails2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackPO = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblPO = new System.Windows.Forms.Label();
            this.lblPR = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblBAGRef = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtPO = new System.Windows.Forms.TextBox();
            this.txtPR = new System.Windows.Forms.TextBox();
            this.txtBAGRef = new System.Windows.Forms.TextBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccept = new System.Windows.Forms.Button();
            this.rdServed = new System.Windows.Forms.RadioButton();
            this.rdPrinted = new System.Windows.Forms.RadioButton();
            this.chkReset = new System.Windows.Forms.CheckBox();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.menuStrip1);
            this.grpMenu.Controls.Add(this.menuStrip2);
            this.grpMenu.Location = new System.Drawing.Point(18, 62);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(825, 40);
            this.grpMenu.TabIndex = 48;
            this.grpMenu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(635, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(168, 24);
            this.menuStrip1.TabIndex = 8;
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.receivingToolStripMenuItem,
            this.registerUserToolStripMenuItem});
            this.newRequestToolStripMenuItem.Name = "newRequestToolStripMenuItem";
            this.newRequestToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.newRequestToolStripMenuItem.Text = "Hi Pedro!";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // receivingToolStripMenuItem
            // 
            this.receivingToolStripMenuItem.Name = "receivingToolStripMenuItem";
            this.receivingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.receivingToolStripMenuItem.Text = "Receiving";
            this.receivingToolStripMenuItem.Click += new System.EventHandler(this.receivingToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(819, 24);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newOrderToolStripMenuItem,
            this.orderListToolStripMenuItem,
            this.orderDetailsToolStripMenuItem,
            this.orderDetails2ToolStripMenuItem});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newOrderToolStripMenuItem.Text = "New Order";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // orderListToolStripMenuItem
            // 
            this.orderListToolStripMenuItem.Name = "orderListToolStripMenuItem";
            this.orderListToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.orderListToolStripMenuItem.Text = "Order List";
            this.orderListToolStripMenuItem.Click += new System.EventHandler(this.orderListToolStripMenuItem_Click);
            // 
            // orderDetailsToolStripMenuItem
            // 
            this.orderDetailsToolStripMenuItem.Name = "orderDetailsToolStripMenuItem";
            this.orderDetailsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.orderDetailsToolStripMenuItem.Text = "Order Details";
            this.orderDetailsToolStripMenuItem.Click += new System.EventHandler(this.orderDetailsToolStripMenuItem_Click);
            // 
            // orderDetails2ToolStripMenuItem
            // 
            this.orderDetails2ToolStripMenuItem.Name = "orderDetails2ToolStripMenuItem";
            this.orderDetails2ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.orderDetails2ToolStripMenuItem.Text = "Order Details 2";
            this.orderDetails2ToolStripMenuItem.Click += new System.EventHandler(this.orderDetails2ToolStripMenuItem_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(107, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 23);
            this.btnHome.TabIndex = 47;
            this.btnHome.Text = "🏠";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(57, 21);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(35, 23);
            this.btnForward.TabIndex = 46;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBackPO
            // 
            this.btnBackPO.Location = new System.Drawing.Point(18, 21);
            this.btnBackPO.Name = "btnBackPO";
            this.btnBackPO.Size = new System.Drawing.Size(33, 23);
            this.btnBackPO.TabIndex = 45;
            this.btnBackPO.Text = "←";
            this.btnBackPO.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(148, 23);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(695, 20);
            this.txtURL.TabIndex = 44;
            this.txtURL.Text = "https://bagpurchasing.com";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Location = new System.Drawing.Point(18, 143);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(42, 13);
            this.lblPO.TabIndex = 49;
            this.lblPO.Text = "PO No.";
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Location = new System.Drawing.Point(18, 170);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(42, 13);
            this.lblPR.TabIndex = 50;
            this.lblPR.Text = "PR No.";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(324, 170);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(45, 13);
            this.lblSupplier.TabIndex = 51;
            this.lblSupplier.Text = "Supplier";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(324, 198);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "Date";
            // 
            // lblBAGRef
            // 
            this.lblBAGRef.AutoSize = true;
            this.lblBAGRef.Location = new System.Drawing.Point(18, 198);
            this.lblBAGRef.Name = "lblBAGRef";
            this.lblBAGRef.Size = new System.Drawing.Size(52, 13);
            this.lblBAGRef.TabIndex = 53;
            this.lblBAGRef.Text = "BAG Ref.";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(324, 143);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 52;
            this.lblDept.Text = "Department";
            // 
            // txtPO
            // 
            this.txtPO.Location = new System.Drawing.Point(76, 138);
            this.txtPO.Name = "txtPO";
            this.txtPO.Size = new System.Drawing.Size(171, 20);
            this.txtPO.TabIndex = 55;
            // 
            // txtPR
            // 
            this.txtPR.Location = new System.Drawing.Point(76, 165);
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(171, 20);
            this.txtPR.TabIndex = 56;
            // 
            // txtBAGRef
            // 
            this.txtBAGRef.Location = new System.Drawing.Point(76, 191);
            this.txtBAGRef.Name = "txtBAGRef";
            this.txtBAGRef.Size = new System.Drawing.Size(171, 20);
            this.txtBAGRef.TabIndex = 57;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(392, 167);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(171, 20);
            this.txtSupplier.TabIndex = 59;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(392, 140);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(171, 20);
            this.txtDept.TabIndex = 58;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(392, 192);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemNo,
            this.colDesc});
            this.dataGridView1.Location = new System.Drawing.Point(22, 325);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 179);
            this.dataGridView1.TabIndex = 61;
            // 
            // colItemNo
            // 
            this.colItemNo.HeaderText = "Item No.";
            this.colItemNo.Name = "colItemNo";
            // 
            // colDesc
            // 
            this.colDesc.HeaderText = "Description";
            this.colDesc.Name = "colDesc";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(765, 138);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 62;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(18, 232);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(49, 13);
            this.lblRemarks.TabIndex = 64;
            this.lblRemarks.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemarks.Location = new System.Drawing.Point(21, 248);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(816, 45);
            this.txtRemarks.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.rdServed);
            this.panel1.Controls.Add(this.rdPrinted);
            this.panel1.Controls.Add(this.chkReset);
            this.panel1.Location = new System.Drawing.Point(617, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 98);
            this.panel1.TabIndex = 66;
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(87, 72);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(33, 23);
            this.btnAccept.TabIndex = 67;
            this.btnAccept.Text = "✔";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // rdServed
            // 
            this.rdServed.AutoSize = true;
            this.rdServed.Enabled = false;
            this.rdServed.Location = new System.Drawing.Point(12, 55);
            this.rdServed.Name = "rdServed";
            this.rdServed.Size = new System.Drawing.Size(59, 17);
            this.rdServed.TabIndex = 2;
            this.rdServed.TabStop = true;
            this.rdServed.Text = "Served";
            this.rdServed.UseVisualStyleBackColor = true;
            this.rdServed.CheckedChanged += new System.EventHandler(this.rdServed_CheckedChanged);
            // 
            // rdPrinted
            // 
            this.rdPrinted.AutoSize = true;
            this.rdPrinted.Enabled = false;
            this.rdPrinted.Location = new System.Drawing.Point(12, 34);
            this.rdPrinted.Name = "rdPrinted";
            this.rdPrinted.Size = new System.Drawing.Size(58, 17);
            this.rdPrinted.TabIndex = 1;
            this.rdPrinted.TabStop = true;
            this.rdPrinted.Text = "Printed";
            this.rdPrinted.UseVisualStyleBackColor = true;
            this.rdPrinted.CheckedChanged += new System.EventHandler(this.rdPrinted_CheckedChanged);
            // 
            // chkReset
            // 
            this.chkReset.AutoSize = true;
            this.chkReset.Location = new System.Drawing.Point(12, 8);
            this.chkReset.Name = "chkReset";
            this.chkReset.Size = new System.Drawing.Size(54, 17);
            this.chkReset.TabIndex = 0;
            this.chkReset.Text = "Reset";
            this.chkReset.UseVisualStyleBackColor = true;
            this.chkReset.CheckedChanged += new System.EventHandler(this.chkReset_CheckedChanged);
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerUserToolStripMenuItem.Text = "Register User";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // frmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtBAGRef);
            this.Controls.Add(this.txtPR);
            this.Controls.Add(this.txtPO);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblBAGRef);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblPR);
            this.Controls.Add(this.lblPO);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackPO);
            this.Controls.Add(this.txtURL);
            this.Name = "frmOrderDetails";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackPO;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ToolStripMenuItem orderDetails2ToolStripMenuItem;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblBAGRef;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtPO;
        private System.Windows.Forms.TextBox txtPR;
        private System.Windows.Forms.TextBox txtBAGRef;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDesc;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.ToolStripMenuItem receivingToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkReset;
        private System.Windows.Forms.RadioButton rdServed;
        private System.Windows.Forms.RadioButton rdPrinted;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
    }
}