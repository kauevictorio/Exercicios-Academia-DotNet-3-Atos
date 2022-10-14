namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro positivo:  ");
            int x = int.Parse(Console.ReadLine());
            while (x <= 0)
            {
             Console.WriteLine("Numero Invalido, Digite um numero Valido: ");
              x = int.Parse(Console.ReadLine());
            }
                for (int i = 1; i < x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }


            }

        }
    }
}