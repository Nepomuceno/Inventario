using System;
using System.Collections.Generic;
using System.Text;
using Sirius.Coletor.Base;
using Sirius.Coletor.Base.Extensions;

namespace Sirius.Coletor.VewModel
{
    public class LeiturasViewModel
    {
        public LeiturasViewModel(Inventario inventario)
        {
            Leituras = inventario.Leituras.ParaViewModel();
        }
        public IList<LeituraViewModel> Leituras { get; set; }
    }

    public class LeituraViewModel
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
    }
}
