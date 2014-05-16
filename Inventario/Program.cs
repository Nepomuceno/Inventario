using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using Sirius.Coletor.Base;
using Sirius.Coletor.Dados;
using Sirius.Coletor.Util;
using Sirius.Coletor.Views;
using System.Threading;

namespace Sirius.Coletor
{
    static class Program
    {
        private static string _caminho = null;
        public static string Caminho
        {
            get
            {
                if (string.IsNullOrEmpty(_caminho))
                {
                    _caminho = PathUtil.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "\\SiriusInventario");
                    if (!Directory.Exists(_caminho))
                    {
                        Directory.CreateDirectory(_caminho);
                    }
                }
                return _caminho;
            }
        }
        public static Operador Operador { get; set; }
        public static Banco Banco { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Banco = new Banco();
            new Thread(CarregarBase).Start();
            Application.Run(new FrmLogin());
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        public static void StartWaiting(Form form)
        {
            Cursor.Current = Cursors.WaitCursor;
        }
        public static void StopWaiting(Form form)
        {
            Cursor.Current = Cursors.Default;
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var stream = File.Open(PathUtil.Combine(Caminho, "\\logcrash.json"), FileMode.OpenOrCreate);
            var textWriter = new JsonTextWriter(new StreamWriter(stream));
            textWriter.WriteRaw(JsonConvert.SerializeObject(e, Formatting.Indented));
            textWriter.Flush();
            stream.Flush();
            stream.Dispose();
        }
        static void CarregarBase()
        {
            Program.StartWaiting(new Form());
            Banco.Carregar(Caminho);
            if (!Banco.Operadores.Any())
            {
                Banco.Operadores.Add(new Operador()
                {
                    Codigo = 1,
                    Nome = "admin",
                    Senha = "admin",
                    TipoUsuario = TipoUsuario.Administrador
                });
            }
            Program.StopWaiting(new Form());
        }

    }
}