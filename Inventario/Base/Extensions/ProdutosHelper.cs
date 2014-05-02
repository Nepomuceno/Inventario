using System.Collections.Generic;
using System.Linq;

namespace Sirius.Coletor.Base.Extensions
{
    public static class ProdutosExtensions
    {
        public static Produto ComCodigo(this IEnumerable<Produto> produtos, long codigo)
        {
            return produtos.SingleOrDefault(p => p.Codigo == codigo);
        }
    }
}