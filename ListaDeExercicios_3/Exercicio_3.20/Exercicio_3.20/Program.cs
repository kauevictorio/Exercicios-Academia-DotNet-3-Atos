namespace Exercicio_3._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
                 certa região, a qual coletou os seguintes dados referentes a cada habitante para 
                 serem analisados:
                 - sexo (masculino e feminino)
                 - cor dos olhos (azuis, verdes ou castanhos)
                 - cor dos cabelos ( louros, castanhos, pretos)
                 - idade 

                 Faça um algoritmo que determine e escreva: 

                 - a maior idade dos habitantes
                 - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
                 e que tenham olhos verdes e cabelos louros.
                 O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
             */

            string nome, corOlhos, corCabelo, sexo;
            int idade, maiorIdade, cabeloLouro, cabeloCastanho, cabeloPreto, olhosVerdes, olhosAzuis, olhosCastanhos, fem18a35 = 0, countIdade = 0;

            do
            {
                Console.WriteLine("Qual seu nome: ");
                nome = Console.ReadLine().ToUpper();
                Console.WriteLine("Qual seu sexo: M/F ?");
                sexo = Console.ReadLine().ToUpper();
                Console.WriteLine("Qual sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a cor dos seus olhos: ");
                corOlhos = Console.ReadLine().ToUpper();
                Console.WriteLine("Qual a cor do seu cabelo");
                corCabelo = Console.ReadLine().ToUpper();

                if(sexo == "F")
                {
                    if (idade > 18 && idade < 35)
                    {
                        if(corOlhos == "VERDE")
                        {
                            if(corCabelo == "LOIRO")
                            {
                                fem18a35++;
                            }
                        }
                    }
                }
                else if (idade > idade +1)
                {
                    countIdade = idade;
                }
                else if (idade == -1)
                {
                    break;
                }

            } while (idade != -1);
            Console.WriteLine("Na cidade tem " + fem18a35 + " Mulheres entre 18 a 35 anos com olhos verdes e cabelos loiros");
            Console.WriteLine(" O habitante mais velho tem " + countIdade);

        }
    }
}