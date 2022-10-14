namespace Exercicio_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Faça um programa para controlar o aluguel de carros. 
                Deve ter as classes Carro, aluguel e cliente.
            
             */

            Carros carro = new Carros();
            Console.WriteLine("Qual a marca do carro? ");
            carro.fabricante = Console.ReadLine();
            Console.WriteLine("Qaul o modelo do carro? ");
            carro.modelo = Console.ReadLine();
            Console.WriteLine("Qual a placa do carro? ");
            carro.placa = Console.ReadLine();
            Console.WriteLine("Qual a Cor do carro?");
            carro.setCor(Console.ReadLine());


            Cliente cliente = new Cliente();
            Console.WriteLine("Qual o nome do cliente; ");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Qaul a idade do cliente: ");
            cliente.idade = int.Parse(Console.ReadLine());

            Aluguel aluguel = new Aluguel();
            aluguel.seguro = true;
            aluguel.inicio = new DateTime(2022, 10, 10, 14, 0, 0);
            aluguel.termino = new DateTime(2022, 10, 15, 18, 0, 0);
            aluguel.valorDiaria = 240;
            aluguel.carro = carro;
            aluguel.cliente = cliente;

        }
    }
}