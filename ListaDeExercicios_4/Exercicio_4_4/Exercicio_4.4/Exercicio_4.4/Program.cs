namespace Exercicio_4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a
            //multiplicação dos elementos de mesmo índice, colocando o resultado
            //em um terceiro vetor. Mostre o vetor resultante.

            int[] resultado = new int[10], vetor1 = new int[10], vetor2 = new int[10];
            int i, pos;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("digite os valores para o primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite os valores para o segundo vetor : ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                resultado[i] = vetor1[i] * vetor2[i];
                Console.WriteLine(" Os valores do vetor1 na posição " + i + " multiplicada pelos valores do vetor 2 são: " + resultado[i]);
            }
        }
    }
}