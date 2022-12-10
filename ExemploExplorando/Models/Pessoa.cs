using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome , string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper();
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                }

                _nome = value;
            }
        }
        private string _sobrenome;
        public string Sobrenome { get => _sobrenome.ToUpper(); set => _sobrenome = value;}
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        private int _idade;
        public int Idade 
        {
            get => _idade;
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("A Idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade} anos.");
        }
    }
}