namespace Exercicio_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4. Fazer um programa em VS que realize um CRUD (inserir, pesquisar, atualizar e deletar) 
                completo em uma lista de nomes de criptomoedas. Neste programa, somente o nome da criptomoeda deve 
                ser cadastrado (em maiúsculo). Ao cadastrar, não pode haver duplicidade de dados na lista. Sempre
                que a opção listar for acionada, a listagem deve ser exibida de forma ordenada. No processo de 
                remoção, o usuário entra com o nome da criptomoeda que deseja remover. Caso o programa a encontre,
                deve remover e avisar o usuário que a operação ocorreu corretamente, e caso não a encontre, avisar
                ao usuário que nome não foi encontrado.
                            Menu 
                1 - Cadastrar criptomoeda 
                2 - Listar criptomoedas
                3 - Remover criptomoeda
                4 - Atualizar criptomoeda   
                5 - Sair
                Opção: 
             */

            List<string> listaCrypto = new List<string>();
            List<double> valorCrypto = new List<double>();
            List<double> quantidadeCrypto = new List<double>();
            Console.WriteLine("-----MENU-----");
            string cryptoNome;
            double cryptoValor, quantidade;
            int opcao = 0;
            do
            {
                Console.WriteLine("1- Cadastras Criptomoedas");
                Console.WriteLine("2- Listar Criptomoedas");
                Console.WriteLine("3- Remover Criptomoedas");
                Console.WriteLine("4- Atualizar Criptomoedas");
                Console.WriteLine("5- Sair.");
               opcao = int.Parse(Console.ReadLine());
                if(opcao == 1)
                {
                    do
                    {
                     Console.WriteLine("Digite a Criptomoeda a ser cadastrada:");
                        cryptoNome = Console.ReadLine().ToUpper();
                        if(listaCrypto.Contains(cryptoNome) == true)
                        {
                            Console.WriteLine("Item já Cadastrado!");

                        }
                        else 
                        {   
                            listaCrypto.Add(cryptoNome);
                            Console.WriteLine("Qual a quantidade possuida ? ");
                            quantidade = double.Parse(Console.ReadLine());
                            
                            quantidadeCrypto.Add(quantidade);
                            Console.WriteLine("Qual a cotação Atual? ");
                           
                            cryptoValor = double.Parse(Console.ReadLine());
                            valorCrypto.Add(cryptoValor);
                           
                            Console.WriteLine("Deseja Continuar? 1 - Sim/ 0 - Não");
                            opcao = int.Parse(Console.ReadLine());
                                                        
                        }
                                                   
                    } while (opcao == 1);

                }
                if (opcao == 2)
                {
                    for (int i = 0; i < listaCrypto.Count(); i++)

                    {
                        Console.WriteLine("Posição - " + (i + 1) + " - " + listaCrypto[i]);
                    }
                    for (int j = 0; j < quantidadeCrypto.Count(); j++)
                    {
                        Console.WriteLine("Quantidade - " + (j + 1) + " - " + quantidadeCrypto[j] + "- Unidades");
                    }
                    for (int k = 0; k < valorCrypto.Count(); k++)
                    {
                        Console.WriteLine("Valor - " + (k + 1) + " - " + valorCrypto[k] + "- U$D");
                    }
                }
                Console.WriteLine();
                string continuar;
                if (opcao == 3)
                {
                    do
                    {
                        Console.WriteLine("Digite a Moeda que deseja remover: ");
                        string remover = Console.ReadLine();
                        listaCrypto.Remove(remover);
                        Console.WriteLine(" A moeda " + remover + " Foi removida da Lista");
                        Console.WriteLine("Deseja Remover mais algum item ? \n S/N ?");
                        continuar = Console.ReadLine();
                    }
                    while (continuar != "S");
                } if (opcao == 4)
                {
                    do
                    {
                    Console.WriteLine("Qual a moeda que deseja alterar: ");
                    string indiceAltera = Console.ReadLine();
                        if (listaCrypto.Contains(indiceAltera))
                        {
                            listaCrypto.Remove(indiceAltera);
                            Console.WriteLine("Qual novo nome da moeda? ");
                            string novoNome = Console.ReadLine();
                            listaCrypto.Add(novoNome);
                            Console.WriteLine("Deseja Continuar? 1 - Sim/ 0 - Não");
                            opcao = int.Parse(Console.ReadLine());
                        }




                    } while (opcao != 0 );

                }
            } while (opcao != 5);
        }

                    //    foreach (var item in listaCrypto )
                    //    {
                    //        Console.WriteLine( item );
                    //    }
                    //    foreach (var item in quantidadeCrypto)
                    //    {
                    //        Console.WriteLine(item);
                    //    }
                    //    foreach(var item in valorCrypto)
                    //    {
                    //        Console.WriteLine(item);
                    //    }






        
    }
}