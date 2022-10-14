namespace Exercicio_5._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz
                resultante da divisão dos elementos da matriz A pela soma dos seus indices.
             */
            Random n = new Random();
            double[,] matriz = new double[3, 3] { {1,2,3 },{3,4,5},{ 5,6,7} };
            double[,] result = new double[3,3] ;


          
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = matriz[i, j] * i;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Resultado " + result[i, j] );
                }
            }
        }
    }
}