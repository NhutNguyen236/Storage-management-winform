namespace QuanLyBanHang
{
    partial class frmHoaDonBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxMaHoaDon = new System.Windows.Forms.ComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxMaKhachHang = new System.Windows.Forms.ComboBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cbxMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHoaDonBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.dgvHoaDonBanHang = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxMaHang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.dgvHoaDonBanHang.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.cbxMaHoaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 850);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(497, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(179, 29);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "&Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(42, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 20);
            this.label16.TabIndex = 28;
            this.label16.Text = "Mã Hóa Đơn";
            // 
            // cbxMaHoaDon
            // 
            this.cbxMaHoaDon.FormattingEnabled = true;
            this.cbxMaHoaDon.Location = new System.Drawing.Point(162, 6);
            this.cbxMaHoaDon.Name = "cbxMaHoaDon";
            this.cbxMaHoaDon.Size = new System.Drawing.Size(291, 28);
            this.cbxMaHoaDon.TabIndex = 27;
            this.cbxMaHoaDon.DropDown += new System.EventHandler(this.cbxMaHoaDon_DropDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1221, 850);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxMaKhachHang);
            this.groupBox1.Controls.Add(this.mtbDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.cbxMaNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHoaDonBan);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbxMaKhachHang
            // 
            this.cbxMaKhachHang.FormattingEnabled = true;
            this.cbxMaKhachHang.Location = new System.Drawing.Point(824, 36);
            this.cbxMaKhachHang.Name = "cbxMaKhachHang";
            this.cbxMaKhachHang.Size = new System.Drawing.Size(291, 28);
            this.cbxMaKhachHang.TabIndex = 26;
            this.cbxMaKhachHang.TextChanged += new System.EventHandler(this.cbxMaKhachHang_TextChanged);
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(824, 138);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.ReadOnly = true;
            this.mtbDienThoai.Size = new System.Drawing.Size(291, 27);
            this.mtbDienThoai.TabIndex = 25;
            this.mtbDienThoai.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbDienThoai_MaskInputRejected);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(824, 104);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(291, 27);
            this.txtDiaChi.TabIndex = 24;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(159, 141);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(291, 27);
            this.txtTenNhanVien.TabIndex = 24;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(824, 70);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(291, 27);
            this.txtTenKhach.TabIndex = 23;
            // 
            // cbxMaNhanVien
            // 
            this.cbxMaNhanVien.FormattingEnabled = true;
            this.cbxMaNhanVien.Location = new System.Drawing.Point(159, 104);
            this.cbxMaNhanVien.Name = "cbxMaNhanVien";
            this.cbxMaNhanVien.Size = new System.Drawing.Size(291, 28);
            this.cbxMaNhanVien.TabIndex = 23;
            this.cbxMaNhanVien.TextChanged += new System.EventHandler(this.cbxMaNhanVien_TextChanged);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(159, 68);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(291, 27);
            this.dtpNgayBan.TabIndex = 14;
            this.dtpNgayBan.ValueChanged += new System.EventHandler(this.dtpNgayBan_ValueChanged);
            // 
            // txtMaHoaDonBan
            // 
            this.txtMaHoaDonBan.Location = new System.Drawing.Point(159, 32);
            this.txtMaHoaDonBan.Name = "txtMaHoaDonBan";
            this.txtMaHoaDonBan.ReadOnly = true;
            this.txtMaHoaDonBan.Size = new System.Drawing.Size(291, 27);
            this.txtMaHoaDonBan.TabIndex = 11;
            this.txtMaHoaDonBan.TextChanged += new System.EventHandler(this.txtMaHoaDon_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(673, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Điện Thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(673, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(673, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Tên Khách Hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDBanHang);
            this.groupBox2.Controls.Add(this.dgvHoaDonBanHang);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1221, 424);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBanHang.Location = new System.Drawing.Point(3, 134);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 29;
            this.dgvHDBanHang.Size = new System.Drawing.Size(1215, 171);
            this.dgvHDBanHang.TabIndex = 3;
            this.dgvHDBanHang.DoubleClick += new System.EventHandler(this.dgvHDBanHang_DoubleClick);
            // 
            // dgvHoaDonBanHang
            // 
            this.dgvHoaDonBanHang.Controls.Add(this.txtTongTien);
            this.dgvHoaDonBanHang.Controls.Add(this.label18);
            this.dgvHoaDonBanHang.Controls.Add(this.lblBangChu);
            this.dgvHoaDonBanHang.Controls.Add(this.label17);
            this.dgvHoaDonBanHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDonBanHang.Location = new System.Drawing.Point(3, 305);
            this.dgvHoaDonBanHang.Name = "dgvHoaDonBanHang";
            this.dgvHoaDonBanHang.Size = new System.Drawing.Size(1215, 59);
            this.dgvHoaDonBanHang.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(760, 23);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(144, 27);
            this.txtTongTien.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(673, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Tổng Tiền:";
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.ForeColor = System.Drawing.Color.Blue;
            this.lblBangChu.Location = new System.Drawing.Point(37, 30);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(78, 20);
            this.lblBangChu.TabIndex = 33;
            this.lblBangChu.Text = "Bằng chữ: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(37, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(173, 20);
            this.label17.TabIndex = 32;
            this.label17.Text = "Nháy đúp 1 dòng để xóa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInHoaDon);
            this.panel3.Controls.Add(this.btnDong);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1215, 57);
            this.panel3.TabIndex = 1;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(657, 6);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(160, 33);
            this.btnInHoaDon.TabIndex = 11;
            this.btnInHoaDon.Text = "&In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(873, 6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(160, 33);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(441, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 33);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "&Hủy Hóa Đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(225, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(160, 33);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(9, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(160, 33);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtGiamGia);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtTenHang);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbxMaHang);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 111);
            this.panel2.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(760, 55);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(144, 27);
            this.txtThanhTien.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(673, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 20);
            this.label15.TabIndex = 35;
            this.label15.Text = "Thành Tiền";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(481, 55);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(144, 27);
            this.txtGiamGia.TabIndex = 32;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Giảm Giá %";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(159, 55);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(144, 27);
            this.txtSoLuong.TabIndex = 30;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(760, 12);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(144, 27);
            this.txtDonGia.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(673, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Đơn Giá";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(481, 8);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(144, 27);
            this.txtTenHang.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Tên Hàng";
            // 
            // cbxMaHang
            // 
            this.cbxMaHang.FormattingEnabled = true;
            this.cbxMaHang.Location = new System.Drawing.Point(159, 7);
            this.cbxMaHang.Name = "cbxMaHang";
            this.cbxMaHang.Size = new System.Drawing.Size(144, 28);
            this.cbxMaHang.TabIndex = 26;
            this.cbxMaHang.TextChanged += new System.EventHandler(this.cbxMaHang_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Mã Hàng";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 905);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDonBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.dgvHoaDonBanHang.ResumeLayout(false);
            this.dgvHoaDonBanHang.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpNgayBan;
        private TextBox txtTenNhanVien;
        private ComboBox cbxMaNhanVien;
        private MaskedTextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private GroupBox groupBox2;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtTenHang;
        private Label label11;
        private ComboBox cbxMaHang;
        private Label label10;
        private TextBox txtDonGia;
        private Label label12;
        private TextBox txtThanhTien;
        private Label label15;
        private TextBox txtGiamGia;
        private Label label14;
        private TextBox txtSoLuong;
        private Label label13;
        private Label label16;
        private ComboBox cbxMaHoaDon;
        private Button btnTimKiem;
        private Panel dgvHoaDonBanHang;
        private DataGridView dgvHDBanHang;
        private Label lblBangChu;
        private Label label17;
        private TextBox txtTongTien;
        private Label label18;
        private Button btnInHoaDon;
        private Button btnDong;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private ComboBox cbxMaKhachHang;
        public TextBox txtMaHoaDonBan;
    }
}