using System.Runtime.ConstrainedExecution;

namespace Exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
         //informar um outro número. Caso positivo, o programa em VS deve ser repetido.

            int numero = 1;

            while (numero > 0)
            {
                Console.WriteLine("Digite um numero inteiro e positivo: ");
                numero = int.Parse(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Digite um numero inteiro positivo valido: ");
                    numero = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Os numeros inteiros pares entre 1 e " + numero + " São: ");
                for (int i = 1; i < numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);

                    }
                }
                Console.WriteLine("deseja informar outro numero? s/n ");

                string escolha = Console.ReadLine();
                if (escolha == "n")
                {
                    break;
                }
            }
        }

    }
}