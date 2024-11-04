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
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;
        private int _idade;
        //fazendo o nome não podendo ser vazio 
        public string Nome {
            get => _nome.ToUpper();
                 
            set{
                if(value == ""){ 
                    throw new ArgumentException("O nome não pode ser nulo");
                }

                _nome = value;
            } 
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

            //fazendo a idade não podendo ser menor que 0
        public int Idade {
            get => _idade;
            set{
                if(value < 0){
                    throw new ArgumentException("Idade não pode ser menor que 0");
                }

                _idade = value;
            }
            
            }

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}