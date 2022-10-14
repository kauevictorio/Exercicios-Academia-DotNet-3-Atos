namespace Exercicio_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
            //A 2ª coluna, some 10 aos elementos da 1ª coluna.
            //Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

            int[,] matrix = new int[5,3];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe o valor da Primeira Coluna: ");
                matrix[i, 0] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < 5; i++)
            {
                matrix[i, 1] = matrix[i, 0] + 10;
                matrix[i, 2] = matrix[i, 0] * 2;

            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("[" + i + "," + j + "] = " + matrix[i,j] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}