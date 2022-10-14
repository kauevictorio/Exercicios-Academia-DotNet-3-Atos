namespace Exercicio_5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Leia duas matrizes A e B com 3x3 elementos. Construir
            uma matriz C, onde cada elemento de C é a subtração do 
            elemento correspondente de A com B. 
             
             */


            int[,] matriz = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            float[,] subtrai = new float[3, 3];



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz 1:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

            }
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.WriteLine("Informe um valor para a posição " + a + " - " + b + " da matriz 2:");
                    matriz2[a, b] = int.Parse(Console.ReadLine());
                }


            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    subtrai[i, j] = matriz[i, j] - matriz2[i, j];
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("O resultado da subtração dos indices da matriz A pela B é :[" + i + "," + j + "] = " + subtrai[i, j] + "  ");
                }
                Console.WriteLine();

            }

        }

    }
}