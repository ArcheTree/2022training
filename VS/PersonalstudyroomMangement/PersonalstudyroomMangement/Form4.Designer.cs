namespace PersonalstudyroomMangement
{
    partial class Form_sale
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_detail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_totalcount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_sale = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_refund = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_finalsale = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.registerNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.takeDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refundpayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_detail);
            this.groupBox1.Location = new System.Drawing.Point(14, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1311, 541);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색 결과";
            // 
            // dataGridView_detail
            // 
            this.dataGridView_detail.AutoGenerateColumns = false;
            this.dataGridView_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registerNumDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.roomNumDataGridViewTextBoxColumn,
            this.seatNumDataGridViewTextBoxColumn,
            this.takeDayDataGridViewTextBoxColumn,
            this.payDataGridViewTextBoxColumn,
            this.startdayDataGridViewTextBoxColumn,
            this.enddayDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.refundpayDataGridViewTextBoxColumn});
            this.dataGridView_detail.DataSource = this.registrationBindingSource;
            this.dataGridView_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_detail.Location = new System.Drawing.Point(3, 22);
            this.dataGridView_detail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_detail.Name = "dataGridView_detail";
            this.dataGridView_detail.RowHeadersWidth = 51;
            this.dataGridView_detail.RowTemplate.Height = 23;
            this.dataGridView_detail.Size = new System.Drawing.Size(1305, 515);
            this.dataGridView_detail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(411, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F);
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "검색기간 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 632);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "총 건수 :";
            // 
            // label_totalcount
            // 
            this.label_totalcount.AutoSize = true;
            this.label_totalcount.Location = new System.Drawing.Point(95, 634);
            this.label_totalcount.Name = "label_totalcount";
            this.label_totalcount.Size = new System.Drawing.Size(22, 15);
            this.label_totalcount.TabIndex = 6;
            this.label_totalcount.Text = "건";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "매출 :";
            // 
            // label_sale
            // 
            this.label_sale.AutoSize = true;
            this.label_sale.Location = new System.Drawing.Point(267, 632);
            this.label_sale.Name = "label_sale";
            this.label_sale.Size = new System.Drawing.Size(22, 15);
            this.label_sale.TabIndex = 8;
            this.label_sale.Text = "원";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(402, 632);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "환불금 :";
            // 
            // label_refund
            // 
            this.label_refund.AutoSize = true;
            this.label_refund.Location = new System.Drawing.Point(465, 632);
            this.label_refund.Name = "label_refund";
            this.label_refund.Size = new System.Drawing.Size(22, 15);
            this.label_refund.TabIndex = 12;
            this.label_refund.Text = "원";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(610, 632);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "총 매출:";
            // 
            // label_finalsale
            // 
            this.label_finalsale.AutoSize = true;
            this.label_finalsale.Location = new System.Drawing.Point(673, 632);
            this.label_finalsale.Name = "label_finalsale";
            this.label_finalsale.Size = new System.Drawing.Size(22, 15);
            this.label_finalsale.TabIndex = 14;
            this.label_finalsale.Text = "원";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(126, 29);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(260, 25);
            this.dateTimePicker_start.TabIndex = 15;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker_start_ValueChanged_1);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(463, 29);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(260, 25);
            this.dateTimePicker_end.TabIndex = 16;
            this.dateTimePicker_end.ValueChanged += new System.EventHandler(this.dateTimePicker_end_ValueChanged_1);
            // 
            // registerNumDataGridViewTextBoxColumn
            // 
            this.registerNumDataGridViewTextBoxColumn.DataPropertyName = "registerNum";
            this.registerNumDataGridViewTextBoxColumn.HeaderText = "등록번호";
            this.registerNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registerNumDataGridViewTextBoxColumn.Name = "registerNumDataGridViewTextBoxColumn";
            this.registerNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "roomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "방호수";
            this.roomNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            this.roomNumDataGridViewTextBoxColumn.Width = 80;
            // 
            // seatNumDataGridViewTextBoxColumn
            // 
            this.seatNumDataGridViewTextBoxColumn.DataPropertyName = "seatNum";
            this.seatNumDataGridViewTextBoxColumn.HeaderText = "자리번호";
            this.seatNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatNumDataGridViewTextBoxColumn.Name = "seatNumDataGridViewTextBoxColumn";
            this.seatNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // takeDayDataGridViewTextBoxColumn
            // 
            this.takeDayDataGridViewTextBoxColumn.DataPropertyName = "takeDay";
            this.takeDayDataGridViewTextBoxColumn.HeaderText = "등록일";
            this.takeDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.takeDayDataGridViewTextBoxColumn.Name = "takeDayDataGridViewTextBoxColumn";
            this.takeDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // payDataGridViewTextBoxColumn
            // 
            this.payDataGridViewTextBoxColumn.DataPropertyName = "pay";
            this.payDataGridViewTextBoxColumn.HeaderText = "결제금액";
            this.payDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.payDataGridViewTextBoxColumn.Name = "payDataGridViewTextBoxColumn";
            this.payDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdayDataGridViewTextBoxColumn
            // 
            this.startdayDataGridViewTextBoxColumn.DataPropertyName = "startday";
            this.startdayDataGridViewTextBoxColumn.HeaderText = "시작일";
            this.startdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdayDataGridViewTextBoxColumn.Name = "startdayDataGridViewTextBoxColumn";
            this.startdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // enddayDataGridViewTextBoxColumn
            // 
            this.enddayDataGridViewTextBoxColumn.DataPropertyName = "endday";
            this.enddayDataGridViewTextBoxColumn.HeaderText = "만료일";
            this.enddayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddayDataGridViewTextBoxColumn.Name = "enddayDataGridViewTextBoxColumn";
            this.enddayDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "비고";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // refundpayDataGridViewTextBoxColumn
            // 
            this.refundpayDataGridViewTextBoxColumn.DataPropertyName = "refundpay";
            this.refundpayDataGridViewTextBoxColumn.HeaderText = "환불금";
            this.refundpayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.refundpayDataGridViewTextBoxColumn.Name = "refundpayDataGridViewTextBoxColumn";
            this.refundpayDataGridViewTextBoxColumn.Width = 80;
            // 
            // registrationBindingSource
            // 
            this.registrationBindingSource.DataSource = typeof(PersonalstudyroomMangement.Registration);
            // 
            // Form_sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 670);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label_finalsale);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_refund);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_sale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_totalcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "매출관리";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_totalcount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_sale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_refund;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_finalsale;
        private System.Windows.Forms.BindingSource registrationBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn takeDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refundpayDataGridViewTextBoxColumn;
    }
}