namespace Exercicio_3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
                a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.
             */
            int turma = 0, tamTurma = 0;
            double notaTotal, nota1 = 0, maiorNota = 0, menorNota = 0, mediaTurma = 0;
            double opc;

            do
            {
                Console.WriteLine("Digite 1 para cadastrar notas ou 0 para sair: ");
                opc = double.Parse(Console.ReadLine());
                 while ( tamTurma <= 10)
                {



                    Console.WriteLine("Digite a nota a ser cadastrada: ");
                    nota1 = double.Parse(Console.ReadLine());


                    if (nota1 > maiorNota)
                    {
                        maiorNota = nota1;

                    }
                    else if (nota1 <= menorNota)
                    {
                        menorNota = nota1;

                    }


                    nota1 = nota1 + nota1;
                    tamTurma++;
                }
                    mediaTurma = nota1 / tamTurma;
               
                     Console.WriteLine("A media da turma foi: " + mediaTurma + "A maior nota foi: " + maiorNota + " e a menor nota foi: " + menorNota);
                     
                    
            } while (opc != 0);
                

           
        }
    }
}