namespace BAG_PRandPO_UI.Purchase_Request
{
    partial class frmDisapprove
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
            this.btnCorrection = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnDisapprove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCorrection
            // 
            this.btnCorrection.Location = new System.Drawing.Point(290, 206);
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.Size = new System.Drawing.Size(75, 43);
            this.btnCorrection.TabIndex = 5;
            this.btnCorrection.Text = "For Correction";
            this.btnCorrection.UseVisualStyleBackColor = true;
            this.btnCorrection.Click += new System.EventHandler(this.btnCorrection_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 140);
            this.textBox1.TabIndex = 4;
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Location = new System.Drawing.Point(42, 31);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(56, 13);
            this.lblCancel.TabIndex = 3;
            this.lblCancel.Text = "Comments";
            // 
            // btnDisapprove
            // 
            this.btnDisapprove.Location = new System.Drawing.Point(385, 206);
            this.btnDisapprove.Name = "btnDisapprove";
            this.btnDisapprove.Size = new System.Drawing.Size(75, 43);
            this.btnDisapprove.TabIndex = 6;
            this.btnDisapprove.Text = "Disapprove";
            this.btnDisapprove.UseVisualStyleBackColor = true;
            this.btnDisapprove.Click += new System.EventHandler(this.btnDisapprove_Click);
            // 
            // frmDisapprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 261);
            this.Controls.Add(this.btnDisapprove);
            this.Controls.Add(this.btnCorrection);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDisapprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrection;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnDisapprove;
    }
}