using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BaoHanhNCC
{
    class CTThongKeMH_BUS
    {
        public static List<CTThongKeMH_DTO> Display()
        {
            return CTThongKeMH_DAO.Display();
        }
    }
}
