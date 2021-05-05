using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHanhNCC
{
    class CT_DonTraHangDTO
    {
        private string _maDTH, _maMH;
        private int _soLuong, _lyDoTra;

        // Get - set:
        public string MaDTH
        {
            get { return _maDTH; }
            set { _maDTH = value; }
        }
        public string MaMH
        {
            get { return _maMH; }
            set { _maMH = value; }
        }
        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        public int LyDoTra
        {
            get { return _lyDoTra; }
            set { _lyDoTra = value; }
        }
        // Khởi tạo mặc định:
        public CT_DonTraHangDTO()
        {
            _maDTH = "001";
            _maMH = "";
            _soLuong = 0;
            _lyDoTra = 0;
        }
        // Khởi tạo với tham số đầu vào:
        public CT_DonTraHangDTO(string ma, string maMH, int sl, int lyDo)
        {
            _maDTH = ma;
            _maMH = maMH;
            _soLuong = sl;
            _lyDoTra = lyDo;
        }
    }
}
