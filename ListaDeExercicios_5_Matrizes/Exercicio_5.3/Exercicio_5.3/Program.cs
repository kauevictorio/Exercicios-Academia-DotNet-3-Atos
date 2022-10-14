namespace Exercicio_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

            int[,] matriz = new int[4, 4] ;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 ; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int diagMain;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        diagMain = matriz[i, j];
                        Console.WriteLine("A diagonal principal da matriz é: " + diagMain);
                    }
                }
            }
        }
    }
}