using System;
using System.Linq;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using Sirius.Coletor.Views;

namespace Sirius.Coletor
{
    static class Program
    {
        public static string Caminho { get { return Environment.GetFolderPath(Environment.SpecialFolder.Programs); } }
        public static Operador Operador { get; set; }
        public static Banco Banco { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Banco = new Banco();
            Banco.Carregar(Caminho);
            if (!Banco.Operadores.Any())
            {
                Banco.Operadores.Add(new Operador()
                {
                    Codigo = 1,
                    Nome = "padrao",
                    Senha = "qwe",
                    TipoUsuario = TipoUsuario.Administrador
                });
                Banco.ParametrosDeInicializacao = new ParametrosDeInicializacao()
                {
                    LeituraLocalAposCadaItem = false,
                    TipoLeitura = TipoLeitura.Multipla
                };
            }
            Application.Run(new FrmLogin());
        }
        
    }
}