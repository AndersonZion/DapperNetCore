using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Repository.Contracts;

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

        }
