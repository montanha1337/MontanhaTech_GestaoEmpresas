using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Data;
using System.Reflection;
using MontanhaTech_GestaoEmpresas.DataSouces.TabelaClienteTableAdapters;
using System.Linq;
using System.Windows.Forms;
using MontanhaTech_GestaoEmpresas.DataSouces.TabelaEmpresaTableAdapters;
using MontanhaTech_GestaoEmpresas.DataSouces;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class CadastroCliente : KryptonForm
    {
        public CadastroCliente()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: esta linha de código carrega dados na tabela 'tabelaCliente.MCMT'. Você pode movê-la ou removê-la conforme necessário.
                this.mCMTTableAdapter.Fill(this.tabelaCliente.MCMT);
                // TODO: esta linha de código carrega dados na tabela 'tabelaCliente.MCLI'. Você pode movê-la ou removê-la conforme necessário.
                this.mCLITableAdapter.Fill(this.tabelaCliente.MCLI);
            } catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void DataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                e.Row.Cells[3].Value = true;
                e.Row.Cells[4].Value = Code.Text;
            } catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void Code_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Suponha que seu BindingSource tenha um campo "Id" e você quer filtrar com base nesse campo.
                string filtro = string.IsNullOrEmpty(Code.Text)
                    ? string.Empty
                    : $"IdCliente = {Code.Text}";

                mCMTBindingSource.Filter = filtro; // Aplica o filtro diretamente no Binding
            } catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Finaliza a edição do BindingSource para garantir que os dados sejam salvos
                mCLIBindingSource.EndEdit();
                mCMTBindingSource.EndEdit();

                // Verifica se o registro já existe no DataTable "MCLI" baseado no "Id"
                DataRow linhaExistente = tabelaCliente.MCLI.Rows
                    .Cast<DataRow>()
                    .FirstOrDefault(row => row["Id"].Equals(((DataRowView)mCLIBindingSource.Current)["Id"]));

                bool inserido = false;

                if (linhaExistente == null)
                {
                    // Se o registro não existe, insere um novo
                    DataRowView row = (DataRowView)mCLIBindingSource.Current;

                    // Obtém o método "Insert" do TableAdapter
                    MethodInfo insertMethod = typeof(MCLITableAdapter).GetMethod("Insert");
                    ParameterInfo[] parametros = insertMethod.GetParameters();
                    object[] valores = new object[parametros.Length];

                    // Preenche os valores para a inserção
                    for (int i = 0; i < parametros.Length; i++)
                    {
                        string nomeColuna = parametros[i].Name;
                        object valor = row.Row.Table.Columns.Contains(nomeColuna) ? row[nomeColuna] : null;

                        // Define valores padrão se o valor for nulo ou DBNull
                        if (valor == DBNull.Value || valor == null)
                        {
                            if (parametros[i].ParameterType == typeof(string)) valor = "";
                            else if (parametros[i].ParameterType == typeof(byte[])) valor = new byte[0];
                            else if (parametros[i].ParameterType.IsValueType) valor = Activator.CreateInstance(parametros[i].ParameterType);
                        }

                        valores[i] = valor;
                    }

                    // Invoca o método "Insert" para adicionar o registro no banco
                    insertMethod.Invoke(mCLITableAdapter, valores);
                    inserido = true;
                } else
                {
                    // Se o registro já existe, atualiza o DataTable com as alterações
                    mCLITableAdapter.Update(tabelaCliente.MCLI);
                }

                // Confirma as alterações no DataTable
                tabelaCliente.MCLI.AcceptChanges();
                string idCliente = Code.Text;  // Pega o ID do cliente a partir de um controle de texto

                // Atualiza diretamente as linhas visíveis da DataGridView com o novo IdCliente
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue;  // Ignora a linha de inserção (nova linha na grid)

                    // Verifica se a linha está visível (não filtrada)
                    if (row.Visible)
                    {
                        // Atualiza o valor da célula "IdCliente" da DataGridView
                        row.Cells[4].Value = idCliente;  // A coluna "IdCliente" está na coluna de índice 4

                        // Atualiza o DataRow associado à linha na DataGridView
                        DataRow rowMoto = ((DataRowView)row.DataBoundItem).Row;
                        rowMoto["IdCliente"] = idCliente;  // Atualiza o campo "IdCliente" no DataRow diretamente

                        // Se a linha não está no estado "Deleted", faz a atualização
                        if (rowMoto.RowState != DataRowState.Deleted)
                        {
                            // Finaliza a edição do BindingSource de veículos
                            mCMTBindingSource.EndEdit();

                            // Verifica se o registro do veículo já existe no DataTable "MCMT"
                            linhaExistente = tabelaCliente.MCMT.Rows
                                .Cast<DataRow>()
                                .FirstOrDefault(row1 => row1["Id"].Equals(((DataRowView)mCMTBindingSource.Current)["Id"]));

                            if (linhaExistente == null)
                            {
                                // Se o veículo não existe, insere um novo
                                MethodInfo insertMethod = typeof(MCMTTableAdapter).GetMethod("Insert");
                                ParameterInfo[] parametros = insertMethod.GetParameters();
                                object[] valores = new object[parametros.Length];

                                // Preenche os valores para a inserção do veículo
                                for (int i = 0; i < parametros.Length; i++)
                                {
                                    string nomeColuna = parametros[i].Name;
                                    object valor = rowMoto.Table.Columns.Contains(nomeColuna) ? rowMoto[nomeColuna] : null;

                                    // Define valores padrão se o valor for nulo ou DBNull
                                    if (valor == DBNull.Value || valor == null)
                                    {
                                        if (parametros[i].ParameterType == typeof(string)) valor = "";
                                        else if (parametros[i].ParameterType == typeof(byte[])) valor = new byte[0];
                                        else if (parametros[i].ParameterType.IsValueType) valor = Activator.CreateInstance(parametros[i].ParameterType);
                                    }

                                    valores[i] = valor;
                                }

                                // Invoca o método "Insert" para adicionar o veículo no banco
                                insertMethod.Invoke(mCMTTableAdapter, valores);
                                inserido = true;
                            } else
                            {
                                // Se o veículo já existe, atualiza o DataTable com as alterações
                                mCMTTableAdapter.Update(tabelaCliente.MCMT);
                            }

                            // Confirma as alterações no DataTable dos veículos
                            tabelaCliente.MCMT.AcceptChanges();
                        }
                    }
                }
                inserido = true;

                // Exibe uma mensagem de sucesso para o usuário
                new PadraoRetorno().ApresentaSucessoTela(inserido ? "Cliente e veículos inseridos com sucesso!" : "Cliente e veículos atualizados com sucesso!");
            } catch (Exception C)
            {
                // Exibe uma mensagem de erro para o usuário caso ocorra uma exceção
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Ferramenta.PesquisaDados(mCLIBindingSource, "MCLI");
            } catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

            } catch (Exception C)
            {
                // Exibe uma mensagem de erro para o usuário caso ocorra uma exceção
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    // Filtra todas as motos com o Id correspondente
                    var motosParaExcluir = tabelaCliente.MCMT.AsEnumerable()
                        .Where(row => row["Id"].ToString() == id)
                        .ToList();

                    foreach (DataRow moto in motosParaExcluir)
                    {
                        moto.Delete(); // Marca a linha para exclusão
                    }

                    // Aplica as exclusões no banco
                    mCMTTableAdapter.Update(tabelaCliente.MCMT);
                    tabelaCliente.MCMT.AcceptChanges();

                    new PadraoRetorno().ApresentaSucessoTela("Motos excluídas com sucesso!");
                } else
                {
                    throw new Exception("Selecione uma moto para continuar.");
                }
            } catch (Exception ex)
            {
                new PadraoRetorno().ApresentaErroTela("Erro ao excluir motos: " + ex.Message);
            }
        }
    }
}
