using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class CadastroItem : KryptonForm
    {
        public CadastroItem()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
