using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7._7
{
    public class Elevador
    {
        public double capacidade = 750;
        public int andarAtual  = 0;
        public int totalAndares = 10;
        public Pessoa cargaMax ;
        public int subir;
        public int descer;
        
       
        public void subirAndar()
        {
            andarAtual= andarAtual + 1;
            if (andarAtual == 10)
            {
                Console.WriteLine("Maior andar atingido!");
            }
            
            
        }
        public void descerAndar()
        {
            andarAtual = andarAtual - 1;
            if(andarAtual == 0)
            {
                Console.WriteLine("Chegou no terreo: ");
            }
            else
            {
                andarAtual
            }
    }
}
