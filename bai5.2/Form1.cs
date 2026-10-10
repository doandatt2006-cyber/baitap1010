using System;
using System.Windows.Forms;

namespace bai5._2
{
    public partial class Form1 : Form
    {
        public class ServiceItem
        {
            public string Name { get; set; }
            public decimal Price { get; set; }

            public ServiceItem(string name, decimal price)
            {
                Name = name;
                Price = price;
            }

            public override string ToString()
            {
                return $"{Name} - {Price:N0} VNĐ";
            }
        }

        public Form1()
        {
            InitializeComponent();

            // Tự động gán lại sự kiện
            this.Load += Form1_Load;
            cboCategory.SelectedIndexChanged += cboCategory_SelectedIndexChanged;
            btnSelect.Click += btnSelect_Click;
            btnRemove.Click += btnRemove_Click;
            btnClearAll.Click += btnClearAll_Click;
            lstAvailableServices.MouseDoubleClick += lstAvailableServices_MouseDoubleClick;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
        }

        // --- HÀM KHẮC PHỤC LỖI RÁC TỪ DESIGNER ---
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void cboCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboCategory_SelectedIndexChanged(sender, e);
        }

        // --- XỬ LÝ LOGIC CHÍNH ---
        private void Form1_Load(object sender, EventArgs e)
        {
            cboCategory.Items.Clear();
            cboCategory.Items.Add("Khám bệnh");
            cboCategory.Items.Add("Xét nghiệm");
            cboCategory.Items.Add("Chụp X-Quang");
            cboCategory.Items.Add("Vắc-xin");

            cboCategory.SelectedIndex = 0;
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAvailableServices.Items.Clear();
            if (cboCategory.SelectedItem == null) return;

            string selectedCategory = cboCategory.SelectedItem.ToString();

            switch (selectedCategory)
            {
                case "Khám bệnh":
                    lstAvailableServices.Items.Add(new ServiceItem("Khám tổng quát", 150000));
                    lstAvailableServices.Items.Add(new ServiceItem("Khám chuyên khoa", 250000));
                    lstAvailableServices.Items.Add(new ServiceItem("Tư vấn sức khỏe", 100000));
                    break;
                case "Xét nghiệm":
                    lstAvailableServices.Items.Add(new ServiceItem("Xét nghiệm máu", 200000));
                    lstAvailableServices.Items.Add(new ServiceItem("Xét nghiệm nước tiểu", 120000));
                    lstAvailableServices.Items.Add(new ServiceItem("Xét nghiệm COVID-19", 150000));
                    break;
                case "Chụp X-Quang":
                    lstAvailableServices.Items.Add(new ServiceItem("Chụp X-Quang Ngực", 250000));
                    lstAvailableServices.Items.Add(new ServiceItem("Chụp X-Quang Cột sống", 300000));
                    break;
                case "Vắc-xin":
                    lstAvailableServices.Items.Add(new ServiceItem("Tiêm Vắc-xin Cúm", 350000));
                    lstAvailableServices.Items.Add(new ServiceItem("Tiêm Vắc-xin Viêm gan B", 250000));
                    break;
            }
        }

        private void AddSelectedService()
        {
            if (lstAvailableServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Add(lstAvailableServices.SelectedItem);
                CalculateTotal();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AddSelectedService();
        }

        private void lstAvailableServices_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddSelectedService();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelectedServices.SelectedItem != null)
            {
                lstSelectedServices.Items.Remove(lstSelectedServices.SelectedItem);
                CalculateTotal();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            lstSelectedServices.Items.Clear();
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal subTotal = 0;

            foreach (ServiceItem item in lstSelectedServices.Items)
            {
                subTotal += item.Price;
            }

            decimal discountPercent = 0;
            decimal.TryParse(txtDiscount.Text, out discountPercent);

            decimal total = subTotal * (1 - (discountPercent / 100));

            txtSubTotal.Text = subTotal.ToString("N0");
            txtTotal.Text = total.ToString("N0");
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }
    }
}