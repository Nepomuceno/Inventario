using System;

namespace Sirius.Coletor.Base
{
    public class Leitura
    {
        public long Codigo { get; set; }
        public long CodigoProduto { get; set; }
        public int CodigoLocalizacao { get; set; }
        public int Quantidade { get; set; }
        public TipoLeitura TipoLeitura { get; set; }
        public DateTime DataDeLeitura { get; set; }
        public int CodigoOperador { get; set; }
        public string CodigoEquipamento { get; set; }
        public string ValorDeLeitura { get; set; }
    }
}