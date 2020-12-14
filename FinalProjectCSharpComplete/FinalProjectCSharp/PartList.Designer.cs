namespace FinalProjectCSharp
{
    partial class PartList
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
            this.dgv_PartList = new System.Windows.Forms.DataGridView();
            this.gb_Information = new System.Windows.Forms.GroupBox();
            this.lbl_PartId = new System.Windows.Forms.Label();
            this.txt_PartId = new System.Windows.Forms.TextBox();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.RichTextBox();
            this.txt_PartNumber = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_BackupData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartList)).BeginInit();
            this.gb_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PartList
            // 
            this.dgv_PartList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PartList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PartList.Location = new System.Drawing.Point(12, 260);
            this.dgv_PartList.Name = "dgv_PartList";
            this.dgv_PartList.Size = new System.Drawing.Size(1297, 284);
            this.dgv_PartList.TabIndex = 13;
            this.dgv_PartList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PartList_CellContentClick);
            // 
            // gb_Information
            // 
            this.gb_Information.Controls.Add(this.lbl_PartId);
            this.gb_Information.Controls.Add(this.txt_PartId);
            this.gb_Information.Controls.Add(this.btn_AddNew);
            this.gb_Information.Controls.Add(this.lbl_Description);
            this.gb_Information.Controls.Add(this.lbl_PartNumber);
            this.gb_Information.Controls.Add(this.txt_Description);
            this.gb_Information.Controls.Add(this.txt_PartNumber);
            this.gb_Information.Location = new System.Drawing.Point(286, 12);
            this.gb_Information.Name = "gb_Information";
            this.gb_Information.Size = new System.Drawing.Size(1023, 242);
            this.gb_Information.TabIndex = 12;
            this.gb_Information.TabStop = false;
            this.gb_Information.Text = "Information";
            // 
            // lbl_PartId
            // 
            this.lbl_PartId.AutoSize = true;
            this.lbl_PartId.Location = new System.Drawing.Point(196, 100);
            this.lbl_PartId.Name = "lbl_PartId";
            this.lbl_PartId.Size = new System.Drawing.Size(68, 21);
            this.lbl_PartId.TabIndex = 38;
            this.lbl_PartId.Text = "Part ID:";
            // 
            // txt_PartId
            // 
            this.txt_PartId.Location = new System.Drawing.Point(270, 97);
            this.txt_PartId.Name = "txt_PartId";
            this.txt_PartId.Size = new System.Drawing.Size(129, 29);
            this.txt_PartId.TabIndex = 37;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(270, 132);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(129, 29);
            this.btn_AddNew.TabIndex = 36;
            this.btn_AddNew.Text = "AddNew";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(438, 65);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(96, 21);
            this.lbl_Description.TabIndex = 35;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_PartNumber
            // 
            this.lbl_PartNumber.AutoSize = true;
            this.lbl_PartNumber.Location = new System.Drawing.Point(155, 65);
            this.lbl_PartNumber.Name = "lbl_PartNumber";
            this.lbl_PartNumber.Size = new System.Drawing.Size(109, 21);
            this.lbl_PartNumber.TabIndex = 32;
            this.lbl_PartNumber.Text = "Part Number:";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(540, 62);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(326, 99);
            this.txt_Description.TabIndex = 31;
            this.txt_Description.Text = "";
            // 
            // txt_PartNumber
            // 
            this.txt_PartNumber.Location = new System.Drawing.Point(270, 62);
            this.txt_PartNumber.Name = "txt_PartNumber";
            this.txt_PartNumber.Size = new System.Drawing.Size(129, 29);
            this.txt_PartNumber.TabIndex = 27;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 198);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(268, 56);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(12, 74);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(268, 56);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 136);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(268, 56);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(268, 56);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 550);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(268, 29);
            this.txt_Search.TabIndex = 39;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(286, 550);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 29);
            this.btn_Search.TabIndex = 39;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(421, 550);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 29);
            this.btn_Clear.TabIndex = 40;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_BackupData
            // 
            this.btn_BackupData.Location = new System.Drawing.Point(1173, 550);
            this.btn_BackupData.Name = "btn_BackupData";
            this.btn_BackupData.Size = new System.Drawing.Size(136, 29);
            this.btn_BackupData.TabIndex = 41;
            this.btn_BackupData.Text = "Backup Data";
            this.btn_BackupData.UseVisualStyleBackColor = true;
            this.btn_BackupData.Click += new System.EventHandler(this.btn_BackupData_Click);
            // 
            // PartList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 591);
            this.Controls.Add(this.btn_BackupData);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_PartList);
            this.Controls.Add(this.gb_Information);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "PartList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Part List";
            this.Load += new System.EventHandler(this.PartList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartList)).EndInit();
            this.gb_Information.ResumeLayout(false);
            this.gb_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PartList;
        private System.Windows.Forms.GroupBox gb_Information;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.RichTextBox txt_Description;
        private System.Windows.Forms.TextBox txt_PartNumber;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_PartId;
        private System.Windows.Forms.TextBox txt_PartId;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_BackupData;
    }
}