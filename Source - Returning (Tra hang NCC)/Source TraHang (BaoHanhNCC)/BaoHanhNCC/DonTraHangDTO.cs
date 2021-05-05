using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHanhNCC
{
    class DonTraHangDTO
    {
        private string _maDTH, _ngayLap, _nvLapDon, _maNCC;

        // Get - set:
        public string MaDTH
        {
            get { return _maDTH; }
            set { _maDTH = value; }
        }
        public string NgayLap
        {
            get { return _ngayLap; }
            set { _ngayLap = value; }
        }
        public string NVLapDon
        {
            get { return _nvLapDon; }
            set { _nvLapDon = value; }
        }
        public string MaNCC
        {
            get { return _maNCC; }
            set { _maNCC = value; }
        }
        // Khởi tạo mặc định:
        public DonTraHangDTO()
        {
            _maDTH = "001";
            _ngayLap = "";
            _nvLapDon = "";
            _maNCC = "";
        }
        // Khởi tạo với tham số đầu vào:
        public DonTraHangDTO(string ma, string ngay, string nvLap, string maNCC)
        {
            _maDTH = ma;
            _ngayLap = ngay;
            _nvLapDon = nvLap;
            _maNCC = maNCC;
        }
    }
}
