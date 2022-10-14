using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7._5
{
    public class Produto
    {
        private string categoria;

        public string nome;

        public int quantidadeEstoque;

        public double preco;

        public Produto(string nome ,string categoria, int quantidadeEstoque, double preco )
        {
            this.categoria = categoria;
            this.nome = nome;
            this.quantidadeEstoque = quantidadeEstoque;
            this.preco = preco;
        }
        public string getCategoria()
        {
            return this.categoria;
        }
        public string getNome()
        {
            return this.nome;
        }
        public int getQuantidadeEstoque()
        {
            return this.quantidadeEstoque;

        }
        public double getPreco()
        {
            return this.preco;
        }
    }
}
