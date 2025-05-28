using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Data;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class Pesquisar : KryptonForm
    {
        public event Action<string> OnValorSelecionado;
        private DataTable dados;
        public PadraoRetorno padraoRetorno;

        public Pesquisar(DataTable tabela)
        {
            InitializeComponent();
            Ferramenta.InsereTema(this, button1);
            dados = tabela;
            dataGridView1.DataSource = dados;
            PreencherComboBoxComCampos(dados);
            padraoRetorno = new PadraoRetorno { Sucesso = false };
        }

        public Pesquisar(string sql)
    : this(DBConnection.ExecutarConsulta(sql))
        {
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            try
            {
                pesquisaDados();
            }
            catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void EdPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pesquisaDados();
            }
            catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SelecionarLinhaAtual();
            }
            catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, EventArgs e)
        {
            try
            {
                SelecionarLinhaAtual();
            }
            catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void pesquisaDados()
        {
            string campo = cmbPesquisa.SelectedItem.ToString(); // Campo selecionado
            string valor = EdPesquisa.Text;

            // Obtém a coluna da DataTable para verificar o tipo
            DataColumn coluna = dados.Columns[campo];
            string filtro = "";

            if (coluna.DataType == typeof(string))
            {
                filtro = $"{campo} LIKE '%{valor}%'";
            }
            else if (coluna.DataType == typeof(DateTime))
            {
                filtro = $"{campo} = #{Convert.ToDateTime(valor):MM/dd/yyyy}#";
            }
            else if (coluna.DataType == typeof(int) || coluna.DataType == typeof(decimal))
            {
                if (decimal.TryParse(valor, out decimal valorNumerico))
                    filtro = $"{campo} = {valorNumerico}";
                else
                    MessageBox.Show("Valor inválido para campo numérico.");
            }

            // Aplica o filtro na DataView
            dados.DefaultView.RowFilter = filtro;
        }

        private void PreencherComboBoxComCampos(DataTable tabela)
        {
            cmbPesquisa.Items.Clear(); // Limpa os itens existentes

            // Adiciona as colunas do DataTable à ComboBox
            foreach (DataColumn coluna in tabela.Columns)
            {
                cmbPesquisa.Items.Add(coluna.ColumnName);
            }

            // Seleciona a segunda coluna como padrão
            if (cmbPesquisa.Items.Count > 0)
                cmbPesquisa.SelectedIndex = 1;
        }

        private void SelecionarLinhaAtual()
        {
            string valor = dataGridView1.CurrentRow?.Cells[0].Value?.ToString();
            if (!string.IsNullOrEmpty(valor))
            {
                OnValorSelecionado?.Invoke(valor);
                this.Close(); // Ou apenas Hide() se quiser manter aberto
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            padraoRetorno.Sucesso = false; // Dados iguais, não precisa atualizar
            this.Close();
        }
    }
}
