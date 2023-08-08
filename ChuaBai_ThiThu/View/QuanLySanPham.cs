using ChuaBai_ThiThu.Controller.Service;
using ChuaBai_ThiThu.DomainClass;
using ChuaBai_ThiThu.Mod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuaBai_ThiThu.View
{
    public partial class QuanLySanPham : Form
    {
        SanPhamService _service = new SanPhamService();
        List<Guid> _lstIDLoaiSP = new List<Guid>();
        Guid? _idSanPhamWhenClick;
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadDataGrid(null);
        }
        public void LoadComboBox()
        {
            cmbTrangThai.Items.Add("Hoạt động hoặc không hoạt động");
            cmbTrangThai.Items.Add("Hoạt động");
            cmbTrangThai.Items.Add("Không hoạt động");
            cmbTrangThai.SelectedIndex = 0;
            foreach (var item in _service.GetLoaiSP())
            {
                _lstIDLoaiSP.Add(item.Id);
                cmbLoaiSP.Items.Add(item.Ten);
            }
            cmbLoaiSP.SelectedIndex = 0;
        }
        public void LoadDataGrid(string? find)
        {
            int stt = 1;
            Type type = typeof(SanPham);
            dgvSanPham.ColumnCount = type.GetProperties().Length + 1;
            dgvSanPham.Columns[0].Name = "STT";
            dgvSanPham.Columns[1].Name = "Tên";
            dgvSanPham.Columns[2].Name = "Số lượng";
            dgvSanPham.Columns[3].Name = "Trạng thái";
            dgvSanPham.Columns[4].Name = "Loại sản phẩm";
            dgvSanPham.Columns[5].Name = "IDSanPham";
            dgvSanPham.Columns[5].Visible = false;
            dgvSanPham.Columns[6].Name = "Website";
            dgvSanPham.Rows.Clear();
            foreach (var item in _service.GetSanPhams(find))
            {
                var result = _service.GetLoaiSP().FirstOrDefault(x => x.Id == item.IdLoaiSp);
                dgvSanPham.Rows.Add(stt++, item.Ten, item.SoLuong,
                    (item.TrangThai == 0 ? "Không hoạt đông" : "Có hoạt động"),
                    (result != null ? result.Ten : "Vô danh"), item.Id, item.Website);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckRegexText())
            {
                SanPham newSP = new SanPham()
                {
                    Ten = txtTen.Text,
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    Website = txtWeb.Text,
                };

                if (cmbTrangThai.SelectedIndex == 1)
                {
                    newSP.TrangThai = 1;
                }
                else
                {
                    newSP.TrangThai = 0;
                }
                newSP.IdLoaiSp = _lstIDLoaiSP[cmbLoaiSP.SelectedIndex];
                _service.AddSanPham(newSP);
            }
            LoadDataGrid(null);
            //_idSanPhamWhenClick = null;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index == _service.GetSanPhams(null).Count)
            {
                return;
            }
            _idSanPhamWhenClick = Guid.Parse(dgvSanPham.Rows[index].Cells[5].Value.ToString());
            var sanPham = _service.GetSanPhams(null).First(x => x.Id == _idSanPhamWhenClick);
            txtTen.Text = sanPham.Ten;
            txtWeb.Text = sanPham.Website;
            txtSoLuong.Text = sanPham.SoLuong.ToString();
            if (sanPham.TrangThai == 0)
            {
                cmbTrangThai.SelectedIndex = 2;
            }
            else
            {
                cmbTrangThai.SelectedIndex = 1;
            }
            int indexLoaiSP = _lstIDLoaiSP.FindIndex(x => x == sanPham.IdLoaiSp);
            if (indexLoaiSP < 0)
            {
                cmbLoaiSP.SelectedIndex = -1;
            }
            else
            {
                cmbLoaiSP.SelectedIndex = indexLoaiSP;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(CheckRegexText())
            {
                SanPhamMod updateSP = new SanPhamMod()
                {
                    Ten = txtTen.Text,
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    Website = txtWeb.Text,
                };
                if (cmbTrangThai.SelectedIndex == 0)
                {
                    MessageBox.Show("Không thêm được");
                    return;
                }
                else if (cmbTrangThai.SelectedIndex == 1)
                {
                    updateSP.TrangThai = 1;
                }
                else
                {
                    updateSP.TrangThai = 0;
                }
                updateSP.IdLoaiSP = _lstIDLoaiSP[cmbLoaiSP.SelectedIndex];
                if (_idSanPhamWhenClick == null)
                {
                    MessageBox.Show("Không sửa được");
                    return;
                }
                _service.UpdateSanPham(_idSanPhamWhenClick, updateSP);
            }
            LoadDataGrid(null);
            _idSanPhamWhenClick = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.RemoveSanPham(_idSanPhamWhenClick);
            LoadDataGrid(null);
            _idSanPhamWhenClick = null;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Length == 0 || txtTimKiem.Text == null)
            {
                LoadDataGrid(null);
            }
            else
            {
                LoadDataGrid(txtTimKiem.Text);
            }
        }
        public bool CheckRegexText()
        {
            err.SetError(txtTen, "");
            err.SetError(txtSoLuong, "");
            err.SetError(txtWeb, "");
            err.SetError(cmbTrangThai, "");
            if(txtTen.Text.Length == 0)
            {
                err.SetError(txtTen, "Không được bỏ trống");
                return false;
            }
            if(txtWeb.Text.Length == 0)
            {
                err.SetError(txtWeb, "Không được bỏ trống");
                return false;
            }
            else if(!Regex.IsMatch(txtWeb.Text,@"^[\w\d]+\.com$"))
            {
                err.SetError(txtWeb, "Phải có .com");
                return false;
            }
            if(txtSoLuong.Text.Length == 0)
            {
                err.SetError(txtSoLuong, "Không được bỏ trống");
                return false;
            }
            else if (!Regex.IsMatch(txtSoLuong.Text, @"^[\d]+$"))
            {
                err.SetError(txtSoLuong, "Chỉ được nhập số");
                return false;
            }
            if(cmbTrangThai.SelectedIndex == 0)
            {
                err.SetError(cmbTrangThai, "Phải chọn trạng thái");
                return false;
            }
            return true;
        }
    }
}
