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
    public partial class FrmSuaDTH : Form
    {
        public FrmSuaDTH()
        {
            InitializeComponent();
        }

        public string maDTH_Sua;

        private void FrmSuaDTH_Load(object sender, EventArgs e)
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

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string MaDTH = maDTH_Sua;
            string NgayLap = dtpNgayLap.Value.ToString("yyyy-MM-dd");
            string NVLapDon = cbbNVLapDon.Text;
            string MaNCC = cbbMaNCC.Text;

            DonTraHangDTO p = new DonTraHangDTO(MaDTH, NgayLap, NVLapDon, MaNCC);
            int n = DonTraHangBUS.Update(p);
            MessageBox.Show(n.ToString() + " rows updated !!!");
        }
    }
}
