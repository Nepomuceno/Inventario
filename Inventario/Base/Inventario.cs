using System;
using System.Collections.Generic;

namespace Sirius.Coletor.Base
{
    public class Inventario
    {
        public Inventario()
        {
        }

        public long Codigo { get; set; }
        public string Nome { get; set; }
        public TipoInventario TipoInventario { get; set; }
        public Filial Filial { get; set; }
        public int CodigoContagem { get; set; }
        public StatusExecucao StatusInventario { get; set; }
        public IList<LocalizacaoInventario> LocalizacoesInventario { get; set; }
        public IList<Produto> ProdutosPossiveis { get; set; }
    }

    public class LocalizacaoInventario
    {
        public int CodigoLocalizacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DatFim { get; set; }
        public IList<Leitura> Leituras { get; set; }
    }
}