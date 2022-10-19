namespace Exercicio_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               4) Crie uma classe para representar um item de cenário, com os atributos privados de:
                    * descrição (string), 
                    * data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
                    * altura (float). 

                Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
                todos dados de um item de cenário. 
                Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
                a classe criada.
             */
            List<Cenario> c = new List<Cenario>();
            string descrição = null;
            float height = 0;
            DateTime now = DateTime.Now;

            Console.WriteLine("Qual a descrição geral do cenario: ");
            descrição = Console.ReadLine();

            Console.WriteLine("A data de criação do cenarios é:" + now);

            Random rand = new Random();
            height = rand.Next(0, 50);

            Console.WriteLine("A altura do cenario é: " + height +" Metros.");

            Cenario cena1 = new Cenario(descrição, now , height);

            c.Add(cena1);

            foreach (Cenario item in c)
            {
                item.mostraDados();

            }   
        }
    }
}