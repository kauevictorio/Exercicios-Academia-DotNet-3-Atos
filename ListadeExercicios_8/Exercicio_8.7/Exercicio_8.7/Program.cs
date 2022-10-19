namespace Exercicio_8._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                7) Crie um dicionário que faça o armazenamento de Livros. 
                    Os dados para serem armazenados serão o nome do livro e a quantidade de páginas. 
                    Em um menu inicial, possibilite que o usuário do sistema possa cadastrar, 
                    consultar todos livros cadastrados ou pesquisar pelo nome do livro.

                
             */

            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            Console.WriteLine("-----BIBLIOTECA------");
            int opc = 0;

            do
            {
                Console.WriteLine("--==MENU==--");
                Console.WriteLine("1 - cadastrar livros");
                Console.WriteLine("2 - listar livros");
                Console.WriteLine("3 - pesquisar livros ");
                Console.WriteLine("4 - SAIR ");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {

                Console.WriteLine("Qual nome do livro: ");
                string nome = Console.ReadLine().ToUpper();
                Console.WriteLine("Quantas Paginas o livro possui: ");
                int quantPag = int.Parse(Console.ReadLine());

                dic.Add(nome, quantPag );
                }
                if (opc == 2)
                {
                    foreach (KeyValuePair<string, int> item in dic)
                    {
                        Console.WriteLine("Livro: " + item.Key +" Quantidade de paginas: " + item.Value);
                    }
                }
                string pesquisa = null;
                if (opc == 3)
                {
                    Console.WriteLine("Digite o nome do livro a ser pesquisado");
                    pesquisa = Console.ReadLine();
                    if (dic.ContainsKey(pesquisa))
                    {
                        Console.WriteLine("Livro Encontrado!");
                                                
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado na lista!");
                    }
                }
    
            } while (opc !=4);

        }
    }
}