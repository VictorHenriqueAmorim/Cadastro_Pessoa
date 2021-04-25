using Cadastro_Pessoa.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoa.Models.Contracts
{
    public interface IDadosCadastroRepository
    {
        Task InsertDadosCadastro(DadosCadastro dados);
        Task<List<DadosCadastro>> GetDadosCadastro();
    }
}
