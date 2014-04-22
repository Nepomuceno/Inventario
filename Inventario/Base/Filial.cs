using System.Collections.Generic;

namespace Sirius.Coletor.Base
{
    public class Filial
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Deposito> Depositos { get; set; }
        
    }
}