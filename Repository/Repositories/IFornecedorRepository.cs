using Dapper;
using Domain.Entities;
using Repository.Contracts;
using System.Data;

namespace Repository.Repositories
{
    public interface CadastroRepository
    {
        IEnumerable<Fornecedor> GetAsnyFornecedor();

        public class FornecedorRepository : CadastroRepository
        {
            public readonly IConnectionDapperFactory _connectionFactory;

            public FornecedorRepository(IConnectionDapperFactory connectionFactory)
            {
                _connectionFactory = connectionFactory;
            }


            public Fornecedor GetAsnyFornecedor(int id)
            {
                string sql = "select * from Fornecedor where IdFornecedor = @uIdFornecedor";
                using (var connectionDb = _connectionFactory.Connection())
                {
                    connectionDb.Open();
                    var result = connectionDb.QuerySingleOrDefault<Fornecedor>(sql, new { uIdFornecedor = id });
                    return result;
                }

            }

            public IEnumerable<Fornecedor> GetAsnyFornecedor()
            {
                string sql = "select IdFornecedor, Nome from Fornecedor";
                using (var connectionDb = _connectionFactory.Connection())
                {
                    connectionDb.Open();
                    var resut = connectionDb.Query<Fornecedor>(sql);
                    return resut;
                }
            }

            public Fornecedor InsertAsnyFornecedor(Fornecedor fornecedor)
            {

                var query = "INSERT INTO Companies (Nome) VALUES (@Nome)" + "SELECT CAST(SCOPE_IDENTITY() as int)";
                var parameters = new DynamicParameters();
                parameters.Add("Nome", fornecedor.Nome, DbType.String);

                using (var connectionDb = _connectionFactory.Connection())
                {
                    var id = connectionDb.QuerySingle<int>(query, parameters);
                    var createdFornecedor = new Fornecedor
                    {
                        IdFornecedor = id,
                        Nome = fornecedor.Nome
                    };

                    return createdFornecedor;
                }
            }

            public Fornecedor UpdateAsnyFornecedor(Fornecedor fornecedor)
            {
                var query = "UPDATE Fornecedor SET Nome = @Nome WHERE IdFornecedor = @IdFornecedor";
                var parameters = new DynamicParameters();
                parameters.Add("IdFornecedor", fornecedor.IdFornecedor, DbType.Int32);
                parameters.Add("Name", fornecedor.Nome, DbType.String);

                using (var connectionDb = _connectionFactory.Connection())
                {
                    var result = connectionDb.Execute(query, parameters);
                }

                return fornecedor;
            }

            public bool DeleteAsnyFornecedor(int id)
            {
                var query = "DELETE FROM Fornecedor WHERE IdFornecedor = @uIdFornecedor";
                using (var connectionDb = _connectionFactory.Connection())
                {
                    connectionDb.Execute(query, new { uIdFornecedor = id });
                }

                return true;
            }
        }
    }
}