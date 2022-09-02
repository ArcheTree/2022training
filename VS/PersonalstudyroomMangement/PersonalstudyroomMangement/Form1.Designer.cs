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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.신규등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이용현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.매출관련ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_multy = new System.Windows.Forms.Button();
            this.button_personal = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_timer = new System.Windows.Forms.Label();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.personalControl1 = new PersonalstudyroomMangement.PersonalControl();
            this.multiControl1 = new PersonalstudyroomMangement.MultiControl();
            this.mainControl1 = new PersonalstudyroomMangement.MainControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.신규등록ToolStripMenuItem,
            this.이용현황ToolStripMenuItem,
            this.매출관련ToolStripMenuItem});
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
            this.신규등록ToolStripMenuItem.Click += new System.EventHandler(this.신규등록ToolStripMenuItem_Click);
            // 
            // 이용현황ToolStripMenuItem
            // 
            this.이용현황ToolStripMenuItem.Name = "이용현황ToolStripMenuItem";
            this.이용현황ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.이용현황ToolStripMenuItem.Text = "이용현황";
            this.이용현황ToolStripMenuItem.Click += new System.EventHandler(this.이용현황ToolStripMenuItem_Click);
            // 
            // 매출관련ToolStripMenuItem
            // 
            this.매출관련ToolStripMenuItem.Name = "매출관련ToolStripMenuItem";
            this.매출관련ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.매출관련ToolStripMenuItem.Text = "매출 보고";
            this.매출관련ToolStripMenuItem.Click += new System.EventHandler(this.매출관련ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_multy);
            this.panel1.Controls.Add(this.button_personal);
            this.panel1.Controls.Add(this.button_main);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 51);
            this.panel1.TabIndex = 1;
            // 
            // button_multy
            // 
            this.button_multy.BackColor = System.Drawing.Color.White;
            this.button_multy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_multy.Location = new System.Drawing.Point(338, 6);
            this.button_multy.Name = "button_multy";
            this.button_multy.Size = new System.Drawing.Size(104, 42);
            this.button_multy.TabIndex = 2;
            this.button_multy.Text = "Multi_Room";
            this.button_multy.UseVisualStyleBackColor = false;
            this.button_multy.Click += new System.EventHandler(this.button_multy_Click);
            // 
            // button_personal
            // 
            this.button_personal.BackColor = System.Drawing.Color.White;
            this.button_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_personal.Location = new System.Drawing.Point(193, 6);
            this.button_personal.Name = "button_personal";
            this.button_personal.Size = new System.Drawing.Size(104, 42);
            this.button_personal.TabIndex = 1;
            this.button_personal.Text = "Personal";
            this.button_personal.UseVisualStyleBackColor = false;
            this.button_personal.Click += new System.EventHandler(this.button_personal_Click);
            // 
            // button_main
            // 
            this.button_main.BackColor = System.Drawing.Color.White;
            this.button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_main.Location = new System.Drawing.Point(48, 6);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(104, 42);
            this.button_main.TabIndex = 0;
            this.button_main.Text = "Main";
            this.button_main.UseVisualStyleBackColor = false;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.personalControl1);
            this.panel2.Controls.Add(this.multiControl1);
            this.panel2.Controls.Add(this.mainControl1);
            this.panel2.Location = new System.Drawing.Point(2, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 519);
            this.panel2.TabIndex = 2;
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(22, 606);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(38, 12);
            this.label_timer.TabIndex = 3;
            this.label_timer.Text = "label1";
            // 
            // timer_main
            // 
            this.timer_main.Enabled = true;
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // personalControl1
            // 
            this.personalControl1.Location = new System.Drawing.Point(0, 0);
            this.personalControl1.Name = "personalControl1";
            this.personalControl1.Size = new System.Drawing.Size(843, 519);
            this.personalControl1.TabIndex = 2;
            // 
            // multiControl1
            // 
            this.multiControl1.Location = new System.Drawing.Point(0, 0);
            this.multiControl1.Name = "multiControl1";
            this.multiControl1.Size = new System.Drawing.Size(843, 519);
            this.multiControl1.TabIndex = 1;
            // 
            // mainControl1
            // 
            this.mainControl1.BackColor = System.Drawing.Color.LightYellow;
            this.mainControl1.Location = new System.Drawing.Point(-1, -1);
            this.mainControl1.Name = "mainControl1";
            this.mainControl1.Size = new System.Drawing.Size(843, 519);
            this.mainControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 633);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "독서실관리";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 신규등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이용현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 매출관련ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_multy;
        private System.Windows.Forms.Button button_personal;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Timer timer_main;
        private MainControl mainControl1;
        private PersonalControl personalControl1;
        private MultiControl multiControl1;
    }
}

