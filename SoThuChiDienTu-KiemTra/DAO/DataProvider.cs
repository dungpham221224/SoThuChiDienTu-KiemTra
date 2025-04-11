using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        private string connectionSTR = @"Data Source=VINFAST\MSSQLSERVER2022;Initial Catalog=QuanLyChiTieuNop;Integrated Security=True;TrustServerCertificate=True";

        //thực thi câu lệnh SQL trả về DataTable 
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data; //Trả về dạng DataTable
        }
        //thực thi câu lệnh SQL ko trả về dữ liệu, dùng cho INSERT, DELETE, UPDATE 
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        // Thực thi một câu lệnh SQL và trả về giá trị đầu tiên của kết quả
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
        public SqlDataReader ExecuteReader(string query, object[] parameters = null)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            SqlCommand command = new SqlCommand(query, connection);

            if (parameters != null)
            {
                string[] listParams = query.Split(' ');
                int index = 0;
                foreach (string item in listParams)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameters[index]);
                        index++;
                    }
                }
            }
            connection.Open();
            SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return reader;
        }
    }
}
