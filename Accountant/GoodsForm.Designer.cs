namespace Accountant
{
    partial class GoodsForm
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
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.ID_GOOD_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_GOOD_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRADEMARK_COLUMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.AllowUserToDeleteRows = false;
            this.dgvGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_GOOD_COLUMN,
            this.NAME_GOOD_COLUMN,
            this.TRADEMARK_COLUMN});
            this.dgvGoods.Location = new System.Drawing.Point(12, 47);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.RowHeadersVisible = false;
            this.dgvGoods.RowTemplate.Height = 24;
            this.dgvGoods.Size = new System.Drawing.Size(766, 429);
            this.dgvGoods.TabIndex = 0;
            // 
            // ID_GOOD_COLUMN
            // 
            this.ID_GOOD_COLUMN.HeaderText = "ID";
            this.ID_GOOD_COLUMN.Name = "ID_GOOD_COLUMN";
            this.ID_GOOD_COLUMN.ReadOnly = true;
            // 
            // NAME_GOOD_COLUMN
            // 
            this.NAME_GOOD_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NAME_GOOD_COLUMN.HeaderText = "Name";
            this.NAME_GOOD_COLUMN.Name = "NAME_GOOD_COLUMN";
            this.NAME_GOOD_COLUMN.ReadOnly = true;
            // 
            // TRADEMARK_COLUMN
            // 
            this.TRADEMARK_COLUMN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TRADEMARK_COLUMN.HeaderText = "Trademark";
            this.TRADEMARK_COLUMN.Name = "TRADEMARK_COLUMN";
            this.TRADEMARK_COLUMN.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(174, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 29);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 488);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvGoods);
            this.Name = "GoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GOOD_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_GOOD_COLUMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRADEMARK_COLUMN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
    }
}