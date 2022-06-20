namespace Projectlotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Record = new System.Windows.Forms.Button();
            this.Game = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.mainimg = new System.Windows.Forms.PictureBox();
            this.game1 = new Projectlotto.game();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainimg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Record);
            this.panel1.Controls.Add(this.Game);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 486);
            this.panel1.TabIndex = 0;
            // 
            // Record
            // 
            this.Record.BackColor = System.Drawing.Color.Teal;
            this.Record.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Image = ((System.Drawing.Image)(resources.GetObject("Record.Image")));
            this.Record.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Record.Location = new System.Drawing.Point(0, 341);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(155, 96);
            this.Record.TabIndex = 1;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = false;
            // 
            // Game
            // 
            this.Game.BackColor = System.Drawing.Color.Teal;
            this.Game.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Game.Image = ((System.Drawing.Image)(resources.GetObject("Game.Image")));
            this.Game.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Game.Location = new System.Drawing.Point(0, 215);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(155, 96);
            this.Game.TabIndex = 1;
            this.Game.Text = "Game";
            this.Game.UseVisualStyleBackColor = false;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Teal;
            this.Home.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 87);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(155, 96);
            this.Home.TabIndex = 1;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.game1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(155, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 402);
            this.panel2.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(795, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(45, 45);
            this.Exit.TabIndex = 2;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // mainimg
            // 
            this.mainimg.Image = global::Projectlotto.Properties.Resources.lottologo;
            this.mainimg.Location = new System.Drawing.Point(161, 12);
            this.mainimg.Name = "mainimg";
            this.mainimg.Size = new System.Drawing.Size(438, 66);
            this.mainimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainimg.TabIndex = 1;
            this.mainimg.TabStop = false;
            // 
            // game1
            // 
            this.game1.Location = new System.Drawing.Point(0, 0);
            this.game1.Name = "game1";
            this.game1.Size = new System.Drawing.Size(684, 402);
            this.game1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 486);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.mainimg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Game;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox mainimg;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel2;
        private game game1;
    }
}

