using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresaTableAdapters;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class CadastroEmpresa : KryptonForm
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
            Ferramenta.PreencherComboBox(TipoEmp, "MTEP", "RegraNegocio", "Id");
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tabelaEmpresa.MEMP'. Você pode movê-la ou removê-la conforme necessário.
            this.mEMPTableAdapter.Fill(this.tabelaEmpresa.MEMP);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            try
            {
                // Finaliza a edição do BindingSource
                mEMPBindingSource.EndEdit();

                // Verifica se o registro já existe no DataTable
                DataRow linhaExistente = tabelaEmpresa.MEMP.Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(row => row["Id"].Equals(((DataRowView)mEMPBindingSource.Current)["Id"]));

                bool inserido = false;

                if (linhaExistente == null)
                {
                    // Adiciona uma nova linha se não encontrar o registro existente
                    DataRowView row = (DataRowView)mEMPBindingSource.Current;

                    MethodInfo insertMethod = typeof(MEMPTableAdapter).GetMethod("Insert");
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

                    insertMethod.Invoke(mEMPTableAdapter, valores);
                    inserido = true;
                } else
                {
                    // Atualiza o DataTable e aplica as alterações
                    mEMPTableAdapter.Update(tabelaEmpresa.MEMP);
                }

                tabelaEmpresa.MEMP.AcceptChanges();

                // Exibe a mensagem personalizada de acordo com a ação realizada
                new PadraoRetorno().ApresentaSucessoTela(inserido ? "Registro inserido com sucesso!" : "Registro atualizado com sucesso!");
            } catch (Exception ex)
            {
                new PadraoRetorno().ApresentaErroTela(ex.Message);
            }
        }


        private void btnLogo_Click(object sender, EventArgs e)
        {
            Thread STAThread = new Thread(
                delegate ()
                {
                    openFileDialog1.Filter = "Arquivos de Imagem|*.png";
                    openFileDialog1.Title = "Selecione uma Logo";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string caminhoArquivo = openFileDialog1.FileName;
                        Logo.Text = caminhoArquivo;
                        PbLogo.Image = new Bitmap(caminhoArquivo);
                    }
                });
            STAThread.SetApartmentState(ApartmentState.STA);
            STAThread.Start();
            STAThread.Join();
        }



        private void Btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form formAberto = Application.OpenForms["TelaInicial"];

            if (formAberto != null)
            {
                // Cadastro usuário
                CadastroUsuario CadastroUsuario = new CadastroUsuario();
                CadastroUsuario.MdiParent = formAberto;
                CadastroUsuario.Show();
            }
        }
    }
}
