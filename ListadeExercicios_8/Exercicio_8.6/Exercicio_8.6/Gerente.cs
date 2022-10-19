using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8._6
{
    class Gerente : Funcionario
    {
        public Gerente() { }
        public Gerente(string nome, string depto, string dataCriacao, string rg, double salario, bool ativo) : base(nome, depto, dataCriacao, rg, salario, ativo) { }
        public override void ExecutaTrabalho()
        {
            Console.WriteLine("Desempenha a função de Gerente.");
        }
    }
}
