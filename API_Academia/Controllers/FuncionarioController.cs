using API_Academia.Application.Funcionarios;
using API_Academia.Models.Funcionarios;
using Microsoft.AspNetCore.Mvc;

namespace API_Academia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpPost("CadastraFuncionario")]
        public string CadastrarFuncionario(Funcionario infoFuncionario)
        {
            return new FuncionarioApplication().InserirFuncionario(infoFuncionario);
        }

        [HttpGet("ListaFuncionario")]
        public List<Funcionario> ListaFuncionario()
        {
            return new FuncionarioApplication().ListagemFuncionarios();
        }

        [HttpPut("EditaFuncionario")]
        public Funcionario EditaFuncionario(Funcionario infoFuncionario)
        {
            return new FuncionarioApplication().EditaFuncionario(infoFuncionario);
        }

        [HttpPatch("AlteraSalario")]
        public bool AlteraSalario(int idFuncionario, double salarioFuncionario)
        {
            return new FuncionarioApplication().AlterarSalario(idFuncionario, salarioFuncionario);
        }

        [HttpGet("ListaPrimeiraFuncionario")]
        public Funcionario ListaPrimeiroFunc() 
        {
            return new FuncionarioApplication().ListaPrimeiroFuncionario();
        }

        [HttpDelete("InativaFuncionario")]
        public bool InativaFuncionario(int Id) 
        {
            return new FuncionarioApplication().InativarFuncionario(Id);
        }
            
    }
}
