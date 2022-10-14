namespace Exercicio_5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5) Leia duas matrizes 2x3 de números double. 
                Imprima a soma destas duas matrizes.
             */
            double[,] matrix = new double[2, 3];
            double[,] matriz2 = new double[2, 3];
            double[,] result = new double[2, 3];


                for (int i = 0; i < 2; i++)
                {
                    for ( int j = 0; j < 3; j++)
                    {
                        Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz 1:");
                        matrix[i, j] = double.Parse(Console.ReadLine());
                    }
                }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz 2:");
                    matriz2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        result[i, j] = matrix[i,j] + matriz2[i,j];
                        Console.WriteLine("A soma dos valores das matrizes 1 e 2 são: " + result[i,j]);
                    }
            
               
                }
                

        }
    }
}