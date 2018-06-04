namespace MyWebApp.Entidades
{
    public class Produto
    {

        #region Atributos

        private int _Id;
        private string _Nome;
        private string _Descricao;
        private decimal _Preco;

        #endregion

        #region Propriedades

        /// <summary>
        /// Id do Produto
        /// </summary>
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }
        }

        public string Nome
        {
            get
            {
                return this._Nome;
            }
            set
            {
                this._Nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return this._Descricao;
            }
            set
            {
                this._Descricao = value;
            }
        }

        public decimal Preco
        {
            get
            {
                return this._Preco;
            }
            set
            {
                this._Preco = value;
            }

        }

        #endregion

    }
}
