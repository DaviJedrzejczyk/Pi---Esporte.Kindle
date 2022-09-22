using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Funcionario : PessoaFisica
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - DataNascimento.Year;
                if (DataNascimento.Date > today.AddYears(-age))
                {
                    age--;
                }
                return age;

            }
            set
            {

            }
        }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public Genero Genero { get; set; }
        public string Senha { get; set; }
        public TipoFuncionario Nivel_Acesso { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public Funcionario(int iD, string nome, string sobrenome, DateTime dataNascimento, int idade, string telefone, string email, Genero genero, string senha, TipoFuncionario nivel_Acesso, Endereco endereco, string cpf, string rg) : base(cpf, rg)
        {
            ID = iD;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Idade = idade;
            Telefone = telefone;
            Email = email;
            Genero = genero;
            Senha = senha;
            Nivel_Acesso = nivel_Acesso;
            Endereco = endereco;
        }

        public Funcionario()
        {

        }
        public Funcionario(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }
    }
}
