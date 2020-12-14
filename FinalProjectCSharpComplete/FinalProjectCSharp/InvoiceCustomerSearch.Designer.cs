namespace FinalProjectCSharp
{
    partial class InvoiceCustomerSearch
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
            this.dgv_CustomersList = new System.Windows.Forms.DataGridView();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CustomersList
            // 
            this.dgv_CustomersList.AllowUserToAddRows = false;
            this.dgv_CustomersList.AllowUserToDeleteRows = false;
            this.dgv_CustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomersList.Location = new System.Drawing.Point(12, 12);
            this.dgv_CustomersList.MultiSelect = false;
            this.dgv_CustomersList.Name = "dgv_CustomersList";
            this.dgv_CustomersList.ReadOnly = true;
            this.dgv_CustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomersList.Size = new System.Drawing.Size(983, 466);
            this.dgv_CustomersList.TabIndex = 0;
            this.dgv_CustomersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CustomersList_CellClick);
            this.dgv_CustomersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CustomersList_CellContentClick);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(151, 527);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 29);
            this.btn_Clear.TabIndex = 45;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(12, 527);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 29);
            this.btn_Search.TabIndex = 44;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 501);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(268, 20);
            this.txt_Search.TabIndex = 43;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Select.Location = new System.Drawing.Point(596, 501);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(129, 55);
            this.btn_Select.TabIndex = 46;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(731, 501);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(129, 55);
            this.btn_AddNew.TabIndex = 50;
            this.btn_AddNew.Text = "Add New Customer";
            this.btn_AddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(866, 501);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(129, 55);
            this.btn_Exit.TabIndex = 51;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // InvoiceCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 569);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_CustomersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InvoiceCustomerSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Search";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CustomersList;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_Exit;
    }
}