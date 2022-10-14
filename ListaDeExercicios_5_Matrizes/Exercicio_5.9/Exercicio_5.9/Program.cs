using System.Net;

namespace Exercicio_5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
          9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise
          na matriz se o número existe.  
          Caso, seja verdade imprima a mensagem:  “O número existe no vetor” ,
          caso contrário “Número inexistente”. 
            */
            Random n = new Random();
            int[,] matriz = new int [3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = n.Next(0, 10);
                }
            }
            Console.WriteLine("Digite um numero para verificar se está na lista: ");
            int verificador = 0;
            verificador = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ( matriz[i,j] == verificador ) 

                    {
                        Console.WriteLine("O numero " + verificador +" está presente na lisa "+ (i + 1 )+ "da matriz!" );
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O numero " + verificador + " não está na lista " + (i + 1) + " da matriz! ");
                        break;
                    }
                }

                   
            }
        }

    }
}