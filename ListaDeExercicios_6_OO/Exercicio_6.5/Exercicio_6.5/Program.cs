namespace Exercicio_6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5. Crie um programa em VS que popule duas listas (lista1 e lista2) com números aleatórios (100 a 200).
                A quantidade de números deve ser informada pelo usuário. Em seguida, o programa deve listar os 
                conteúdos das duas listas e exibir os números que aparecem em ambas as listas.
             */

            List<int> numerosAleatorios1 = new List<int>();
            Random aleatorio = new Random();
            Random aleatorio2 = new Random();

            Console.WriteLine("Quantos numeros Aleatorios deseja armazenar na lista 1 ");
            int tamanhoLista1 = int.Parse(Console.ReadLine());
            int[] armazenamento = new int[tamanhoLista1];

            do
            {
                numerosAleatorios1.Add(aleatorio.Next(100, 200));
            } while (numerosAleatorios1.Count <= tamanhoLista1);
            Console.WriteLine("Os numeros da lista 1 são: ");
            foreach (var item in numerosAleatorios1)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();
            List<int> numerosAleatorios2 = new List<int>();   
            Console.WriteLine("Quantos numeros Aleatorios deseja armazenar na lista 2 ");
            int tamanhoLista2 = int.Parse(Console.ReadLine());
            do
            {
                numerosAleatorios2.Add(aleatorio2.Next(100, 200));
            } while (numerosAleatorios2.Count <= tamanhoLista1);
            Console.WriteLine("Os numeros da lista 2 são: ");
            foreach (var item in numerosAleatorios2)
            {
                Console.Write(" " + item + " ");
            }
            Console.WriteLine();
            List<int> numerosRepetidos = new List<int>();
            for (int i = 0; i < numerosAleatorios1.Count; i++)
            {
                if (numerosAleatorios1[i] == numerosAleatorios2[i])
                {
                    numerosRepetidos.Add(numerosAleatorios1[i]);

                }
            }
            Console.WriteLine("Os numeros Repetidos na lista 1 e 2 são: ");
            foreach (var item in numerosRepetidos)
            {
                Console.Write(" " + item + " ");
            }
            

        }
    }
}