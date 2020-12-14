namespace FinalProjectCSharp
{
    partial class QuoteDraft
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.dgv_QuoteDrafts = new System.Windows.Forms.DataGridView();
            this.quote_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Invoice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuoteDrafts)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1017, 391);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(268, 56);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(1017, 329);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(268, 56);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(1017, 267);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(268, 56);
            this.btn_Open.TabIndex = 6;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // dgv_QuoteDrafts
            // 
            this.dgv_QuoteDrafts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QuoteDrafts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuoteDrafts.Location = new System.Drawing.Point(12, 12);
            this.dgv_QuoteDrafts.Name = "dgv_QuoteDrafts";
            this.dgv_QuoteDrafts.Size = new System.Drawing.Size(952, 567);
            this.dgv_QuoteDrafts.TabIndex = 5;
            this.dgv_QuoteDrafts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuoteDrafts_CellContentClick);
            // 
            // quote_txt
            // 
            this.quote_txt.Location = new System.Drawing.Point(1053, 201);
            this.quote_txt.Name = "quote_txt";
            this.quote_txt.Size = new System.Drawing.Size(194, 29);
            this.quote_txt.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1049, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quote Number Selected";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1030, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "DRAFTS";
            // 
            // lbl_Invoice
            // 
            this.lbl_Invoice.AutoSize = true;
            this.lbl_Invoice.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invoice.Location = new System.Drawing.Point(1040, 25);
            this.lbl_Invoice.Name = "lbl_Invoice";
            this.lbl_Invoice.Size = new System.Drawing.Size(198, 55);
            this.lbl_Invoice.TabIndex = 9;
            this.lbl_Invoice.Text = "QUOTE";
            // 
            // QuoteDraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 591);
            this.Controls.Add(this.quote_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Invoice);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.dgv_QuoteDrafts);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "QuoteDraft";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quote Drafts";
            this.Load += new System.EventHandler(this.QuoteDraft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuoteDrafts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.DataGridView dgv_QuoteDrafts;
        private System.Windows.Forms.TextBox quote_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Invoice;
    }
}