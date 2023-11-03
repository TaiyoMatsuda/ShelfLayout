using Microsoft.Data.SqlClient;

namespace ShelfLayout.Server.Infrastructure
{
    public class DapperDbContext
    {
        private readonly string _connectionString;

        public DapperDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection"); ;
        }

        public SqlConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
