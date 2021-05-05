using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaoHanhNCC
{
    class CTThongKeMH_DAO
    {
        static public SqlConnection _connection = null;
        static public SqlCommand _command = null;
        static string _connectionString = @"Data Source=DESKTOP-RA09AV3;Initial Catalog = dbQLBanHangQuaMang; Integrated Security = True";

        // DISPLAY:
        public static List<CTThongKeMH_DTO> Display()
        {
            _connection = new SqlConnection(_connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("spDisplayAll_CT_THONG_KE", _connection);

            // Transmission parameters into PROC:
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            //// Transmission value for parameter:
            //adapter.SelectCommand.Parameters.Add("@keyword", SqlDbType.NVarChar).Value = keyword;

            DataTable table = new DataTable();
            adapter.Fill(table);

            List<CTThongKeMH_DTO> list = new List<CTThongKeMH_DTO>();

            foreach (DataRow r in table.Rows)
            {
                string MaThongKe = (string)r["Mã thống kê"];
                string MaMH = (string)r["Mã mặt hàng"];
                int SLDaBan = (int)r["Số lượng đã bán"];
                int SLTon = (int)r["Số lượng tồn"];
                CTThongKeMH_DTO p = new CTThongKeMH_DTO(MaThongKe, MaMH, SLDaBan, SLTon);
                list.Add(p);
            }
            return list;
        }
    }
}
