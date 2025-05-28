using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresaTableAdapters;
using MontanhaTech_GestaoEmpresas.DataSouces;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Data;
using System.Reflection;
using MontanhaTech_GestaoEmpresas.DataSouces.TabelaUsuarioTableAdapters;
using System.Linq;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class CadastroUsuario : KryptonForm
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            Ferramenta.InsereTema(this, Btn1);
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tabelaUsuario.MUSR'. Você pode movê-la ou removê-la conforme necessário.
            this.mUSRTableAdapter.Fill(this.tabelaUsuario.MUSR);

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                // Finaliza a edição do BindingSource
                mUSRBindingSource.EndEdit();

                // Verifica se o registro já existe no DataTable
                DataRow linhaExistente = tabelaUsuario.MUSR.Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(row => row["Id"].Equals(((DataRowView)mUSRBindingSource.Current)["Id"]));

                bool inserido = false;

                if (linhaExistente == null)
                {
                    // Adiciona uma nova linha se não encontrar o registro existente
                    DataRowView row = (DataRowView)mUSRBindingSource.Current;

                    MethodInfo insertMethod = typeof(MUSRTableAdapter).GetMethod("Insert");
                    ParameterInfo[] parametros = insertMethod.GetParameters();
                    object[] valores = new object[parametros.Length];

                    for (int i = 0; i < parametros.Length; i++)
                    {
                        string nomeColuna = parametros[i].Name;
                        object valor = row.Row.Table.Columns.Contains(nomeColuna) ? row[nomeColuna] : null;

                        if (valor == DBNull.Value || valor == null)
                        {
                            // Define valores padrão
                            if (parametros[i].ParameterType == typeof(string)) valor = "";
                            else if (parametros[i].ParameterType == typeof(byte[])) valor = new byte[0];
                            else if (parametros[i].ParameterType.IsValueType) valor = Activator.CreateInstance(parametros[i].ParameterType);
                        }

                        valores[i] = valor;
                    }
                    inserido = true;
                    insertMethod.Invoke(mUSRTableAdapter, valores);
                } else
                {
                    // Atualiza o DataTable e aplica as alterações
                    mUSRTableAdapter.Update(tabelaUsuario.MUSR);
                }

                tabelaUsuario.MUSR.AcceptChanges();

                // Exibe a mensagem personalizada de acordo com a ação realizada
                new PadraoRetorno().ApresentaSucessoTela(inserido ? "Registro inserido com sucesso!" : "Registro atualizado com sucesso!");
            } catch (Exception ex)
            {
                new PadraoRetorno().ApresentaErroTela(ex.Message);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramenta.PesquisaDados(mUSRBindingSource, "MUSR");
            } catch (Exception C)
            {
                // Exibe uma mensagem de erro para o usuário caso ocorra uma exceção
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }
    }
}
