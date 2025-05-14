using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class TelaInicial : KryptonForm
    {
        public string UsuarioLogado { get; set; }

        public TelaInicial()
        {
            try
            {
                DBConnection.ObterConexao();

                if (DBConnection.TestarConexao())
                    InitializeComponent();
                else
                    throw new Exception("Não existe conexão com o banco de dados");

                Ferramenta.InsereTema();
                ConfigurarTreeViewVisual();
            } catch (Exception E)
            {
                new PadraoRetorno().ApresentaErroTela($@"Erro ao iniciar o sistema: {E.Message}");
                Application.Exit();
            }
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            DataTable resultado = DBConnection.ExecutarConsulta(SQLTelaInicial.consultaLogo);

            if (resultado.Rows.Count > 0 && resultado.Rows[0]["Logo"] != DBNull.Value)
            {
                byte[] imagemBytes = (byte[])resultado.Rows[0]["Logo"];
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    this.BackgroundImage = Image.FromStream(ms);// ajusta o tamanho da imagem ao formulário
                }
            }

            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void MenuInicial_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (MenuInicial.SelectedNode.Tag)
            {
                case "1":// Cadastro Empresa
                    CadastroEmpresa CadastroEmpresa = new CadastroEmpresa();
                    CadastroEmpresa.MdiParent = this;
                    CadastroEmpresa.Show();
                    break;
                case "2":// Atualiza Camada
                    AtualizaBancoDados AtualizaBancoDados = new AtualizaBancoDados();
                    AtualizaBancoDados.MdiParent = this;
                    AtualizaBancoDados.Show();
                    break;
                case "3":// Cadastro Cliente
                    CadastroCliente CadastroCliente = new CadastroCliente();
                    CadastroCliente.MdiParent = this;
                    CadastroCliente.Show();
                    CadastroCliente.BringToFront();
                    break;
                case "4":// Cadastro Item
                    CadastroItem CadastroItem = new CadastroItem();
                    CadastroItem.MdiParent = this;
                    CadastroItem.Show();
                    CadastroItem.BringToFront();
                    break;
                case "5":// Atualiza Estoque
                    break;
                case "6":// Ordem de Serviço
                    break;
                case "7":// Cadastro Fornecedor
                    break;
                case "8":// Cadastro Consultor
                    break;
                case "9":// Posição estoque
                    break;
                default:// Caso não instanciado
                    break;
            }

            // Desmarca o item selecionado
            MenuInicial.SelectedNode = null;
        }
        void ConfigurarTreeViewVisual()
        {
            TreeView treeView = this.MenuInicial.TreeView;
            treeView.HideSelection = false; // Evita que o item selecionado mude visualmente
        }
    }
}
