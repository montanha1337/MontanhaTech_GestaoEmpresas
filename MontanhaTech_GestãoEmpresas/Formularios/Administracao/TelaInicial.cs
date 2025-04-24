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
        }
        void ConfigurarTreeViewVisual()
        {
            TreeView treeView = this.MenuInicial.TreeView;
            treeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            treeView.HideSelection = false; // Evita que o item selecionado mude visualmente

            treeView.DrawNode += (s, e) =>
            {
                // Verifica se o nó está selecionado e desenha o fundo fixo
                if (e.State.HasFlag(TreeNodeStates.Selected))
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds); // Fundo fixo mesmo quando selecionado
                } else
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds); // Mesmo fundo para nós não selecionados
                }

                Font fonte = e.Node.NodeFont ?? treeView.Font;
                Brush corTexto = Brushes.Black; // Cor fixa do texto

                // Desenha o ícone se houver ImageList configurado
                if (treeView.ImageList != null && e.Node.ImageIndex >= 0)
                {
                    Image img = treeView.ImageList.Images[e.Node.ImageIndex];
                    int iconY = e.Bounds.Top + (e.Bounds.Height - img.Height) / 2;
                    e.Graphics.DrawImage(img, e.Bounds.Left - 20, iconY); // Posição do ícone
                }

                // Desenha o texto do nó
                e.Graphics.DrawString(e.Node.Text, fonte, corTexto, e.Bounds.X, e.Bounds.Y);

                // Impede o desenho padrão (alteração de seleção)
                e.DrawDefault = false;
            };
        }
    }
}
