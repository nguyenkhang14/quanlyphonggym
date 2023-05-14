namespace BaiTapCuoiKy
{
    partial class ThongKe
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.lblDungCu = new System.Windows.Forms.Label();
            this.BtnThongKe = new System.Windows.Forms.Button();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng số Khách Hàng hiện có";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng số dụng cụ hiện có";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(361, 66);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(0, 17);
            this.lblKhachHang.TabIndex = 2;
            // 
            // lblDungCu
            // 
            this.lblDungCu.AutoSize = true;
            this.lblDungCu.Location = new System.Drawing.Point(361, 107);
            this.lblDungCu.Name = "lblDungCu";
            this.lblDungCu.Size = new System.Drawing.Size(0, 17);
            this.lblDungCu.TabIndex = 3;
            // 
            // BtnThongKe
            // 
            this.BtnThongKe.Location = new System.Drawing.Point(246, 156);
            this.BtnThongKe.Name = "BtnThongKe";
            this.BtnThongKe.Size = new System.Drawing.Size(126, 23);
            this.BtnThongKe.TabIndex = 4;
            this.BtnThongKe.Text = "Thống Kê";
            this.BtnThongKe.UseVisualStyleBackColor = true;
            this.BtnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.Location = new System.Drawing.Point(246, 205);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(126, 23);
            this.BtnQuayLai.TabIndex = 5;
            this.BtnQuayLai.Text = "Quay Lại";
            this.BtnQuayLai.UseVisualStyleBackColor = true;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 274);
            this.Controls.Add(this.BtnQuayLai);
            this.Controls.Add(this.BtnThongKe);
            this.Controls.Add(this.lblDungCu);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblDungCu;
        private System.Windows.Forms.Button BtnThongKe;
        private System.Windows.Forms.Button BtnQuayLai;
    }
}