namespace BAG_PRandPO_UI.Purchase_Order
{
    partial class frmPRtoPO
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblPR = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmPRItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPRDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPRStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmPOItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPODesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPOSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "For PO",
            "Closed"});
            this.comboBox1.Location = new System.Drawing.Point(55, 379);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(153, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblPR);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel2.Controls.Add(this.lblPO);
            this.splitContainer1.Size = new System.Drawing.Size(949, 275);
            this.splitContainer1.SplitterDistance = 486;
            this.splitContainer1.TabIndex = 2;
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPR.Location = new System.Drawing.Point(196, 9);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(111, 13);
            this.lblPR.TabIndex = 3;
            this.lblPR.Text = "Purchase Request";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPRItem,
            this.clmPRDesc,
            this.clmPRStatus});
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 199);
            this.dataGridView1.TabIndex = 2;
            // 
            // clmPRItem
            // 
            this.clmPRItem.HeaderText = "Item";
            this.clmPRItem.Name = "clmPRItem";
            // 
            // clmPRDesc
            // 
            this.clmPRDesc.HeaderText = "Description";
            this.clmPRDesc.Name = "clmPRDesc";
            // 
            // clmPRStatus
            // 
            this.clmPRStatus.HeaderText = "Status";
            this.clmPRStatus.Name = "clmPRStatus";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 47);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPOItem,
            this.clmPODesc,
            this.clmPOSupplier});
            this.dataGridView2.Location = new System.Drawing.Point(3, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(453, 201);
            this.dataGridView2.TabIndex = 5;
            // 
            // clmPOItem
            // 
            this.clmPOItem.HeaderText = "Item";
            this.clmPOItem.Name = "clmPOItem";
            // 
            // clmPODesc
            // 
            this.clmPODesc.HeaderText = "Description";
            this.clmPODesc.Name = "clmPODesc";
            // 
            // clmPOSupplier
            // 
            this.clmPOSupplier.HeaderText = "Supplier";
            this.clmPOSupplier.Name = "clmPOSupplier";
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPO.Location = new System.Drawing.Point(196, 9);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(95, 13);
            this.lblPO.TabIndex = 4;
            this.lblPO.Text = "Purchase Order";
            // 
            // frmPRtoPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 460);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPRtoPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPRItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPRDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPRStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPODesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOSupplier;
    }
}