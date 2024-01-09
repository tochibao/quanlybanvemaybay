namespace QuanLiBanVeMayBay
{
    partial class LichBay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichBay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.dateTimeNgayGio = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoLuongHangVe2 = new System.Windows.Forms.TextBox();
            this.txtSoLuongHangVe1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbSanBayDen = new System.Windows.Forms.ComboBox();
            this.cbbSanBayDi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLichBay = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichBay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaChuyenBay);
            this.groupBox1.Controls.Add(this.dateTimeNgayGio);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoLuongHangVe2);
            this.groupBox1.Controls.Add(this.txtSoLuongHangVe1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbSanBayDen);
            this.groupBox1.Controls.Add(this.cbbSanBayDi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtThoiGianBay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(603, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Mã chuyến bay:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.Location = new System.Drawing.Point(301, 31);
            this.txtMaChuyenBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaChuyenBay.Multiline = true;
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.Size = new System.Drawing.Size(229, 25);
            this.txtMaChuyenBay.TabIndex = 52;
            // 
            // dateTimeNgayGio
            // 
            this.dateTimeNgayGio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayGio.Location = new System.Drawing.Point(301, 151);
            this.dateTimeNgayGio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeNgayGio.Name = "dateTimeNgayGio";
            this.dateTimeNgayGio.Size = new System.Drawing.Size(228, 26);
            this.dateTimeNgayGio.TabIndex = 50;
            this.dateTimeNgayGio.ValueChanged += new System.EventHandler(this.dateTimeNgayGio_ValueChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(489, 317);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(97, 31);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(180, 317);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 31);
            this.btnSua.TabIndex = 48;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(339, 317);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 31);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 317);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 31);
            this.btnThem.TabIndex = 46;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Moccasin;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(101, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 27);
            this.button2.TabIndex = 45;
            this.button2.Text = "Sân Bay Đến:";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Moccasin;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(101, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 26);
            this.button1.TabIndex = 44;
            this.button1.Text = "Sân Bay Đi:";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Moccasin;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 277);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 26);
            this.label8.TabIndex = 43;
            this.label8.Text = "Số lượng hạng vé 2:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoLuongHangVe2
            // 
            this.txtSoLuongHangVe2.Location = new System.Drawing.Point(302, 277);
            this.txtSoLuongHangVe2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongHangVe2.Multiline = true;
            this.txtSoLuongHangVe2.Name = "txtSoLuongHangVe2";
            this.txtSoLuongHangVe2.Size = new System.Drawing.Size(229, 27);
            this.txtSoLuongHangVe2.TabIndex = 42;
            // 
            // txtSoLuongHangVe1
            // 
            this.txtSoLuongHangVe1.Location = new System.Drawing.Point(301, 234);
            this.txtSoLuongHangVe1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongHangVe1.Multiline = true;
            this.txtSoLuongHangVe1.Name = "txtSoLuongHangVe1";
            this.txtSoLuongHangVe1.Size = new System.Drawing.Size(229, 27);
            this.txtSoLuongHangVe1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Moccasin;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 234);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "Số lượng hạng vé 1:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, -30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 21);
            this.textBox1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, -30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã Chuyến Bay:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbSanBayDen
            // 
            this.cbbSanBayDen.FormattingEnabled = true;
            this.cbbSanBayDen.Location = new System.Drawing.Point(302, 108);
            this.cbbSanBayDen.Name = "cbbSanBayDen";
            this.cbbSanBayDen.Size = new System.Drawing.Size(229, 28);
            this.cbbSanBayDen.TabIndex = 37;
            // 
            // cbbSanBayDi
            // 
            this.cbbSanBayDi.FormattingEnabled = true;
            this.cbbSanBayDi.Location = new System.Drawing.Point(302, 70);
            this.cbbSanBayDi.Name = "cbbSanBayDi";
            this.cbbSanBayDi.Size = new System.Drawing.Size(229, 28);
            this.cbbSanBayDi.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Moccasin;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ngày giờ:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Moccasin;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(103, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "Thời Gian Bay:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Location = new System.Drawing.Point(301, 190);
            this.txtThoiGianBay.Margin = new System.Windows.Forms.Padding(4);
            this.txtThoiGianBay.Multiline = true;
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(229, 25);
            this.txtThoiGianBay.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewLichBay);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 367);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(603, 116);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lịch Bay:";
            // 
            // dataGridViewLichBay
            // 
            this.dataGridViewLichBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichBay.Location = new System.Drawing.Point(4, 19);
            this.dataGridViewLichBay.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewLichBay.Name = "dataGridViewLichBay";
            this.dataGridViewLichBay.RowHeadersWidth = 62;
            this.dataGridViewLichBay.RowTemplate.Height = 28;
            this.dataGridViewLichBay.Size = new System.Drawing.Size(595, 138);
            this.dataGridViewLichBay.TabIndex = 0;
            this.dataGridViewLichBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLichBay_CellClick);
            // 
            // LichBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(619, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LichBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ LỊCH BAY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LichBay_FormClosed);
            this.Load += new System.EventHandler(this.LichBay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichBay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoLuongHangVe2;
        private System.Windows.Forms.TextBox txtSoLuongHangVe1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbSanBayDen;
        private System.Windows.Forms.ComboBox cbbSanBayDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewLichBay;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateTimeNgayGio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
    }
}