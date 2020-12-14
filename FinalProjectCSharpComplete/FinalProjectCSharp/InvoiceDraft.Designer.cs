namespace FinalProjectCSharp
{
    partial class InvoiceDraft
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
            this.dgv_InvoiceDrafts = new System.Windows.Forms.DataGridView();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Invoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.invoice_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceDrafts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_InvoiceDrafts
            // 
            this.dgv_InvoiceDrafts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_InvoiceDrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InvoiceDrafts.Location = new System.Drawing.Point(12, 12);
            this.dgv_InvoiceDrafts.Name = "dgv_InvoiceDrafts";
            this.dgv_InvoiceDrafts.Size = new System.Drawing.Size(952, 567);
            this.dgv_InvoiceDrafts.TabIndex = 0;
            this.dgv_InvoiceDrafts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_InvoiceDrafts_CellContentClick_1);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(1003, 293);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(268, 56);
            this.btn_Open.TabIndex = 1;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1003, 355);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(268, 56);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1003, 417);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(268, 56);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Invoice
            // 
            this.lbl_Invoice.AutoSize = true;
            this.lbl_Invoice.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invoice.Location = new System.Drawing.Point(1024, 29);
            this.lbl_Invoice.Name = "lbl_Invoice";
            this.lbl_Invoice.Size = new System.Drawing.Size(247, 55);
            this.lbl_Invoice.TabIndex = 5;
            this.lbl_Invoice.Text = "INVOICE ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1033, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "DRAFTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1052, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Invoice Number Selected";
            // 
            // invoice_txt
            // 
            this.invoice_txt.Location = new System.Drawing.Point(1056, 190);
            this.invoice_txt.Name = "invoice_txt";
            this.invoice_txt.Size = new System.Drawing.Size(194, 29);
            this.invoice_txt.TabIndex = 8;
            this.invoice_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // InvoiceDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 591);
            this.Controls.Add(this.invoice_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Invoice);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.dgv_InvoiceDrafts);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "InvoiceDraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Drafts";
            this.Load += new System.EventHandler(this.InvoiceDraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InvoiceDrafts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_InvoiceDrafts;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Invoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoice_txt;
    }
}