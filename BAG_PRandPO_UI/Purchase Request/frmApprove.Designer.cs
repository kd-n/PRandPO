namespace BAG_PRandPO_UI.Purchase_Request
{
    partial class frmApprove
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
            this.lblReason = new System.Windows.Forms.Label();
            this.rdQuotation = new System.Windows.Forms.RadioButton();
            this.rdFinalPurchase = new System.Windows.Forms.RadioButton();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.clmItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.grpModes = new System.Windows.Forms.GroupBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnDisapprove = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblRequiredDelivery = new System.Windows.Forms.Label();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnPendingRequest = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.grpUrgent = new System.Windows.Forms.GroupBox();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.txtRequestor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtPRNo = new System.Windows.Forms.TextBox();
            this.lblPRNo = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.grpModes.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpUrgent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(145, 17);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(44, 13);
            this.lblReason.TabIndex = 21;
            this.lblReason.Text = "Reason";
            // 
            // rdQuotation
            // 
            this.rdQuotation.AutoSize = true;
            this.rdQuotation.Location = new System.Drawing.Point(18, 19);
            this.rdQuotation.Name = "rdQuotation";
            this.rdQuotation.Size = new System.Drawing.Size(89, 17);
            this.rdQuotation.TabIndex = 20;
            this.rdQuotation.TabStop = true;
            this.rdQuotation.Text = "For Quotation";
            this.rdQuotation.UseVisualStyleBackColor = true;
            // 
            // rdFinalPurchase
            // 
            this.rdFinalPurchase.AutoSize = true;
            this.rdFinalPurchase.Location = new System.Drawing.Point(144, 19);
            this.rdFinalPurchase.Name = "rdFinalPurchase";
            this.rdFinalPurchase.Size = new System.Drawing.Size(113, 17);
            this.rdFinalPurchase.TabIndex = 21;
            this.rdFinalPurchase.TabStop = true;
            this.rdFinalPurchase.Text = "For Final Purchase";
            this.rdFinalPurchase.UseVisualStyleBackColor = true;
            // 
            // dgvItems
            // 
            this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmItemNo,
            this.clmDesc,
            this.clmBrand,
            this.clmQty,
            this.clmUOM,
            this.clmDate});
            this.dgvItems.Location = new System.Drawing.Point(78, 467);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(1079, 179);
            this.dgvItems.TabIndex = 49;
            // 
            // clmItemNo
            // 
            this.clmItemNo.HeaderText = "Item No.";
            this.clmItemNo.Name = "clmItemNo";
            // 
            // clmDesc
            // 
            this.clmDesc.HeaderText = "Desciption";
            this.clmDesc.Name = "clmDesc";
            // 
            // clmBrand
            // 
            this.clmBrand.HeaderText = "Brand/Maker";
            this.clmBrand.Name = "clmBrand";
            // 
            // clmQty
            // 
            this.clmQty.HeaderText = "Quantity";
            this.clmQty.Name = "clmQty";
            // 
            // clmUOM
            // 
            this.clmUOM.HeaderText = "UOM";
            this.clmUOM.Name = "clmUOM";
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Required Delivery Date";
            this.clmDate.Name = "clmDate";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurpose.Location = new System.Drawing.Point(78, 375);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(1079, 55);
            this.txtPurpose.TabIndex = 48;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(75, 359);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(46, 13);
            this.lblPurpose.TabIndex = 47;
            this.lblPurpose.Text = "Purpose";
            // 
            // grpModes
            // 
            this.grpModes.Controls.Add(this.rdQuotation);
            this.grpModes.Controls.Add(this.rdFinalPurchase);
            this.grpModes.Location = new System.Drawing.Point(78, 270);
            this.grpModes.Name = "grpModes";
            this.grpModes.Size = new System.Drawing.Size(262, 54);
            this.grpModes.TabIndex = 46;
            this.grpModes.TabStop = false;
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(148, 33);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(166, 95);
            this.txtReason.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1082, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAttach
            // 
            this.btnAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttach.Location = new System.Drawing.Point(980, 211);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 33);
            this.btnAttach.TabIndex = 52;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // btnDisapprove
            // 
            this.btnDisapprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisapprove.Location = new System.Drawing.Point(1082, 164);
            this.btnDisapprove.Name = "btnDisapprove";
            this.btnDisapprove.Size = new System.Drawing.Size(75, 33);
            this.btnDisapprove.TabIndex = 51;
            this.btnDisapprove.Text = "Disapprove";
            this.btnDisapprove.UseVisualStyleBackColor = true;
            this.btnDisapprove.Click += new System.EventHandler(this.btnDisapprove_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(980, 164);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 33);
            this.btnApprove.TabIndex = 50;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplete.Location = new System.Drawing.Point(980, 260);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(75, 33);
            this.btnComplete.TabIndex = 54;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // lblRequiredDelivery
            // 
            this.lblRequiredDelivery.AutoSize = true;
            this.lblRequiredDelivery.Location = new System.Drawing.Point(6, 71);
            this.lblRequiredDelivery.Name = "lblRequiredDelivery";
            this.lblRequiredDelivery.Size = new System.Drawing.Size(91, 13);
            this.lblRequiredDelivery.TabIndex = 20;
            this.lblRequiredDelivery.Text = "Required Delivery";
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.btnPendingRequest);
            this.grpMenu.Controls.Add(this.btnNewRequest);
            this.grpMenu.Controls.Add(this.menuStrip1);
            this.grpMenu.Location = new System.Drawing.Point(13, 75);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(1188, 40);
            this.grpMenu.TabIndex = 38;
            this.grpMenu.TabStop = false;
            // 
            // btnPendingRequest
            // 
            this.btnPendingRequest.Location = new System.Drawing.Point(130, 11);
            this.btnPendingRequest.Name = "btnPendingRequest";
            this.btnPendingRequest.Size = new System.Drawing.Size(109, 23);
            this.btnPendingRequest.TabIndex = 11;
            this.btnPendingRequest.Text = "Request List";
            this.btnPendingRequest.UseVisualStyleBackColor = true;
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(15, 11);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(109, 23);
            this.btnNewRequest.TabIndex = 10;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(998, 13);
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
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(102, 36);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 23);
            this.btnHome.TabIndex = 37;
            this.btnHome.Text = "🏠";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(52, 36);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(35, 23);
            this.btnForward.TabIndex = 36;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 23);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(143, 38);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1058, 20);
            this.txtURL.TabIndex = 34;
            this.txtURL.Text = "https://bagpurchasing.com";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // grpUrgent
            // 
            this.grpUrgent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpUrgent.Controls.Add(this.txtReason);
            this.grpUrgent.Controls.Add(this.lblReason);
            this.grpUrgent.Controls.Add(this.lblRequiredDelivery);
            this.grpUrgent.Controls.Add(this.dateDelivery);
            this.grpUrgent.Controls.Add(this.chkUrgent);
            this.grpUrgent.Location = new System.Drawing.Point(559, 178);
            this.grpUrgent.Name = "grpUrgent";
            this.grpUrgent.Size = new System.Drawing.Size(332, 146);
            this.grpUrgent.TabIndex = 45;
            this.grpUrgent.TabStop = false;
            // 
            // dateDelivery
            // 
            this.dateDelivery.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDelivery.Location = new System.Drawing.Point(9, 89);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(119, 20);
            this.dateDelivery.TabIndex = 1;
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(9, 30);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(58, 17);
            this.chkUrgent.TabIndex = 0;
            this.chkUrgent.Text = "Urgent";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // txtRequestor
            // 
            this.txtRequestor.Location = new System.Drawing.Point(143, 232);
            this.txtRequestor.Name = "txtRequestor";
            this.txtRequestor.Size = new System.Drawing.Size(245, 20);
            this.txtRequestor.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Requestor";
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(143, 197);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(245, 20);
            this.txtDept.TabIndex = 42;
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(75, 200);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 41;
            this.lblDept.Text = "Department";
            // 
            // txtPRNo
            // 
            this.txtPRNo.Location = new System.Drawing.Point(143, 160);
            this.txtPRNo.Name = "txtPRNo";
            this.txtPRNo.Size = new System.Drawing.Size(245, 20);
            this.txtPRNo.TabIndex = 40;
            // 
            // lblPRNo
            // 
            this.lblPRNo.AutoSize = true;
            this.lblPRNo.Location = new System.Drawing.Point(75, 163);
            this.lblPRNo.Name = "lblPRNo";
            this.lblPRNo.Size = new System.Drawing.Size(42, 13);
            this.lblPRNo.TabIndex = 39;
            this.lblPRNo.Text = "PR No.";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(1082, 260);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 33);
            this.btnPrint.TabIndex = 55;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerUserToolStripMenuItem.Text = "Register User";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // frmApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 682);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtPurpose);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.grpModes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.btnDisapprove);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.grpUrgent);
            this.Controls.Add(this.txtRequestor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.txtPRNo);
            this.Controls.Add(this.lblPRNo);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmApprove";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.grpModes.ResumeLayout(false);
            this.grpModes.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpUrgent.ResumeLayout(false);
            this.grpUrgent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.RadioButton rdQuotation;
        private System.Windows.Forms.RadioButton rdFinalPurchase;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.GroupBox grpModes;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnDisapprove;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lblRequiredDelivery;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.Button btnPendingRequest;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.GroupBox grpUrgent;
        private System.Windows.Forms.DateTimePicker dateDelivery;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.TextBox txtRequestor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtPRNo;
        private System.Windows.Forms.Label lblPRNo;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
    }
}