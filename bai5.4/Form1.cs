using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace bai5._4
{
    // 1. Class Form1 BẮT BUỘC nằm ĐẦU TIÊN để Visual Studio nhận diện Designer
    public partial class Form1 : Form
    {
        private List<Employee> employeeList = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupListView();
            SetupComboBoxView();
            InitSampleData();
            LoadTreeViewData();

            // Đăng ký sự kiện
            tvDepartments.AfterSelect += tvDepartments_AfterSelect;
            cboView.SelectedIndexChanged += cboView_SelectedIndexChanged;
        }

        // Cấu hình các cột cho ListView
        private void SetupListView()
        {
            lsvEmployees.View = View.Details;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;

            lsvEmployees.Columns.Add("Mã NV", 80);
            lsvEmployees.Columns.Add("Họ Tên", 150);
            lsvEmployees.Columns.Add("Chức vụ", 120);
            lsvEmployees.Columns.Add("Ngày vào làm", 110);
        }

        // Nạp các chế độ xem vào ComboBox
        private void SetupComboBoxView()
        {
            cboView.Items.Clear();
            cboView.Items.AddRange(new string[] { "Details", "LargeIcon", "SmallIcon", "List", "Tile" });
            cboView.SelectedIndex = 0;
        }

        // Khởi tạo dữ liệu mẫu
        private void InitSampleData()
        {
            employeeList = new List<Employee>()
            {
                new Employee { Id = "NV01", Name = "Nguyễn Văn A", Position = "Trưởng phòng", StartDate = new DateTime(2020, 1, 15), DepartmentId = "P_KT" },
                new Employee { Id = "NV02", Name = "Trần Thị B", Position = "Kế toán viên", StartDate = new DateTime(2021, 5, 10), DepartmentId = "N_KTDN" },
                new Employee { Id = "NV03", Name = "Lê Văn C", Position = "Lập trình viên", StartDate = new DateTime(2022, 3, 1), DepartmentId = "N_DEV" },
                new Employee { Id = "NV04", Name = "Phạm Thị D", Position = "Tester", StartDate = new DateTime(2023, 7, 20), DepartmentId = "N_QC" },
                new Employee { Id = "NV05", Name = "Hoàng Văn E", Position = "Giám đốc", StartDate = new DateTime(2018, 1, 1), DepartmentId = "ROOT" }
            };
        }

        // Tạo cây phân cấp dữ liệu cho TreeView
        private void LoadTreeViewData()
        {
            tvDepartments.Nodes.Clear();

            TreeNode rootNode = new TreeNode("Công ty ABC") { Tag = "ROOT", ImageIndex = 0, SelectedImageIndex = 0 };

            TreeNode nodeKT = new TreeNode("Phòng Kế toán") { Tag = "P_KT", ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode nodeKTDN = new TreeNode("Nhóm Kế toán DN") { Tag = "N_KTDN", ImageIndex = 1, SelectedImageIndex = 1 };
            nodeKT.Nodes.Add(nodeKTDN);

            TreeNode nodeIT = new TreeNode("Phòng CNTT") { Tag = "P_IT", ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode nodeDev = new TreeNode("Nhóm Lập trình") { Tag = "N_DEV", ImageIndex = 1, SelectedImageIndex = 1 };
            TreeNode nodeQC = new TreeNode("Nhóm Kiểm thử") { Tag = "N_QC", ImageIndex = 1, SelectedImageIndex = 1 };
            nodeIT.Nodes.Add(nodeDev);
            nodeIT.Nodes.Add(nodeQC);

            rootNode.Nodes.Add(nodeKT);
            rootNode.Nodes.Add(nodeIT);

            tvDepartments.Nodes.Add(rootNode);
            tvDepartments.ExpandAll();
        }

        // Sự kiện khi chọn Node trên TreeView
        private void tvDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            string selectedTag = e.Node.Tag?.ToString();
            DisplayEmployeesByDepartment(selectedTag);
        }

        // Lọc danh sách nhân viên theo Phòng/Nhóm
        private void DisplayEmployeesByDepartment(string deptId)
        {
            lsvEmployees.Items.Clear();

            foreach (var emp in employeeList)
            {
                if (deptId == "ROOT" || emp.DepartmentId == deptId)
                {
                    ListViewItem item = new ListViewItem(emp.Id, 0);
                    item.SubItems.Add(emp.Name);
                    item.SubItems.Add(emp.Position);
                    item.SubItems.Add(emp.StartDate.ToString("dd/MM/yyyy"));

                    lsvEmployees.Items.Add(item);
                }
            }
        }

        // Sự kiện chuyển chế độ xem qua ComboBox
        private void cboView_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboView.SelectedItem.ToString())
            {
                case "Details":
                    lsvEmployees.View = View.Details;
                    break;
                case "LargeIcon":
                    lsvEmployees.View = View.LargeIcon;
                    break;
                case "SmallIcon":
                    lsvEmployees.View = View.SmallIcon;
                    break;
                case "List":
                    lsvEmployees.View = View.List;
                    break;
                case "Tile":
                    lsvEmployees.View = View.Tile;
                    break;
            }
        }
    }

    // 2. Class Employee BẮT BUỘC nằm DƯỚI class Form1
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime StartDate { get; set; }
        public string DepartmentId { get; set; }
    }
}