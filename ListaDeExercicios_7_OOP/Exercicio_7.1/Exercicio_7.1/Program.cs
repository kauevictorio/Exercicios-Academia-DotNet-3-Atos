using System.Security.AccessControl;

namespace Exercicio_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 - Crie uma classe Livro que represente os dados básicos de 
             um livro. Faça a leitura pelo teclado dos atributos e crie um 
            construtor para fazer o instanciamento.  */
                
            Livro livro = new Livro();
            Console.WriteLine("Qual o nome do autor do livro:" );
            livro.autor = Console.ReadLine();
            Console.WriteLine("Qual o titulo do livro: ");
            livro.nome = Console.ReadLine();
            Console.WriteLine("Quantas paginas tem o livro; ");
            livro.quantPaginas = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }
    }
}