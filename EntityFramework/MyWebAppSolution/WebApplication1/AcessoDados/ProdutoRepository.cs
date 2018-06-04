using MyWebApp.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace MyWebApp.AcessoDados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext _myWebAppContext;

        public ProdutoRepository(MyWebAppContext myWebAppContext)
        {
            this._myWebAppContext = myWebAppContext;
        }

        public List<Produto> ListarProdutos()
        {
            return _myWebAppContext.Produtos.ToList();
        }
    }
}
