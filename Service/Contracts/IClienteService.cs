﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IClienteService
    {
        Cliente InsertAsnyCliente(Cliente cliente);
        Cliente UpdateAsnyCliente(Cliente cliente);
        bool DeleteAsnyCliente(int id);
        Cliente GetAsnyCliente(int id);
        Task<IEnumerable<Cliente>> GetAsnyClientes();
        
    }
}
