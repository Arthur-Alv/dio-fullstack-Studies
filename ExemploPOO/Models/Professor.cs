using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome) : base (nome)  
        {

        }
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.Write($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um professor e ganho {Salario}.");
        }
        
    }
}