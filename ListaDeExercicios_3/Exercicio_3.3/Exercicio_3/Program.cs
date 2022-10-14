namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            int numero = 1;
            while (numero != 0)
            {
                Console.WriteLine("Digite um numero inteiro: ou digite (0) zero para sair.");
                numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Numero Par!");
                }
                else (numero % 2 == 1)
                {
                    Console.WriteLine("Numero Impar!");

                }
                else
                {
                    Console.WriteLine("Numero Primo");
                }
            }

        }
    }
}