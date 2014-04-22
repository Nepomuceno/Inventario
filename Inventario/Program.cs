using System;
using System.Windows.Forms;
using Sirius.Coletor.Base;
using Sirius.Coletor.Views;

namespace Sirius.Coletor
{
    static class Program
    {
        public static Operador Operador { get; set; }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new FrmLogin());
        }
        
    }
}