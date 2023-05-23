using API_Academia.Models.Base;

namespace API_Academia.Models.Clientes
{
    public class Cliente : Pessoa
    {
        public double Mensalidade { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
