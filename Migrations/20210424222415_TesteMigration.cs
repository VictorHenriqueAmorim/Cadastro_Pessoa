using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cadastro_Pessoa.Migrations
{
    public partial class TesteMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DadosCadastro",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Sobrenome = table.Column<string>(type: "TEXT", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CNPJ = table.Column<string>(type: "TEXT", nullable: true),
                    RazaoSocial = table.Column<string>(type: "TEXT", nullable: true),
                    NomeFantasia = table.Column<string>(type: "TEXT", nullable: true),
                    CEP = table.Column<string>(type: "TEXT", nullable: false),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: false),
                    Numero = table.Column<string>(type: "TEXT", nullable: true),
                    Complemento = table.Column<string>(type: "TEXT", nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    UF = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DadosCadastro", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DadosCadastro");
        }
    }
}
