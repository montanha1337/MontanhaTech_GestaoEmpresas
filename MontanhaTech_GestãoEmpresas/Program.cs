using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace MontanhaTech_GestaoEmpresas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            KryptonManager manager = new KryptonManager();
            manager.GlobalPaletteMode = PaletteModeManager.Office2010Blue;
            Application.Run(new TelaInicial());
        }
    }
}
