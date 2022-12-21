using Domain.Entities;
using Repository.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ClienteService : IClienteService
    {
        public readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
     

        public Cliente GetAsnyCliente(int id)
        {
           return _clienteRepository.GetAsnyCliente(id);
        }

        public IEnumerable<Cliente> GetAsnyClientes()
        {
            return _clienteRepository.GetAsnyClientes();
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
