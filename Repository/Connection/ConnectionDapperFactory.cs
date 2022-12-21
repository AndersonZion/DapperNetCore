using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Connection
{
    public class ConnectionDapperFactory : IConnectionDapperFactory
    {
        //Todo: Mudar string de conexão

        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ConnectionDapperFactory(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection Connection()
        {
            return new SqlConnection(_connectionString);
        }

       
    }
}
