namespace Exercicio_6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6. Continuação do exercício 1. Entretanto, quando listar os nomes, mostrar somente os sobrenomes.
                Além disso, o programa deve mostrar as pessoas que são da mesma família.
             */


            string nomeCompleto;
            List<string> nomesPessoas = new List<string>();
            List<string> listaSobrenomes = new List<string>();
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

            foreach (var item in nomesPessoas)
            {
                String[] nomeSeparado = item.Split(" ").ToArray();
                string nome = nomeSeparado[0];
                string sobrenome = nomeSeparado[1];
                string sobrenome2 = nomeSeparado[2];
                string sobrenome3 = nomeSeparado[3];
               
                if (listaSobrenomes.Contains(sobrenome) == false)
                {
                    listaSobrenomes.Add(sobrenome + sobrenome2 + sobrenome3);
                }

            }
                
            listaSobrenomes.Sort();
            Console.WriteLine("---Sobrenomes Cadastrados---");
            foreach (var item in listaSobrenomes)
            {
                if (item != (item + 1) )
                {
                    Console.WriteLine(item +","+ item + " São da Mesma Familia");
                }
                else  
                { 
                 Console.Write(item + (item+1) + " São da Mesma Familia");
                }   
            }

        }
    }
}