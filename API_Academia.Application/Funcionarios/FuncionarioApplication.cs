using System.ComponentModel;
using API_Academia.Models.Funcionarios;

namespace API_Academia.Application.Funcionarios
{
    public class FuncionarioApplication
    {
        public string InserirFuncionario(Funcionario infoFuncionario)
        {
            try
            {
                var listaFuncionario = new List<Funcionario>();

                listaFuncionario.Add(infoFuncionario);

                return "Cadastro Efetuado com sucesso!!!";
            }
            catch (Exception e)
            {
                return $"Erro ao cadastrar o Funcionario. Message:{e.Message}";
            }
        }

        public List<Funcionario> ListagemFuncionarios() 
        {
            var listaFuncionario = new List<Funcionario>();
            var memoriaFuncionario1 = new Funcionario();
            var memoriaFuncionario2 = new Funcionario();

            memoriaFuncionario1.Id = 1;
            memoriaFuncionario1.Nome = "Raphael";
            memoriaFuncionario1.Idade = 24;
            memoriaFuncionario1.Ativo = 1;
            memoriaFuncionario1.Funcao = "CEO";
            memoriaFuncionario1.Salario = 10000000;
            memoriaFuncionario1.DataContratacao = DateTime.Now;

            memoriaFuncionario2.Id = 2;
            memoriaFuncionario2.Nome = "Alisson";
            memoriaFuncionario2.Idade = 25;
            memoriaFuncionario2.Ativo = 1;
            memoriaFuncionario2.Funcao = "Recepcionista";
            memoriaFuncionario2.Salario = 10000;
            memoriaFuncionario2.DataContratacao = DateTime.Now;

            listaFuncionario.Add(memoriaFuncionario1);
            listaFuncionario.Add(memoriaFuncionario2);

            return listaFuncionario;
        }

        public Funcionario EditaFuncionario(Funcionario infoFuncionario) 
        {
            var memoriaFuncionario = new Funcionario()
            {
                Id = 1,
                Nome = "Raphael",
                Idade = 24,
                Ativo = 1,
                Funcao = "CEO",
                Salario = 100000,
                DataContratacao = DateTime.Now
            };

            memoriaFuncionario.Id = infoFuncionario.Id;
            memoriaFuncionario.Nome = infoFuncionario.Nome;
            memoriaFuncionario.Idade = infoFuncionario.Idade;
            memoriaFuncionario.Ativo = infoFuncionario.Ativo;
            memoriaFuncionario.Funcao = infoFuncionario.Funcao;
            memoriaFuncionario.Salario = infoFuncionario.Salario;
            memoriaFuncionario.DataContratacao = infoFuncionario.DataContratacao;

            return memoriaFuncionario;
    }

        public bool AlterarSalario(int idFuncionario, double salarioFuncionario)
        {
            var listaFuncionario = new List<Funcionario>();

            listaFuncionario.Add(new Funcionario { Id = 1, Nome = "Raphael", Idade = 24, Ativo = 1, Funcao = "CEO", Salario = 100000, DataContratacao = DateTime.Now });
            listaFuncionario.Add(new Funcionario { Id = 2, Nome = "Alisson", Idade = 25, Ativo = 2, Funcao = "Recepcionista", Salario = 10000, DataContratacao = DateTime.Now });

            try
            {
                var infoFuncionario = listaFuncionario.Find(x => x.Id == idFuncionario);
                infoFuncionario.Salario = salarioFuncionario;

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Funcionario ListaPrimeiroFuncionario()
        {
            var listaFuncionario = new List<Funcionario>();

            listaFuncionario.Add(new Funcionario { Id = 1, Nome = "Raphael", Idade = 24, Ativo = 1, Funcao = "CEO", Salario = 100000, DataContratacao = DateTime.Now });
            listaFuncionario.Add(new Funcionario { Id = 2, Nome = "Alisson", Idade = 25, Ativo = 2, Funcao = "Recepcionista", Salario = 10000, DataContratacao = DateTime.Now });

            return listaFuncionario.FirstOrDefault();

        }

        public bool InativarFuncionario(int Id) 
        {
            var listaFuncionario = new List<Funcionario>();

            listaFuncionario.Add(new Funcionario { Id = 1, Nome = "Raphael", Idade = 24, Ativo = 1, Funcao = "CEO", Salario = 100000, DataContratacao = DateTime.Now });
            listaFuncionario.Add(new Funcionario { Id = 2, Nome = "Alisson", Idade = 25, Ativo = 2, Funcao = "Recepcionista", Salario = 10000, DataContratacao = DateTime.Now });

            try
            {
                var statusFuncionario = listaFuncionario.Find(x => x.Id == 1);
                statusFuncionario.Ativo = 0;

                if (statusFuncionario.Ativo == 1)
                {
                    return true;
                }
                else 
                {
                    listaFuncionario.Find(x => x.Id == Id).Ativo = 1;

                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
