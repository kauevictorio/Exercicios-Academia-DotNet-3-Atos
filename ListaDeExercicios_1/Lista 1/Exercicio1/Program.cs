using System.ComponentModel;
using System.Security.Cryptography;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.
             
            int num1 = 15;
            int num2 = 7;
            int soma = (num1 + num2);
            float media = soma / 2;
            Console.WriteLine("a Media dos numeros " + num1+ " e "  + num2 + " é:  " + media);

            2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

                int num1 = 15;
            int num2 = 7;
            int num3 = 19;
            int num4 = 96; 
            int soma = (num1 + num2 + num3 + num4);
            float media = soma / 4;
            Console.WriteLine("a Media dos numeros " + num1 + " ," + num2 + " ," + num3 + " ," + num4 + " é:  " + media);



            3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            si os valores de duas variáveis A e B.

            int a, b, c;
            a = 10;
            b = 20;

            c = a;
            a = b;
            b = c; 


            4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            int dia, mes, ano;
            Console.WriteLine("Digite o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o mês: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            ano = int.Parse(Console.ReadLine());

            //mostrar AAAAMMDD
            Console.WriteLine(ano + "/" + mes + "/" + dia);
            int ano2 = ano % 100;
            Console.WriteLine(ano2);
            Console.WriteLine(ano2 + "/" + mes + "/" + dia);*/

            //substring modo

            /*
            string data;
            string dia, ano, mes;
            data = Console.ReadLine();
            Console.WriteLine(data);
            dia = data.Substring( 0, 2);
            Console.WriteLine("Dia: " + dia);
            mes = data.Substring( 2, 2);
            Console.WriteLine("Mes; " + mes);
            ano = data.Substring(4, 4);
            Console.WriteLine("Ano: " + ano);
            Console.WriteLine(ano + "" + mes + "" + dia);
            Console.WriteLine(ano.Substring(2, 2) + "" + mes + "" dia);
            int n;
            n = int.Parse(dia);
            Console.WriteLine("Dia convertido: " +n );



            5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
            consumido para percorrê-la (medido em l). */

            /*
            float km, l, consumo;
            km = 400;
            l = 22;
            consumo = km / l;
            Console.WriteLine("o consumido pelo automovel para a distancia de 400 Km foi de " + consumo + " Km/l.");
            

            6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
            de IPI (única) a ser acrescentada. 
           

            Console.WriteLine("informe o codigo do parafuso A :");
            int codA = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o quantidade do parafuso A :");
            int quantA = int.Parse(Console.ReadLine());
            Console.WriteLine( "Informe o valor do parafuso A: ");
            double valorA =  double.Parse(Console.ReadLine());


            Console.WriteLine("informe o codigo do parafuso B :");
            int codB = int.Parse(Console.ReadLine());
            Console.WriteLine("informe o quantidade do parafuso B :");
            int quantB = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do parafuso B: ");
            double valorB = double.Parse(Console.ReadLine());

            Console.WriteLine("informe o percentual do IPI: ");
            double ipi = double.Parse(Console.ReadLine());

            double totalA, totalB;

            totalA = (quantA * valorA);
            totalA = totalA +(totalA * (ipi /100));

            totalB = quantB * valorB;
            totalB = totalB + (totalB * (ipi / 100));
            Console.WriteLine("O custo total dos parafusos A: " + totalA);
            Console.WriteLine("O custo total dos parafusos B: "+ totalB);



            
            7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            Calcule o salário total */


            // não consigui fazer o resultado final ser lido como numero, apenas string
            /*
            double  vendas, comissao, vendedor;
            double  salario = 1800;
            Console.WriteLine("Digite o seu numero de Vendedor: ");
            vendedor = double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o total de vendas: ");
            vendas = double.Parse(Console.ReadLine());
            comissao = 0.25 * vendas;
            Console.WriteLine("\nO total de comissão do vendedor "+ vendedor + comissao);
            Console.WriteLine("\nO salario mais comissão do vendedor: " + vendedor + " foi: " + comissao +""+ salario); 

            */

            /*
            8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            A fórmula da conversão é F=(9*C+160)/5.
            
            double f, c;
            Console.WriteLine("Digite a Temperatura em ºC :");
            c = double.Parse(Console.ReadLine();
            f = (9 * c + 160) / 5;
            Console.WriteLine("\nA temperatura em ºF é: " + f);


            9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis. 
            Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00; 
            se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
            Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            da entrada e das duas prestações, de acordo com as regras acima. 
            Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
            conseqüente pagamento dos boletos das duas prestações.
            
            
            //metodo do professor
            
            Console.WriteLine("Informe o valor da mercadoria");
          
            double mercadoria = double.Parse(Console.ReadLine());
            double prestacao = 0;
            double resto = mercadoria % 3;
            mercadoria = mercadoria - resto;
            prestacao = mercadoria / 3;
            double entrada = prestacao + resto;
        
            Console.WriteLine("entrade de " + entrada + " e 2x de " + prestacao);

                       
            10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
            para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
            realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
            notas de menor valor fossem distribuídas em número mínimo possível. 
            Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, 
            três notas de R$ 10,00, uma nota de R$ 5,00 e uma nota de R$ 2,00. 
            Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
            de acordo com o critério da “distribuição ótima”.
         
            
            double saque = 0;

                int total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;
            Console.WriteLine("Informar o Valor do saque: ");
            saque = double.Parse(Console.ReadLine());

            total100 = (int)(saque / 100);
            Console.WriteLine("Notas de 100: " + total100);
            saque = saque - (100 * total100);

            total50 = (int)(saque / 50);
            Console.WriteLine("Notas de 50: " + total50);
            saque = saque - (50 * total50);

            total20 = (int)(saque / 20);
            Console.WriteLine("Notas de 20: " + total20);
            saque = saque - (20 * total20);

            total10 = (int)(saque / 10);
            Console.WriteLine("Notas de 10: " + total10);
            saque = saque - (10 * total10);

            total5 = (int)(saque / 5);
            Console.WriteLine("Notas de 5: " + total5);
            saque = saque - (5 * total5);

            total2 = (int)(saque / 2);
            Console.WriteLine("Notas de 2: " + total2);
            saque = saque - (2 * total2);

            total1 = (int)(saque / 1);
            Console.WriteLine("Notas de 1: " + total1);
            saque = saque - (1 * total1);
            
       
            11) Escreva um algoritmo para ler o número de eleitores de um município, 
            o número de votos brancos, nulos e válidos. 
            Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
            */
            //int eleitores = 0, branco = 0, nulo = 0, validos = 0;
            //Console.WriteLine("Digite o numero de eleitores: ");
            //eleitores = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero de votos validos: ");
            //validos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero de votos em branco: ");
            //branco = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o numero de votos nulos: ");
            //nulo = int.Parse(Console.ReadLine());





            /*
            12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
            marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
            dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

            Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

            Média do consumo = Total quilometragem/ quantidade de combustível gasto

            Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

            */
            //double odometroInicio = 0;
            //Console.WriteLine("Digite o valor inicial do odometro em KM:  ");
            //odometroInicio = double.Parse(Console.ReadLine());

            //double odometroFinal = 0, kmTotal = 0; 
            
            //Console.WriteLine("Digite o valor final do odometro em KM: ");
            //odometroFinal = double.Parse(Console.ReadLine());
            //kmTotal = odometroFinal - odometroInicio;

            //double quantGas = 0;
            //double mediaKmL = 0; 
            //Console.WriteLine("Digite o total de combustivel Gasto em litros : ");
            //quantGas = double.Parse(Console.ReadLine());
            //mediaKmL = kmTotal / quantGas;


            //double lucroLiquido = 0, lucro = 0;
            //Console.WriteLine("Digite o Total Ganho no dia em reais : ");
            //lucro = double.Parse(Console.ReadLine());   
            //double precoGas = 6.9;
            //lucroLiquido = lucro - (quantGas * precoGas);
            //Console.WriteLine(" O Lucro Liquido do dia foi:  $" + lucroLiquido + " Reais");






            /*
            13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga 
                a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do 
                salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
            vendidas pelo vendedor, calcule e mostre: o salário do empregado
           

            double salarioMin = 0;
            double comissao = 0, custo = 0;
            int quantidade = 0;

            Console.WriteLine("Informe o salário mínimo atual:");
            salarioMin = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço de custo da bike:");
            custo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de bikes vendidas:");
            quantidade = int.Parse(Console.ReadLine());

            double venda = custo + (custo * 0.5);
            comissao = (quantidade * venda) * 0.15;
            double salario = (salarioMin * 2) + comissao;
            Console.WriteLine("O salário resultou em: " + salario);
        
            */


        }
    }
}