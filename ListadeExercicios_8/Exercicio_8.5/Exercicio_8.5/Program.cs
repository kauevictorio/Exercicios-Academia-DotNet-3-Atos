namespace Exercicio_8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              5) Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
                tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
                um método para exibir um objeto (x,y).
                Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
                os objetos da lista.

             */


            Random random = new Random();
            List<Objeto2D> list = new List<Objeto2D>();
            int objeto = 0;
            for (int i = 0; i < 50; i++)
            {
                Objeto2D temp = new Objeto2D(random.Next(-100, 100), random.Next(-50, 50));
                list.Add(temp);

            }

            foreach (Objeto2D item in list)
            {
                item.motraDados();
            }
        }
    }
}