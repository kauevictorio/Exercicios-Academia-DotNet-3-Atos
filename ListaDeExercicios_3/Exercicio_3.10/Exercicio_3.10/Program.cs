namespace Exercicio_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
                Número de pessoas do sexo masculino.
                Número de pessoas do sexo feminino.
                Número de pessoas com idade inferior a 30 anos.
                Número de pessoas com idade superior a 60 anos.
                Média de idade das mulheres.
             */
            int idade = 0;
            string sexo;
            int pessoas = 0;
            int sexoMasculino = 0, sexoFeminino = 0, sub30 = 0, sup60 = 0, mediaMulheres;
            do
            {
                Console.WriteLine("Qual seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Qual sua idade:");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual sexo? M ou F");
                sexo = Console.ReadLine().ToUpper();

                if (sexo == "M")
                {
                    sexoMasculino++;
                }
                else if ( sexo == "F")
                {
                    sexoFeminino++;
                }

                if(idade < 30)
                {
                    sub30++;
                }
                else if(idade > 60)
                {
                    sup60++;
                }
                if (sexo == "F")
                {
                    idade += idade;
                }
                pessoas++;

            } while (pessoas < 5);
            Console.WriteLine(sexoFeminino);
            mediaMulheres = idade / sexoFeminino; 
            Console.WriteLine("A media das idades das mulheres é: " + mediaMulheres);
            Console.WriteLine( sub30 + " Pessoa(s) com menos de 30 anos ");
            Console.WriteLine(sup60 + " Pessoa(s) com mais de 60 anos");
            Console.WriteLine(sexoFeminino + " Pessoa(s) do sexo feminino");
            Console.WriteLine(sexoMasculino + " Pessoa(s) do sexo Masculino");
         }
    }
}