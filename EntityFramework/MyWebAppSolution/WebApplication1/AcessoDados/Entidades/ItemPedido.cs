namespace MyWebApp.Entidades
{
    public class ItemPedido
    {
        /// <summary>
        /// Id do item do Pedido
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Produto referente ao item de pedido
        /// </summary>
        public Produto Produto { get; set; }

        /// <summary>
        /// Quantidade do produto
        /// </summary>
        public int Quantidade { get; set; }

    }
}
