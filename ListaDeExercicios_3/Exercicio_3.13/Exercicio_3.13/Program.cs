namespace Exercicio_3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             13. Elaborar um programa que apresente o somatório dos valores pares existentes 
                 entre 1 e 500.
             */
            int i = 0, somapares = 0;

            for (i = 0; i < 500; i++)
            {
                if(i % 2 == 0)
                {
                    somapares = somapares + i;
                }
            }
            Console.WriteLine("A soma dos numeros pares de 0 a 500 é " + somapares);
        }
    }
}