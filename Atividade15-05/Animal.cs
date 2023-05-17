using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade15_05
{
    internal class Animal{
        private String nome = "";
        private double tamanho;
        private double peso;
        private String barulho = "";

        public Animal(string nome, double tamanho, double peso, string barulho)
        {
            this.nome = nome;
            this.tamanho = tamanho;
            this.peso = peso;
            this.barulho = barulho;
        }

        public string Nome { get => nome; set => nome = value; }
        public double Tamanho { get => tamanho; set => tamanho = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Barulho { get => barulho; set => barulho = value; }


        public void som(){

        }
        
    }
}
