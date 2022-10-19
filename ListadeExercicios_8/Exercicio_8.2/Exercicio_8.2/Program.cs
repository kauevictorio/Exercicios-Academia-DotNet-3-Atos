namespace Exercicio_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             2) Crie um programa em C# no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
                 O programa deverá exibir na tela para o usuário quantos Cachorros, Gatos e Peixes foram informados.

                 Regras que deverão ser seguidas para a implementação do programa:

                 Os únicos tipos de animais válidos são Cachorro, Gato, Peixe.
                 Caso seja informado um tipo diferente o programa repetir até o usuário digitar um tipo válido.
                 É obrigatório criar uma classe para representar o Animal.
                 A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
                 A classe deverá possuir métodos de acesso (propriedade getter e setter) para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades).
             */

            List<string> pets = new List<string>();
            List<string> specie = new List<string>();
                string petName = null;
            string specieName = null;
            int count = 0;
            do
            {
                Console.WriteLine("Informe o nome do animal: ");
                petName = Console.ReadLine().ToUpper();
                Console.WriteLine("Agora o tipo do animal: Cachorro, Gato  ou Peixe ");
                specieName = Console.ReadLine().ToUpper();
                if (!specieName.Contains("CACHORRO"))
                {
                    if (!specieName.Contains("GATO"))
                    {
                        if (!specieName.Contains("PEIXE"))
                        {

                            Console.WriteLine("Espécie Invalida, Digite novamente, Cachorro, Gato ou Peixe ");
                            specieName = Console.ReadLine().ToUpper();
                        }

                    }
                }
                else
                {
                pets.Add(petName);
                specie.Add(specieName);
                }
                    count++;
                
            } while (count <= 5);

                    Animal animal = new Animal(specieName, petName);
            for (int i = 0; i < pets.Count(); i++)
            {
                animal.getSpecies();
                animal.getName();
            }

            for (int i = 0; i < petName.Length; i++)
            {
               
            }

        }
    }
}