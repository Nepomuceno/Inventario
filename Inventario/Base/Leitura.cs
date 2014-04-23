using System;

namespace Sirius.Coletor.Base
{
    public class Leitura
    {
        public long Codigo { get; set; }
        public int CodigoProduto { get; set; }
        public int CodigoLocalizacao { get; set; }
        public int Quantidade { get; set; }
        public TipoLeitura TipoLeitura { get; set; }
        public DateTime DataDeLeitura { get; set; }
        public int CodigoOperador { get; set; }
    }
}