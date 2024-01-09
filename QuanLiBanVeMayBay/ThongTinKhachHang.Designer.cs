namespace QuanLiBanVeMayBay
{
    partial class ThongTinKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTTKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dataGridViewTTKhachHang
            // 
            this.dataGridViewTTKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTKhachHang.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewTTKhachHang.Name = "dataGridViewTTKhachHang";
            this.dataGridViewTTKhachHang.RowHeadersWidth = 62;
            this.dataGridViewTTKhachHang.RowTemplate.Height = 28;
            this.dataGridViewTTKhachHang.Size = new System.Drawing.Size(776, 322);
            this.dataGridViewTTKhachHang.TabIndex = 1;
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTTKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU THÔNG TIN KHÁCH HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongTinKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.ThongTinKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTTKhachHang;
    }
}