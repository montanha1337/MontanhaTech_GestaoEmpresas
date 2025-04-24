using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class CadastroUsuario : KryptonForm
    {
        public CadastroUsuario()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'montanhaTechDataSet1.MUSR'. Você pode movê-la ou removê-la conforme necessário.
            this.mUSRTableAdapter.Fill(this.montanhaTechDataSet1.MUSR);

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            var Usuario = new List<(string campo, object valor)>
            {
                ("Id", Code.Text),
                ("User", user.Text.ToString()),
                ("Password", Ferramenta.Criptografar(senha.Text)),
                ("Active", ativo.Checked)

            };
            var retorno = DBConnection.InserirOuAtualizarRegistro("MUSR", Usuario);
            this.mUSRTableAdapter.Fill(this.montanhaTechDataSet1.MUSR);
            MessageBox.Show(retorno.Mensagem);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            //    DataTable usuario = Ferramenta.PesquisaTabela("MUSR", 1);
            //    Code.Text = usuario.Rows[0]["Id"].ToString();
            //    user.Text = usuario.Rows[0]["User"].ToString();
            //    senha.Text = Ferramenta.Descriptografar(usuario.Rows[0]["Password"].ToString());
            //    ativo.Checked = Convert.ToBoolean(usuario.Rows[0]["Active"]);
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            //    DataTable usuario = Ferramenta.PesquisaTabela("MUSR", 2);
            //    Code.Text = usuario.Rows[0]["Id"].ToString();
            //    user.Text = usuario.Rows[0]["User"].ToString();
            //    senha.Text = Ferramenta.Descriptografar(usuario.Rows[0]["Password"].ToString());
            //    ativo.Checked = Convert.ToBoolean(usuario.Rows[0]["Active"]);
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            //    DataTable usuario = Ferramenta.PesquisaTabela("MUSR", 3);
            //    Code.Text = usuario.Rows[0]["Id"].ToString();
            //    user.Text = usuario.Rows[0]["User"].ToString();
            //    senha.Text = Ferramenta.Descriptografar(usuario.Rows[0]["Password"].ToString());
            //    ativo.Checked = Convert.ToBoolean(usuario.Rows[0]["Active"]);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            //    DataTable usuario = Ferramenta.PesquisaTabela("MUSR", 4);
            //    Code.Text = usuario.Rows[0]["Id"].ToString();
            //    user.Text = usuario.Rows[0]["User"].ToString();
            //    senha.Text = Ferramenta.Descriptografar(usuario.Rows[0]["Password"].ToString());
            //    ativo.Checked = Convert.ToBoolean(usuario.Rows[0]["Active"]);
        }
    }
}
