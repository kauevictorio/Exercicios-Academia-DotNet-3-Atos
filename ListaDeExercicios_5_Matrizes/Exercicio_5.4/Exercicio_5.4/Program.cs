namespace Exercicio_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Popule uma matriz 5x5 e informe:
                -Quantos números são pares
                -Quantos números são impares
                -Quantos números são positivos
                -Quantos números são negativos
                -Quantos zeros existem!
            */
            int pares, impares, positivos, negativos, zero;
            float[,] matriz = new float[5, 5];
            Random n = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = n.Next(-25, 25);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                }
            }
            
        
        
        
        }


    } 
} 