using API_Academia.Application.Clientes;
using API_Academia.Models.Clientes;
using Microsoft.AspNetCore.Mvc;

namespace API_Academia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpPost("InserirCliente")]
        public string InserirCliente(Cliente infoCliente)
        {
            new ClienteApplication().CadastroDeCliente(infoCliente);

            return "Cadastro efetuado com sucesso!!!";
        }

        [HttpGet("ListaCliente")]
        public List<Cliente> ListaClientes()
        {
            return new ClienteApplication().ListarClientes();
        }

        [HttpPut("EditaCliente")]
        public Cliente EditaCliente(Cliente infoCliente)
        {
            return new ClienteApplication().EditarInfoClientes(infoCliente);
        }


    }
}
