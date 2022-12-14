using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6._7
{
    public class ControleElevador
    {
        public Estado EstadoAtual;
        private readonly int _andaresDoPredio;

        public ControleElevador(int andaresDoPredio)
        {
            _andaresDoPredio = andaresDoPredio;
            EstadoAtual = new ElevadorParado(1, this); // O 1º andar é o padrão.
        }

        public void IniciarElevador()
        {
            while (true)
                Console.WriteLine(EstadoAtual.MovimentarElevador());
        }

        public int ObterAndares()
        {
            return _andaresDoPredio;
        }

        public int ValidarEntrada()
        {
        NovaEntrada:
            var entrada = Console.ReadLine();

            if (entrada == "0")
                Environment.Exit(0);

            if (!int.TryParse(entrada, out int resultado))
            {
                Console.WriteLine("Somente valores numéricos. Informe novamente o andar desejado:");
                goto NovaEntrada;
            }

            else if (resultado < 1 || resultado > _andaresDoPredio)
            {
                Console.WriteLine($"Este elevador vai do 1º ao {_andaresDoPredio}º andar. Informe novamente o andar desejado:");
                goto NovaEntrada;
            }

            return resultado;
        }
    }
}
