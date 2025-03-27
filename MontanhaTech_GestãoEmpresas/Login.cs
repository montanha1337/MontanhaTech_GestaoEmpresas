using MontanhaTech_GestãoEmpresas;
using System;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string login = this.user.Text;
                string senha = this.senha.Text;

                if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                {
                    if (login.Equals("MontanhaTech") && senha.Equals("Admin"))
                    {
                        TelaInicial telaPrincipal = (TelaInicial)Application.OpenForms["TelaInicial"];

                        telaPrincipal.MenuInicial.Visible = true;

                        this.Close();
                    } else
                    {

                        MessageBox.Show("Acesso banco de dados!!!");
                    }
                }
            } catch (Exception C)
            {
                MessageBox.Show(C.Message);
            }
        }
    }
}
