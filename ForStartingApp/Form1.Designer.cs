
namespace ForStartingApp
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
            this.btnPutty = new System.Windows.Forms.Button();
            this.btnFilezilla = new System.Windows.Forms.Button();
            this.btnMobaXterm = new System.Windows.Forms.Button();
            this.btnMobaXtermPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxMobaXtermPath = new System.Windows.Forms.TextBox();
            this.tBoxFileZillaPath = new System.Windows.Forms.TextBox();
            this.tBoxPuttyPath = new System.Windows.Forms.TextBox();
            this.btnPuttyPath = new System.Windows.Forms.Button();
            this.btnFileZillaPath = new System.Windows.Forms.Button();
            this.pBoxGreen = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxIp = new System.Windows.Forms.TextBox();
            this.tBoxPassword = new System.Windows.Forms.TextBox();
            this.tBoxUserName = new System.Windows.Forms.TextBox();
            this.pBoxRed = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPutty
            // 
            this.btnPutty.Location = new System.Drawing.Point(671, 387);
            this.btnPutty.Name = "btnPutty";
            this.btnPutty.Size = new System.Drawing.Size(168, 104);
            this.btnPutty.TabIndex = 0;
            this.btnPutty.Text = "Putty";
            this.btnPutty.UseVisualStyleBackColor = true;
            this.btnPutty.Click += new System.EventHandler(this.btnPutty_Click);
            // 
            // btnFilezilla
            // 
            this.btnFilezilla.Location = new System.Drawing.Point(845, 387);
            this.btnFilezilla.Name = "btnFilezilla";
            this.btnFilezilla.Size = new System.Drawing.Size(168, 104);
            this.btnFilezilla.TabIndex = 8;
            this.btnFilezilla.Text = "FileZilla";
            this.btnFilezilla.UseVisualStyleBackColor = true;
            this.btnFilezilla.Click += new System.EventHandler(this.btnFilezilla_Click);
            // 
            // btnMobaXterm
            // 
            this.btnMobaXterm.Location = new System.Drawing.Point(1019, 387);
            this.btnMobaXterm.Name = "btnMobaXterm";
            this.btnMobaXterm.Size = new System.Drawing.Size(168, 104);
            this.btnMobaXterm.TabIndex = 9;
            this.btnMobaXterm.Text = "MobaXterm";
            this.btnMobaXterm.UseVisualStyleBackColor = true;
            this.btnMobaXterm.Click += new System.EventHandler(this.btnMobaXterm_Click);
            // 
            // btnMobaXtermPath
            // 
            this.btnMobaXtermPath.Location = new System.Drawing.Point(316, 143);
            this.btnMobaXtermPath.Name = "btnMobaXtermPath";
            this.btnMobaXtermPath.Size = new System.Drawing.Size(70, 28);
            this.btnMobaXtermPath.TabIndex = 12;
            this.btnMobaXtermPath.Text = "설정";
            this.btnMobaXtermPath.UseVisualStyleBackColor = true;
            this.btnMobaXtermPath.Click += new System.EventHandler(this.btnMobaXtermPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBoxMobaXtermPath);
            this.groupBox1.Controls.Add(this.tBoxFileZillaPath);
            this.groupBox1.Controls.Add(this.tBoxPuttyPath);
            this.groupBox1.Controls.Add(this.btnPuttyPath);
            this.groupBox1.Controls.Add(this.btnFileZillaPath);
            this.groupBox1.Controls.Add(this.btnMobaXtermPath);
            this.groupBox1.Location = new System.Drawing.Point(33, 293);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 198);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "MobaXterm 경로";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "FileZilla 경로";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Putty 경로";
            // 
            // tBoxMobaXtermPath
            // 
            this.tBoxMobaXtermPath.Location = new System.Drawing.Point(126, 143);
            this.tBoxMobaXtermPath.Name = "tBoxMobaXtermPath";
            this.tBoxMobaXtermPath.ReadOnly = true;
            this.tBoxMobaXtermPath.Size = new System.Drawing.Size(158, 25);
            this.tBoxMobaXtermPath.TabIndex = 17;
            // 
            // tBoxFileZillaPath
            // 
            this.tBoxFileZillaPath.Location = new System.Drawing.Point(126, 97);
            this.tBoxFileZillaPath.Name = "tBoxFileZillaPath";
            this.tBoxFileZillaPath.ReadOnly = true;
            this.tBoxFileZillaPath.Size = new System.Drawing.Size(158, 25);
            this.tBoxFileZillaPath.TabIndex = 16;
            // 
            // tBoxPuttyPath
            // 
            this.tBoxPuttyPath.Location = new System.Drawing.Point(126, 47);
            this.tBoxPuttyPath.Name = "tBoxPuttyPath";
            this.tBoxPuttyPath.ReadOnly = true;
            this.tBoxPuttyPath.Size = new System.Drawing.Size(158, 25);
            this.tBoxPuttyPath.TabIndex = 15;
            // 
            // btnPuttyPath
            // 
            this.btnPuttyPath.Location = new System.Drawing.Point(316, 47);
            this.btnPuttyPath.Name = "btnPuttyPath";
            this.btnPuttyPath.Size = new System.Drawing.Size(70, 25);
            this.btnPuttyPath.TabIndex = 14;
            this.btnPuttyPath.Text = "설정";
            this.btnPuttyPath.UseVisualStyleBackColor = true;
            this.btnPuttyPath.Click += new System.EventHandler(this.btnPuttyPath_Click_Click);
            // 
            // btnFileZillaPath
            // 
            this.btnFileZillaPath.Location = new System.Drawing.Point(316, 97);
            this.btnFileZillaPath.Name = "btnFileZillaPath";
            this.btnFileZillaPath.Size = new System.Drawing.Size(70, 25);
            this.btnFileZillaPath.TabIndex = 13;
            this.btnFileZillaPath.Text = "설정";
            this.btnFileZillaPath.UseVisualStyleBackColor = true;
            this.btnFileZillaPath.Click += new System.EventHandler(this.btnFileZillaPath_Click);
            // 
            // pBoxGreen
            // 
            this.pBoxGreen.Image = global::ForStartingApp.Properties.Resources.Green_Light_PNG_Transparent_Image;
            this.pBoxGreen.Location = new System.Drawing.Point(1129, 12);
            this.pBoxGreen.Name = "pBoxGreen";
            this.pBoxGreen.Size = new System.Drawing.Size(73, 55);
            this.pBoxGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxGreen.TabIndex = 15;
            this.pBoxGreen.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegist);
            this.groupBox2.Controls.Add(this.tBoxUserName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tBoxPassword);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tBoxIp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(33, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 184);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "접속 정보";
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(364, 119);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(88, 55);
            this.btnRegist.TabIndex = 23;
            this.btnRegist.Text = "등록";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "IP주소";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "비밀번호";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "아이디";
            // 
            // tBoxIp
            // 
            this.tBoxIp.Location = new System.Drawing.Point(97, 77);
            this.tBoxIp.Name = "tBoxIp";
            this.tBoxIp.Size = new System.Drawing.Size(251, 25);
            this.tBoxIp.TabIndex = 2;
            // 
            // tBoxPassword
            // 
            this.tBoxPassword.Location = new System.Drawing.Point(97, 149);
            this.tBoxPassword.Name = "tBoxPassword";
            this.tBoxPassword.PasswordChar = '*';
            this.tBoxPassword.Size = new System.Drawing.Size(251, 25);
            this.tBoxPassword.TabIndex = 3;
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Location = new System.Drawing.Point(97, 43);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.Size = new System.Drawing.Size(251, 25);
            this.tBoxUserName.TabIndex = 1;
            // 
            // pBoxRed
            // 
            this.pBoxRed.Image = global::ForStartingApp.Properties.Resources.Light_Effect_Transparent_Background;
            this.pBoxRed.Location = new System.Drawing.Point(1129, 12);
            this.pBoxRed.Name = "pBoxRed";
            this.pBoxRed.Size = new System.Drawing.Size(73, 55);
            this.pBoxRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxRed.TabIndex = 17;
            this.pBoxRed.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("나눔고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblState.Location = new System.Drawing.Point(1050, 24);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(93, 32);
            this.lblState.TabIndex = 18;
            this.lblState.Text = "미등록";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 512);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pBoxRed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pBoxGreen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMobaXterm);
            this.Controls.Add(this.btnFilezilla);
            this.Controls.Add(this.btnPutty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxGreen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPutty;
        private System.Windows.Forms.Button btnFilezilla;
        private System.Windows.Forms.Button btnMobaXterm;
        private System.Windows.Forms.Button btnMobaXtermPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPuttyPath;
        private System.Windows.Forms.Button btnFileZillaPath;
        public System.Windows.Forms.TextBox tBoxMobaXtermPath;
        public System.Windows.Forms.TextBox tBoxFileZillaPath;
        public System.Windows.Forms.TextBox tBoxPuttyPath;
        private System.Windows.Forms.PictureBox pBoxGreen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pBoxRed;
        private System.Windows.Forms.Label lblState;
        public System.Windows.Forms.TextBox tBoxUserName;
        public System.Windows.Forms.TextBox tBoxIp;
    }
}

