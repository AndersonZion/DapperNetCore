using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Service.Contracts
{
    public interface FornecedorService
    {
        FornecedorService InsertAsnyFornecedor(FornecedorService fornecedor);
        FornecedorService UpdateAsnyCliente(FornecedorService fornecedor);
        bool DeleteAsnyFornecedor(int id);
        FornecedorService GetAsnyFornecedor(int id);
        IEnumerable<FornecedorService> GetAsnyFornecedor();
    }
}
