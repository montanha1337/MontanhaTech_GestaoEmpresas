using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class CadastroEmpresa : KryptonForm
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {

            Ramo.DisplayMember = "Key";
            Ramo.ValueMember = "Value";
            Ramo.DataSource = new[]
            {
                new KeyValuePair<string, string>("Oficina", "1"),
                new KeyValuePair<string, string>("Loja Varejo", "2"),
                new KeyValuePair<string, string>("Loja Informatica", "3")
            };

            DataTable empresa = DBConnection.ExecutarConsulta("SELECT [CNPJ], [Logo], [NomeEmpresa], [TipoEmpresa], [CaminhoLogo]  FROM [dbo].[MEMP]");
            NomeEmpresa.Text = empresa.Rows[0]["NomeEmpresa"].ToString();
            Cnpj.Text = empresa.Rows[0]["CNPJ"].ToString();
            Ramo.SelectedValue = empresa.Rows[0]["TipoEmpresa"].ToString();
            NomeEmpresa.Text = empresa.Rows[0]["NomeEmpresa"].ToString();
            Logo.Text = empresa.Rows[0]["CaminhoLogo"].ToString();

            // Carregar a imagem (Logo) do banco de dados e atribuir ao PictureBox
            if (empresa.Rows[0]["Logo"] != DBNull.Value)
            {
                byte[] logoBytes = (byte[])empresa.Rows[0]["Logo"];
                using (MemoryStream ms = new MemoryStream(logoBytes))
                {
                    PbLogo.Image = Image.FromStream(ms);
                }
            }

        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            // Converte a imagem do PictureBox para byte[]
            using (MemoryStream ms = new MemoryStream())
            {
                PbLogo.Image.Save(ms, PbLogo.Image.RawFormat);

                var Empresa = new List<(string campo, object valor)>
            {
                ("Id", 1),
                ("NomeEmpresa", NomeEmpresa.Text),
                ("CNPJ", Cnpj.Text),
                ("TipoEmpresa", Ramo.SelectedValue.ToString()),
                ("Logo", ms.ToArray()),
                ("CaminhoLogo", Logo.Text)

            };
                var retorno = DBConnection.InserirOuAtualizarRegistro("MEMP", Empresa);
                MessageBox.Show(retorno.Mensagem);

            }
        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            // Criando uma instância do OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Definindo o filtro para selecionar apenas arquivos de imagem
                Filter = "Arquivos de Imagem|*.png;",
                Title = "Selecione uma Logo"
            };

            // Mostra o diálogo para o usuário escolher o arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho do arquivo selecionado
                string caminhoArquivo = openFileDialog.FileName;

                // Exibe o caminho na TextBox
                Logo.Text = caminhoArquivo;

                // Carrega a imagem na PictureBox
                PbLogo.Image = new Bitmap(caminhoArquivo);
            }
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
