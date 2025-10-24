using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đăng_ký_tín_chỉ
{
    public partial class UC_PhatTrienUD : UserControl
    {
        public UC_PhatTrienUD()
        {
            InitializeComponent();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string lop = "";

            if (rdbLop1.Checked)
                lop = rdbLop1.Text;       // lấy đúng nội dung Text của RadioButton
            else if (rdbLop2.Checked)
                lop = rdbLop2.Text;

            if (lop == "")
            {
                MessageBox.Show("Vui lòng chọn lớp học phần trước khi đăng ký!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Bạn đã đăng ký thành công " + lop,
                            "Đăng ký",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn quay lại?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Lấy Form chứa UserControl này
                Form1 f = this.FindForm() as Form1;
                if (f != null)
                {
                    // Ẩn user control hiện tại
                    this.Visible = false;

                    // Hiện lại user control chính
                  
                }
            }
        }
    }
}
