using Cadastro_Pessoa.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_Pessoa.Database.Mapping
{
    public class DadosCadastroMapping : IEntityTypeConfiguration<DadosCadastro>
    {
        public void Configure(EntityTypeBuilder<DadosCadastro> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome);
            builder.Property(x => x.Sobrenome);
            builder.Property(x => x.CPF);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.RazaoSocial);
            builder.Property(x => x.NomeFantasia);
            builder.Property(x => x.CNPJ);
            builder.Property(x => x.CEP).IsRequired();
            builder.Property(x => x.Logradouro).IsRequired();
            builder.Property(x => x.Complemento);
            builder.Property(x => x.Bairro).IsRequired();
            builder.Property(x => x.Cidade).IsRequired();
            builder.Property(x => x.UF).IsRequired();
        }
    }
}
