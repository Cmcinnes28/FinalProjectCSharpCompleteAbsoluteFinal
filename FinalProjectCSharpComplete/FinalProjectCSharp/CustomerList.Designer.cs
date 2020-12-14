namespace FinalProjectCSharp
{
    partial class CustomerList
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.gb_Information = new System.Windows.Forms.GroupBox();
            this.lbl_PostalCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.txt_Province = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_StreetAddress = new System.Windows.Forms.TextBox();
            this.lbl_CustomerNumber = new System.Windows.Forms.Label();
            this.txt_CustomerNumber = new System.Windows.Forms.TextBox();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.dgv_CustomersList = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_BackupData = new System.Windows.Forms.Button();
            this.gb_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomersList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(12, 12);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(268, 56);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(12, 136);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(268, 56);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(12, 74);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(268, 56);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 198);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(268, 56);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // gb_Information
            // 
            this.gb_Information.Controls.Add(this.lbl_PostalCode);
            this.gb_Information.Controls.Add(this.label2);
            this.gb_Information.Controls.Add(this.lbl_City);
            this.gb_Information.Controls.Add(this.txt_PostalCode);
            this.gb_Information.Controls.Add(this.txt_Province);
            this.gb_Information.Controls.Add(this.txt_City);
            this.gb_Information.Controls.Add(this.txt_StreetAddress);
            this.gb_Information.Controls.Add(this.lbl_CustomerNumber);
            this.gb_Information.Controls.Add(this.txt_CustomerNumber);
            this.gb_Information.Controls.Add(this.btn_AddNew);
            this.gb_Information.Controls.Add(this.lbl_Address);
            this.gb_Information.Controls.Add(this.lbl_PhoneNumber);
            this.gb_Information.Controls.Add(this.lbl_LastName);
            this.gb_Information.Controls.Add(this.lbl_FirstName);
            this.gb_Information.Controls.Add(this.txt_PhoneNumber);
            this.gb_Information.Controls.Add(this.txt_LastName);
            this.gb_Information.Controls.Add(this.txt_FirstName);
            this.gb_Information.Location = new System.Drawing.Point(286, 12);
            this.gb_Information.Name = "gb_Information";
            this.gb_Information.Size = new System.Drawing.Size(1023, 242);
            this.gb_Information.TabIndex = 6;
            this.gb_Information.TabStop = false;
            this.gb_Information.Text = "Information";
            this.gb_Information.Enter += new System.EventHandler(this.gb_Information_Enter);
            // 
            // lbl_PostalCode
            // 
            this.lbl_PostalCode.AutoSize = true;
            this.lbl_PostalCode.Location = new System.Drawing.Point(471, 170);
            this.lbl_PostalCode.Name = "lbl_PostalCode";
            this.lbl_PostalCode.Size = new System.Drawing.Size(106, 21);
            this.lbl_PostalCode.TabIndex = 45;
            this.lbl_PostalCode.Text = "Postal Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Province:";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(532, 100);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(45, 21);
            this.lbl_City.TabIndex = 43;
            this.lbl_City.Text = "City:";
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Location = new System.Drawing.Point(583, 167);
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(129, 29);
            this.txt_PostalCode.TabIndex = 42;
            // 
            // txt_Province
            // 
            this.txt_Province.Location = new System.Drawing.Point(583, 132);
            this.txt_Province.Name = "txt_Province";
            this.txt_Province.Size = new System.Drawing.Size(129, 29);
            this.txt_Province.TabIndex = 41;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(583, 97);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(129, 29);
            this.txt_City.TabIndex = 40;
            // 
            // txt_StreetAddress
            // 
            this.txt_StreetAddress.Location = new System.Drawing.Point(583, 62);
            this.txt_StreetAddress.Name = "txt_StreetAddress";
            this.txt_StreetAddress.Size = new System.Drawing.Size(129, 29);
            this.txt_StreetAddress.TabIndex = 39;
            // 
            // lbl_CustomerNumber
            // 
            this.lbl_CustomerNumber.AutoSize = true;
            this.lbl_CustomerNumber.Location = new System.Drawing.Point(112, 170);
            this.lbl_CustomerNumber.Name = "lbl_CustomerNumber";
            this.lbl_CustomerNumber.Size = new System.Drawing.Size(152, 21);
            this.lbl_CustomerNumber.TabIndex = 38;
            this.lbl_CustomerNumber.Text = "Customer Number:";
            // 
            // txt_CustomerNumber
            // 
            this.txt_CustomerNumber.Location = new System.Drawing.Point(270, 167);
            this.txt_CustomerNumber.Name = "txt_CustomerNumber";
            this.txt_CustomerNumber.Size = new System.Drawing.Size(129, 29);
            this.txt_CustomerNumber.TabIndex = 37;
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Location = new System.Drawing.Point(270, 202);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(129, 29);
            this.btn_AddNew.TabIndex = 36;
            this.btn_AddNew.Text = "AddNew";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(453, 65);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(124, 21);
            this.lbl_Address.TabIndex = 35;
            this.lbl_Address.Text = "Street Address:";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(138, 135);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(126, 21);
            this.lbl_PhoneNumber.TabIndex = 34;
            this.lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(170, 100);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(94, 21);
            this.lbl_LastName.TabIndex = 33;
            this.lbl_LastName.Text = "Last Name:";
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(168, 62);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(96, 21);
            this.lbl_FirstName.TabIndex = 32;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(270, 132);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(129, 29);
            this.txt_PhoneNumber.TabIndex = 29;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(270, 97);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(129, 29);
            this.txt_LastName.TabIndex = 28;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(270, 62);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(129, 29);
            this.txt_FirstName.TabIndex = 27;
            // 
            // dgv_CustomersList
            // 
            this.dgv_CustomersList.AllowUserToAddRows = false;
            this.dgv_CustomersList.AllowUserToDeleteRows = false;
            this.dgv_CustomersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CustomersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomersList.Location = new System.Drawing.Point(12, 260);
            this.dgv_CustomersList.MultiSelect = false;
            this.dgv_CustomersList.Name = "dgv_CustomersList";
            this.dgv_CustomersList.ReadOnly = true;
            this.dgv_CustomersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CustomersList.Size = new System.Drawing.Size(1297, 284);
            this.dgv_CustomersList.TabIndex = 7;
            this.dgv_CustomersList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CustomersList_CellClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(12, 550);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(268, 29);
            this.txt_Search.TabIndex = 40;
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(286, 550);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(129, 29);
            this.btn_Search.TabIndex = 41;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(421, 550);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(129, 29);
            this.btn_Clear.TabIndex = 42;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_BackupData
            // 
            this.btn_BackupData.Location = new System.Drawing.Point(1173, 550);
            this.btn_BackupData.Name = "btn_BackupData";
            this.btn_BackupData.Size = new System.Drawing.Size(136, 29);
            this.btn_BackupData.TabIndex = 43;
            this.btn_BackupData.Text = "Backup Data";
            this.btn_BackupData.UseVisualStyleBackColor = true;
            this.btn_BackupData.Click += new System.EventHandler(this.btn_BackupData_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 591);
            this.Controls.Add(this.btn_BackupData);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dgv_CustomersList);
            this.Controls.Add(this.gb_Information);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.gb_Information.ResumeLayout(false);
            this.gb_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox gb_Information;
        private System.Windows.Forms.DataGridView dgv_CustomersList;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Label lbl_CustomerNumber;
        private System.Windows.Forms.TextBox txt_CustomerNumber;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_BackupData;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.TextBox txt_PostalCode;
        private System.Windows.Forms.TextBox txt_Province;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_StreetAddress;
    }
}