namespace Exercicio_3._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
                  elevada a um expoente qualquer, ou seja, NM.
             */
            int expoente , base1;
            int contador = 0;
            Console.WriteLine("Qual o numero a ser multiplicado: ");
            base1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qaul o valor do expoente: ");
            expoente = int.Parse(Console.ReadLine());
            int aux; 

            while (contador <= 10)
            {
                aux = (expoente * base1) * contador;

                Console.Write(aux  + " - ");                
                contador++; 
            }
          



        
        }

    }
}