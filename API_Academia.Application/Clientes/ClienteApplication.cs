using API_Academia.Models.Clientes;

namespace API_Academia.Application.Clientes
{
    public class ClienteApplication
    {
        public bool CadastroDeCliente(Cliente infoCliente)
        {
			try
			{
                var listaCliente = new List<Cliente>();

                listaCliente.Add(infoCliente);

				return true;
			}

			catch (Exception e)
			{
                return false;
            }
        }

        public List<Cliente> ListarClientes()
        {
            var listaClientes = new List<Cliente>();
            var memoriaCliente1 = new Cliente();
            var memoriaCliente2 = new Cliente();

            memoriaCliente1.Id = 1;
            memoriaCliente1.Nome = "Raphael";
            memoriaCliente1.Idade = 24;
            memoriaCliente1.Ativo = 1;
            memoriaCliente1.Mensalidade = 200;
            memoriaCliente1.DataCadastro = DateTime.Now;

            memoriaCliente2.Id = 2;
            memoriaCliente2.Nome = "Alisson";
            memoriaCliente2.Idade = 25;
            memoriaCliente2.Ativo = 1;
            memoriaCliente2.Mensalidade = 150;
            memoriaCliente2.DataCadastro = DateTime.Now;

            listaClientes.Add(memoriaCliente1);
            listaClientes.Add(memoriaCliente2);

            return listaClientes;
        }

        public Cliente EditarInfoClientes(Cliente infoCliente) 
        {
            var memoriaCliente = new Cliente() 
            { 
                Id = 1,
                Nome = "Raphael",
                Idade = 24,
                Ativo = 1,
                Mensalidade = 200,
                DataCadastro= DateTime.Now
            };

            memoriaCliente.Id = infoCliente.Id;
            memoriaCliente.Nome = infoCliente.Nome;
            memoriaCliente.Idade = infoCliente.Idade;
            memoriaCliente.Ativo = infoCliente.Ativo;
            memoriaCliente.Mensalidade = infoCliente.Mensalidade;
            memoriaCliente.DataCadastro = infoCliente.DataCadastro;

            return memoriaCliente;
        }
    }
}
