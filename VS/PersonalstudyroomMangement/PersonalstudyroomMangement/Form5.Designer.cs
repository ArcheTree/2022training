namespace PersonalstudyroomMangement
{
    partial class Form_charge
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_setNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.domainUpDown_day = new System.Windows.Forms.DomainUpDown();
            this.label_money = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_pay = new System.Windows.Forms.Button();
            this.button_refund = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 11F);
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "자리번호 :";
            // 
            // label_setNum
            // 
            this.label_setNum.AutoSize = true;
            this.label_setNum.Font = new System.Drawing.Font("굴림", 11F);
            this.label_setNum.Location = new System.Drawing.Point(203, 74);
            this.label_setNum.Name = "label_setNum";
            this.label_setNum.Size = new System.Drawing.Size(55, 19);
            this.label_setNum.TabIndex = 1;
            this.label_setNum.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F);
            this.label3.Location = new System.Drawing.Point(79, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "사용자ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11F);
            this.label5.Location = new System.Drawing.Point(79, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "이용기간 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11F);
            this.label6.Location = new System.Drawing.Point(79, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "시작날짜 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11F);
            this.label7.Location = new System.Drawing.Point(79, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "결제금액 : ";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.CustomFormat = "";
            this.dateTimePicker_start.Font = new System.Drawing.Font("굴림", 11F);
            this.dateTimePicker_start.Location = new System.Drawing.Point(175, 248);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(239, 29);
            this.dateTimePicker_start.TabIndex = 7;
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Enabled = false;
            this.dateTimePicker_end.Font = new System.Drawing.Font("굴림", 11F);
            this.dateTimePicker_end.Location = new System.Drawing.Point(176, 308);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(238, 29);
            this.dateTimePicker_end.TabIndex = 8;
            // 
            // domainUpDown_day
            // 
            this.domainUpDown_day.Font = new System.Drawing.Font("굴림", 9F);
            this.domainUpDown_day.Items.Add("1일");
            this.domainUpDown_day.Items.Add("7일(1주일)");
            this.domainUpDown_day.Items.Add("15일");
            this.domainUpDown_day.Items.Add("30일");
            this.domainUpDown_day.Location = new System.Drawing.Point(175, 188);
            this.domainUpDown_day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.domainUpDown_day.Name = "domainUpDown_day";
            this.domainUpDown_day.Size = new System.Drawing.Size(165, 25);
            this.domainUpDown_day.TabIndex = 9;
            this.domainUpDown_day.Text = "사용일 선택(필수)";
            this.domainUpDown_day.SelectedItemChanged += new System.EventHandler(this.domainUpDown_day_SelectedItemChanged);
            // 
            // label_money
            // 
            this.label_money.AutoSize = true;
            this.label_money.Font = new System.Drawing.Font("굴림", 11F);
            this.label_money.Location = new System.Drawing.Point(187, 368);
            this.label_money.Name = "label_money";
            this.label_money.Size = new System.Drawing.Size(0, 19);
            this.label_money.TabIndex = 10;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("굴림", 11F);
            this.textBox_id.Location = new System.Drawing.Point(175, 128);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(179, 29);
            this.textBox_id.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F);
            this.label4.Location = new System.Drawing.Point(79, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "만료날짜 : ";
            // 
            // button_pay
            // 
            this.button_pay.Location = new System.Drawing.Point(82, 426);
            this.button_pay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(135, 54);
            this.button_pay.TabIndex = 13;
            this.button_pay.Text = "결제하기";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button_pay_Click);
            // 
            // button_refund
            // 
            this.button_refund.Location = new System.Drawing.Point(253, 425);
            this.button_refund.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_refund.Name = "button_refund";
            this.button_refund.Size = new System.Drawing.Size(135, 54);
            this.button_refund.TabIndex = 13;
            this.button_refund.Text = "환불하기";
            this.button_refund.UseVisualStyleBackColor = true;
            // 
            // Form_charge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 558);
            this.Controls.Add(this.button_refund);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_money);
            this.Controls.Add(this.domainUpDown_day);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_setNum);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_charge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " 결재페이지";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_setNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DomainUpDown domainUpDown_day;
        private System.Windows.Forms.Label label_money;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_pay;
        private System.Windows.Forms.Button button_refund;
    }
}