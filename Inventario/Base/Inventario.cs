using System;
using System.Collections.Generic;

namespace Sirius.Coletor.Base
{
    public class Inventario
    {
        public Inventario()
        {
            Leituras = new List<Leitura>();
        }

        public long Codigo { get; set; }
        public string Nome { get; set; }
        public TipoInventario TipoInventario { get; set; }
        public Filial Filial { get; set; }
        public DateTime DataInicio { get; set; }
        public int CodigoContagem { get; set; }
        public StatusInventario StatusInventario { get; set; }
        public IList<Leitura> Leituras { get; set; }
    }
}