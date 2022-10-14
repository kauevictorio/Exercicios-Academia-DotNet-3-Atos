namespace Exercicio_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3. Fazer um programa em VS, com uso de menu, com cadastrar emails, listar emails e sair do programa.
                Os emails digitados devem ser cadastrados em uma lista e não pode haver emails duplicados, ou seja,
                o programa deve controlar essa situação. Quando o usuário solicitar a listagem dos emails, além dessa
                lista, o programa deve listar os domínios de emails cadastrados no programa.

                Menu
                1 - Cadastrar email
                2 - Listar 
                3 - Sair 
                Opção: 

             */

            List<string> listaEmails  = new List<string>();
            List<string> listaDominios = new List<string>(); 
            int acao, resposta;
            string email;
            string [] emailAux;
                Console.WriteLine("-----MENU-----");
            do
            {
                Console.WriteLine("1- cadastrar e-mails");
                Console.WriteLine("2- Listar E-mails Cadastrados");
                Console.WriteLine("3- Sair");
                acao = int.Parse(Console.ReadLine());
                if(acao == 1)
                {
                    Console.WriteLine("Digite o email a ser cadastrado" );
                    email = Console.ReadLine();
                    if (listaEmails.Contains(email))
                    {
                        Console.WriteLine("Email já Cadastrado!");
                    }
                    else
                    {
                        listaEmails.Add(email); // *como validar email*
                        
                        Console.WriteLine("deseja continuar? digite 1 para Sim ou 3 para sair");
                        acao = int.Parse(Console.ReadLine());
                    }
                    foreach (var item in listaEmails)
                    {
                       String[] emailSeparado = item.Split("@");
                        string dominio = emailSeparado[1];
                        if (listaDominios.Contains(dominio) == false)
                        {
                            listaDominios.Add(dominio);
                        }
                    }
                }
                else if (acao == 2)
                {
                    listaEmails.Sort();
                    Console.WriteLine("Lista de E-mails Cadastrados: ");
                    foreach (var item in listaEmails)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Os dominios Presentes na lista: ");
                    foreach (var item in listaDominios)
                    {
                        Console.WriteLine(item);
                    }
                }

            } while (acao != 3);



        }
    }
}