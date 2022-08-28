using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
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
        public string RG { get; set; }
        public Genero Genero { get; set; }
        public Cliente()
        {

        }

        public Cliente(string nome, string sobrenome, string cPF, DateTime dataNascimento, string telefone, string email, string rG, Genero genero)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            RG = rG;
            Genero = genero;
        }
        public Cliente(string nome, string sobrenome, string cPF, DateTime dataNascimento, string telefone, string email, string rG)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            RG = rG;
        }
    }
}