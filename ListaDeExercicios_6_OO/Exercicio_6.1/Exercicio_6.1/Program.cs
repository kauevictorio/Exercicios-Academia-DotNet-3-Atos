namespace Exercicio_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Fazer um programa em VS que popule uma lista de nomes, com nomes completos obrigatoriamente.
            Ao cadastrar o nome na lista, o nome deve ser validado para que tenha no mínimo duas palavras e 
            que não esteja na lista. Ao final, caso o nome não esteja na lista, cadastra-lo em maiúsculo e 
            exibir a lista ordenada.
              */
            string nomeCompleto;
            List<string> nomesPessoas = new List<string>();
            int continuar;
            string[] dadosNome;
            do
            {
                //
                do
                {
                    Console.Write("Digite seu nome completo: ");
                    nomeCompleto = Console.ReadLine().ToUpper();
                    dadosNome = nomeCompleto.Split(" ");
                    Console.WriteLine(dadosNome[0]);
                } while (dadosNome.Length <= 1);

                if (nomesPessoas.Contains(nomeCompleto))
                {
                    Console.WriteLine("Nome já cadastrado");
                }
                else
                {
                    nomesPessoas.Add(nomeCompleto);
                }

                Console.Write("1 - para continuar; 2 - para sair: ");
                continuar = int.Parse(Console.ReadLine());
            } while (continuar == 1);

            nomesPessoas.Sort();
            Console.WriteLine("Pessoas cadastradas");
            foreach (var item in nomesPessoas)
            {
                Console.WriteLine(item);
            }




        }
    }
}