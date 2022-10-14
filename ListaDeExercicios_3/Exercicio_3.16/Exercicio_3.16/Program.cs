namespace Exercicio_3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
                  multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
                  (N*3; N*3*3; N*3*3*3; etc).
             */

            Console.WriteLine("Digite um valor inteiro menor que 50");
            int numero = int.Parse(Console.ReadLine());
            int i = 0;
            int temp;
            

            Console.WriteLine("O numero atingiu o valor limite de 250 após " + i + " multiplicações por 3, resultando em: " + numero );
        }
    }
}