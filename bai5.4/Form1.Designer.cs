namespace bai5._4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            tvDepartments = new TreeView();
            panel1 = new Panel();
            label1 = new Label();
            cboView = new ComboBox();
            lsvEmployees = new ListView();
            imgListTree = new ImageList(components);
            imgListSmall = new ImageList(components);
            imgListLarge = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tvDepartments);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lsvEmployees);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 0;
            // 
            // tvDepartments
            // 
            tvDepartments.Dock = DockStyle.Fill;
            tvDepartments.ImageIndex = 0;
            tvDepartments.ImageList = imgListTree;
            tvDepartments.Location = new Point(0, 0);
            tvDepartments.Name = "tvDepartments";
            tvDepartments.SelectedImageIndex = 0;
            tvDepartments.Size = new Size(250, 450);
            tvDepartments.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboView);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 40);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Chế độ xem :";
            // 
            // cboView
            // 
            cboView.DropDownStyle = ComboBoxStyle.DropDownList;
            cboView.FormattingEnabled = true;
            cboView.Location = new Point(115, 15);
            cboView.Name = "cboView";
            cboView.Size = new Size(151, 28);
            cboView.TabIndex = 1;
            // 
            // lsvEmployees
            // 
            lsvEmployees.Dock = DockStyle.Fill;
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.GridLines = true;
            lsvEmployees.LargeImageList = imgListLarge;
            lsvEmployees.Location = new Point(0, 40);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(546, 410);
            lsvEmployees.SmallImageList = imgListSmall;
            lsvEmployees.TabIndex = 1;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.View = View.Details;
            // 
            // imgListTree
            // 
            imgListTree.ColorDepth = ColorDepth.Depth32Bit;
            imgListTree.ImageStream = (ImageListStreamer)resources.GetObject("imgListTree.ImageStream");
            imgListTree.TransparentColor = Color.Transparent;
            imgListTree.Images.SetKeyName(0, "Anh-den-thanh-pho-lung-linh-trong-dem.jpg");
            imgListTree.Images.SetKeyName(1, "Screenshot (3).png");
            imgListTree.Images.SetKeyName(2, "Capture.PNG");
            // 
            // imgListSmall
            // 
            imgListSmall.ColorDepth = ColorDepth.Depth32Bit;
            imgListSmall.ImageStream = (ImageListStreamer)resources.GetObject("imgListSmall.ImageStream");
            imgListSmall.TransparentColor = Color.Transparent;
            imgListSmall.Images.SetKeyName(0, "ảnh mn trong nhóm.jpg");
            // 
            // imgListLarge
            // 
            imgListLarge.ColorDepth = ColorDepth.Depth32Bit;
            imgListLarge.ImageStream = (ImageListStreamer)resources.GetObject("imgListLarge.ImageStream");
            imgListLarge.TransparentColor = Color.Transparent;
            imgListLarge.Images.SetKeyName(0, "e khóc à.PNG");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView tvDepartments;
        private Panel panel1;
        private Label label1;
        private ListView lsvEmployees;
        private ComboBox cboView;
        private ImageList imgListTree;
        private ImageList imgListSmall;
        private ImageList imgListLarge;
    }
}
