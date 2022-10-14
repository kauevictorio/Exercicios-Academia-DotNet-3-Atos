namespace Exercicio_3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             12. Apresentar o total da soma dos cem primeiros números inteiros.
             */
            int total = 0, i = 0;
            for (i = 0; i <= 100 ; i++)
            {
                total = total + i;
                
            }
            Console.WriteLine("O total de numeros inteiros de 1 a 100 somados é: " + total);

        }
    }
}