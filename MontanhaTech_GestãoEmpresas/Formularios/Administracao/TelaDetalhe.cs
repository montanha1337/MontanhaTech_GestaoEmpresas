using ComponentFactory.Krypton.Toolkit;
using MontanhaTech_GestaoEmpresas.Framework;
using System;
using System.Data;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas
{
    public partial class Detalhe : KryptonForm
    {
        private DataTable dados;

        public Detalhe(DataTable tabela, string Dado, string Label, string Titulo)
        {
            InitializeComponent();
            Ferramenta.InsereTema(this, button1);
            dados = tabela;
            dataGridView1.DataSource = dados;
            dado.Text = Dado;
            label1.Text = Label;
            this.Text = Titulo;
        }

        public Detalhe(string sql, string Dado, string Label, string Titulo)
    : this(DBConnection.ExecutarConsulta(sql), Dado, Label, Titulo)
        {
        }
    }
}
