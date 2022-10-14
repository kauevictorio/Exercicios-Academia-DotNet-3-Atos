namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16 - 
            // vetor x e y
            // união - elementos de X e os elementos de Y que não estão estão em x
            // diferença - elementos de X que não estão em Y
            // intersecção - elementos que aparecem em X e Y


            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 1, 5, 6, 4, 9, 12, 11, 16, 43, 19 };

            int[] uniao = new int[20];
            int[] diferença = new int[10];
            int[] interseccao = new int[10];

            Console.WriteLine("UNIÃO");
            x.CopyTo(uniao, 0);
            int auxU = 10;


            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }
                    if (j == (x.Length - 1))
                    {
                        uniao[auxU] = y[i];
                        auxU++;
                    }
                }
            }

            for (int i = 0; i < auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("DIFERENÇA");

            int auxD = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }
                    if (j == (y.Length - 1))
                    {
                        diferença[auxD] = x[i];
                        auxD++;
                    }
                }


            }
            for (int i = 0; i < auxD; i++)
            {
                Console.WriteLine(diferença[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("INTERSECÇÃO");
            int auxI = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[i])
                    {
                        interseccao[auxI] = x[i];
                        auxI++;
                        break;
                    }
                }

            }

                for (int i = 0; i < auxI; i++)
                {
                    Console.WriteLine(diferença[i]);
                }

           
        }
    }
}