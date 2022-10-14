namespace Exercicio_4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
                e em seguida ordene em ordem crescente os valores desse vetor, utilizando um 
                vetor auxiliar.
             */
            int[] vetor = new int[10] { 10, 7, 3, 4, 2, 12, 13,5, 9, 19 };
            int [] vetorAux =new int [10];
            int aux = 0, trocas = 0;
            int comparador = 0;
            int tamanho = vetor.Length;

            for (int i = tamanho -1 ; i >= 1; i--)
            {
                for (int j = 0; j < i ; j++)
                {
                    comparador++;

                    if (vetor[j] > vetor[ j + 1])
                    {
                        vetorAux[i] = vetor[j];
                            vetor[j] = vetor[j + 1];
                        vetor[j + 1] = vetorAux[i + 1];
                                trocas++; 

                      
                    }               
                }
            }
            
            for (int i = 0; i < vetorAux.Length; i++)
            {
                Console.WriteLine("vetor[" + i + "] = " + vetorAux[i]);
            }
        }
    }
}