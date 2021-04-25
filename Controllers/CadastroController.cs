using Cadastro_Pessoa.Models.Contracts;
using Cadastro_Pessoa.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cadastro_Pessoa.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Post(DadosCadastro dados, [FromServices]IDadosCadastroRepository _repository)
        {
            await _repository.InsertDadosCadastro(dados);
            return View();
        }
        [HttpGet]
        public async Task<List<DadosCadastro>> Get([FromServices] IDadosCadastroRepository _repository) {
            return  await _repository.GetDadosCadastro();
        }
    }
}
