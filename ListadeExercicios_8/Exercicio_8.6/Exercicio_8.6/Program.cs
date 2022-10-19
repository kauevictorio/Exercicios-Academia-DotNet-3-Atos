using System.IO;
namespace Exercicio_8._6

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6) Crie uma classe para funcionário. Ele deve ter o nome do funcionário, o departamento onde trabalha, seu salário (double), a data de entrada no banco (String), seu RG (String) e um valor booleano que indique se o
                funcionário ainda está ativa na empresa no momento ou se já foi mandado embora.
                Você deve criar alguns métodos de acordo com sua necessidade. Além deles, crie um método bonifica que aumenta o salario do funcionário de acordo com o parâmetro passado como argumento. Crie, também, um
                método demite, que não recebe parâmetro algum, só modifica o valor booleano indicando que o funcionário não trabalha mais aqui.
                Crie uma lista de funcionários e faça um menu iterativo onde você pode inserir e consultar todos os funcionários cadastratos.

                Utilizando o exercício anterior, faça um método abstrato na classe funcionário chamado "ExecutaTrabalho". Haverá duas implementações da classe Funcionario chamada de Gerente e Operador. 
                Nos metodos de cada uma das classes Gerente e Operador deverá aparecer a mensagem informando qual é a função desempenhada pelo funcionário
             
             */

            List<Funcionario> listaFuncionario = new List<Funcionario>();
            Funcionario f = new Gerente(), funcionarioBusca = new Gerente();
            string nome, depto, rg, nomeBusca = "";
            int op;
            double salario, aumento;
            DateTime dataCriacao = DateTime.Today;
            string data = dataCriacao.ToShortDateString();
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar, 2 aumentar salário, 3 para demitir" + " 4 para mostrar os dados e 5 para sair.");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Qual cargo do funcionário? 1 = Gerente, 2 = Operador");
                        int cargo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do funcionário");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite o departamento do funcionário");
                        depto = Console.ReadLine();
                        Console.WriteLine("Digite o RG do funcionário");
                        rg = Console.ReadLine();
                        Console.WriteLine("Digite o salário do funcionário");
                        salario = float.Parse(Console.ReadLine());
                        if (cargo == 1)
                        {
                            f = new Gerente(nome, depto, data, rg, salario, true);
                        }
                        else if (cargo == 2)
                        {
                            f = new Operador(nome, depto, data, rg, salario, true);
                        }
                        listaFuncionario.Add(f);
                        break;
                    case 2:
                        Console.WriteLine("Digite o nome do funcionário que deseja aumentar o salário:");
                        nomeBusca = Console.ReadLine();
                        funcionarioBusca = listaFuncionario.Find(delegate (Funcionario f) { return f.Nome == nomeBusca; });
                        if (funcionarioBusca == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        Console.WriteLine("Em quanto deseja aumentar o salário? ");
                        aumento = int.Parse(Console.ReadLine());
                        funcionarioBusca.Bonifica(aumento);
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do funcionário que deseja demitir:");
                        nomeBusca = Console.ReadLine();
                        funcionarioBusca = listaFuncionario.Find(delegate (Funcionario f) { return f.Nome == nomeBusca; });
                        if (funcionarioBusca == null)
                        {
                            Console.WriteLine("Funcionário não encontrado");
                            break;
                        }
                        funcionarioBusca.Demite();
                        break;
                    case 4:
                        Console.WriteLine("------------");
                        foreach (Funcionario funcio in listaFuncionario)
                        {
                            funcio.MostraDados();
                            funcio.ExecutaTrabalho();
                            Console.WriteLine("------------");
                        }
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente:");
                        break;
                }
            }
        }
    }
}