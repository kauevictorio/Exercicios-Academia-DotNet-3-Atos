namespace Exercicio_5._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos,
             em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.
             */
            Random n = new Random();
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];

            for (int i = 0; i < 4; i++) //preencher a matriz1
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz1[i, j] = n.Next(1, 25);
                }
            }
           
            
            for (int i = 0; i < 4; i++)//preencher a matriz2
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz2[i, j] = n.Next(1, 25);
                }
            }


            //for (int a = 0; a < 4; a++) //mostrar a matriz1 temp 
            //{
            //    for (int b = 0; b < 4; b++)
            //    {
            //        Console.Write("[" + a + "," + b + "] = " + matriz1[a, b] + "  ");
            //    }
            //    Console.WriteLine();


            //}
            //for (int x = 0; x < 4; x++) // mostrar a matriz2 temp
            //{
            //    for (int y = 0; y < 4; y++)
            //    {
            //        Console.Write("[" + x + "," + y + "] = " + matriz2[x, y] + "  ");
            //    }
            //    Console.WriteLine();

            //}   
                    double media1 = 0;
                    double soma = 0;



            
                        
                




        }
    }
}