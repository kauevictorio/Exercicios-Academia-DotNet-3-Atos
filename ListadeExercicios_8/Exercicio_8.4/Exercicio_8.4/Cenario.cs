using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8._4
{
    public class Cenario
    {
        private string description { get; set; } 
        private DateTime creation { get; set; }  
        private float height { get; set; }   


        public Cenario(string description, DateTime creation, float height)
        {
            this.description = description;
            this.creation = creation;
            this.height = height;   
        }

        public void mostraDados()
        {
            Console.WriteLine("Descrição: " + description + ", Data de criação: " + creation + ", tamanho do cenario: " + height +" Metros quadrados.");
        }
    }
}
