namespace Exercicio_5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
             Random random = new Random();
             int randomNumber = random.Next(0, 100);
             */
            int maior = 0;
            int[,] matriz = new int[4, 4];
            Random n = new Random();

            for (int i = 0; i < 4; i++)
            {
                for ( int j = 0; j < 4; j++)
                {
                    matriz[i, j] = n.Next(0, 10);
                    Console.Write(matriz[i,j] +" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matriz[i,j] >  maior  )
                    {
                        maior = matriz[i, j];
                    }
                }
            }
                        Console.WriteLine("O maior numero da matriz foi: " + maior);
        }
    }
}