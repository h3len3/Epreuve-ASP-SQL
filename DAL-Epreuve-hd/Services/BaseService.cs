using Microsoft.Extensions.Configuration;

namespace DAL_Epreuve_hd.Services
{
    public abstract class BaseService
    {
        protected readonly string _connectionString;

        public BaseService(IConfiguration configuration, string dbname)
        {
            _connectionString = configuration.GetConnectionString(dbname);
        }
    }
}
