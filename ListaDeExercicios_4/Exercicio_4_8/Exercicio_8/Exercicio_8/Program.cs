namespace Exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada numero menor que zero desse vetor. Exemplo:
            //        a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
            //        b.	escreve: 	|3|5|6|7|9|10|14|. . .
            //dado o array X.
            // percorrer o array item a item
            // para cada item verificar se < 0 
            // então se < que 0 exibir posição
            // se não não faz nada.           0  1  2    3   4    5    6   7   8    9   
           
            
            double[] vetor = new double[10] {5.1,0,-3.6,4.1,-2.5,-1.3,6.4,154,1.39,-88};
            for (int i = 0; i < vetor.Length; i++)
            {
                if ( vetor[i] < 0) 
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}