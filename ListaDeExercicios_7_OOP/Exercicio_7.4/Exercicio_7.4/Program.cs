namespace Exercicio_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             4 - Faça um programa que represente a arvore genealógica da tua familia. Para isso, uma classe Pessoa
                 precisa ser indicar quem são seus pais, alem deinformações básicas sobre a pessoa.
             */

            Pessoa filho = new Pessoa();
            filho.idade = 12;
            filho.nome = "Zézinho";
            filho.sexo = "Masculino";

            Pessoa pai = new Pessoa();
            pai.nome = "José Toalha";
            pai.idade = 38;

            Pessoa mae = new Pessoa();
            mae.nome = "Maria Cabide";
            mae.idade = 34;

            filho.nomePai = pai;
            filho.nomeMae = mae;

            Console.Write(filho.nome +" ,tem "+ filho.idade + " anos ,filho de  "+ pai.nome + " ,e " + mae.nome );


        } 
    }
}