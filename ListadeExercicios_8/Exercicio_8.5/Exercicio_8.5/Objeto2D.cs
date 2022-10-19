using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8._5
{
    public class Objeto2D
    {

        private float eixoX { get; set; } 
        private float eixoY { get; set; }

        public Objeto2D (int eixoX, int eixoY)
        {
            this.eixoX = eixoX;
            this.eixoY = eixoY;
        }

        public void motraDados()
        {
            Console.WriteLine("O objeto está localizado no plano cartesiano nas coordenadas X: " + eixoX +" e Y: "+ eixoY);
        }

    }
}
