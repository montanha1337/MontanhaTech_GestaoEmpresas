using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class AtualizaBancoDados: KryptonForm
    {
        public AtualizaBancoDados()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                bool criadoTabelas = true;

                CheckedListBox checkedListBox = this.Controls.OfType<CheckedListBox>().FirstOrDefault(c => c.Name == "ListaBase");
                List<string> selecionados = checkedListBox.CheckedItems
                                    .Cast<object>()
                                    .Select(i => i.ToString())
                                    .ToList();
                if (selecionados.Contains("Base de dados genérico"))
                {
                    PadraoRetorno padraoRetorno = new CamadaPadrao().CriaCamadaPadrao();
                    criadoTabelas = padraoRetorno.Sucesso;
                }
                if (selecionados.Contains("Base de dados complementar"))
                {
                    PadraoRetorno padraoRetorno = new CamadaEspecifica().CriaCamadaPadrao();
                    criadoTabelas = padraoRetorno.Sucesso;
                }

                if (criadoTabelas)
                    new PadraoRetorno().ApresentaSucessoTela("Banco de dados atualizado!");
            } catch (Exception E)
            {
                new PadraoRetorno().ApresentaErroTela(E.Message);
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
