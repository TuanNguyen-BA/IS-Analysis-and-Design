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
    public partial class FrmThemCT_DTH : Form
    {
        public FrmThemCT_DTH()
        {
            InitializeComponent();
        }

        public string maDTH;

        private void FrmThemCT_DTH_Load(object sender, EventArgs e)
        {
            // Load lên ComboBox MAT_HANG:
            cbbMaMH.DisplayMember = "MaMH";
            cbbMaMH.DataSource = DonTraHangBUS.LoadMatHang();
            cbbMaMH.SelectedIndex = -1;
        }

        private void btnThemCT_DTH_Click(object sender, EventArgs e)
        {
            CT_DonTraHangDTO p = new CT_DonTraHangDTO();
            p.MaDTH = maDTH;
            MessageBox.Show("p.MaDTH = " + maDTH);
            p.MaMH = cbbMaMH.Text;
            p.SoLuong = int.Parse(txtSoLuong.Text);
            p.LyDoTra = int.Parse(txtLyDo.Text);

            // Handle BUS class to add data:
            int n = CT_DonTraHangBUS.Insert(p);
            if (n > 0)
            {
                MessageBox.Show("Insert successfully!!!");
            }
            else
            {
                MessageBox.Show("Failed !!!");
            }
        }
    }
}
