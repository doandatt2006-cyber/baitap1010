using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace bai5._3
{
    public partial class Form1 : Form
    {
        // Khai báo danh sách sản phẩm và BindingSource
        private List<Product> listProducts = new List<Product>();
        private BindingSource bindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        // 1. Sự kiện Load Form - Khởi tạo liên kết dữ liệu
        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = listProducts;
            dgvProducts.DataSource = bindingSource;
        }

        // Cập nhật lại giao diện DataGridView
        private void RefreshGrid()
        {
            bindingSource.ResetBindings(false);
        }

        // Xóa trắng các ô nhập liệu
        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtCategory.Clear();
            txtProductId.Focus();
        }

        // 2. Chức năng Nút Thêm (Kiểm tra đầy đủ điều kiện)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra không được bỏ trống ô nào
            if (string.IsNullOrWhiteSpace(txtProductId.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tất cả các ô!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng Mã SP
            if (listProducts.Any(p => p.ProductId.Equals(txtProductId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng số cho Đơn giá và Số lượng
            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ (>= 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên hợp lệ (>= 0)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tạo đối tượng và thêm vào danh sách
            Product newProduct = new Product
            {
                ProductId = txtProductId.Text.Trim(),
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = price,
                Quantity = qty,
                Category = txtCategory.Text.Trim()
            };

            listProducts.Add(newProduct);
            RefreshGrid();
            ClearInputs();
            MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Đẩy dữ liệu dòng chọn ngược lên ô nhập liệu
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProducts.Rows.Count)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                txtProductId.Text = row.Cells["ProductId"].Value?.ToString();
                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
                txtCategory.Text = row.Cells["Category"].Value?.ToString();
            }
        }

        // 4. Chức năng Nút Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtProductId.Text.Trim();
            Product p = listProducts.FirstOrDefault(x => x.ProductId.Equals(id, StringComparison.OrdinalIgnoreCase));

            if (p != null)
            {
                if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) || price < 0 ||
                    !int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
                {
                    MessageBox.Show("Đơn giá hoặc Số lượng không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                p.ProductName = txtProductName.Text.Trim();
                p.UnitPrice = price;
                p.Quantity = qty;
                p.Category = txtCategory.Text.Trim();

                RefreshGrid();
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Mã SP cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 5. Chức năng Nút Xóa (Xác nhận MessageBox)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null || dgvProducts.CurrentRow.Index < 0)
            {
                MessageBox.Show("Vui lòng chọn dòng sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sản phẩm này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                string id = dgvProducts.CurrentRow.Cells["ProductId"].Value?.ToString();
                Product p = listProducts.FirstOrDefault(x => x.ProductId == id);
                if (p != null)
                {
                    listProducts.Remove(p);
                    RefreshGrid();
                    ClearInputs();
                    MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // 6. Chức năng Nút Tìm kiếm (theo Tên SP)
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                bindingSource.DataSource = listProducts;
            }
            else
            {
                var searchResult = listProducts.Where(p => p.ProductName.ToLower().Contains(keyword)).ToList();
                bindingSource.DataSource = searchResult;
            }
            RefreshGrid();
        }
    }
}