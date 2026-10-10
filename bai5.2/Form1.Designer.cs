namespace bai5._2
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
            grpSelect = new GroupBox();
            lblCategory = new Label();
            cboCategory = new ComboBox();
            lblAvailable = new Label();
            lstAvailableServices = new ListBox();
            btnSelect = new Button();
            btnRemove = new Button();
            btnClearAll = new Button();
            grpSelected = new GroupBox();
            lblSelected = new Label();
            lstSelectedServices = new ListBox();
            lblSubTotal = new Label();
            txtDiscount = new TextBox();
            ldlDiscount = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTotal = new TextBox();
            grpSelect.SuspendLayout();
            grpSelected.SuspendLayout();
            SuspendLayout();
            // 
            // grpSelect
            // 
            grpSelect.Controls.Add(lblCategory);
            grpSelect.Controls.Add(cboCategory);
            grpSelect.Controls.Add(lblAvailable);
            grpSelect.Controls.Add(lstAvailableServices);
            grpSelect.Location = new Point(12, 19);
            grpSelect.Name = "grpSelect";
            grpSelect.Size = new Size(306, 419);
            grpSelect.TabIndex = 0;
            grpSelect.TabStop = false;
            grpSelect.Text = "Chọn dịch vụ";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(20, 36);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(88, 20);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Loại dịch vụ";
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(20, 71);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 2;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged_1;
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(20, 112);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(128, 20);
            lblAvailable.TabIndex = 3;
            lblAvailable.Text = "Danh sách dịch vụ";
            // 
            // lstAvailableServices
            // 
            lstAvailableServices.FormattingEnabled = true;
            lstAvailableServices.Location = new Point(20, 145);
            lstAvailableServices.Name = "lstAvailableServices";
            lstAvailableServices.Size = new Size(280, 264);
            lstAvailableServices.TabIndex = 4;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(348, 409);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 29);
            btnSelect.TabIndex = 5;
            btnSelect.Text = "Thêm";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(452, 409);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Bỏ";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(552, 409);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(94, 29);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "Xóa tất cả";
            btnClearAll.UseVisualStyleBackColor = true;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // grpSelected
            // 
            grpSelected.Controls.Add(lblSelected);
            grpSelected.Controls.Add(lstSelectedServices);
            grpSelected.Location = new Point(348, 19);
            grpSelected.Name = "grpSelected";
            grpSelected.Size = new Size(440, 210);
            grpSelected.TabIndex = 8;
            grpSelected.TabStop = false;
            grpSelected.Text = "Dịch vụ đã chọn và thanh toán";
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(6, 36);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(115, 20);
            lblSelected.TabIndex = 9;
            lblSelected.Text = "Dịch vụ đã chọn";
            // 
            // lstSelectedServices
            // 
            lstSelectedServices.FormattingEnabled = true;
            lstSelectedServices.Location = new Point(6, 59);
            lstSelectedServices.Name = "lstSelectedServices";
            lstSelectedServices.Size = new Size(428, 144);
            lstSelectedServices.TabIndex = 10;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(348, 256);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(146, 20);
            lblSubTotal.TabIndex = 11;
            lblSubTotal.Text = "Tổng tiền chưa giảm";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(521, 304);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 12;
            txtDiscount.Text = ":\"0\"";
            // 
            // ldlDiscount
            // 
            ldlDiscount.AutoSize = true;
            ldlDiscount.Location = new Point(348, 304);
            ldlDiscount.Name = "ldlDiscount";
            ldlDiscount.Size = new Size(105, 20);
            ldlDiscount.TabIndex = 13;
            ldlDiscount.Text = "tỉ lệ chiết khấu";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(348, 351);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(153, 20);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Thành tiền thanh toán";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(521, 253);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(125, 27);
            txtSubTotal.TabIndex = 15;
            txtSubTotal.Text = ":\"0\"";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(521, 351);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 16;
            txtTotal.Text = ":\"0\"";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(ldlDiscount);
            Controls.Add(txtDiscount);
            Controls.Add(lblSubTotal);
            Controls.Add(grpSelected);
            Controls.Add(btnClearAll);
            Controls.Add(btnRemove);
            Controls.Add(btnSelect);
            Controls.Add(grpSelect);
            Name = "Form1";
            Text = "Form1";
            grpSelect.ResumeLayout(false);
            grpSelect.PerformLayout();
            grpSelected.ResumeLayout(false);
            grpSelected.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpSelect;
        private Label lblCategory;
        private ComboBox cboCategory;
        private Label lblAvailable;
        private ListBox lstAvailableServices;
        private Button btnSelect;
        private Button btnRemove;
        private Button btnClearAll;
        private GroupBox grpSelected;
        private Label lblSelected;
        private ListBox lstSelectedServices;
        private Label lblSubTotal;
        private TextBox txtDiscount;
        private Label ldlDiscount;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTotal;
    }
}
