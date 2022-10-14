namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 40 | 0 | 22 | 7 | 3 | 9 | 21 | 63 | 31 | 7 |

            int[] impar = new int[] { };
            int[] pares = new int[] { };
            int[] lista1 = new int[10] { 7, 40, 3, 9, 21, 0, 63, 31, 7, 22 };

            for (int i = 0; i < lista1.Length; i++)
            {
                if (lista1[i] % 2 == 0)
                {
                    //Console.WriteLine(lista1[i]);
                    pares = pares.Append(lista1[i]).ToArray();
                    //Console.WriteLine(pares[i]);
                }
                else
                {
                    impar = impar.Append(lista1[i]).ToArray();
                }

            }
            //for (int i = 0; i < lista1.Length; i++)
            //{
            //    if (lista1[i] % 2 == 1)
            //    {
            //        //Console.WriteLine(lista1[i]);
            //        impar = impar.Append(lista1[i]).ToArray();
            //        //Console.WriteLine(impar[i]);
            //    }
            //}
            int[] result = new int[] { };
            result = result.Concat(pares).ToArray();
            result = result.Concat(impar).ToArray();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}