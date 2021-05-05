using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHanhNCC
{
    class CT_DonTraHangBUS
    {
        public static int Insert(CT_DonTraHangDTO p)
        {
            int n = CT_DonTraHangDAO.Insert(p);
            return n;
        }
    }
}
