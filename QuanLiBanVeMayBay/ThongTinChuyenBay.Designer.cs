namespace QuanLiBanVeMayBay
{
    partial class ThongTinChuyenBay
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
            this.dataGridViewTTChuyenBay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTChuyenBay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CHUYẾN BAY";
            // 
            // dataGridViewTTChuyenBay
            // 
            this.dataGridViewTTChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTChuyenBay.Location = new System.Drawing.Point(12, 118);
            this.dataGridViewTTChuyenBay.Name = "dataGridViewTTChuyenBay";
            this.dataGridViewTTChuyenBay.RowHeadersWidth = 62;
            this.dataGridViewTTChuyenBay.RowTemplate.Height = 28;
            this.dataGridViewTTChuyenBay.Size = new System.Drawing.Size(776, 320);
            this.dataGridViewTTChuyenBay.TabIndex = 1;
            // 
            // ThongTinChuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTTChuyenBay);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinChuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU THÔNG TIN CHUYẾN BAY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongTinChuyenBay_FormClosed);
            this.Load += new System.EventHandler(this.ThongTinChuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTChuyenBay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTTChuyenBay;
    }
}