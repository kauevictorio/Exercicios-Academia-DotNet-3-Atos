namespace Exercicio_5._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor,
                    substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.
             */
            int[] array = new int[20];
            int[] array2 = new int[20];
            Random n = new Random();
            for (int i = 0; i < array.Length ; i++)
            {
                array[i] = n.Next(0,6);
               
            }
            for (int i = 0; i < array2.Length; i++)
            {
                if (array[i] != 0 )
                {
                    array2[i] = array[i];
                   
                }
                else
                {
                    array2[i] = array[i] + 2 ;
                }
            }
                Console.WriteLine( "O vetor 1 com os valores originais: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" | " + array[i]  );
            }
            Console.WriteLine();
            Console.WriteLine("O novo vetor com os valores nulos substituidos: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(" | " + array2[i]  );
            }
            Console.WriteLine();
         } 
    }
}