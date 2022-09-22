namespace PersonalstudyroomMangement
{
    partial class MainControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_all_expired = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_all_share = new System.Windows.Forms.Label();
            this.label_all_empty = new System.Windows.Forms.Label();
            this.label_all_now = new System.Windows.Forms.Label();
            this.label_all_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_all_expired);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_all_share);
            this.groupBox1.Controls.Add(this.label_all_empty);
            this.groupBox1.Controls.Add(this.label_all_now);
            this.groupBox1.Controls.Add(this.label_all_total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(80, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(250, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "독서실 정보";
            // 
            // label_all_expired
            // 
            this.label_all_expired.AutoSize = true;
            this.label_all_expired.Location = new System.Drawing.Point(155, 301);
            this.label_all_expired.Name = "label_all_expired";
            this.label_all_expired.Size = new System.Drawing.Size(45, 15);
            this.label_all_expired.TabIndex = 11;
            this.label_all_expired.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "만료예정";
            // 
            // label_all_share
            // 
            this.label_all_share.AutoSize = true;
            this.label_all_share.Location = new System.Drawing.Point(155, 388);
            this.label_all_share.Name = "label_all_share";
            this.label_all_share.Size = new System.Drawing.Size(53, 15);
            this.label_all_share.TabIndex = 9;
            this.label_all_share.Text = "label10";
            // 
            // label_all_empty
            // 
            this.label_all_empty.AutoSize = true;
            this.label_all_empty.Location = new System.Drawing.Point(155, 234);
            this.label_all_empty.Name = "label_all_empty";
            this.label_all_empty.Size = new System.Drawing.Size(45, 15);
            this.label_all_empty.TabIndex = 7;
            this.label_all_empty.Text = "label8";
            // 
            // label_all_now
            // 
            this.label_all_now.AutoSize = true;
            this.label_all_now.Location = new System.Drawing.Point(155, 162);
            this.label_all_now.Name = "label_all_now";
            this.label_all_now.Size = new System.Drawing.Size(45, 15);
            this.label_all_now.TabIndex = 6;
            this.label_all_now.Text = "label7";
            // 
            // label_all_total
            // 
            this.label_all_total.AutoSize = true;
            this.label_all_total.Location = new System.Drawing.Point(155, 88);
            this.label_all_total.Name = "label_all_total";
            this.label_all_total.Size = new System.Drawing.Size(31, 15);
            this.label_all_total.TabIndex = 5;
            this.label_all_total.Text = "110";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "점유비율";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "빈 자리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "등록 수";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "총 좌석 수";
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(963, 649);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_all_share;
        private System.Windows.Forms.Label label_all_empty;
        private System.Windows.Forms.Label label_all_now;
        private System.Windows.Forms.Label label_all_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_all_expired;
        private System.Windows.Forms.Label label6;
    }
}
