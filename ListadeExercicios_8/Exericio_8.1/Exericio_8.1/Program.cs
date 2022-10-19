using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace Exericio_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1) Implemente um programa em C# no qual o usuário deverá informar o nome e o poder (0 a 10) de três personagens. 
                O programa deverá informar o nome do personagem que possuir o maior poder.

                Regras que deverão ser seguidas para a implementação do algoritmo:

                É obrigatório o uso de classe para representar um Personagem e a mesma deverá possuir como propriedades (características) um nome e um poder.
                A classe também deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e o poder do personagem em questão.
                Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e outro que 
                irá receber o nome e o poder de um personagem

             */
            Console.WriteLine("----Personagens e Poderes----");
            string nome1 = null,  nome2 = null,  nome3 = null;
            NameEntry1:
            Console.WriteLine("Qual o nome do personagem 1: ");
             nome1 = Console.ReadLine();
            while (nome1 == null || nome1 == string.Empty)
            {
                Console.WriteLine("Nome Invalido! digite o nome novamente! ");
                nome1 = Console.ReadLine();

            }
            
            Console.WriteLine("Qual o poder do personagem 1, de 0 a 10: ");
            int poder1 = int.Parse(Console.ReadLine());

            if (poder1 > 10 && poder1 != null )
            {
                Console.WriteLine("Poder Invalido! Digite novamente: ");
                poder1 = int.Parse(Console.ReadLine());

            }
            Personagem personagem1 = new Personagem(nome1, poder1);
            
            Console.WriteLine("Qual o nome do personagem 2: ");
             nome2 = Console.ReadLine();
            while (nome2 == null || nome2 == string.Empty)
            {
                Console.WriteLine("Nome Invalido! digite o nome novamente! ");
                nome2 = Console.ReadLine();

            }

            Console.WriteLine("Qual o poder do personagem 1, de 0 a 10: ");
            int poder2 = int.Parse(Console.ReadLine());

            if (poder2 > 10 && poder2 != null)
            {
                Console.WriteLine("Poder Invalido! Digite novamente: ");
                poder2 = int.Parse(Console.ReadLine());

            }
            Personagem personagem2 = new Personagem(nome2 , poder2);

            NameEntry3:
            Console.WriteLine("Qual o nome do personagem 3: ");
             nome3 = Console.ReadLine();
            while (nome3 == null || nome3 == string.Empty)
            {
                Console.WriteLine("Nome Invalido! digite o nome novamente! ");
                nome3 = Console.ReadLine();

            }

            Console.WriteLine("Qual o poder do personagem 1, de 0 a 10: ");
            int poder3 = int.Parse(Console.ReadLine());

            if (poder3 > 10 && poder3 != null)
            {
                Console.WriteLine("Poder Invalido! Digite novamente: ");
                poder3 = int.Parse(Console.ReadLine());

            }
            Personagem personagem3 = new Personagem (nome3 , poder3);


            if( poder1 > poder2 && poder1 > poder3)
            {
                    personagem1.mostraDados();
            }
            else if(poder2 > poder3 && poder2 > poder1)
            {
                personagem2.mostraDados();
            }
            else if (poder3 > poder1 && poder3 > poder2)
            {
                personagem3.mostraDados();
            }

            
        }
    }
}