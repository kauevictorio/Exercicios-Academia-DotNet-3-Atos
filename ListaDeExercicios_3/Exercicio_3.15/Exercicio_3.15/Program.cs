namespace Exercicio_3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
                 ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
                 Considerar nota 7,0 como mínima para aprovação.
             */

            Console.WriteLine("Digite a nota 1 do aluno: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2 do aluno: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3 do aluno: ");
            int nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4 do aluno: ");
            int nota4 = int.Parse(Console.ReadLine());
            double media;
            int peso1 = 2, peso2 = 1, peso3 = 2, peso4 = 4;
            nota1 = nota1 * peso1;
            nota2 = nota2 * peso2;  
            nota3 = nota3 * peso3;
            nota4 = nota4 * peso4;
            media = (nota1 + nota2 + nota3 + nota4) / (peso1 + peso2 + peso3 + peso4);

            if(media < 7)
            {
                Console.WriteLine("Media inferior a 7, Aluno reprovado com media " + media);
            }
            else
            {
                Console.WriteLine("Aluno Aprovado! com media: " + media);
            }
        }
    }
}