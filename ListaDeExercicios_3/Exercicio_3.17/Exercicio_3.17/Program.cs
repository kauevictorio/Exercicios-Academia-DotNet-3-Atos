namespace Exercicio_3._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             17. Apresentar os quadrados dos números inteiros de 15 a 200.
             */

            int a = 15, b = 200;
            int aux = 0;

            for ( a = 15; a <= b ; a++)
            {
                aux = a * a;
                Console.Write(  aux + " - ");
            }

        }
    }
}