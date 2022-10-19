namespace Exercicio_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             3) Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
                uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
                um plano cartesiano), tamanho do asteroide (1 a 10), velocidade do asteroide (1 a 5) e energia (1 a 5). Para esses atributos privados, gerar os métodos de acesso
                (propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
                terceiro que constrói um asteroide com posição x e posição y. 
                O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
                asteróides da lista.
             */

            Random random = new Random();
            List<Asteroid> listAsteroid = new List<Asteroid>();
                Console.WriteLine("Preencha os dados do Asteroid que será lançado contra a nave: ");
                Console.WriteLine("---------------------------------------------------------------");
                int asteroidId = 0, asteroidSize = 0, asteroidSpeed = 0, asteroidEnergy = 0 ;
            int count = 0;
            do
            {

                try
                {
                    Console.WriteLine("Digite o numero ID do asteroid " + (count + 1) + ": ");
                    asteroidId = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formato invalido");

                } 
                catch (Exception ex)
                {
                    Console.WriteLine();
                }

                try
                {
                    Console.WriteLine("Digite o tamanho do asteroid de 1 a 10: ");
                    asteroidSize = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formato invalido");

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }

                try
                {
                    Console.WriteLine("Digite a velocidade do asteroid de 1 a 5: ");
                    asteroidSpeed = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formato invalido");

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }
                try
                {
                    Console.WriteLine("Agora o valor da Energia do asteroid de 1 a 5: ");
                    asteroidEnergy = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Formato invalido");

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                }


                float AxysX = random.Next(-20, 20);

                float AxysY = random.Next(-20, 20);

                Asteroid firstAsteroid = new Asteroid(asteroidId, asteroidSize, asteroidSpeed, asteroidEnergy, AxysX, AxysY);


                listAsteroid.Add(firstAsteroid);
                count++;
            } while (count <= 5);

            foreach (Asteroid A in listAsteroid)
            {
                A.mostraDados();
            }

        }
    }
}