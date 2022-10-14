namespace Exercicio_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*2) Solicite ao usuário, preencher uma Matriz 3x3

                    Informe ao usuário:
                    *A soma dos elementos de cada linha
	                    -Ex: Linha 1: 30
	                         Linha 2: 17
                    *A soma dos elementos de cada coluna
	                    -Ex: Coluna 1: 23
	                         Coluna 2: 36
             */

            int[,] matriz = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite os valores para a matriz 3x3: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(" [" + i + "," + j + "] " + matriz[i, j] + " ");
                }
                Console.WriteLine();
                
            }
            int somaLinha1;
            for (int i = 0; i < 3; i++)
            {
                somaLinha1 = matriz[i, 0] + matriz[i, 1] + matriz[i, 2]; 
            Console.WriteLine("A soma dos valores da linha " +(i +1) + " da matriz é: " + somaLinha1 );
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" [" + i + "," + j + "] " + matriz[i, j] + " ");
                }
                Console.WriteLine();

            }
            int somaColuna;
            for (int i = 0; i < 3; i++)
            {
                somaColuna = matriz[ 0 , i ] + matriz[1 , i] + matriz[2 , i];
                Console.WriteLine("A soma dos valores da coluna " + (i + 1) + " da matriz é: " + somaColuna);
            }

        }
    }
}