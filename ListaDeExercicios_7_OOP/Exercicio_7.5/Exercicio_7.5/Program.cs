namespace Exercicio_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             5 - Identifique as classes	e implemente um programa para a seguinte especificação:
                   "O supermercado vende diferentes tipos de produtos. 
                    Cada produto tem um	 preço e uma quantidade	em estoque.	
                    Um	pedido de um cliente é composto de itens, onde cada item 
                    especifica o produto que o cliente deseja e	a respectiva quantidade.
                    Esse pedido	pode ser pago em dinheiro, cheque ou cartão." 
            
            DEFINIR PRODUTO GENERICO
             
             */
            string pagamento = "dinheiro";
            Produto produto = new Produto("Sucrilhos" , "Cereal" , 20 , 15.99 );
            Cliente cliente1 = new Cliente("João Pereira");
            Produto[] produtosLista = new Produto[] {} ;
            produtosLista.Append(produto);
            Pedido pedido = new Pedido(cliente1, produtosLista , pagamento );


            Console.WriteLine(pedido.getCliente().getNome());


          // exibir metodo de pagamento * 
          // exibir lista de pedidos *

        }
    }
}