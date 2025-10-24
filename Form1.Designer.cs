namespace đăng_ký_tín_chỉ
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLichsu = new System.Windows.Forms.Button();
            this.btnHocphan = new System.Windows.Forms.Button();
            this.btnTracuu = new System.Windows.Forms.Button();
            this.btnTinchi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucLichsu1 = new đăng_ký_tín_chỉ.UCLichsu();
            this.ucHocphan1 = new đăng_ký_tín_chỉ.UCHocphan();
            this.ucTracuu1 = new đăng_ký_tín_chỉ.UCTracuu();
            this.userTinchi1 = new đăng_ký_tín_chỉ.UserTinchi();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.Controls.Add(this.btnLichsu);
            this.splitContainer1.Panel1.Controls.Add(this.btnHocphan);
            this.splitContainer1.Panel1.Controls.Add(this.btnTracuu);
            this.splitContainer1.Panel1.Controls.Add(this.btnTinchi);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 700);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnLichsu
            // 
            this.btnLichsu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLichsu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLichsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichsu.ForeColor = System.Drawing.Color.White;
            this.btnLichsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichsu.Location = new System.Drawing.Point(33, 543);
            this.btnLichsu.Name = "btnLichsu";
            this.btnLichsu.Size = new System.Drawing.Size(214, 40);
            this.btnLichsu.TabIndex = 7;
            this.btnLichsu.Text = "Lịch sử đăng ký tín chỉ";
            this.btnLichsu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichsu.UseVisualStyleBackColor = false;
            this.btnLichsu.Click += new System.EventHandler(this.btnLichsu_Click);
            // 
            // btnHocphan
            // 
            this.btnHocphan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHocphan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHocphan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocphan.ForeColor = System.Drawing.Color.White;
            this.btnHocphan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocphan.Location = new System.Drawing.Point(33, 491);
            this.btnHocphan.Name = "btnHocphan";
            this.btnHocphan.Size = new System.Drawing.Size(214, 40);
            this.btnHocphan.TabIndex = 6;
            this.btnHocphan.Text = "Học phần tương đương";
            this.btnHocphan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHocphan.UseVisualStyleBackColor = false;
            this.btnHocphan.Click += new System.EventHandler(this.btnHocphan_Click);
            // 
            // btnTracuu
            // 
            this.btnTracuu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTracuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTracuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTracuu.ForeColor = System.Drawing.Color.White;
            this.btnTracuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTracuu.Location = new System.Drawing.Point(33, 439);
            this.btnTracuu.Name = "btnTracuu";
            this.btnTracuu.Size = new System.Drawing.Size(214, 40);
            this.btnTracuu.TabIndex = 5;
            this.btnTracuu.Text = "Tra cứu học phần";
            this.btnTracuu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTracuu.UseVisualStyleBackColor = false;
            this.btnTracuu.Click += new System.EventHandler(this.btnTracuu_Click);
            // 
            // btnTinchi
            // 
            this.btnTinchi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTinchi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinchi.ForeColor = System.Drawing.Color.White;
            this.btnTinchi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinchi.Location = new System.Drawing.Point(33, 387);
            this.btnTinchi.Name = "btnTinchi";
            this.btnTinchi.Size = new System.Drawing.Size(214, 40);
            this.btnTinchi.TabIndex = 4;
            this.btnTinchi.Text = "Đăng ký tín chỉ";
            this.btnTinchi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTinchi.UseVisualStyleBackColor = false;
            this.btnTinchi.Click += new System.EventHandler(this.btnTinchi_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(24, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 136);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(23, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 110);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "   11235542    ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phạm Ngọc Mai Anh";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Image = global::đăng_ký_tín_chỉ.Properties.Resources.user_vector_icon_profile_illustration_260nw_1588646515_preview_rev_1;
            this.pictureBox2.Location = new System.Drawing.Point(72, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(33, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 42);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHỨC NĂNG";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = global::đăng_ký_tín_chỉ.Properties.Resources.images_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(92, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel5.Controls.Add(this.ucLichsu1);
            this.panel5.Controls.Add(this.ucHocphan1);
            this.panel5.Controls.Add(this.ucTracuu1);
            this.panel5.Controls.Add(this.userTinchi1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 88);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(838, 612);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 88);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::đăng_ký_tín_chỉ.Properties.Resources.user_vector_icon_profile_illustration_260nw_1588646515_preview_rev_1;
            this.pictureBox4.Location = new System.Drawing.Point(696, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::đăng_ký_tín_chỉ.Properties.Resources._1f1fb_1f1f3;
            this.pictureBox3.Location = new System.Drawing.Point(657, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẠI HỌC KINH TẾ QUỐC DÂN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ucLichsu1
            // 
            this.ucLichsu1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucLichsu1.Location = new System.Drawing.Point(0, -3);
            this.ucLichsu1.Name = "ucLichsu1";
            this.ucLichsu1.Size = new System.Drawing.Size(838, 612);
            this.ucLichsu1.TabIndex = 3;
            // 
            // ucHocphan1
            // 
            this.ucHocphan1.Location = new System.Drawing.Point(0, -3);
            this.ucHocphan1.Name = "ucHocphan1";
            this.ucHocphan1.Size = new System.Drawing.Size(838, 612);
            this.ucHocphan1.TabIndex = 2;
            // 
            // ucTracuu1
            // 
            this.ucTracuu1.Location = new System.Drawing.Point(0, -3);
            this.ucTracuu1.Name = "ucTracuu1";
            this.ucTracuu1.Size = new System.Drawing.Size(838, 612);
            this.ucTracuu1.TabIndex = 1;
            // 
            // userTinchi1
            // 
            this.userTinchi1.Location = new System.Drawing.Point(0, 0);
            this.userTinchi1.Name = "userTinchi1";
            this.userTinchi1.Size = new System.Drawing.Size(838, 612);
            this.userTinchi1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 700);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLichsu;
        private System.Windows.Forms.Button btnHocphan;
        private System.Windows.Forms.Button btnTracuu;
        private System.Windows.Forms.Button btnTinchi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private UserTinchi userTinchi1;
        private UCTracuu ucTracuu1;
        private UCLichsu ucLichsu1;
        private UCHocphan ucHocphan1;
    }
}

