using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Chama o método de serviço periódico
            //await ServicosPeriodicosAsync();

            Application.Run(new TelaInicial());
        }

        /// <summary>
        /// Método assíncrono para chamar o processo de atualização de municípios
        /// </summary>
        /// <returns></returns>
        private static async Task ServicosPeriodicosAsync()
        {
            await new Mensalmente().RotinaMensal();
        }
    }
}
