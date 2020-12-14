namespace FinalProjectCSharp
{
    partial class Quote
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
            this.gb_Quote = new System.Windows.Forms.GroupBox();
            this.gb_Customer = new System.Windows.Forms.GroupBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_SaveAsDraft = new System.Windows.Forms.Button();
            this.btn_SaveAndPrint = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lbl_Quote = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_Hst = new System.Windows.Forms.TextBox();
            this.txt_QuoteNo = new System.Windows.Forms.TextBox();
            this.lbl_Hst = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_TaxExempt = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_QuoteNo = new System.Windows.Forms.Label();
            this.cb_TaxExempt = new System.Windows.Forms.ComboBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.gb_Comments = new System.Windows.Forms.GroupBox();
            this.txt_Comments = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_PartsAndLabour = new System.Windows.Forms.GroupBox();
            this.txt_QuantityHours = new System.Windows.Forms.TextBox();
            this.txt_PartNumber = new System.Windows.Forms.TextBox();
            this.txt_PartName = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Discount = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_PartName = new System.Windows.Forms.Label();
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.dgv_QuotePartsAndLabour = new System.Windows.Forms.DataGridView();
            this.lbl_quantityHours = new System.Windows.Forms.Label();
            this.gb_Vehicle = new System.Windows.Forms.GroupBox();
            this.lbl_Mileage = new System.Windows.Forms.Label();
            this.lbl_Model = new System.Windows.Forms.Label();
            this.lbl_Make = new System.Windows.Forms.Label();
            this.txt_Mileage = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Make = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.gb_Quote.SuspendLayout();
            this.gb_Customer.SuspendLayout();
            this.gb_Comments.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gb_PartsAndLabour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuotePartsAndLabour)).BeginInit();
            this.gb_Vehicle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Quote
            // 
            this.gb_Quote.Controls.Add(this.gb_Customer);
            this.gb_Quote.Controls.Add(this.btn_Exit);
            this.gb_Quote.Controls.Add(this.btn_SaveAsDraft);
            this.gb_Quote.Controls.Add(this.btn_SaveAndPrint);
            this.gb_Quote.Controls.Add(this.btn_Save);
            this.gb_Quote.Controls.Add(this.lbl_Quote);
            this.gb_Quote.Controls.Add(this.lbl_Total);
            this.gb_Quote.Controls.Add(this.txt_Total);
            this.gb_Quote.Controls.Add(this.txt_Hst);
            this.gb_Quote.Controls.Add(this.txt_QuoteNo);
            this.gb_Quote.Controls.Add(this.lbl_Hst);
            this.gb_Quote.Controls.Add(this.lbl_Subtotal);
            this.gb_Quote.Controls.Add(this.lbl_TaxExempt);
            this.gb_Quote.Controls.Add(this.lbl_Date);
            this.gb_Quote.Controls.Add(this.lbl_QuoteNo);
            this.gb_Quote.Controls.Add(this.cb_TaxExempt);
            this.gb_Quote.Controls.Add(this.txt_Date);
            this.gb_Quote.Controls.Add(this.txt_Subtotal);
            this.gb_Quote.Controls.Add(this.gb_Comments);
            this.gb_Quote.Controls.Add(this.gb_PartsAndLabour);
            this.gb_Quote.Controls.Add(this.gb_Vehicle);
            this.gb_Quote.Location = new System.Drawing.Point(12, 12);
            this.gb_Quote.Name = "gb_Quote";
            this.gb_Quote.Size = new System.Drawing.Size(1297, 669);
            this.gb_Quote.TabIndex = 4;
            this.gb_Quote.TabStop = false;
            this.gb_Quote.Text = "Quote";
            // 
            // gb_Customer
            // 
            this.gb_Customer.Controls.Add(this.lbl_PhoneNumber);
            this.gb_Customer.Controls.Add(this.txt_PhoneNumber);
            this.gb_Customer.Controls.Add(this.btn_Search);
            this.gb_Customer.Controls.Add(this.label1);
            this.gb_Customer.Controls.Add(this.txt_LastName);
            this.gb_Customer.Controls.Add(this.txt_FirstName);
            this.gb_Customer.Controls.Add(this.label2);
            this.gb_Customer.Location = new System.Drawing.Point(311, 28);
            this.gb_Customer.Name = "gb_Customer";
            this.gb_Customer.Size = new System.Drawing.Size(336, 166);
            this.gb_Customer.TabIndex = 1;
            this.gb_Customer.TabStop = false;
            this.gb_Customer.Text = "Customer";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(6, 95);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(126, 21);
            this.lbl_PhoneNumber.TabIndex = 6;
            this.lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(132, 92);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(198, 29);
            this.txt_PhoneNumber.TabIndex = 2;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(174, 127);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(156, 29);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Last Name:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(132, 57);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(198, 29);
            this.txt_LastName.TabIndex = 1;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(132, 22);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(198, 29);
            this.txt_FirstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1098, 86);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 29);
            this.btn_Exit.TabIndex = 34;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_SaveAsDraft
            // 
            this.btn_SaveAsDraft.Location = new System.Drawing.Point(1017, 158);
            this.btn_SaveAsDraft.Name = "btn_SaveAsDraft";
            this.btn_SaveAsDraft.Size = new System.Drawing.Size(156, 29);
            this.btn_SaveAsDraft.TabIndex = 33;
            this.btn_SaveAsDraft.Text = "Save as Draft";
            this.btn_SaveAsDraft.UseVisualStyleBackColor = true;
            this.btn_SaveAsDraft.Click += new System.EventHandler(this.btn_SaveAsDraft_Click);
            // 
            // btn_SaveAndPrint
            // 
            this.btn_SaveAndPrint.Location = new System.Drawing.Point(1017, 123);
            this.btn_SaveAndPrint.Name = "btn_SaveAndPrint";
            this.btn_SaveAndPrint.Size = new System.Drawing.Size(156, 29);
            this.btn_SaveAndPrint.TabIndex = 32;
            this.btn_SaveAndPrint.Text = "Save and Print";
            this.btn_SaveAndPrint.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1017, 86);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 29);
            this.btn_Save.TabIndex = 31;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Quote
            // 
            this.lbl_Quote.AutoSize = true;
            this.lbl_Quote.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quote.Location = new System.Drawing.Point(997, 28);
            this.lbl_Quote.Name = "lbl_Quote";
            this.lbl_Quote.Size = new System.Drawing.Size(198, 55);
            this.lbl_Quote.TabIndex = 2;
            this.lbl_Quote.Text = "QUOTE";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(1035, 514);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(52, 21);
            this.lbl_Total.TabIndex = 28;
            this.lbl_Total.Text = "Total:";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(1095, 511);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(129, 29);
            this.txt_Total.TabIndex = 27;
            this.txt_Total.Text = "0.00";
            // 
            // txt_Hst
            // 
            this.txt_Hst.Location = new System.Drawing.Point(1095, 476);
            this.txt_Hst.Name = "txt_Hst";
            this.txt_Hst.ReadOnly = true;
            this.txt_Hst.Size = new System.Drawing.Size(129, 29);
            this.txt_Hst.TabIndex = 26;
            this.txt_Hst.Text = "0.00";
            // 
            // txt_QuoteNo
            // 
            this.txt_QuoteNo.Location = new System.Drawing.Point(145, 50);
            this.txt_QuoteNo.Name = "txt_QuoteNo";
            this.txt_QuoteNo.ReadOnly = true;
            this.txt_QuoteNo.Size = new System.Drawing.Size(129, 29);
            this.txt_QuoteNo.TabIndex = 17;
            // 
            // lbl_Hst
            // 
            this.lbl_Hst.AutoSize = true;
            this.lbl_Hst.Location = new System.Drawing.Point(992, 479);
            this.lbl_Hst.Name = "lbl_Hst";
            this.lbl_Hst.Size = new System.Drawing.Size(97, 21);
            this.lbl_Hst.TabIndex = 24;
            this.lbl_Hst.Text = "HST (13%)";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(1013, 444);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(76, 21);
            this.lbl_Subtotal.TabIndex = 23;
            this.lbl_Subtotal.Text = "Subtotal:";
            // 
            // lbl_TaxExempt
            // 
            this.lbl_TaxExempt.AutoSize = true;
            this.lbl_TaxExempt.Location = new System.Drawing.Point(35, 123);
            this.lbl_TaxExempt.Name = "lbl_TaxExempt";
            this.lbl_TaxExempt.Size = new System.Drawing.Size(104, 21);
            this.lbl_TaxExempt.TabIndex = 5;
            this.lbl_TaxExempt.Text = "Tax Exempt:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Location = new System.Drawing.Point(91, 88);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(48, 21);
            this.lbl_Date.TabIndex = 4;
            this.lbl_Date.Text = "Date:";
            // 
            // lbl_QuoteNo
            // 
            this.lbl_QuoteNo.AutoSize = true;
            this.lbl_QuoteNo.Location = new System.Drawing.Point(50, 53);
            this.lbl_QuoteNo.Name = "lbl_QuoteNo";
            this.lbl_QuoteNo.Size = new System.Drawing.Size(89, 21);
            this.lbl_QuoteNo.TabIndex = 19;
            this.lbl_QuoteNo.Text = "Quote No.";
            // 
            // cb_TaxExempt
            // 
            this.cb_TaxExempt.BackColor = System.Drawing.SystemColors.Window;
            this.cb_TaxExempt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TaxExempt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_TaxExempt.FormattingEnabled = true;
            this.cb_TaxExempt.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_TaxExempt.Location = new System.Drawing.Point(145, 120);
            this.cb_TaxExempt.Name = "cb_TaxExempt";
            this.cb_TaxExempt.Size = new System.Drawing.Size(129, 29);
            this.cb_TaxExempt.TabIndex = 11;
            this.cb_TaxExempt.Tag = "";
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(145, 85);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.ReadOnly = true;
            this.txt_Date.Size = new System.Drawing.Size(129, 29);
            this.txt_Date.TabIndex = 9;
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Location = new System.Drawing.Point(1095, 441);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.ReadOnly = true;
            this.txt_Subtotal.Size = new System.Drawing.Size(129, 29);
            this.txt_Subtotal.TabIndex = 13;
            this.txt_Subtotal.Text = "0.00";
            // 
            // gb_Comments
            // 
            this.gb_Comments.Controls.Add(this.txt_Comments);
            this.gb_Comments.Controls.Add(this.groupBox5);
            this.gb_Comments.Location = new System.Drawing.Point(922, 200);
            this.gb_Comments.Name = "gb_Comments";
            this.gb_Comments.Size = new System.Drawing.Size(359, 172);
            this.gb_Comments.TabIndex = 18;
            this.gb_Comments.TabStop = false;
            this.gb_Comments.Text = "Comments";
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(6, 28);
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(347, 138);
            this.txt_Comments.TabIndex = 23;
            this.txt_Comments.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox2);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(0, 189);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 166);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Customer";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(132, 95);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(198, 61);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Last Name:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(132, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(198, 29);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(132, 22);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(198, 29);
            this.textBox8.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "First Name:";
            // 
            // gb_PartsAndLabour
            // 
            this.gb_PartsAndLabour.Controls.Add(this.txt_QuantityHours);
            this.gb_PartsAndLabour.Controls.Add(this.txt_PartNumber);
            this.gb_PartsAndLabour.Controls.Add(this.txt_PartName);
            this.gb_PartsAndLabour.Controls.Add(this.txt_Price);
            this.gb_PartsAndLabour.Controls.Add(this.btn_Submit);
            this.gb_PartsAndLabour.Controls.Add(this.lbl_Discount);
            this.gb_PartsAndLabour.Controls.Add(this.txt_Discount);
            this.gb_PartsAndLabour.Controls.Add(this.lbl_Price);
            this.gb_PartsAndLabour.Controls.Add(this.lbl_PartName);
            this.gb_PartsAndLabour.Controls.Add(this.lbl_PartNumber);
            this.gb_PartsAndLabour.Controls.Add(this.dgv_QuotePartsAndLabour);
            this.gb_PartsAndLabour.Controls.Add(this.lbl_quantityHours);
            this.gb_PartsAndLabour.Location = new System.Drawing.Point(6, 200);
            this.gb_PartsAndLabour.Name = "gb_PartsAndLabour";
            this.gb_PartsAndLabour.Size = new System.Drawing.Size(895, 464);
            this.gb_PartsAndLabour.TabIndex = 17;
            this.gb_PartsAndLabour.TabStop = false;
            this.gb_PartsAndLabour.Text = "Parts/Labour";
            // 
            // txt_QuantityHours
            // 
            this.txt_QuantityHours.Location = new System.Drawing.Point(6, 58);
            this.txt_QuantityHours.Name = "txt_QuantityHours";
            this.txt_QuantityHours.Size = new System.Drawing.Size(156, 29);
            this.txt_QuantityHours.TabIndex = 0;
            // 
            // txt_PartNumber
            // 
            this.txt_PartNumber.Location = new System.Drawing.Point(190, 58);
            this.txt_PartNumber.Name = "txt_PartNumber";
            this.txt_PartNumber.Size = new System.Drawing.Size(156, 29);
            this.txt_PartNumber.TabIndex = 1;
            // 
            // txt_PartName
            // 
            this.txt_PartName.Location = new System.Drawing.Point(372, 58);
            this.txt_PartName.Name = "txt_PartName";
            this.txt_PartName.Size = new System.Drawing.Size(156, 29);
            this.txt_PartName.TabIndex = 2;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(553, 58);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(156, 29);
            this.txt_Price.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(733, 98);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(156, 29);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Discount
            // 
            this.lbl_Discount.AutoSize = true;
            this.lbl_Discount.Location = new System.Drawing.Point(729, 34);
            this.lbl_Discount.Name = "lbl_Discount";
            this.lbl_Discount.Size = new System.Drawing.Size(114, 21);
            this.lbl_Discount.TabIndex = 10;
            this.lbl_Discount.Text = "Discount (%):";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(733, 58);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(156, 29);
            this.txt_Discount.TabIndex = 4;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(549, 34);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(52, 21);
            this.lbl_Price.TabIndex = 9;
            this.lbl_Price.Text = "Price:";
            // 
            // lbl_PartName
            // 
            this.lbl_PartName.AutoSize = true;
            this.lbl_PartName.Location = new System.Drawing.Point(368, 34);
            this.lbl_PartName.Name = "lbl_PartName";
            this.lbl_PartName.Size = new System.Drawing.Size(92, 21);
            this.lbl_PartName.TabIndex = 8;
            this.lbl_PartName.Text = "Part Name:";
            // 
            // lbl_PartNumber
            // 
            this.lbl_PartNumber.AutoSize = true;
            this.lbl_PartNumber.Location = new System.Drawing.Point(186, 34);
            this.lbl_PartNumber.Name = "lbl_PartNumber";
            this.lbl_PartNumber.Size = new System.Drawing.Size(54, 21);
            this.lbl_PartNumber.TabIndex = 7;
            this.lbl_PartNumber.Text = "Part#:";
            // 
            // dgv_QuotePartsAndLabour
            // 
            this.dgv_QuotePartsAndLabour.AllowUserToAddRows = false;
            this.dgv_QuotePartsAndLabour.AllowUserToDeleteRows = false;
            this.dgv_QuotePartsAndLabour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QuotePartsAndLabour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_QuotePartsAndLabour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuotePartsAndLabour.Location = new System.Drawing.Point(6, 140);
            this.dgv_QuotePartsAndLabour.Name = "dgv_QuotePartsAndLabour";
            this.dgv_QuotePartsAndLabour.ReadOnly = true;
            this.dgv_QuotePartsAndLabour.Size = new System.Drawing.Size(881, 314);
            this.dgv_QuotePartsAndLabour.TabIndex = 11;
            // 
            // lbl_quantityHours
            // 
            this.lbl_quantityHours.AutoSize = true;
            this.lbl_quantityHours.Location = new System.Drawing.Point(2, 34);
            this.lbl_quantityHours.Name = "lbl_quantityHours";
            this.lbl_quantityHours.Size = new System.Drawing.Size(74, 21);
            this.lbl_quantityHours.TabIndex = 6;
            this.lbl_quantityHours.Text = "Qty/Hrs:";
            // 
            // gb_Vehicle
            // 
            this.gb_Vehicle.Controls.Add(this.lbl_Mileage);
            this.gb_Vehicle.Controls.Add(this.lbl_Model);
            this.gb_Vehicle.Controls.Add(this.lbl_Make);
            this.gb_Vehicle.Controls.Add(this.txt_Mileage);
            this.gb_Vehicle.Controls.Add(this.txt_Model);
            this.gb_Vehicle.Controls.Add(this.txt_Make);
            this.gb_Vehicle.Controls.Add(this.txt_Year);
            this.gb_Vehicle.Controls.Add(this.lbl_Year);
            this.gb_Vehicle.Location = new System.Drawing.Point(685, 28);
            this.gb_Vehicle.Name = "gb_Vehicle";
            this.gb_Vehicle.Size = new System.Drawing.Size(216, 166);
            this.gb_Vehicle.TabIndex = 2;
            this.gb_Vehicle.TabStop = false;
            this.gb_Vehicle.Text = "Vehicle";
            // 
            // lbl_Mileage
            // 
            this.lbl_Mileage.AutoSize = true;
            this.lbl_Mileage.Location = new System.Drawing.Point(6, 130);
            this.lbl_Mileage.Name = "lbl_Mileage";
            this.lbl_Mileage.Size = new System.Drawing.Size(71, 21);
            this.lbl_Mileage.TabIndex = 7;
            this.lbl_Mileage.Text = "Mileage:";
            // 
            // lbl_Model
            // 
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Location = new System.Drawing.Point(15, 95);
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(62, 21);
            this.lbl_Model.TabIndex = 6;
            this.lbl_Model.Text = "Model:";
            // 
            // lbl_Make
            // 
            this.lbl_Make.AutoSize = true;
            this.lbl_Make.Location = new System.Drawing.Point(22, 60);
            this.lbl_Make.Name = "lbl_Make";
            this.lbl_Make.Size = new System.Drawing.Size(55, 21);
            this.lbl_Make.TabIndex = 5;
            this.lbl_Make.Text = "Make:";
            // 
            // txt_Mileage
            // 
            this.txt_Mileage.Location = new System.Drawing.Point(79, 127);
            this.txt_Mileage.Name = "txt_Mileage";
            this.txt_Mileage.Size = new System.Drawing.Size(129, 29);
            this.txt_Mileage.TabIndex = 3;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(79, 92);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(129, 29);
            this.txt_Model.TabIndex = 2;
            // 
            // txt_Make
            // 
            this.txt_Make.Location = new System.Drawing.Point(79, 57);
            this.txt_Make.Name = "txt_Make";
            this.txt_Make.Size = new System.Drawing.Size(129, 29);
            this.txt_Make.TabIndex = 1;
            // 
            // txt_Year
            // 
            this.txt_Year.Location = new System.Drawing.Point(79, 22);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(129, 29);
            this.txt_Year.TabIndex = 0;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(30, 25);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(47, 21);
            this.lbl_Year.TabIndex = 4;
            this.lbl_Year.Text = "Year:";
            // 
            // Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 693);
            this.Controls.Add(this.gb_Quote);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Quote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quote";
            this.Load += new System.EventHandler(this.Quote_Load);
            this.gb_Quote.ResumeLayout(false);
            this.gb_Quote.PerformLayout();
            this.gb_Customer.ResumeLayout(false);
            this.gb_Customer.PerformLayout();
            this.gb_Comments.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gb_PartsAndLabour.ResumeLayout(false);
            this.gb_PartsAndLabour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuotePartsAndLabour)).EndInit();
            this.gb_Vehicle.ResumeLayout(false);
            this.gb_Vehicle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Quote;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_Hst;
        private System.Windows.Forms.Label lbl_Hst;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_TaxExempt;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_QuoteNo;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.GroupBox gb_Comments;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_PartsAndLabour;
        private System.Windows.Forms.DataGridView dgv_QuotePartsAndLabour;
        private System.Windows.Forms.GroupBox gb_Vehicle;
        private System.Windows.Forms.Label lbl_Mileage;
        private System.Windows.Forms.Label lbl_Model;
        private System.Windows.Forms.Label lbl_Make;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_SaveAsDraft;
        private System.Windows.Forms.Button btn_SaveAndPrint;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lbl_Quote;
        private System.Windows.Forms.GroupBox gb_Customer;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_QuantityHours;
        private System.Windows.Forms.TextBox txt_PartNumber;
        private System.Windows.Forms.TextBox txt_PartName;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Discount;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_PartName;
        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.Label lbl_quantityHours;
        public System.Windows.Forms.TextBox txt_QuoteNo;
        public System.Windows.Forms.ComboBox cb_TaxExempt;
        public System.Windows.Forms.TextBox txt_Date;
        public System.Windows.Forms.RichTextBox txt_Comments;
        public System.Windows.Forms.TextBox txt_Mileage;
        public System.Windows.Forms.TextBox txt_Model;
        public System.Windows.Forms.TextBox txt_Make;
        public System.Windows.Forms.TextBox txt_Year;
        public System.Windows.Forms.TextBox txt_PhoneNumber;
        public System.Windows.Forms.TextBox txt_LastName;
        public System.Windows.Forms.TextBox txt_FirstName;
    }
}