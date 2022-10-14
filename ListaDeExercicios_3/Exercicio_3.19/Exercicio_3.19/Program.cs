namespace Exercicio_3._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
                coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
                a) média do salário da população;
                b) média do número de filhos;
                c) maior salário;
                d) percentual de pessoas com salário até R$ 100,00.
                O final da leitura de dados se dará com a entrada de um salário negativo.
             
             */

            //media dos salarios e percentual das pessoas com salario até 100
            double mediaSalario, salario, maiorSalario;
            double aux = 0;
            int op = 0;
            int op2 = 0;
            do
            {
            Console.WriteLine("Digite seu salario:  ");
                 salario = double.Parse(Console.ReadLine());
                if(salario >= 100)
                {
                    op2++;

                }
                salario = salario + salario;
                aux  = aux + salario ;
                op++;
                Console.WriteLine(op);

            } while (op < 10);
            mediaSalario = aux / op;
            Console.WriteLine("Media dos Salarios da cidade" + mediaSalario);
            maiorSalario = op * op2;
            Console.WriteLine("numero de pessoas com salario acima de 100,00 reais é: " + op2 + "que corresponde a "+ maiorSalario +" % da população");
            
        }
    }
}