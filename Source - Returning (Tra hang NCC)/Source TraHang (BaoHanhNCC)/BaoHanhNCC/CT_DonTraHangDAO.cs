using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaoHanhNCC
{
    class CT_DonTraHangDAO
    {
        static public SqlConnection _connection = null;
        static public SqlCommand _command = null;
        static string _connectionString = @"Data Source=DESKTOP-RA09AV3;Initial Catalog = dbQLBanHangQuaMang; Integrated Security = True";
        // INSERT:
        public static int Insert(CT_DonTraHangDTO p)
        {
            try
            {
                // B1: Create object to connect CSDL and open connection:
                _connection = new SqlConnection(_connectionString);
                _connection.Open();

                // B2: Build sql command:
                String procName = "spInsertNewCTDTH";
                //  private string _maDTH, _maMH;
                //private int _soLuong, _lyDoTra;
                // B3: Create object to execute sql command:
                _command = new SqlCommand(procName);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;

                // Transmission parameters into PROC:
                _command.Parameters.Add("@maDTH", SqlDbType.VarChar);
                _command.Parameters.Add("@maMH", SqlDbType.VarChar);
                _command.Parameters.Add("@soLuong", SqlDbType.Int);
                _command.Parameters.Add("@lyDo", SqlDbType.Int);

                // Transmission value for parameter:
                _command.Parameters["@maDTH"].Value = p.MaDTH;
                _command.Parameters["@maMH"].Value = p.MaMH;
                _command.Parameters["@soLuong"].Value = p.SoLuong;
                _command.Parameters["@lyDo"].Value = p.LyDoTra; //-- 0: Hết hạn, 1: Hỏng, 2: Bán không chạy.

                // B4: Execute sql command and get returned value:
                int n = _command.ExecuteNonQuery();
                int id = -1;
                if (n > 0)
                {
                    id = 1;
                }

                // B5:
                _connection.Close();
                return id;
            }
            catch
            {
                return -1;
            }
        }
    }
}
