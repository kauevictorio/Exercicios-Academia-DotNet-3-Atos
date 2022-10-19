using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8._3
{
    public class Asteroid
    {
        private int id;
        private int size;
        private int speed;
        private int energy;
        private float positionX { get; set; }
        private float positionY { get; set; }

        public Asteroid(int id, int size, int energy, int speed, float positionX , float positionY)
        {
            this.id = id;
            this.size = size;
            this.speed = speed;
            this.energy = energy;
            this.positionX = positionX;
            this.positionY = positionY;
        }

         
       public void mostraDados()
        {
            Console.WriteLine("id do asteroid " + id + ", tamanho: " + size + ", velocidade: " + speed + ", energia: " + energy + ", Posição no eixo X: " + positionX + ", Posição no eixo Y: " + positionY);
        }
    }
}
