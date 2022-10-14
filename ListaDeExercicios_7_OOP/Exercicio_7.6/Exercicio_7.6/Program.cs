﻿namespace Exercicio_6._7
{
    internal class Program
    {

        static int _andaresDoPredio => 10; // int statica definida conforme a aula de 13/10

        
        static void Main(string[] args)
        {
            /*
             7 - Crie uma classe denominada Elevador para armazenar as informações de um elevador dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0),
                    total de andares no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão presentes nele. A classe deve também disponibilizar os 
                    seguintes métodos:
                      Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de andares no prédio (os elevadores sempre começam no térreo e vazio);
                      Entra : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver espaço);
                      Sai : para remover uma pessoa do elevador (só deve remover se houver alguém dentro dele);
                      Sobe : para subir um andar (não deve subir se já estiver no último andar);
                      Desce : para descer um andar (não deve descer se já estiver no térreo);
                      Encapsular todos os atributos da classe (criar os métodos set e get).
             */
            var controle = new ControleElevador(_andaresDoPredio);

            
            Console.WriteLine("Bem vindo ao software de elevador");
            Console.WriteLine("Digite 0 a qualquer momento para sair!");
            Console.WriteLine($"Considere que o prédio tem {_andaresDoPredio} andares.");

            controle.IniciarElevador();

        }
    }
}