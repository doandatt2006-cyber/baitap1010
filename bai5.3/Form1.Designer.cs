namespace bai5._3
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
            groupBox1 = new GroupBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCategory);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(116, 167);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(125, 27);
            txtCategory.TabIndex = 9;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(119, 130);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(117, 94);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(125, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(113, 61);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 6;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(106, 26);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 167);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 4;
            label5.Text = "Danh mục :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 122);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Số Lượng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 90);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 58);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên SP :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã SP :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnEdit);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(349, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(349, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(166, 172);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(28, 170);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(28, 117);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(28, 77);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 28);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(57, 277);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(300, 188);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvProducts;
    }
}
