namespace SegundaListaDeExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            Área do triangulo = (base * altura) / 2; 
            Teste se a base ou a altura digitada não foi igual a zero. 

           
            double altura = 0;
            double area = 0;
            double b1 = 0;
            Console.WriteLine("Digite a medida da base do triangulo em cm: \n");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a medida da altura do triangulo em cm: \n");
            altura = double.Parse(Console.ReadLine());
            
            area = (b1 * altura) / 2;
            Console.WriteLine("A area do triangulo é: " + area + "cm quadrados.");
            

            

           2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 
            
            //int num = 0 , par = 0;
            //Console.WriteLine("digite um numero inteiro qualquer: ");
            //num = int.Parse(Console.ReadLine());
             
            //if ( num % 2 == 0 )
            //{
            //    Console.WriteLine("Numero é Par");

            //} else
            //{
            //    Console.WriteLine("È impar!");
            //} 
            
                        

           3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
            */
            //int valor1, valor2, valor3, valor4;
            //Console.WriteLine("Digite um numero inteiro 1: ");
            //valor1 = int.Parse(Console.ReadLine()); 
            //Console.WriteLine("Digite um numero inteiro 2: ");
            //valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um numero inteiro 3: ");
            //valor3 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um numero inteiro 4: ");
            //valor4 = int.Parse(Console.ReadLine());

            //double media = 0;

            //media = (valor1 + valor2 + valor3 + valor4) / 4 ;
            //Console.WriteLine("A media dos valores digitados foi: " + media);
            //if (valor1 > media) 
            //    {
            //    Console.WriteLine("o valor 1 está acima da media!");
            //    } 
            //if (valor2 > media)
            //    {
            //    Console.WriteLine("o valor 2 está acima da media!");            
            //    }
            //if (valor3 > media)
            //    {
            //    Console.WriteLine("o valor 3 está acima da media!");

            //    } 
            //else if (valor4 > media)
            //    {
            //    Console.WriteLine("o valor 4 está acima da media!");
            //    }



            /*
           4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
           Mostrar na tela qual dos professores tem o maior salário total.

            */
            //double horaProf1, horaProf2, valorHora1, valorHora2;
            //Console.WriteLine("Professor A quantas horas de aula foram ministradas:");
            //horaProf1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Professor B quantas horas de aula foram ministradas:");
            //horaProf2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Qual o valor da aula Professor A: ");
            //valorHora1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Qual o valor da aula Professor B:  ");
            //valorHora2 = double.Parse(Console.ReadLine());  
            //double calcSal1, calcSal2;
            //calcSal1 = horaProf1 * valorHora1;
            //calcSal2 = horaProf2 * valorHora2;


            //    Console.WriteLine("O professor A recebeu no total " + calcSal1 + " Reais");


            //    Console.WriteLine("O professor B recebeu no total " + calcSal2 + " Reais");



            /*
           5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
           se a média das duas notas for maior ou igual a 7,0. 

           Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
           é a média entre a nota do exame e a média das 2 notas. 
           Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
           escrever “Reprovado”.
            */
            //double exameFinal, mediaFinal, nota1, nota2, media1, media2;
            //Console.WriteLine("Digite a  primeira nota do Aluno: ");
            //nota1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a segunda nota do Aluno: ");
            //nota2 = double.Parse(Console.ReadLine());

            //media1 = (nota1 + nota2) / 2;
            //media2 = 5;
            //if (media1 >= 7)
            //{
            //    Console.WriteLine("Aluno Aprovado! com media" + media1);

            //}
            //else
            //{
            //    Console.WriteLine("aluno reprovado na primeira avaliação!");
            //}

            //    Console.WriteLine("Qual a nota do Exame final ?");
            //    exameFinal = double.Parse(Console.ReadLine());

            //    mediaFinal = ((nota1 + nota2 + exameFinal) / 3) ;
            //    if (mediaFinal >= 5 || media1 > 6)
            //{
            //    Console.WriteLine("Aluno Aprovado com media " + mediaFinal +" !");
            //}
            //else
            //{
            //    Console.WriteLine("Aluno reprovado!");
            //}



            /*
           6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
           O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
           O cálculo do imc = peso / (altura * altura)

           IMC 
           menor que 18                -> baixo peso
           maior que 18 e menor que 25 -> peso normal
           maior que 25 e menor que 30 -> sobrepeso
           maior que 30 e menor que 35 -> obesidade
           maior que 35                -> obesidade grau sério
            */
            //string nome;
            //double altura, peso, imc;
            //Console.WriteLine("Digite seu nome com letras maiusculas: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite seu Peso: ");
            //peso = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite sua altura: ");
            //altura = double.Parse(Console.ReadLine());


            //imc = peso / (altura * altura);

            //if(imc <18)
            //{
            //    Console.WriteLine(nome +" Seu IMC está muito baixo");
            //}
            //else if (imc >= 18 && imc < 25)
            //{
            //    Console.WriteLine(nome +" Seu IMC está ideal! ");
            //} else if (imc >= 25 && imc < 30)
            //{
            //    Console.WriteLine(nome + " seu IMC consta como sobrepeso");

            //} else if (imc >= 30 && imc < 35)
            //{
            //    Console.WriteLine(nome + " Seu IMC consta como obesidade grau 1! ");
            //}
            //else if (imc >= 35)
            //{
            //    Console.WriteLine(nome + " Seu IMC consta como Obesidade grave! ");
            //}



            /*

           7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
           O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
           exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.
           
            String frase = "";
            String palavra = "";


            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Digite uma palavra: ");
            palavra= Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra encontra-se na frase!");
            }
            else
            {
                Console.WriteLine("A palavra não se encontra na frase! ");
            }


       
            8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
            Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
            E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
            total de vendas. 
           
            //string nome;
            //double salarioBase, totalVendas, comissao1, comissao2, comissao3;
            //double salarioFinal;
            //salarioBase = 1200;
            //Console.WriteLine("Digite o nome do vendedor: ");
            //nome = Console.ReadLine();
            //Console.WriteLine("Digite o total de vendas do " + nome + ": ");
            //totalVendas = double.Parse(Console.ReadLine());
            //comissao1 = (totalVendas / 100) * 5;
            //comissao2 = (totalVendas / 100) * 7;
            //comissao3 = (totalVendas / 100) * 10;
            //if(totalVendas >= 5000)
            //{
            //    salarioFinal = salarioBase + comissao3;
            //    Console.WriteLine("O Salario final do vendedor baseado nas comissões, foi de: " + salarioFinal);
            //}else if (totalVendas >= 1000)
            //{
            //    salarioFinal = salarioBase + comissao2;
            //    Console.WriteLine("O Salario final do vendedor baseado nas comissões, foi de: " + salarioFinal);
            //} else if (totalVendas >= 500)
            //{
            //    salarioFinal = salarioBase + comissao1;
            //    Console.WriteLine("O Salario final do vendedor baseado nas comissões, foi de: " + salarioFinal);
            //}
            
            
            
            
            9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
            Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

            Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
            menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
            150, avisá-lo que será necessário adicionar 2 unidades de insulina.
            */
            //int glicemia1, glicemia2, glicemia3;
            //int mediaDiaria, media, dose1, dose2;

            //Console.WriteLine("Qual o indice glicemico a 08:00 horas: ");
            //glicemia1 = int.Parse(Console.ReadLine());
            //if(glicemia1 < 65)
            //{
            //    Console.WriteLine("Tome uma dose de insulina! RISCO DE HIPOGLICEMIA PROCURE UM MEDICO URGENTE!");
            //}
            //else if (glicemia1 >=65)
            //{
            //    Console.WriteLine("Indice glicemico ideal!");
            //}
            //else if (glicemia1 >= 250)
            //{
            //    Console.WriteLine("Indice glicemico muito alto! RISCO DE HIPERGLICEMIA PROCURE UM MEDICO URGENTE!");
            //}
            //Console.WriteLine("Qual o indice glicemico a 13:00 horas: ");
            //glicemia2 = int.Parse(Console.ReadLine());
            //if (glicemia2 < 65)
            //{
            //    Console.WriteLine("Tome uma dose de insulina! RISCO DE HIPOGLICEMIA PROCURE UM MEDICO URGENTE!");
            //}
            //else if (glicemia2 >= 65)
            //{
            //    Console.WriteLine("Indice glicemico ideal!");
            //}
            //else if (glicemia2 >= 250)
            //{
            //    Console.WriteLine("Indice glicemico muito alto! RISCO DE HIPERGLICEMIA PROCURE UM MEDICO URGENTE!");
            //}

            //Console.WriteLine("Qual o indice glicemico a 19:00 horas: ");
            //glicemia3 = int.Parse(Console.ReadLine());


            //if (glicemia3 < 65)
            //{
            //    Console.WriteLine("Tome uma dose de insulina! RISCO DE HIPOGLICEMIA PROCURE UM MEDICO URGENTE!");
            //}
            //else if (glicemia3 >= 65)
            //{
            //    Console.WriteLine("Indice glicemico ideal!");
            //}
            //else if (glicemia3 >= 250)
            //{
            //    Console.WriteLine("Indice glicemico muito alto! RISCO DE HIPERGLICEMIA PROCURE UM MEDICO URGENTE!");
            //}

            //mediaDiaria = (glicemia1 + glicemia2 + glicemia3) / 3;
            //if (mediaDiaria < 80)
            //{
            //    Console.WriteLine("Diminua 2 doses de insulina!, suma media diaria foi de: "+ mediaDiaria);
            //}
            //else if (mediaDiaria > 150)
            //{
            //    Console.WriteLine("Aumente 2 doses de insulina, sua media diaria foi de: " + mediaDiaria);
            //}

            /*
            10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
            O programa deve mostrar os dados do atleta mais novo e mais alto.
            */
            //string nome1, nome2;
            //int idade1, idade2;
            //double altura1, altura2;
            //Console.WriteLine("Digite o nome do atleta 1:");
            //nome1 = Console.ReadLine();
            //Console.WriteLine("Digite a idade do etleta 1: ");
            //idade1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a altura do atleta 1:");
            //altura1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome do atleta 2:");
            //nome2 = Console.ReadLine();
            //Console.WriteLine("Digite a idade do etleta 2: ");
            //idade2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a altura do atleta 2:");
            //altura2 = double.Parse(Console.ReadLine());

            //if (idade1 > idade2 && altura1 > altura2)
            //{
            //    Console.WriteLine("O atleta mais novo é: " + nome2 + " tem " + idade2 + " anos, e o atleta mais alto foi " + nome1 + " com " + altura1 + " Metros de altura");
            //}
            //else
            //{
            //    Console.WriteLine("O atleta mais novo é: " + nome1 + " tem " + idade1 + " anos, e o atleta mais alto foi " + nome2 + " com " + altura2 + " Metros de altura");
            //}

            /*
                11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
                O programa deve exibir se a hora digitada está ou não válida. 
                Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
            */
            // Console.WriteLine("Informe as Hora no formato 24 horas: ");
            // int horas = int.Parse(Console.ReadLine());
            // Console.WriteLine("Iforme os Minutos: ");
            // int minutos = int.Parse(Console.ReadLine());    

            // while ( horas > 23 )
            // {
            //     Console.WriteLine("Hora Invalida, Digite novamente: ");
            //     horas = int.Parse(Console.ReadLine());
            // }
            //while (minutos > 59 )
            // {
            //     Console.WriteLine("Minutos Invalido! Digite novamente: ");
            //     minutos = int.Parse(Console.ReadLine());
            // }

            //     Console.WriteLine("Agora são " + horas + " horas e " + minutos + " minutos ");







            /*

                12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
                número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
                R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
                armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
                No final do processamento, exibir o salário total e o salário excedente do operário.

            */
            //double numeroHoras, numeroExtras, salarioMax, codigo, salarioTotal, salarioHoras, salarioExtras;
            //Console.WriteLine("Digite o numero de horas trabalhadas: ");
            //numeroHoras = int.Parse(Console.ReadLine());
            //salarioHoras = 10;
            //salarioExtras = 20;
            //if (numeroHoras > 50)
            //{
            //    numeroExtras = numeroHoras - 50;
            //    salarioMax = numeroHoras * salarioHoras;
            //    salarioTotal = salarioMax + (numeroExtras * salarioExtras);

            //}
            //else
            //{
            //    salarioMax = numeroHoras * salarioHoras;
            //    numeroExtras = 0;
            //    salarioTotal = salarioMax + numeroExtras;
            //}

            //Console.WriteLine("O salario do funcionario baseado no numero de horas trabalhadas a 10 reais foi: " + salarioMax +" Reais. e teve mais " + numeroExtras + " de horas extras!");
            //Console.WriteLine("Totalizando " +salarioTotal+ " Reais");
            /*

                13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
                seu peso ideal, utilizando as seguintes fórmulas:
                Para homens: (72.7 * h) - 58
                Para mulheres: (62.1 * h) - 44.7

            */
            //Console.WriteLine("Digite sua altura: ");
            //double altura = double.Parse(Console.ReadLine());
            //Console.WriteLine("se for homem digite 'H' e se for mulher digite 'M'");
            //string genero = Console.ReadLine();
            //double homem;
            //double mulher;
            //if (genero == "H")
            //{
            //    homem = (72.7 * altura) - 58;
            //    Console.WriteLine ("O seu peso ideal masculino é: " + homem  );

            //}
            //else if (genero == "M")
            //{
            //    mulher = (62.1 * altura) - 44.7;
            //    Console.WriteLine("o seu peso ideal feminino é: "+ mulher);
            //}





            /*

                14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
                link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
                do arquivo usando este link (em minutos).
            */
            //double tamanhoArqv, velocidadeNet, tempoTotal;
            //Console.WriteLine("Digite o tamanho do arquivo em MB: ");
            //tamanhoArqv = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a velocidade de download em Mbps da sua internet: ");
            //velocidadeNet = double.Parse(Console.ReadLine());

            //tempoTotal = tamanhoArqv / (velocidadeNet * 8);

            //    Console.WriteLine("O tempo aproximado de download do arquivo será: " + tempoTotal + " minutos");


            /*

                15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
                da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
                e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
                Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            */
            //double altura, comprimento, area, formula;
            //double precoTinta = 80;
            //Console.WriteLine("Digite a altura da area a ser pintada: ");
            //altura = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o comprimento da area a ser pintada: ");
            //comprimento = double.Parse(Console.ReadLine());
            //area = altura * comprimento;
            //formula = area / 54;
            //formula = Math.Round(formula);

            //Console.WriteLine(" Area total a ser pintada é: " + area + " M², e serão necessários " + formula + " latas de tinta, que custaram: " + (formula * precoTinta));


            /*

         16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
         na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
         enfrentar novamente em um novo jogo.
         ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
         ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
         plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
            */

            //int golsTimeCasa, golsTimeFora, gols1, gols2;

            //Console.WriteLine("Quantos gols o time da casa fez ?");
            //golsTimeCasa = int.Parse(Console.ReadLine());
            //Console.WriteLine("Quantos gols o time de fora fez ?");
            //golsTimeFora = int.Parse(Console.ReadLine());

            //if (golsTimeFora - 2 == golsTimeCasa)
            //{
            //    Console.WriteLine("Time de fora Classificado com 2 gols de vantagem!");
            //} else if (golsTimeCasa == golsTimeFora)
            //{
            //    Console.WriteLine("Teremos um novo jogo para decidir o empate!");
            //}
            //else
            //{
            //    Console.WriteLine("Os times de enfrentaram novamente para decidir! ");
            //}

            /*
        17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
        formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
        os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).
            */
            //double a, b, c;
            //Console.WriteLine("Digite os valores dos lados do triangulo: ");
            //Console.Write("A:");
            //a = double.Parse(Console.ReadLine());
            //Console.Write("B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.Write("C: ");
            //c = double.Parse(Console.ReadLine());
            //if ((a + b) > c && (a + c) > b && (c + b) > a)

            //{
            //    Console.WriteLine("Forma um triangulo! ");
            //    if(a == b || a == c )
            //    {
            //        Console.WriteLine("Triangulo Equilatero!");
            //    }
            //    else if (a != c && a != b && b != c)
            //    {
            //        Console.WriteLine("Triangulo Isoceles!");

            //    }else
            //    {
            //        Console.WriteLine("Triangulo Escaleno");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Não forma um triangulo valido!");
            //}


            /*
       18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
            */
            //int valor1, valor2, valor3;
            //Console.WriteLine("Digite o valor 1: ");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor 2: ");
            //valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor 3: ");
            //valor3 = int.Parse(Console.ReadLine());

            //if (valor1 > valor2 && valor1 > valor3)
            //{
            //    Console.WriteLine("Valor 1 é maior! ");
            //}
            //else if (valor2 > valor1 && valor2 > valor3) 
            //{
            //    Console.WriteLine("Valor 2 é o maior!");            
            //}
            //else
            //{
            //    Console.WriteLine("Valor 3 é o maior!");
            //}

            /*
                19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.
                    */
            //int valor1, valor2, valor3;
            //Console.WriteLine("Digite o valor 1: ");
            //valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor 2: ");
            //valor2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o valor 3: ");
            //valor3 = int.Parse(Console.ReadLine());

            //if (valor1 > valor2 || valor1 > valor3)
            //{
            //    Console.WriteLine("Valor 1 é maior! ");
            //}
            //else if (valor2 > valor1 || valor2 > valor3) 
            //{
            //    Console.WriteLine("Valor 2 é o maior!");            
            //}
            //else
            //{
            //    Console.WriteLine("Valor 3 é o maior!");
            //}
            /*
        20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
        plus: você pode gerar o número de forma randomica (função random c#).
         */
            //int tentativas = 0;
            //int num = 0;
            //Random r = new Random();
            //int a = r.Next(0, 100);
            //while (true)
            //{
            //    tentativas++;



            //    Console.WriteLine("Advinha o numero!");
            //    try
            //    {
            //        num = int.Parse(Console.ReadLine());
            //    }
            //    catch { Console.WriteLine("Eu disse número."); }
            //    if (num < a) { Console.WriteLine("Maior..."); }
            //    else if (num > a) { Console.WriteLine("Menor..."); }
            //    if (num == a)
            //    {
            //        Console.WriteLine("Acertou!");
            //        Console.WriteLine("\nDepois de {0} tentativas.", tentativas);

            //        break;

            //    }

            //}
            //Console.Read();

        }
    }
}