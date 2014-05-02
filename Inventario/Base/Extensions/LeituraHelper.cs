using System.Collections.Generic;
using System.Linq;
using Sirius.Coletor.VewModel;

namespace Sirius.Coletor.Base.Extensions
{
    public static class LeiturasExtensions
    {
        public static IList<LeituraViewModel> ParaViewModel(this IEnumerable<Leitura> leituras)
        {
            return leituras.Select(l => new LeituraViewModel()
            {
                Nome = Program.Banco.Produtos.ComCodigo(l.CodigoProduto).Descricao,
                Quantidade = l.Quantidade
            }).ToList();
        }
    }
}