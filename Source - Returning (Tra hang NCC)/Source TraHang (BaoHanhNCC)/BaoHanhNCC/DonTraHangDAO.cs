using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BaoHanhNCC
{
    class DonTraHangDAO
    {
        static public SqlConnection _connection = null;
        static public SqlCommand _command = null;
        static string _connectionString = @"Data Source=DESKTOP-RA09AV3;Initial Catalog = dbQLBanHangQuaMang; Integrated Security = True";

        public static DataTable LoadDonTraHang()
        {
            //-----------------------------------

            _connection = new SqlConnection(_connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("spShowCTDonTraHangALL", _connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static DataTable LoadNhanVienCbb()
        {
            _connection = new SqlConnection(_connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("ShowNV", _connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static DataTable LoadNhaCungCapCbb()
        {
            _connection = new SqlConnection(_connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("ShowNCC", _connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public static DataTable LoadMatHang()
        {
            _connection = new SqlConnection(_connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("ShowMatHang", _connection);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        // INSERT:
        public static int Insert(DonTraHangDTO p)
        {
            try
            {
                // B1: Create object to connect CSDL and open connection:
                _connection = new SqlConnection(_connectionString);
                _connection.Open();

                // B2: Build sql command:
                String procName = "spInsertNewDTH";

                // B3: Create object to execute sql command:
                _command = new SqlCommand(procName);
                _command.CommandType = CommandType.StoredProcedure;
                _command.Connection = _connection;

                // Transmission parameters into PROC:
                _command.Parameters.Add("@maDTH", SqlDbType.VarChar);
                _command.Parameters.Add("@ngayLap", SqlDbType.Date);
                _command.Parameters.Add("@NVLapDon", SqlDbType.VarChar);
                _command.Parameters.Add("@maNCC", SqlDbType.VarChar);

                // Transmission value for parameter:
                _command.Parameters["@maDTH"].Value = p.MaDTH;
                _command.Parameters["@ngayLap"].Value = p.NgayLap;
                _command.Parameters["@NVLapDon"].Value = p.NVLapDon;
                _command.Parameters["@maNCC"].Value = p.MaNCC;

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
        // READ:
        public static DataTable Read(string maDTH)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable tableDonTraHang = new DataTable();

            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * From DON_TRA_HANG Where MaDTH = " + maDTH;
            command.Connection = connection;
            adapter.SelectCommand = command;
            adapter.Fill(tableDonTraHang);

            return tableDonTraHang;
        }

        // UPDATE:
        public static int Update(DonTraHangDTO pNew)
        {
            // B1:
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            // B2:
            String procName = "spUpdateDTH";

            // B3:
            _command = new SqlCommand(procName);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            // Transmission parameters into PROC:
            _command.Parameters.Add("@MaDTH", SqlDbType.VarChar);
            _command.Parameters.Add("@NgayLap", SqlDbType.Date);
            _command.Parameters.Add("@NVLapDon", SqlDbType.VarChar);
            _command.Parameters.Add("@MaNCC", SqlDbType.VarChar);

            // Transmission value for parameter:
            _command.Parameters["@MaDTH"].Value = pNew.MaDTH;
            _command.Parameters["@NgayLap"].Value = pNew.NgayLap;
            _command.Parameters["@NVLapDon"].Value = pNew.NVLapDon;
            _command.Parameters["@MaNCC"].Value = pNew.MaNCC;

            // B4:
            int n = _command.ExecuteNonQuery();

            // B5:
            _connection.Close();

            return n;
        }

        // DELETE:
        public static int Delete(string code)
        {
            // B1:
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            // B2:
            String procName = "spDeleteDTH";

            // B3:
            _command = new SqlCommand(procName);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            // Transmission parameters into PROC:
            _command.Parameters.Add("@maDTH", SqlDbType.VarChar);

            // Transmission value for parameter:
            _command.Parameters["@maDTH"].Value = code;

            // B4:
            int n = _command.ExecuteNonQuery();

            // B5:
            _connection.Close();

            return n;
        }

        // Kiểm tra có tồn tại mã đơn trả hàng không? 0: không thấy; 1: thấy.
        public static int KiemTraTonTaiMaDTH(string code)
        {
            // B1:
            _connection = new SqlConnection(_connectionString);
            _connection.Open();

            // B2:
            String procName = "spReadDTH";

            // B3:
            _command = new SqlCommand(procName);
            _command.CommandType = CommandType.StoredProcedure;
            _command.Connection = _connection;

            // Transmission parameters into PROC:
            _command.Parameters.Add("@maDTH", SqlDbType.VarChar);

            // Transmission value for parameter:
            _command.Parameters["@maDTH"].Value = code;

            // B4:
            int n = _command.ExecuteNonQuery();

            // B5:
            _connection.Close();

            return n;
        }
    }
}
