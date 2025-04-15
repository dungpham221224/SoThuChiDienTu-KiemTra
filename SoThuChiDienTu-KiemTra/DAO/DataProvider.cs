using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SoThuChiDienTu_KiemTra.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }

            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = @"Data Source=TIENHUNGDZAIVCL;Initial Catalog=QuanLyChiTieuNop;Integrated Security=True;TrustServerCertificate=True";

        //thực thi câu lệnh SQL trả về DataTable 
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            // Bắt @parameter trong query bằng Regex
                            var matches = Regex.Matches(query, @"@\w+");
                            int i = 0;
                            foreach (Match match in matches)
                            {
                                command.Parameters.AddWithValue(match.Value, parameter[i]);
                                i++;
                            }
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(data);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ExecuteQuery: " + ex.Message);
                throw; // Hoặc return null tùy bạn
            }
            return data;
        }
        //thực thi câu lệnh SQL ko trả về dữ liệu, dùng cho INSERT, DELETE, UPDATE 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            // Tạo regex bắt các biến @param trong query
                            var matches = Regex.Matches(query, @"@\w+");
                            int i = 0;
                            foreach (Match match in matches)
                            {
                                // match.Value chính là @paramName
                                command.Parameters.AddWithValue(match.Value, parameter[i]);
                                i++;
                            }
                        }

                        data = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ExecuteNonQuery: " + ex.Message);
                // Tùy bạn, có thể throw lại hoặc return -1 báo lỗi
                throw;
            }
            return data;
        }

        // Thực thi một câu lệnh SQL và trả về giá trị đầu tiên của kết quả
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameter != null)
                        {
                            var matches = Regex.Matches(query, @"@\w+");
                            int i = 0;
                            foreach (Match match in matches)
                            {
                                command.Parameters.AddWithValue(match.Value, parameter[i]);
                                i++;
                            }
                        }

                        data = command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ExecuteScalar: " + ex.Message);
                throw; // Hoặc return null nếu bạn thích
            }
            return data;
        }
        public SqlDataReader ExecuteReader(string query, object[] parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                if (parameters != null)
                {
                    var matches = Regex.Matches(query, @"@\w+");
                    int index = 0;
                    foreach (Match match in matches)
                    {
                        command.Parameters.AddWithValue(match.Value, parameters[index]);
                        index++;
                    }
                }

                connection.Open();
                // CommandBehavior.CloseConnection: tự đóng connection khi reader.Close()
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi ExecuteReader: " + ex.Message);
                connection.Dispose(); // Giải phóng connection nếu lỗi
                throw; // Bắn lỗi lên cho dễ debug
            }
        }
    }
}

