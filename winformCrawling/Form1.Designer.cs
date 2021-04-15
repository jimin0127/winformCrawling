namespace winformCrawling
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxPW = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.pboxMain = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tboxUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tboxNow = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();


            this.tboxID.Location = new System.Drawing.Point(65, 30);
            this.tboxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxID.Name = "tboxID";
            this.tboxID.Size = new System.Drawing.Size(122, 23);
            this.tboxID.TabIndex = 0;


            this.tboxPW.Location = new System.Drawing.Point(65, 61);
            this.tboxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxPW.Name = "tboxPW";
            this.tboxPW.PasswordChar = '*';
            this.tboxPW.Size = new System.Drawing.Size(122, 23);
            this.tboxPW.TabIndex = 0;


            this.btnLogin.Location = new System.Drawing.Point(209, 30);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(88, 58);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);


            this.btnSearch.Location = new System.Drawing.Point(221, 24);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 24);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);


            this.tboxSearch.Location = new System.Drawing.Point(65, 24);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(150, 23);
            this.tboxSearch.TabIndex = 0;


            this.pboxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxMain.Location = new System.Drawing.Point(21, 24);
            this.pboxMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pboxMain.Name = "pboxMain";
            this.pboxMain.Size = new System.Drawing.Size(293, 367);
            this.pboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxMain.TabIndex = 2;
            this.pboxMain.TabStop = false;


            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(143, 404);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "/ 0";


            this.btnPre.Location = new System.Drawing.Point(42, 399);
            this.btnPre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(60, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "◀";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);


            this.btnNext.Location = new System.Drawing.Point(236, 399);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(60, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "▶";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);


            this.tboxUrl.Location = new System.Drawing.Point(65, 61);
            this.tboxUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxUrl.Multiline = true;
            this.tboxUrl.Name = "tboxUrl";
            this.tboxUrl.Size = new System.Drawing.Size(244, 252);
            this.tboxUrl.TabIndex = 0;


            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxID);
            this.groupBox1.Controls.Add(this.tboxPW);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(333, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. 특정 Site Login";


            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "PW :";


            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";


            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tboxSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.tboxUrl);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(333, 329);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.1. 이미지 검색";


            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "URL :";


            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "검색어 :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tboxNow);
            this.groupBox3.Controls.Add(this.pboxMain);
            this.groupBox3.Controls.Add(this.btnPre);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.btnGo);
            this.groupBox3.Controls.Add(this.btnNext);
            this.groupBox3.Location = new System.Drawing.Point(351, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(320, 442);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2.2. 이미지 검색 상세";


            this.tboxNow.Location = new System.Drawing.Point(109, 399);
            this.tboxNow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNow.Name = "tboxNow";
            this.tboxNow.Size = new System.Drawing.Size(28, 23);
            this.tboxNow.TabIndex = 3;
            this.tboxNow.Text = "0";
            this.tboxNow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;


            this.btnGo.Location = new System.Drawing.Point(170, 399);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(60, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox tboxID;
        private System.Windows.Forms.TextBox tboxPW;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.PictureBox pboxMain;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tboxUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tboxNow;
        private System.Windows.Forms.Button btnGo;
    }
}

