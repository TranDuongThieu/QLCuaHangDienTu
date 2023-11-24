using CuaHangDienTu.UI.Login;
using Microsoft.Data.SqlClient;

namespace CuaHangDienTu.Models
{
    public class DBConnection : IDisposable
    {

        private SqlConnection? connection;
        private SqlConnection? connectionAdmin;

        public SqlConnection GetConnection()
        {
            if (this.connection == null)
            {
                connection = new SqlConnection(string.Format(
                "Data Source=localhost, 1433; Initial Catalog = CuaHangDienTu; TrustServerCertificate=True; User Id ={0}; Password ={1}",
                UserLoginInfomation.Username, UserLoginInfomation.Password));
            }
            return this.connection;
        }

        public SqlConnection GetConnectionAdmin()
        {
            if (this.connectionAdmin == null)
            {
                connectionAdmin = new SqlConnection(string.Format(
                "Data Source=LAPTOP-6280OKSE; Initial Catalog = CuaHangDienTu; Integrated Security=True; Encrypt=False;"));
            }
            return this.connectionAdmin;
        }

        public void OpenConnection()
        {
            this.connection.Open();
        }

        public void OpenConnectionAdmin()
        {
            this.connectionAdmin.Open();
        }

        public void CloseConnection()
        {
            this.connection.Close();
        }
        public void CloseConnectionAdmin()
        {
            this.connectionAdmin.Close();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources (close connections)
                    connection?.Dispose();
                    connectionAdmin?.Dispose();
                }

                // Dispose any unmanaged resources here if needed.

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
