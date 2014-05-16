using Sirius.Coletor.Base;

namespace Sirius.Coletor.Dados
{
    public class ParametrosDeInicializacao
    {
        public TipoLeitura TipoLeitura { get; set; }
        public bool LeituraLocalAposCadaItem { get; set; }
        public bool LeituraDeProdutoNaoCadastrado { get; set; }
    }
}