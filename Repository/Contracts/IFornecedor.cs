using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Repository.Contracts
{
    public interface IFornecedor
    {
        Fornecedor InsertAsnyFornecedor(Fornecedor fornecedor);
        Cliente UpdateAsnyFornecedor(Fornecedor fornecedor);
        bool DeleteAsnyFornecedor(int id);
        Fornecedor GetAsnyFornecedor(int id);
        IEnumerable<Fornecedor> GetAsnyFornecedor();
    }
}
