using System;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public class PadraoRetorno
    {
        public bool Sucesso { get; set; } = true;
        public string Mensagem { get; set; } = string.Empty;
        public int Codigo { get; set; } = 0;

        public void ApresentaErroTela(string erro)
        {
            try
            {
                MessageBox.Show($@"MontanhaTech Erro: {erro}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception E)
            {
                MessageBox.Show($@"MontanhaTech Erro: {E.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ApresentaSucessoTela(string Msg)
        {
            try
            {
                MessageBox.Show($@"MontanhaTech: {Msg}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception E)
            {
                MessageBox.Show($@"MontanhaTech Erro: {E.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
