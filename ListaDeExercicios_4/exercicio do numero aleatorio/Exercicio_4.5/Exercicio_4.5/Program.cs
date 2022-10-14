namespace Exercicio_4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5) Escreva um algoritmo que leia um vetor de 80 elementos inteiros.
              Encontre e mostre o menor elemento e a sua posição.
             */
            Random n = new Random();
            const int numeroQtd = 80;
            int[] numeros = new int[numeroQtd];
            int menor = 0, maior = 0, posicao_menor = 0, posicao_maior = 0;

            

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = n.Next(0, 100);

                if (i == 0)
                {
                    menor = numeros[0];
                    maior = numeros[0];
                }

                if (numeros[i] < menor)
                {

                    menor = numeros[i];
                    posicao_menor = i;

                }
                else if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posicao_maior = i;
                }

            }

            Console.WriteLine("O menor número é:" + menor);
            Console.WriteLine("A posição do menor número é:" + posicao_menor);
          
            Console.Read();
        }
    }
} 
