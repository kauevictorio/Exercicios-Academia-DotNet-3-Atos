namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco. 

            //5.Modifique o programa em VS anterior para aceitar votos nulos
            //(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos
            //e o número de pessoas que votaram.

            int totaljoao = 0, totalzeca = 0, totalbranco = 0, totalNulo = 0;
            string voto = "";
            while (voto != "FIM")
            {
                Console.WriteLine("Digite o nome do candidato zeca ou joao: ");
                Console.WriteLine("Ou digite FIM para encerrar a votação.");
                voto = Console.ReadLine();
                if (voto == "joao")
                {
                    totaljoao++;
                }
                else if (voto == "zeca")
                {
                    totalzeca++;
                }
                else if (voto == "branco")
                {
                    totalbranco++;
                }
                else
                {
                    totalNulo++;
                }

            }
            Console.WriteLine("O total de Votos para cada candidato foi: ");
            Console.WriteLine("total de votos do ZECA " + totalzeca);
            Console.WriteLine("Total de votos do JOAO " + totaljoao);
            Console.WriteLine("Total de votos em BRANCO " + totalbranco);
            Console.WriteLine("Total de votos NULOS " + totalNulo);

        }
    }
}