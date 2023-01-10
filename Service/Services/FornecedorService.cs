using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Repository.Contracts;
using Repository.Repositories;

namespace Service.Services
{
    public  class FornecedorService : CadastroRepository
    {
        public readonly CadastroRepository _fornecedorRepository;
        public FornecedorService(CadastroRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }


        public Fornecedor GetAsnyFornecedor(int id)
        {
            return fornecedorRepository.GetAsnyFornecedor(id);
        }

        public IEnumerable<Fornecedor> GetAsnyFornecedor()
        {
            return _fornecedorRepository.GetAsnyFornecedor();
        }

        public Cliente InsertAsnyCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente UpdateAsnyCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAsnyCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}

