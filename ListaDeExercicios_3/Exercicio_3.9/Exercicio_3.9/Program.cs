namespace Exercicio_3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
             o zoológico num determinado dia, imprimindo:
             Quantas pessoas tem entre 1 e 3 filhos.
             Quantas pessoas tem entre 4 e 7 filhos.
             Quantas pessoas tem mais de 8 filhos.
             Quantas pessoas não tem filhos.
             */
            int pessoas = 0;
            int filhos;
            int umatres = 0, quatroasete = 0, maisdeoito = 0   ;
                int naotem = 0;


            while (pessoas <= 30)
            {
            Console.WriteLine("Quantos filhos?: ");
            filhos = int.Parse(Console.ReadLine());

                if (filhos <= 3)
                {
                    umatres++;

                }
                else if (filhos > 3 && filhos <= 7)
                {
                    quatroasete++;
                }
                else if (filhos > 7)
                {
                    maisdeoito++;
                }
                else if (filhos == 0)
                {
                    naotem++;
                }
               pessoas++;

            }
            Console.WriteLine(umatres+ " Pessoas tem de 1 a 3 filhos");
            Console.WriteLine(quatroasete + " Pessoas tem de 4 a 7 filhos ");
            Console.WriteLine(maisdeoito + " Pessoas tem mais de 8 filhos");
            Console.WriteLine( naotem + " Pessoas não tem nenhum filho");

        
        }


    }
}