using QuanLyBanHang.Class;
using System.Data;

namespace QuanLyBanHang
{
    public partial class frmHoaDonBan : Form
    {
        DataTable tblCTHDB; //Bảng chi tiết hoá đơn bán
        public frmHoaDonBan()
        {
            InitializeComponent();
        }
        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtMaHoaDon.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhach.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            mtbDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            Functions.FillCombo("SELECT MaKhach, TenKhach FROM tblKhach", cbxMaKhachHang, "MaKhach", "MaKhach");
            cbxMaKhachHang.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNhanVien, TenNhanVien FROM tblNhanVien", cbxMaNhanVien, "MaNhanVien", "TenKhach");
            cbxMaNhanVien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHang, TenHang FROM tblHang", cbxMaHang, "MaHang", "MaHang");
            cbxMaHang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtMaHoaDon.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM tblChiTietHDBan AS a, tblHang AS b WHERE a.MaHDBan = N'" + txtMaHoaDon.Text + "' AND a.MaHang=b.MaHang";
            tblCTHDB = Functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 80;
            dgvHDBanHang.Columns[1].Width = 130;
            dgvHDBanHang.Columns[2].Width = 80;
            dgvHDBanHang.Columns[3].Width = 90;
            dgvHDBanHang.Columns[4].Width = 90;
            dgvHDBanHang.Columns[5].Width = 90;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM tblHDBan WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'";
            dtpNgayBan.Value = DateTime.Parse(Functions.GetFieldValues(str));
            str = "SELECT MaNhanVien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'";
            cbxMaNhanVien.Text = Functions.GetFieldValues(str);
            str = "SELECT MaKhach FROM tblHDBan WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'";
            cbxMaKhachHang.Text = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
            lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(txtTongTien.Text);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHoaDon.Text = Functions.CreateKey("HDB");
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtMaHoaDon.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            cbxMaNhanVien.Text = "";
            cbxMaKhachHang.Text = "";
            txtTongTien.Text = "0";
            lblBangChu.Text = "Bằng chữ: ";
            cbxMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHDBan FROM tblHDBan WHERE MaHDBan=N'" + txtMaHoaDon.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (dtpNgayBan.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpNgayBan.Focus();
                    return;
                }
                if (cbxMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxMaNhanVien.Focus();
                    return;
                }
                if (cbxMaKhachHang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxMaKhachHang.Focus();
                    return;
                }
                sql = "INSERT INTO tblHDBan(MaHDBan, NgayBan, MaNhanVien, MaKhach, TongTien) VALUES (N'" + txtMaHoaDon.Text.Trim() + "','" +
                        dtpNgayBan.Value + "',N'" + cbxMaNhanVien.SelectedValue + "',N'" +
                        cbxMaKhachHang.SelectedValue + "'," + txtTongTien.Text + ")";
                Functions.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbxMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbxMaHang.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            if (txtGiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamGia.Focus();
                return;
            }
            sql = "SELECT MaHang FROM tblChiTietHDBan WHERE MaHang=N'" + cbxMaHang.SelectedValue + "' AND MaHDBan = N'" + txtMaHoaDon.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbxMaHang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHang WHERE MaHang = N'" + cbxMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO tblChiTietHDBan(MaHDBan,MaHang,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + txtMaHoaDon.Text.Trim() + "',N'" + cbxMaHang.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGia.Text + "," + txtGiamGia.Text + "," + txtThanhTien.Text + ")";
            Functions.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE tblHang SET SoLuong =" + SLcon + " WHERE MaHang= N'" + cbxMaHang.SelectedValue + "'";
            Functions.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE tblHDBan SET TongTien =" + Tongmoi + " WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(Tongmoi.ToString());
            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
        }
        private void ResetValuesHang()
        {
            cbxMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void cbxMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbxMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGia.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT TenHang FROM tblHang WHERE MaHang =N'" + cbxMaHang.SelectedValue + "'";
            txtTenHang.Text = Functions.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM tblHang WHERE MaHang =N'" + cbxMaHang.SelectedValue + "'";
            cbxMaHang.Text = Functions.GetFieldValues(str);

        }

        private void cbxMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbxMaKhachHang.Text == "")
            {
                txtTenKhach.Text = "";
                txtDiaChi.Text = "";
                mtbDienThoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select TenKhach from tblKhach where MaKhach = N'" + cbxMaKhachHang.SelectedValue + "'";
            txtTenKhach.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from tblKhach where MaKhach = N'" + cbxMaKhachHang.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai from tblKhach where MaKhach= N'" + cbxMaKhachHang.SelectedValue + "'";
            mtbDienThoai.Text = Functions.GetFieldValues(str);
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgayBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbxMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtbDienThoai_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvHDBanHang_DoubleClick(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            Double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
            if (tblCTHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dgvHDBanHang.CurrentRow.Cells["MaHang"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHDBanHang.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sql = "DELETE tblChiTietHDBan WHERE MaHDBan=N'" + txtMaHoaDon.Text + "' AND MaHang = N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM tblHang WHERE MaHang = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tblHang SET SoLuong =" + slcon + " WHERE MaHang= N'" + MaHangxoa + "'";
                Functions.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM tblHDBan WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblHDBan SET TongTien =" + tongmoi + " WHERE MaHDBan = N'" + txtMaHoaDon.Text + "'";
                Functions.RunSQL(sql);
                txtTongTien.Text = tongmoi.ToString();
                lblBangChu.Text = "Bằng chữ: " + Functions.ChuyenSoSangChu(tongmoi.ToString());
                LoadDataGridView();
            }
        }
    }
}
