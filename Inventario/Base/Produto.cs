using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Coletor.Base
{
    public class Produto
    {
        public long Codigo { get; set; }
        public IEnumerable<string> EANS { get; set; }
        public string Descricao { get; set; }
        public TipoLeitura TipoLeitura { get; set; }

    }
}
