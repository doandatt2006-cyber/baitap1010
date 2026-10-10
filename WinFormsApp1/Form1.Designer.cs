namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtTenDN = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdoNam = new RadioButton();
            chkDieuKhoan = new CheckBox();
            epCheck = new ErrorProvider(components);
            btnDangKy = new Button();
            btnLamMoi = new Button();
            rdoNu = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)epCheck).BeginInit();
            SuspendLayout();
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(50, 45);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(125, 27);
            txtTenDN.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(50, 78);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(125, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(50, 111);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(125, 27);
            txtXacNhanMK.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(32, 144);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 3;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(50, 187);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(62, 24);
            rdoNam.TabIndex = 4;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // chkDieuKhoan
            // 
            chkDieuKhoan.AutoSize = true;
            chkDieuKhoan.Location = new Point(46, 221);
            chkDieuKhoan.Name = "chkDieuKhoan";
            chkDieuKhoan.Size = new Size(207, 24);
            chkDieuKhoan.TabIndex = 5;
            chkDieuKhoan.Text = "Đồng ý điều khoản dịch vụ";
            chkDieuKhoan.UseVisualStyleBackColor = true;
            // 
            // epCheck
            // 
            epCheck.ContainerControl = this;
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(81, 258);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(94, 29);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(85, 306);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(173, 187);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(50, 24);
            rdoNu.TabIndex = 8;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(250, 48);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 9;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 78);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 10;
            label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 107);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 11;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rdoNu);
            Controls.Add(btnLamMoi);
            Controls.Add(btnDangKy);
            Controls.Add(chkDieuKhoan);
            Controls.Add(rdoNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDN);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)epCheck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDN;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdoNam;
        private CheckBox chkDieuKhoan;
        private ErrorProvider epCheck;
        private Button btnLamMoi;
        private Button btnDangKy;
        private RadioButton rdoNu;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
