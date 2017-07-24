namespace Accountant
{
    partial class MainForm
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
            this.btnNewBill = new System.Windows.Forms.Button();
            this.lnkGoods = new System.Windows.Forms.LinkLabel();
            this.lnkProviders = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewBill
            // 
            this.btnNewBill.Location = new System.Drawing.Point(31, 41);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(175, 66);
            this.btnNewBill.TabIndex = 0;
            this.btnNewBill.Text = "New Bill";
            this.btnNewBill.UseVisualStyleBackColor = true;
            // 
            // lnkGoods
            // 
            this.lnkGoods.AutoSize = true;
            this.lnkGoods.Location = new System.Drawing.Point(12, 176);
            this.lnkGoods.Name = "lnkGoods";
            this.lnkGoods.Size = new System.Drawing.Size(50, 17);
            this.lnkGoods.TabIndex = 1;
            this.lnkGoods.TabStop = true;
            this.lnkGoods.Text = "Goods";
            this.lnkGoods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoods_LinkClicked);
            // 
            // lnkProviders
            // 
            this.lnkProviders.AutoSize = true;
            this.lnkProviders.Location = new System.Drawing.Point(12, 193);
            this.lnkProviders.Name = "lnkProviders";
            this.lnkProviders.Size = new System.Drawing.Size(68, 17);
            this.lnkProviders.TabIndex = 1;
            this.lnkProviders.TabStop = true;
            this.lnkProviders.Text = "Providers";
            this.lnkProviders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProviders_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(160, 189);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 226);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lnkProviders);
            this.Controls.Add(this.lnkGoods);
            this.Controls.Add(this.btnNewBill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accountant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.LinkLabel lnkGoods;
        private System.Windows.Forms.LinkLabel lnkProviders;
        private System.Windows.Forms.Button btnExit;
    }
}