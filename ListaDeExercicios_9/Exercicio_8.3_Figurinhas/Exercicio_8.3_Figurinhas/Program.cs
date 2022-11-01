namespace Exercicio_8._3_Figurinhas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             3. Fazer um programa em VS para gerenciar figurinhas da copa. O programa deve possuir um Menu 

                    Menu
                    1 - Cadastrar figurinha repetida
                    2 - Cadastrar figurinha faltante
                    3 - Listar figurinhas repetidas
                    4 - Listar figurinhas faltantes
                    5 - Sair
                    Opção:

                    Para este programa, usar a classe Figurinha (codigo_figurinha, selecao, nome_jogador), lista que armazena as figurinhas em memória,
                    arquivo .csv com os dados das figurinhas persistidos em disco.

                    Para as figurinhas repetidas, deve haver uma lista e um arquivo .csv; o mesmo para as figurinhas faltantes. Toda vez que as opções 3 ou 4 foram selecionadas,
                    além da listagem na tela, gerar um arquivo de saída com os mesmos dados da tela. Esse arquivo é o utilizado para mandar aos amigos.


                    nos arquivos .csv. Por exemplo, arquivo de figurinhas repetidas, repetidas.csv

                    codigo figurinha;seleçao;nome do jogador 
                    codigo figurinha;seleçao;nome do jogador 
                    codigo figurinha;seleçao;nome do jogador 
                    codigo figurinha;seleçao;nome do jogador 
                    codigo figurinha;seleçao;nome do jogador 
             */


            List<Figurinha> listaRepetidas = new List<Figurinha>();
            List<Figurinha> listaFaltantes = new List<Figurinha>();


            void cadastrarFigurinhaRepetida()
            {
                string codigo;
                string selecao;
                string jogador;
                Figurinha figurinha;

                Console.WriteLine("Cadastrando figurinha repetida!");

                Console.Write("Código da figurinha: ");
                codigo = Console.ReadLine().ToUpper();

                Console.Write("Seleção da figurinha: ");
                selecao = Console.ReadLine().ToUpper();

                Console.Write("Nome do jogador: ");
                jogador = Console.ReadLine().ToUpper();

                figurinha = new Figurinha(codigo, selecao, jogador);

                if (Util.jaNaListaFigurinha(figurinha, listaRepetidas))
                {
                    Console.WriteLine("Figurinha já cadastrada");
                }
                else
                {
                    listaRepetidas.Add(figurinha);
                    Util.gravarFigurinhaArquivo(figurinha, "repetidas.csv");
                }
            }



            //conectar com a base de dados
            Util.popularArquivoNaListaFigurinha(listaRepetidas, "repetidas.csv");
            Util.popularArquivoNaListaFigurinha(listaFaltantes, "faltantes.csv");

            string opcao;

            do
            {
                Console.WriteLine("1 - Cadastrar figurinha repetida");
                Console.WriteLine("2 - Cadastrar figurinha faltante");
                Console.WriteLine("3 - Listar figurinhas repetidas");
                Console.WriteLine("4 - Listar figurinhas faltantes");
                Console.WriteLine("5 - Sair");
                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        cadastrarFigurinhaRepetida();
                        break;
                    case "2":
                        break;
                    case "3":
                        Util.mostrarListaFigurinhas(listaRepetidas, "minhasRepetidas.txt", "Repetidas");
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (opcao != "5");
        }
    }
}