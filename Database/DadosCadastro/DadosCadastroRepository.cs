﻿using Cadastro_Pessoa.Models.Contracts;
using Cadastro_Pessoa.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoa.Database
{
    public class DadosCadastroRepository : IDadosCadastroRepository
    {
        private readonly Context _context;

        public DadosCadastroRepository(Context context)
        {
            _context = context;
        }
        public async Task InsertDadosCadastro(DadosCadastro dados)
        {
            _context.DadosCadastro.Add(dados);
            await _context.SaveChangesAsync();
        }
    }
}
