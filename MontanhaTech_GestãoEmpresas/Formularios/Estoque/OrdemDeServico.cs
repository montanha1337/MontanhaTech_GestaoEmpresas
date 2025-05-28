using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class OrdemDeServico : KryptonForm
    {
        public OrdemDeServico()
        {
            InitializeComponent();
            Ferramenta.InsereTema(this, button1);
        }

        public OrdemDeServico(string Cliente, string Moto)
        {
            InitializeComponent();
            Ferramenta.InsereTema(this, button1);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
