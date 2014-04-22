using System.Collections.Generic;

namespace Sirius.Coletor.Base
{
    public class Deposito
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Localizacao> Localizacoes { get; set; }
    }
}