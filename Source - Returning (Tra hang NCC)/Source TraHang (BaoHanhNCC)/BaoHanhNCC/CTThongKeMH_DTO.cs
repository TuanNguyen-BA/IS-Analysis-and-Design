using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHanhNCC
{
    class CTThongKeMH_DTO
    {
        private string _maTK, _maMH;
        private int _slDaBan, _slTon;

        // Get - set:
        public string MaTK
        {
            get { return _maTK; }
            set { _maTK = value; }
        }
        public string MaMH
        {
            get { return _maMH; }
            set { _maMH = value; }
        }
        public int SLDaBan
        {
            get { return _slDaBan; }
            set { _slDaBan = value; }
        }
        public int SLTon
        {
            get { return _slTon; }
            set { _slTon = value; }
        }

        // Khởi tạo mặc định:
        public CTThongKeMH_DTO()
        {
            _maTK = "001";
            _maMH = "MH001";
            _slDaBan = 0;
            _slTon = 0;
        }
        // Khởi tạo có tham số đầu vào:
        public CTThongKeMH_DTO(string maTK, string maMH, int slDaBan, int slTon)
        {
            _maTK = maTK;
            _maMH = maMH;
            _slDaBan = slDaBan;
            _slTon = slTon;
        }
    }
}
