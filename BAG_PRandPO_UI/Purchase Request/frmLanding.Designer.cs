namespace BAG_PRandPO_UI
{
    partial class frmLanding
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
            this.btnBack = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.btnPendingRequest = new System.Windows.Forms.Button();
            this.btnNewRequest = new System.Windows.Forms.Button();
            this.grpPendingRequest = new System.Windows.Forms.GroupBox();
            this.linkRequestCount = new System.Windows.Forms.LinkLabel();
            this.linkPendingCount = new System.Windows.Forms.LinkLabel();
            this.linkRequests = new System.Windows.Forms.LinkLabel();
            this.linkPendingActions = new System.Windows.Forms.LinkLabel();
            this.registerUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.grpMenu.SuspendLayout();
            this.grpPendingRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(101, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(35, 23);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "🏠";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(51, 12);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(35, 23);
            this.btnForward.TabIndex = 6;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(33, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtURL
            // 
            this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtURL.Location = new System.Drawing.Point(142, 14);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(497, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "https://bagpurchasing.com";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRequestToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(437, 13);
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
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMenu.Controls.Add(this.btnPendingRequest);
            this.grpMenu.Controls.Add(this.btnNewRequest);
            this.grpMenu.Controls.Add(this.menuStrip1);
            this.grpMenu.Location = new System.Drawing.Point(12, 51);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(627, 40);
            this.grpMenu.TabIndex = 9;
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
            this.btnPendingRequest.Click += new System.EventHandler(this.btnPendingRequest_Click);
            // 
            // btnNewRequest
            // 
            this.btnNewRequest.Location = new System.Drawing.Point(15, 11);
            this.btnNewRequest.Name = "btnNewRequest";
            this.btnNewRequest.Size = new System.Drawing.Size(109, 23);
            this.btnNewRequest.TabIndex = 10;
            this.btnNewRequest.Text = "New Request";
            this.btnNewRequest.UseVisualStyleBackColor = true;
            this.btnNewRequest.Click += new System.EventHandler(this.btnNewRequest_Click);
            // 
            // grpPendingRequest
            // 
            this.grpPendingRequest.Controls.Add(this.linkRequestCount);
            this.grpPendingRequest.Controls.Add(this.linkPendingCount);
            this.grpPendingRequest.Controls.Add(this.linkRequests);
            this.grpPendingRequest.Controls.Add(this.linkPendingActions);
            this.grpPendingRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.grpPendingRequest.Location = new System.Drawing.Point(27, 126);
            this.grpPendingRequest.Name = "grpPendingRequest";
            this.grpPendingRequest.Size = new System.Drawing.Size(281, 223);
            this.grpPendingRequest.TabIndex = 10;
            this.grpPendingRequest.TabStop = false;
            this.grpPendingRequest.Text = "Pending Requests";
            // 
            // linkRequestCount
            // 
            this.linkRequestCount.AutoSize = true;
            this.linkRequestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkRequestCount.LinkColor = System.Drawing.Color.Red;
            this.linkRequestCount.Location = new System.Drawing.Point(152, 113);
            this.linkRequestCount.Name = "linkRequestCount";
            this.linkRequestCount.Size = new System.Drawing.Size(13, 13);
            this.linkRequestCount.TabIndex = 14;
            this.linkRequestCount.TabStop = true;
            this.linkRequestCount.Text = "1";
            this.linkRequestCount.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // linkPendingCount
            // 
            this.linkPendingCount.AutoSize = true;
            this.linkPendingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkPendingCount.LinkColor = System.Drawing.Color.Red;
            this.linkPendingCount.Location = new System.Drawing.Point(152, 60);
            this.linkPendingCount.Name = "linkPendingCount";
            this.linkPendingCount.Size = new System.Drawing.Size(13, 13);
            this.linkPendingCount.TabIndex = 13;
            this.linkPendingCount.TabStop = true;
            this.linkPendingCount.Text = "3";
            this.linkPendingCount.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // linkRequests
            // 
            this.linkRequests.AutoSize = true;
            this.linkRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkRequests.Location = new System.Drawing.Point(21, 113);
            this.linkRequests.Name = "linkRequests";
            this.linkRequests.Size = new System.Drawing.Size(69, 13);
            this.linkRequests.TabIndex = 12;
            this.linkRequests.TabStop = true;
            this.linkRequests.Text = "My Requests";
            this.linkRequests.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkRequests.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRequests_LinkClicked);
            // 
            // linkPendingActions
            // 
            this.linkPendingActions.AutoSize = true;
            this.linkPendingActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.linkPendingActions.Location = new System.Drawing.Point(21, 60);
            this.linkPendingActions.Name = "linkPendingActions";
            this.linkPendingActions.Size = new System.Drawing.Size(84, 13);
            this.linkPendingActions.TabIndex = 11;
            this.linkPendingActions.TabStop = true;
            this.linkPendingActions.Text = "Pending Actions";
            this.linkPendingActions.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // registerUserToolStripMenuItem
            // 
            this.registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
            this.registerUserToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registerUserToolStripMenuItem.Text = "Register User";
            this.registerUserToolStripMenuItem.Click += new System.EventHandler(this.registerUserToolStripMenuItem_Click);
            // 
            // frmLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 429);
            this.Controls.Add(this.grpPendingRequest);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtURL);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLanding";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.grpPendingRequest.ResumeLayout(false);
            this.grpPendingRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRequestToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btnPendingRequest;
        private System.Windows.Forms.Button btnNewRequest;
        private System.Windows.Forms.GroupBox grpPendingRequest;
        private System.Windows.Forms.LinkLabel linkPendingActions;
        private System.Windows.Forms.LinkLabel linkRequests;
        private System.Windows.Forms.LinkLabel linkRequestCount;
        private System.Windows.Forms.LinkLabel linkPendingCount;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUserToolStripMenuItem;
    }
}