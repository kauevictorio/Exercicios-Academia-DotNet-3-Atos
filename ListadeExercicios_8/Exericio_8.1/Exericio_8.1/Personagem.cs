using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exericio_8._1
{
    public class Personagem
    {
        private string nome { get; set; }

        private int poder ;

        public Personagem(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }

        public void mostraDados()
        {
            Console.WriteLine(nome+ " Foi o mais forte com poder de: " + poder);
        }

        public void getPoder()
        {
            Console.WriteLine(poder);
        }
        
    }
}
