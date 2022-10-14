namespace Exercicio_3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
                ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
                Ao final, mostre a idade digitada.
               */



            int idade;
            do
            {
                Console.WriteLine("Digite sua idade: ");
                 idade = int.Parse(Console.ReadLine());
                if (idade < 18)
                {
                    Console.WriteLine("Idade Invalida!");
                    
                }
                else
                {
                    Console.WriteLine("Bem Vindo!");
                }




            }while (idade < 18);
        }

    }
}