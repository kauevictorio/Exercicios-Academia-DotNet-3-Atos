using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8._2
{
    public class Animal
    {
        private string name;
        private string species;

        public Animal(string name, string species)
        {
            this.name = name;
            this.species = species;
        }
    
        public void getName()
        {
            
            Console.WriteLine("Nome: " + this.name);
        }

        public void getSpecies()
        {
            Console.WriteLine("Specie: " + this.species);
        }
        public string setSpecies()
        {
            return this.species;
        }

        public string setName()
        {
            return this.name;
        }
    }
}
