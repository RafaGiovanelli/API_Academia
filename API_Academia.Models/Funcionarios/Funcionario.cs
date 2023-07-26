using API_Academia.Models.Base;

namespace API_Academia.Models.Funcionarios
{
    public class Funcionario : Pessoa
    {
        public string? Funcao { get; set; }
        public double Salario { get; set; }
        public DateTime DataContratacao { get; set; }
        }
}
