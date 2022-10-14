namespace Exercicio_3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
                 A cada solicitação, teste se o usuário informou um valor válido. 
                 Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
                 informe que ele está incorreto e saia do programa em VS. 
                 Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
                 informe que está errada e saia. Se estiver correta, solicite o salário. 
                 Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
                 Se estiver correto, mostre todos os valores lidos.

             */
            string nome;
            string idade;
            string salario;
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            if (String.IsNullOrEmpty(nome) || (nome.Any(char.IsDigit)))
            {
                Console.WriteLine("Nome digitado invalido!\n Finalizando Programa...");
                Environment.Exit(0);
            }
            Console.WriteLine("Digite sua idade: ");
            idade = Console.ReadLine();
            if (String.IsNullOrEmpty(idade) || (idade.Any(char.IsDigit)))
            {
                Console.WriteLine("idade digitada invalida!\n Finalizando Programa...");
                Environment.Exit(0);
            }

            Console.WriteLine("Digite seu salario!");
                    salario = Console.ReadLine();
            if (String.IsNullOrEmpty(salario) || (salario.Any(char.IsDigit)))
            {
                 Console.WriteLine("Salario digitado invalido!\n Finalizando o programa... ");
                Environment.Exit(0);
                }
        



        }
    }
}