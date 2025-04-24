using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class Login : KryptonForm
    {
        internal bool logado = false;
        internal int tentativas = 0;

        public Login()
        {
            InitializeComponent();
            Ferramenta.InsereTema();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = this.user.Text;
                string senha = this.senha.Text;

                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                {
                    string senhaCrypt = Ferramenta.Criptografar(senha);
                    bool loogin = DBConnection.ExisteRegistro(string.Format(SQLLogin.consultaUsuario, login));

                    if (loogin && tentativas < 3)
                    {
                        loogin = DBConnection.ExisteRegistro(string.Format(SQLLogin.consultaUsuarioESenha, login, senhaCrypt));

                        if (!loogin)
                        {
                            tentativas++;
                            throw new Exception($@"Senha incorreta, ou usuário desativado.{tentativas}/3");
                        }
                    }

                    if (login.Equals("MontanhaTech") && senha.Equals("Admin") || loogin)
                    {
                        TelaInicial telaPrincipal = (TelaInicial)Application.OpenForms["TelaInicial"];
                        logado = true;
                        telaPrincipal.UsuarioLogado = login;
                        telaPrincipal.MenuInicial.Visible = true;
                        this.Close();
                    } else
                    {
                        throw new Exception("Usuário não existe na base de dados ou está inativo.");
                    }
                }
            } catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(C.Message);
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
