using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BaoHanhNCC
{
    class DonTraHangBUS
    {
        public static DataTable LoadDonTraHang()
        {
            return DonTraHangDAO.LoadDonTraHang();
        }
        public static DataTable LoadNhanVienCbb()
        {
            return DonTraHangDAO.LoadNhanVienCbb();
        }
        public static DataTable LoadNhaCungCapCbb()
        {
            return DonTraHangDAO.LoadNhaCungCapCbb();
        }
        public static DataTable LoadMatHang()
        {
            return DonTraHangDAO.LoadMatHang();
        }
        public static int Insert(DonTraHangDTO p)
        {
            int n = DonTraHangDAO.Insert(p);
            return n;
        }
        public static DataTable Read(string MaDTH)
        {
            return DonTraHangDAO.Read(MaDTH);
        }

        public static int Update(DonTraHangDTO pNew)
        {
            return DonTraHangDAO.Update(pNew);
        }

        internal static int Delete(string code)
        {
            return DonTraHangDAO.Delete(code);
        }

        public static int KiemTraTonTaiMaDTH(string code)
        {
            return DonTraHangDAO.KiemTraTonTaiMaDTH(code);
        }
    }
}
