namespace QuanLiBanVeMayBay
{
    partial class DoanhThu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimTatCa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeSau = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTruoc = new System.Windows.Forms.DateTimePicker();
            this.btnTong = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewDoanhThu = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimTatCa);
            this.groupBox1.Controls.Add(this.btnTim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimeSau);
            this.groupBox1.Controls.Add(this.dateTimeTruoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(389, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo doanh thu:";
            // 
            // btnTimTatCa
            // 
            this.btnTimTatCa.Location = new System.Drawing.Point(232, 135);
            this.btnTimTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimTatCa.Name = "btnTimTatCa";
            this.btnTimTatCa.Size = new System.Drawing.Size(136, 38);
            this.btnTimTatCa.TabIndex = 5;
            this.btnTimTatCa.Text = "Tìm tất cả";
            this.btnTimTatCa.UseVisualStyleBackColor = true;
            this.btnTimTatCa.Click += new System.EventHandler(this.btnTimTatCa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(13, 135);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(136, 38);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ:";
            // 
            // dateTimeSau
            // 
            this.dateTimeSau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeSau.Location = new System.Drawing.Point(133, 84);
            this.dateTimeSau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeSau.Name = "dateTimeSau";
            this.dateTimeSau.Size = new System.Drawing.Size(184, 30);
            this.dateTimeSau.TabIndex = 1;
            // 
            // dateTimeTruoc
            // 
            this.dateTimeTruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTruoc.Location = new System.Drawing.Point(133, 44);
            this.dateTimeTruoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeTruoc.Name = "dateTimeTruoc";
            this.dateTimeTruoc.Size = new System.Drawing.Size(184, 30);
            this.dateTimeTruoc.TabIndex = 0;
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(417, 145);
            this.btnTong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(152, 38);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tính tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(417, 76);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(240, 40);
            this.txtTongTien.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "VND";
            // 
            // dataGridViewDoanhThu
            // 
            this.dataGridViewDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoanhThu.Location = new System.Drawing.Point(11, 208);
            this.dataGridViewDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDoanhThu.Name = "dataGridViewDoanhThu";
            this.dataGridViewDoanhThu.RowHeadersWidth = 62;
            this.dataGridViewDoanhThu.RowTemplate.Height = 28;
            this.dataGridViewDoanhThu.Size = new System.Drawing.Size(720, 143);
            this.dataGridViewDoanhThu.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(576, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xuất Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDoanhThu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ DOANH THU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoanhThu_FormClosed);
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTimTatCa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeSau;
        private System.Windows.Forms.DateTimePicker dateTimeTruoc;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewDoanhThu;
        private System.Windows.Forms.Button button1;
    }
}