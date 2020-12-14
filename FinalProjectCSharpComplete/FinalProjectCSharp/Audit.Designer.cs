namespace FinalProjectCSharp
{
    partial class Audit
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
            this.dgv_Audit = new System.Windows.Forms.DataGridView();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.mc_DateOne = new System.Windows.Forms.MonthCalendar();
            this.mc_DateTwo = new System.Windows.Forms.MonthCalendar();
            this.btn_ClearFilter = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_PrintResults = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Audit)).BeginInit();
            this.gb_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Audit
            // 
            this.dgv_Audit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Audit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Audit.Location = new System.Drawing.Point(12, 12);
            this.dgv_Audit.Name = "dgv_Audit";
            this.dgv_Audit.Size = new System.Drawing.Size(907, 580);
            this.dgv_Audit.TabIndex = 0;
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.mc_DateOne);
            this.gb_Filter.Controls.Add(this.mc_DateTwo);
            this.gb_Filter.Controls.Add(this.btn_ClearFilter);
            this.gb_Filter.Controls.Add(this.btn_Filter);
            this.gb_Filter.Location = new System.Drawing.Point(925, 12);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Size = new System.Drawing.Size(384, 442);
            this.gb_Filter.TabIndex = 3;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Filter";
            // 
            // mc_DateOne
            // 
            this.mc_DateOne.Location = new System.Drawing.Point(86, 31);
            this.mc_DateOne.Name = "mc_DateOne";
            this.mc_DateOne.ShowToday = false;
            this.mc_DateOne.ShowTodayCircle = false;
            this.mc_DateOne.TabIndex = 7;
            // 
            // mc_DateTwo
            // 
            this.mc_DateTwo.Location = new System.Drawing.Point(86, 211);
            this.mc_DateTwo.Name = "mc_DateTwo";
            this.mc_DateTwo.ShowToday = false;
            this.mc_DateTwo.ShowTodayCircle = false;
            this.mc_DateTwo.TabIndex = 6;
            // 
            // btn_ClearFilter
            // 
            this.btn_ClearFilter.Location = new System.Drawing.Point(202, 393);
            this.btn_ClearFilter.Name = "btn_ClearFilter";
            this.btn_ClearFilter.Size = new System.Drawing.Size(122, 28);
            this.btn_ClearFilter.TabIndex = 5;
            this.btn_ClearFilter.Text = "Clear";
            this.btn_ClearFilter.UseVisualStyleBackColor = true;
            this.btn_ClearFilter.Click += new System.EventHandler(this.btn_ClearFilter_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(68, 393);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(122, 28);
            this.btn_Filter.TabIndex = 4;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_PrintResults
            // 
            this.btn_PrintResults.Location = new System.Drawing.Point(993, 474);
            this.btn_PrintResults.Name = "btn_PrintResults";
            this.btn_PrintResults.Size = new System.Drawing.Size(256, 56);
            this.btn_PrintResults.TabIndex = 4;
            this.btn_PrintResults.Text = "Save Selection";
            this.btn_PrintResults.UseVisualStyleBackColor = true;
            this.btn_PrintResults.Click += new System.EventHandler(this.btn_PrintResults_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(993, 536);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(256, 56);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 604);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PrintResults);
            this.Controls.Add(this.gb_Filter);
            this.Controls.Add(this.dgv_Audit);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Audit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit";
            this.Load += new System.EventHandler(this.Audit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Audit)).EndInit();
            this.gb_Filter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Audit;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_PrintResults;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_ClearFilter;
        private System.Windows.Forms.MonthCalendar mc_DateOne;
        private System.Windows.Forms.MonthCalendar mc_DateTwo;
    }
}