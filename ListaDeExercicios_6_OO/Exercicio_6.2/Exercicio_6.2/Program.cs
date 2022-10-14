using System.Runtime.Intrinsics.X86;

namespace Exercicio_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Fazer um programa em VS que popule uma lista com números inteiros(0 a 1000)
            //que sejam sorteados randomicamente.O programa deve pedir ao usuário quantos números
            //deseja armazenar. Ao final, o programa deve exibir os números populados na lista.

            List<int> numerosAleatorios = new List<int>();
            Random aleatorio = new Random();
            Console.WriteLine("Quantos numeros aleatorios deseja armazenar na lista: ");
            int tamanhoLista = int.Parse(Console.ReadLine());  
            int[] armazenamento = new int[tamanhoLista];

            do
            {
                numerosAleatorios.Add(aleatorio.Next(0,1000));

            } while (numerosAleatorios.Count <= tamanhoLista);
            Console.WriteLine("Os numeros Armazenados Aleatoriamente foram: ");
            foreach (var item in numerosAleatorios)
            {
                Console.Write(" " +item + " ");
            }
        }
    }
}