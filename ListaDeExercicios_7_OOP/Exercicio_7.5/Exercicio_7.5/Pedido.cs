using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7._5
{
    internal class Pedido
    {
        public Cliente cliente;

        private string pagamento; 

        private Produto[] produtos;
             public Pedido(Cliente cliente, Produto[] produtos, string pagamento )
        {
            this.cliente = cliente;
            this.produtos = produtos;
            this.pagamento = pagamento;
            
        }
        public Cliente getCliente()
        {
            return this.cliente;
        }

    }
}
