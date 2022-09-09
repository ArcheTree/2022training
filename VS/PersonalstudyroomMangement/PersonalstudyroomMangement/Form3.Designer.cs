namespace PersonalstudyroomMangement
{
    partial class Form_now
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
            this.groupBox_serch = new System.Windows.Forms.GroupBox();
            this.button_serch = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_now = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seatMngBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_serch.SuspendLayout();
            this.groupBox_now.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatMngBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_serch
            // 
            this.groupBox_serch.Controls.Add(this.button_serch);
            this.groupBox_serch.Controls.Add(this.textBox3);
            this.groupBox_serch.Controls.Add(this.textBox2);
            this.groupBox_serch.Controls.Add(this.textBox1);
            this.groupBox_serch.Controls.Add(this.label3);
            this.groupBox_serch.Controls.Add(this.label2);
            this.groupBox_serch.Controls.Add(this.label1);
            this.groupBox_serch.Location = new System.Drawing.Point(14, 15);
            this.groupBox_serch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_serch.Name = "groupBox_serch";
            this.groupBox_serch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_serch.Size = new System.Drawing.Size(889, 62);
            this.groupBox_serch.TabIndex = 0;
            this.groupBox_serch.TabStop = false;
            this.groupBox_serch.Text = "검색";
            // 
            // button_serch
            // 
            this.button_serch.Location = new System.Drawing.Point(586, 16);
            this.button_serch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_serch.Name = "button_serch";
            this.button_serch.Size = new System.Drawing.Size(114, 36);
            this.button_serch.TabIndex = 6;
            this.button_serch.Text = "검색";
            this.button_serch.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(432, 21);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 25);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 21);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 25);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 25);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "연락처 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // groupBox_now
            // 
            this.groupBox_now.Controls.Add(this.dataGridView1);
            this.groupBox_now.Location = new System.Drawing.Point(14, 85);
            this.groupBox_now.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_now.Name = "groupBox_now";
            this.groupBox_now.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_now.Size = new System.Drawing.Size(889, 514);
            this.groupBox_now.TabIndex = 1;
            this.groupBox_now.TabStop = false;
            this.groupBox_now.Text = "등록현황";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumDataGridViewTextBoxColumn,
            this.seatNumDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.startdayDataGridViewTextBoxColumn,
            this.enddayDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seatMngBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(881, 485);
            this.dataGridView1.TabIndex = 0;
            // 
            // seatMngBindingSource
            // 
            this.seatMngBindingSource.DataSource = typeof(PersonalstudyroomMangement.seatMng);
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "roomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "roomNum";
            this.roomNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            this.roomNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // seatNumDataGridViewTextBoxColumn
            // 
            this.seatNumDataGridViewTextBoxColumn.DataPropertyName = "seatNum";
            this.seatNumDataGridViewTextBoxColumn.HeaderText = "seatNum";
            this.seatNumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.seatNumDataGridViewTextBoxColumn.Name = "seatNumDataGridViewTextBoxColumn";
            this.seatNumDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // startdayDataGridViewTextBoxColumn
            // 
            this.startdayDataGridViewTextBoxColumn.DataPropertyName = "startday";
            this.startdayDataGridViewTextBoxColumn.HeaderText = "startday";
            this.startdayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdayDataGridViewTextBoxColumn.Name = "startdayDataGridViewTextBoxColumn";
            this.startdayDataGridViewTextBoxColumn.Width = 125;
            // 
            // enddayDataGridViewTextBoxColumn
            // 
            this.enddayDataGridViewTextBoxColumn.DataPropertyName = "endday";
            this.enddayDataGridViewTextBoxColumn.HeaderText = "endday";
            this.enddayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.enddayDataGridViewTextBoxColumn.Name = "enddayDataGridViewTextBoxColumn";
            this.enddayDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form_now
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 614);
            this.Controls.Add(this.groupBox_now);
            this.Controls.Add(this.groupBox_serch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_now";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "등록확인";
            this.groupBox_serch.ResumeLayout(false);
            this.groupBox_serch.PerformLayout();
            this.groupBox_now.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatMngBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_serch;
        private System.Windows.Forms.GroupBox groupBox_now;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_serch;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddayDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seatMngBindingSource;
    }
}