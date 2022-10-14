namespace Exercicio_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2 - Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. 
                 Faça métodos para apresentar os dados.
                 Faça a leitura pelo teclado dos atributos e crie um construtor para
                 fazer o instanciamento.  
             */

            Pessoas pessoas = new Pessoas();
            Console.WriteLine("Digite o nome da pessoa: ");
            pessoas.nome = Console.ReadLine();
            Console.WriteLine("Qual da data de nascimento, no formato DD/MM/AAAA");
            pessoas.dataDeNascimento = Console.ReadLine();
            Console.WriteLine("Qual altura da Pessoa: ");
            pessoas.altura = double.Parse(Console.ReadLine());  
            Console.WriteLine("Qual a cor dos olhos da pessoa: ");
            pessoas.corDosOlhos = Console.ReadLine();


        }
    }
}