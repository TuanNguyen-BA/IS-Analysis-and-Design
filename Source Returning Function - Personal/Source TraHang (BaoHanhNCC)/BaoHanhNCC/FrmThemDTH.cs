using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoHanhNCC
{
    public partial class FrmThemDTH : Form
    {
        public FrmThemDTH()
        {
            InitializeComponent();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện txtMaDTH nhập vào:

            if (txtMaDTH.Text == "" || txtMaDTH.Text == null || txtMaDTH.Text.Length > 5)
            {
                MessageBox.Show("Thông tin mã đơn trả hàng cần thêm không hợp lệ!!!");
                return;
            }

            DonTraHangDTO p = new DonTraHangDTO();
            p.MaDTH = txtMaDTH.Text;
            p.NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
            p.NVLapDon = cbbNVLapDon.Text;
            p.MaNCC = cbbMaNCC.Text;

            // Handle BUS class to add data:
            int n = DonTraHangBUS.Insert(p);
            if (n > 0)
            {
                MessageBox.Show("Insert successfully!!!");
            }
            else
            {
                MessageBox.Show("Failed !!!");
            }
        }

        private void FrmThemDTH_Load(object sender, EventArgs e)
        {
            // Load lên ComboBox NHAN_VIEN:
            cbbNVLapDon.DisplayMember = "MaNV";
            cbbNVLapDon.DataSource = DonTraHangBUS.LoadNhanVienCbb();
            cbbNVLapDon.SelectedIndex = -1;

            // Load lên ComboBox NHA_CUNG_CAP:
            cbbMaNCC.DisplayMember = "MaNCC";
            cbbMaNCC.DataSource = DonTraHangBUS.LoadNhaCungCapCbb();
            cbbMaNCC.SelectedIndex = -1;
        }

        private void btnThemCT_DTH_Click(object sender, EventArgs e)
        {
            FrmThemCT_DTH frm = new FrmThemCT_DTH();
            frm.maDTH = txtMaDTH.Text;
            frm.ShowDialog();
        }

        private void cbbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbNVLapDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaDTH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //private void cbbNVLapDon_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string nv = cbbNVLapDon.Text;
        //}
    }
}
