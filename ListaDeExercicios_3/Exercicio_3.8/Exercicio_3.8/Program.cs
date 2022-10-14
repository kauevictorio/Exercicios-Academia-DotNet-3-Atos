namespace Exercicio_3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
     8. Faça um programa em VS que solicite um numero inteiro. S
         e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
         Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
             */

            Console.WriteLine("Digite um numero inteiro: ");
            float d = float.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Numero Invalido. Digite um numero inteiro: ");
                d = float.Parse(Console.ReadLine());    


            } while (d - (int)d != 0);

            Console.WriteLine("Numero Valido! Obrigado....");
                
        }
    }
}