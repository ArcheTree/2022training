namespace PersonalstudyroomMangement
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.신규등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이용현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.변경내역ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button_main = new System.Windows.Forms.Button();
            this.button_personal = new System.Windows.Forms.Button();
            this.button_multy = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.신규등록ToolStripMenuItem,
            this.이용현황ToolStripMenuItem,
            this.매출관련ToolStripMenuItem,
            this.변경내역ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 신규등록ToolStripMenuItem
            // 
            this.신규등록ToolStripMenuItem.Name = "신규등록ToolStripMenuItem";
            this.신규등록ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.신규등록ToolStripMenuItem.Text = "신규등록";
            // 
            // 이용현황ToolStripMenuItem
            // 
            this.이용현황ToolStripMenuItem.Name = "이용현황ToolStripMenuItem";
            this.이용현황ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.이용현황ToolStripMenuItem.Text = "이용현황";
            // 
            // 매출관련ToolStripMenuItem
            // 
            this.매출관련ToolStripMenuItem.Name = "매출관련ToolStripMenuItem";
            this.매출관련ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.매출관련ToolStripMenuItem.Text = "매출관련";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_multy);
            this.panel1.Controls.Add(this.button_personal);
            this.panel1.Controls.Add(this.button_main);
            this.panel1.Location = new System.Drawing.Point(2, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 56);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 519);
            this.panel2.TabIndex = 2;
            // 
            // 변경내역ToolStripMenuItem
            // 
            this.변경내역ToolStripMenuItem.Name = "변경내역ToolStripMenuItem";
            this.변경내역ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.변경내역ToolStripMenuItem.Text = "변경 내역";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 612);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button_main
            // 
            this.button_main.Location = new System.Drawing.Point(48, 6);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(104, 42);
            this.button_main.TabIndex = 0;
            this.button_main.Text = "Main";
            this.button_main.UseVisualStyleBackColor = true;
            // 
            // button_personal
            // 
            this.button_personal.Location = new System.Drawing.Point(193, 6);
            this.button_personal.Name = "button_personal";
            this.button_personal.Size = new System.Drawing.Size(104, 42);
            this.button_personal.TabIndex = 1;
            this.button_personal.Text = "Personal";
            this.button_personal.UseVisualStyleBackColor = true;
            // 
            // button_multy
            // 
            this.button_multy.Location = new System.Drawing.Point(338, 6);
            this.button_multy.Name = "button_multy";
            this.button_multy.Size = new System.Drawing.Size(104, 42);
            this.button_multy.TabIndex = 2;
            this.button_multy.Text = "Multi_Room";
            this.button_multy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 신규등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이용현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관련ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 변경내역ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_multy;
        private System.Windows.Forms.Button button_personal;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

