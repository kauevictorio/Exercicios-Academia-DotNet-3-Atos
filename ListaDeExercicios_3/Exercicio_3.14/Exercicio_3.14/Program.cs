namespace Exercicio_3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             14. Mostrar as potências de 2 variando de 0 a 10.
             */
            int i = 0, potencia = 2;
            int resultado;

            for (i = 0; i <= 10; i++)
            {
                resultado = potencia * i;

            
           
              Console.Write(resultado + ",");
            }

        }
    }
}