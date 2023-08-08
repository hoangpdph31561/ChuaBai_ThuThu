namespace ChuaBai_ThiThu.View
{
    partial class QuanLySanPham
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cmbLoaiSP = new ComboBox();
            cmbTrangThai = new ComboBox();
            txtSoLuong = new TextBox();
            txtWeb = new TextBox();
            txtTen = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox3 = new GroupBox();
            dgvSanPham = new DataGridView();
            txtTimKiem = new TextBox();
            lablel6 = new Label();
            err = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbLoaiSP);
            groupBox1.Controls.Add(cmbTrangThai);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtWeb);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbLoaiSP
            // 
            cmbLoaiSP.FormattingEnabled = true;
            cmbLoaiSP.Location = new Point(164, 222);
            cmbLoaiSP.Name = "cmbLoaiSP";
            cmbLoaiSP.Size = new Size(230, 28);
            cmbLoaiSP.TabIndex = 9;
            // 
            // cmbTrangThai
            // 
            cmbTrangThai.FormattingEnabled = true;
            cmbTrangThai.Location = new Point(164, 181);
            cmbTrangThai.Name = "cmbTrangThai";
            cmbTrangThai.Size = new Size(230, 28);
            cmbTrangThai.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(164, 135);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(230, 27);
            txtSoLuong.TabIndex = 7;
            // 
            // txtWeb
            // 
            txtWeb.Location = new Point(164, 89);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(230, 27);
            txtWeb.TabIndex = 6;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(164, 43);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(230, 27);
            txtTen.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 230);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 4;
            label5.Text = "Loại SP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 184);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 138);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Website";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 46);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(501, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 285);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(89, 238);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(89, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(89, 114);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 52);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSanPham);
            groupBox3.Controls.Add(txtTimKiem);
            groupBox3.Controls.Add(lablel6);
            groupBox3.Location = new Point(12, 303);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 294);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(44, 80);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 29;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(712, 188);
            dgvSanPham.TabIndex = 2;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(286, 37);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên để loại trừ";
            txtTimKiem.Size = new Size(367, 27);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // lablel6
            // 
            lablel6.AutoSize = true;
            lablel6.Location = new Point(97, 44);
            lablel6.Name = "lablel6";
            lablel6.Size = new Size(70, 20);
            lablel6.TabIndex = 0;
            lablel6.Text = "Tìm kiếm";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 609);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "QuanLySanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuanLySanPham";
            Load += QuanLySanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox cmbLoaiSP;
        private ComboBox cmbTrangThai;
        private TextBox txtSoLuong;
        private TextBox txtWeb;
        private TextBox txtTen;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvSanPham;
        private TextBox txtTimKiem;
        private Label lablel6;
        private ErrorProvider err;
    }
}