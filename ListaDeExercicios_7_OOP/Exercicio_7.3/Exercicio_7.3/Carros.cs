using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7._3
{
    public class Carros
    {
        public string fabricante;
        public string modelo;
        public string ano;
        public string placa;
        private string cor { get; set; }


        private string getCor()
        {
            return cor;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }


    }
}
