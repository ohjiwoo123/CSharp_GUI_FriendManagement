namespace CSharp_GUI_FriendManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.R_Men_Btn = new System.Windows.Forms.RadioButton();
            this.R_Women_Btn = new System.Windows.Forms.RadioButton();
            this.AddFriend_Btn = new System.Windows.Forms.Button();
            this.RemoveFriend_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "이름 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "나이 : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "성별 : ";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(141, 99);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(131, 21);
            this.NameBox.TabIndex = 5;
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(141, 131);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(131, 21);
            this.AgeBox.TabIndex = 6;
            // 
            // R_Men_Btn
            // 
            this.R_Men_Btn.AutoSize = true;
            this.R_Men_Btn.Location = new System.Drawing.Point(157, 167);
            this.R_Men_Btn.Name = "R_Men_Btn";
            this.R_Men_Btn.Size = new System.Drawing.Size(47, 16);
            this.R_Men_Btn.TabIndex = 7;
            this.R_Men_Btn.TabStop = true;
            this.R_Men_Btn.Text = "남성";
            this.R_Men_Btn.UseVisualStyleBackColor = true;
            // 
            // R_Women_Btn
            // 
            this.R_Women_Btn.AutoSize = true;
            this.R_Women_Btn.Location = new System.Drawing.Point(157, 201);
            this.R_Women_Btn.Name = "R_Women_Btn";
            this.R_Women_Btn.Size = new System.Drawing.Size(47, 16);
            this.R_Women_Btn.TabIndex = 8;
            this.R_Women_Btn.TabStop = true;
            this.R_Women_Btn.Text = "여성";
            this.R_Women_Btn.UseVisualStyleBackColor = true;
            // 
            // AddFriend_Btn
            // 
            this.AddFriend_Btn.Location = new System.Drawing.Point(54, 254);
            this.AddFriend_Btn.Name = "AddFriend_Btn";
            this.AddFriend_Btn.Size = new System.Drawing.Size(142, 114);
            this.AddFriend_Btn.TabIndex = 9;
            this.AddFriend_Btn.Text = "친구추가";
            this.AddFriend_Btn.UseVisualStyleBackColor = true;
            this.AddFriend_Btn.Click += new System.EventHandler(this.AddFriend_Btn_Click);
            // 
            // RemoveFriend_Btn
            // 
            this.RemoveFriend_Btn.Location = new System.Drawing.Point(216, 254);
            this.RemoveFriend_Btn.Name = "RemoveFriend_Btn";
            this.RemoveFriend_Btn.Size = new System.Drawing.Size(142, 114);
            this.RemoveFriend_Btn.TabIndex = 10;
            this.RemoveFriend_Btn.Text = "친구삭제";
            this.RemoveFriend_Btn.UseVisualStyleBackColor = true;
            this.RemoveFriend_Btn.Click += new System.EventHandler(this.RemoveFriend_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoveFriend_Btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddFriend_Btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.R_Women_Btn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.R_Men_Btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AgeBox);
            this.groupBox1.Controls.Add(this.NameBox);
            this.groupBox1.Location = new System.Drawing.Point(64, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 408);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "친구입력";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(665, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 408);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "나이";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "성별";
            this.columnHeader3.Width = 135;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.열기ToolStripMenuItem,
            this.저장ToolStripMenuItem,
            this.toolStripSeparator1,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            this.열기ToolStripMenuItem.Click += new System.EventHandler(this.열기ToolStripMenuItem_Click);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.저장ToolStripMenuItem.Text = "저장";
            this.저장ToolStripMenuItem.Click += new System.EventHandler(this.저장ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.AddFriend_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 645);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.RadioButton R_Men_Btn;
        private System.Windows.Forms.RadioButton R_Women_Btn;
        private System.Windows.Forms.Button AddFriend_Btn;
        private System.Windows.Forms.Button RemoveFriend_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

