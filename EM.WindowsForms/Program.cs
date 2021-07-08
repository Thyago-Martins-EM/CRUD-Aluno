using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EM.WindowsForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TrataEx trataEx = new TrataEx();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CadastroAluno());
            Application.ThreadException += new ThreadExceptionEventHandler(trataEx.Trata);
        }
    }

    internal class TrataEx
    {
        public void Trata(object sender, ThreadExceptionEventArgs e) => MessageBox.Show("Tratando as exceções globalmente");
    }
}
