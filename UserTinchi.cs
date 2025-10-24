using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // Thêm thư viện để làm việc với SQL Server
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace đăng_ký_tín_chỉ
{
    public partial class UserTinchi : UserControl
    {
        //sqlconnection connection; // đối tượng kết nối
        //sqlcommand command; // đối tượng thực thi câu lệnh sql
        //string str = @"data source=admin-pc;initial catalog=qlmonhoc;integrated security=true;trust server certificate=true"; // chuỗi kết nối
        //sqldataadapter adapter = new sqldataadapter(); // đối tượng điều phối dữ liệu
        //datatable table = new datatable(); // đối tượng bảng dữ liệu

        //void loaddata ()
        //{
        //    command = connection.createcommand(); // tạo đối tượng command
        //    command.commandtext = "select * from thongtinmonhoc"; // câu lệnh sql
        //    adapter.selectcommand = command; // chỉ định đối tượng command
        //    table.clear(); // xóa dữ liệu trong bảng
        //    adapter.fill(table); // đổ dữ liệu từ adapter vào bảng
        //    dgvmonhoc.datasource = table; // hiển thị dữ liệu lên datagridview
        //}

        public UserTinchi()
        {
            InitializeComponent();

            // Ẩn DataGridView ban đầu
            dgvMonhoc.Visible = false;

            // Gán sự kiện cho ComboBox (nếu chưa gán trong thiết kế)
            cboChuongtrinh.SelectedIndexChanged += cboChuongtrinh_SelectedIndexChanged;
        }

        private void cboChuongtrinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // kiểm tra nếu có mục được chọn
            if (cboChuongtrinh.SelectedItem != null)
            {
                //loaddata(); // gọi hàm load dữ liệu
                dgvMonhoc.Visible = true; // hiển thị datagridview khi có mục được chọn
            }
        }


        private void UserTinchi_Load(object sender, EventArgs e)
        {
            try
            {
                // Đảm bảo DataGridView đã được thêm vào form (từ Designer)
                if (dgvMonhoc == null)
                {
                    dgvMonhoc = new DataGridView();
                    dgvMonhoc.Name = "dgvMonHoc";
                    dgvMonhoc.Dock = DockStyle.Fill;
                    this.Controls.Add(dgvMonhoc); // Thêm vào form nếu chưa có
                }
                {


                    // Xử lý sự kiện khi nhấn Button
                    dgvMonhoc.CellContentClick += dgvMonhoc_CellContentClick;

                    // Thêm dữ liệu
                    dgvMonhoc.Rows.Add(1, "TIHT1113", "Phát triển các ứng dụng trong quản lý", 3, 2);
                    dgvMonhoc.Rows.Add(2, "TIHT1105", "Lập trình nâng cao", 3, 3);
                    dgvMonhoc.Rows.Add(3, "TIKT1117", "Tin học kế toán", 3, 4);
                    dgvMonhoc.Rows.Add(4, "TIKT1122", "Tri thức kinh doanh", 3, 2);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi khởi tạo DataGridView: " + ex.Message);
            }
        }

        private void dgvMonhoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMonhoc.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                string tenMon = dgvMonhoc.Rows[e.RowIndex]
                                     .Cells[e.ColumnIndex]
                                     .Value.ToString();


                switch (tenMon)
                {
                    case "Phát triển các ứng dụng trong quản lý":
                       uC_PhatTrienUD1.Visible = true;
                        break;
                    
                }
            }
        }

        private void uC_PhatTrienUD1_Load(object sender, EventArgs e)
        {

        }
    }
}
