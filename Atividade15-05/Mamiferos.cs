using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade15_05
{
    class Mamiferos : Animal
    {
        private bool amamenta;

        public Mamiferos(string nome, double tamanho, double peso, string barulho, bool amamenenta) : base(nome, tamanho, peso, barulho)
        {
            Amamenta = true;
        }

        public bool Amamenta { get => amamenta; set => amamenta = value; }

        public void som()
        {
            Console.WriteLine("O Som do Animal" + Barulho);
        }

    }
}
