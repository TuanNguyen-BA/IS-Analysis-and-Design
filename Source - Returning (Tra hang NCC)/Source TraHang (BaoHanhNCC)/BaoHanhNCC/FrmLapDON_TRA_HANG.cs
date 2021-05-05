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
    public partial class FrmLapDON_TRA_HANG : Form
    {
        public FrmLapDON_TRA_HANG()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemDTH frm = new FrmThemDTH();

            frm.ShowDialog();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện txtMaDTH nhập vào:

            if (txtMaDTH.Text == "" || txtMaDTH.Text == null || txtMaDTH.Text.Length > 5)
            {
                MessageBox.Show("Thông tin mã đơn trả hàng cần xem không hợp lệ!!!");
                return;
            }

            DataTable list = DonTraHangBUS.Read(txtMaDTH.Text);

            dgvLapDTH.DataSource = list;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện txtMaDTH nhập vào:

            if (txtMaDTH.Text == "" || txtMaDTH.Text == null || txtMaDTH.Text.Length > 5)
            {
                MessageBox.Show("Thông tin mã đơn trả hàng cần xóa không hợp lệ!!!");
                return;
            }

            string maDTH = txtMaDTH.Text;
            int n = DonTraHangBUS.Delete(maDTH);
            MessageBox.Show(n.ToString() + " rows deleted !!!");

            // Cập nhật dgv:
            dgvLapDTH.DataSource = DonTraHangBUS.LoadDonTraHang();
        }

        private void FrmLapDON_TRA_HANG_Load(object sender, EventArgs e)
        {
            dgvLapDTH.DataSource = DonTraHangBUS.LoadDonTraHang();
        }

        private void btnXemTKMH_Click(object sender, EventArgs e)
        {
            List<CTThongKeMH_DTO> list = CTThongKeMH_BUS.Display();

            dgvLapDTH.DataSource = list;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra điều kiện txtMaDTH nhập vào:

            if (txtMaDTH.Text == "" || txtMaDTH.Text == null || txtMaDTH.Text.Length > 5)
            {
                MessageBox.Show("Thông tin mã đơn trả hàng cần sửa không hợp lệ!!!");
                return;
            }

            FrmSuaDTH frm = new FrmSuaDTH();
            frm.maDTH_Sua = txtMaDTH.Text;
            frm.ShowDialog();
        }

        private void dgvLapDTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
