namespace đăng_ký_tín_chỉ
{
    partial class UserTinchi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_PhatTrienUD1 = new đăng_ký_tín_chỉ.UC_PhatTrienUD();
            this.grbMIS = new System.Windows.Forms.GroupBox();
            this.dgvMonhoc = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mhp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thp = new System.Windows.Forms.DataGridViewButtonColumn();
            this.stc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sll = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboChuongtrinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grbMIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbMIS);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 542);
            this.panel1.TabIndex = 0;
            // 
            // uC_PhatTrienUD1
            // 
            this.uC_PhatTrienUD1.Location = new System.Drawing.Point(-3, 3);
            this.uC_PhatTrienUD1.Name = "uC_PhatTrienUD1";
            this.uC_PhatTrienUD1.Size = new System.Drawing.Size(838, 608);
            this.uC_PhatTrienUD1.TabIndex = 1;
            this.uC_PhatTrienUD1.Visible = false;
            this.uC_PhatTrienUD1.Load += new System.EventHandler(this.uC_PhatTrienUD1_Load);
            // 
            // grbMIS
            // 
            this.grbMIS.BackColor = System.Drawing.Color.White;
            this.grbMIS.Controls.Add(this.dgvMonhoc);
            this.grbMIS.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMIS.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbMIS.Location = new System.Drawing.Point(26, 89);
            this.grbMIS.Name = "grbMIS";
            this.grbMIS.Size = new System.Drawing.Size(779, 424);
            this.grbMIS.TabIndex = 1;
            this.grbMIS.TabStop = false;
            this.grbMIS.Text = "Các học phần trong chương trình";
            // 
            // dgvMonhoc
            // 
            this.dgvMonhoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonhoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.mhp,
            this.thp,
            this.stc,
            this.sll});
            this.dgvMonhoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonhoc.Location = new System.Drawing.Point(3, 30);
            this.dgvMonhoc.Name = "dgvMonhoc";
            this.dgvMonhoc.RowHeadersWidth = 62;
            this.dgvMonhoc.RowTemplate.Height = 28;
            this.dgvMonhoc.Size = new System.Drawing.Size(773, 391);
            this.dgvMonhoc.TabIndex = 0;
            this.dgvMonhoc.Visible = false;
            this.dgvMonhoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonhoc_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.MinimumWidth = 8;
            this.stt.Name = "stt";
            this.stt.Width = 150;
            // 
            // mhp
            // 
            this.mhp.HeaderText = "Mã học phần";
            this.mhp.MinimumWidth = 8;
            this.mhp.Name = "mhp";
            this.mhp.Width = 150;
            // 
            // thp
            // 
            this.thp.HeaderText = "Tên học phần";
            this.thp.MinimumWidth = 8;
            this.thp.Name = "thp";
            this.thp.Width = 150;
            // 
            // stc
            // 
            this.stc.HeaderText = "STC";
            this.stc.MinimumWidth = 8;
            this.stc.Name = "stc";
            this.stc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.stc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stc.Width = 150;
            // 
            // sll
            // 
            this.sll.HeaderText = "Số lượng lớp";
            this.sll.MinimumWidth = 8;
            this.sll.Name = "sll";
            this.sll.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cboChuongtrinh);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(26, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 62);
            this.panel2.TabIndex = 0;
            // 
            // cboChuongtrinh
            // 
            this.cboChuongtrinh.FormattingEnabled = true;
            this.cboChuongtrinh.Items.AddRange(new object[] {
            "Hệ thống thông tin quản lý 65"});
            this.cboChuongtrinh.Location = new System.Drawing.Point(245, 22);
            this.cboChuongtrinh.Name = "cboChuongtrinh";
            this.cboChuongtrinh.Size = new System.Drawing.Size(402, 28);
            this.cboChuongtrinh.TabIndex = 1;
            this.cboChuongtrinh.SelectedIndexChanged += new System.EventHandler(this.cboChuongtrinh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chương trình đào tạo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG KÝ TÍN CHỈ";
            // 
            // UserTinchi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.uC_PhatTrienUD1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "UserTinchi";
            this.Size = new System.Drawing.Size(838, 612);
            this.Load += new System.EventHandler(this.UserTinchi_Load);
            this.panel1.ResumeLayout(false);
            this.grbMIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonhoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboChuongtrinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbMIS;
        private System.Windows.Forms.DataGridView dgvMonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mhp;
        private System.Windows.Forms.DataGridViewButtonColumn thp;
        private System.Windows.Forms.DataGridViewTextBoxColumn stc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sll;
        private UC_PhatTrienUD uC_PhatTrienUD1;
    }
}
