﻿namespace BAG_PRandPO_UI.Purchase_Order
{
    partial class frmOrderList
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackPO = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrinted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmServed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderDetails2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(101, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 23);
            this.btnHome.TabIndex = 18;
            this.btnHome.Text = "🏠";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(51, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(35, 23);
            this.btnForward.TabIndex = 17;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBackPO
            // 
            this.btnBackPO.Location = new System.Drawing.Point(12, 12);
            this.btnBackPO.Name = "btnBackPO";
            this.btnBackPO.Size = new System.Drawing.Size(33, 23);
            this.btnBackPO.TabIndex = 16;
            this.btnBackPO.Text = "←";
            this.btnBackPO.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(142, 14);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(500, 20);
            this.txtURL.TabIndex = 15;
            this.txtURL.Text = "https://bagpurchasing.com";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 125);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 20;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItem,
            this.clmDesc,
            this.clmDept,
            this.clmPrinted,
            this.clmServed});
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 192);
            this.dataGridView1.TabIndex = 21;
            // 
            // clmItem
            // 
            this.clmItem.HeaderText = "Item No.";
            this.clmItem.Name = "clmItem";
            // 
            // clmDesc
            // 
            this.clmDesc.HeaderText = "Description";
            this.clmDesc.Name = "clmDesc";
            // 
            // clmDept
            // 
            this.clmDept.HeaderText = "Department";
            this.clmDept.Name = "clmDept";
            // 
            // clmPrinted
            // 
            this.clmPrinted.HeaderText = "Printed";
            this.clmPrinted.Name = "clmPrinted";
            // 
            // clmServed
            // 
            this.clmServed.HeaderText = "Served";
            this.clmServed.Name = "clmServed";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Printed",
            "Served"});
            this.comboBox1.Location = new System.Drawing.Point(521, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.menuStrip1);
            this.grpMenu.Controls.Add(this.menuStrip2);
            this.grpMenu.Location = new System.Drawing.Point(12, 53);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(620, 40);
            this.grpMenu.TabIndex = 24;
            this.grpMenu.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(430, 13);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(168, 24);
            this.menuStrip1.TabIndex = 8;
            // 
            // newRequestToolStripMenuItem
            // 
            this.newRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.approveToolStripMenuItem,
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
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.approveToolStripMenuItem.Text = "Receiving";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 16);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(614, 24);
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
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerUserToolStripMenuItem.Text = "Register User";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 358);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBackPO);
            this.Controls.Add(this.txtURL);
            this.Name = "frmOrderList";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackPO;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmPrinted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmServed;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderDetails2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
    }
}