namespace Exercicio_5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
             */
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            } 
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(matriz[i,j] + ",");
                }
            }

        }
    }
}