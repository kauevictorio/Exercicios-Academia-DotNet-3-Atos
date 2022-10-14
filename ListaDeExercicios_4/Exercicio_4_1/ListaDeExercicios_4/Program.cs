namespace ListaDeExercicios_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Escreva um algoritmo que leia os valores para um vetor
            // de 10 elementos e então mostre na tela a quantidade de
            // números pares e ímpares.
            int i;
            int[] lista1 = new int[10] ;
            Console.WriteLine("Leitura dos valores!");
            int aux1 = 0;
            Console.WriteLine("dada a Lista: ");
            for (i = 0; i < lista1.Length ; i++)
            {
               if(i % 2 == 0)
                {
                    Console.WriteLine( i + " É par!" );
                    aux1 =  i;  
                    i++;
                    
                }
               else if (i % 2== 1)
                {
                    Console.WriteLine( i + " É Impar");
                    
                }

                
            }
          

            //int[] vetor = new int[10];
            //int i, maior, pos;

            //for (i = 0; i < 10; i++)

            //{
            //    Console.WriteLine("Digite o valor do elemento " + i);
            //    vetor[i] = int.Parse(Console.ReadLine());
            //}
            //maior = vetor[0]; //defino que o primeiro elemento é o maior
            //pos = 0;
            //for (i = 0; i < 10; i++)
            //{
            //    if (vetor[i] > maior)
            //    {
            //        maior = vetor[i];
            //        pos = i;
            //    }
            //}
            //Console.WriteLine("O maior elemneto é: " + maior + " e está na posiçao " + pos);



        }
    }
}