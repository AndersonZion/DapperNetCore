using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Repository.Contracts
{
    public interface ICadastroRepository
    {
        Cadastro InsertAsnyCadastro(Cadastro cadastro);
        Cadastro UpdateAsnyCadastro(Cadastro cadastro);
        bool DeleteAsnyCadastro(int id);
        Cadastro GetAsnyCadastro(int id);
        IEnumerable<Cadastro> GetAsnyCadastros();
    }
}
