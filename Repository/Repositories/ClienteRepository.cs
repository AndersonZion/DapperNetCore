using Domain.Entities;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Repository.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly IConnectionDapperFactory _connectionFactory;

        public ClienteRepository(IConnectionDapperFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
       

        public Cliente GetAsnyCliente(int id)
        {
            string sql = "select * from Cliente where IdCliente = @uIdCliente";
            using (var connectionDb = _connectionFactory.Connection())
            {
                connectionDb.Open();
                var result =  connectionDb.QuerySingleOrDefault<Cliente>(sql, new { uIdCliente = id });
                return result;
            }
          
        }

        public IEnumerable<Cliente> GetAsnyClientes()
        {
            string sql = "select IdCliente, Nome from Cliente";
            using (var connectionDb = _connectionFactory.Connection())
            {
                connectionDb.Open();
                var resut =   connectionDb.Query<Cliente>(sql);
                return resut;
            }
        }

        public Cliente InsertAsnyCliente(Cliente cliente)
        {

            var query = "INSERT INTO Clientes (Nome) VALUES (@Nome)"+"SELECT CAST(SCOPE_IDENTITY() as int)";
            var parameters = new DynamicParameters();
            parameters.Add("Name", cliente.Nome, DbType.String);

            using (var connectionDb = _connectionFactory.Connection())
            {
                var id =  connectionDb.QuerySingle<int>(query, parameters);
                var createdCliente = new Cliente
                {
                    IdCliente = id,
                    Nome = cliente.Nome
                };

                return createdCliente;
            }
        }

        public Cliente UpdateAsnyCliente(Cliente cliente)
        {
            var query = "UPDATE Cliente SET Nome = @Nome WHERE IdCliente = @IdCliente";
            var parameters = new DynamicParameters();
            parameters.Add("IdCliente", cliente.IdCliente, DbType.Int32);
            parameters.Add("Name", cliente.Nome, DbType.String);

            using (var connectionDb = _connectionFactory.Connection())
            {
                var result =  connectionDb.Execute(query, parameters);
            }
            
            return cliente;
        }

        public bool DeleteAsnyCliente(int id)
        {
            var query = "DELETE FROM Cliente WHERE IdCliente = @uIdCliente";
            using (var connectionDb = _connectionFactory.Connection())
            {
                 connectionDb.Execute(query, new { uIdCliente = id });
            }

            return true;
        }
    }
}
