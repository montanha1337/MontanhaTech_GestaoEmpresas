using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MontanhaTech_GestaoEmpresas.Framework
{
    public class Ferramenta
    {
        #region Métodos Publicos

        /// <summary>
        /// criptografa o texto enviado
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static string Criptografar(string texto)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(ObterChave());
                aes.IV = new byte[16]; // IV fixo

                ICryptoTransform encryptor = aes.CreateEncryptor();
                byte[] dados = Encoding.UTF8.GetBytes(texto);
                byte[] resultado = encryptor.TransformFinalBlock(dados, 0, dados.Length);

                return Convert.ToBase64String(resultado);
            }
        }

        /// <summary>
        ///  descriptografa o texto enviado
        /// </summary>
        /// <param name="textoCriptografado"></param>
        /// <returns></returns>
        public static string Descriptografar(string textoCriptografado)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(ObterChave());
                aes.IV = new byte[16];

                ICryptoTransform decryptor = aes.CreateDecryptor();
                byte[] dados = Convert.FromBase64String(textoCriptografado);
                byte[] resultado = decryptor.TransformFinalBlock(dados, 0, dados.Length);

                return Encoding.UTF8.GetString(resultado);
            }
        }

        /// <summary>
        /// Pesquisa com base na navegação o cadastro correto.
        /// </summary>
        /// <param name="tabela"></param>
        /// <param name="sentido"></param>
        /// <returns></returns>
        public static DataTable PesquisaTabela(string tabela, int direcao)
        {
            string sql = string.Empty;

            switch (direcao)
            {
                case 1: // Primeiro
                    sql = $@"SELECT TOP 1 * FROM {tabela} ORDER BY Id ASC";
                    break;
                case 2: // Último
                    sql = $@"SELECT TOP 1 * FROM {tabela} ORDER BY Id DESC";
                    break;
                case 3: // Anterior
                    sql = $@"SELECT TOP 1 * FROM {tabela} WHERE Id < @idAtual ORDER BY Id DESC";
                    break;
                case 4: // Próximo
                    sql = $@"SELECT TOP 1 * FROM {tabela} WHERE Id > @idAtual ORDER BY Id ASC";
                    break;
                default:
                    throw new ArgumentException("Direção inválida.");
            }

            return DBConnection.ExecutarConsulta(sql);
        }

        /// <summary>
        /// Inclui o tema no formulário
        /// </summary>
        public static void InsereTema(Form oForm, Button BotaoClick)
        {
            KryptonManager manager = new KryptonManager();
            manager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
            oForm.KeyPreview = true;
            oForm.KeyDown += (s, e) => TratarTecla(e, BotaoClick);
        }

        /// <summary>
        /// Inclui o tema no formulário
        /// </summary>
        public static void InsereTema()
        {
            KryptonManager manager = new KryptonManager();
            manager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }

        /// <summary>
        /// Retorna o ramo da empresa com base parametrizado no cadastro empresa
        /// </summary>
        /// <returns></returns>
        public static int RetornaTipoEmpresa()
        {
            DataTable Dtemp = DBConnection.ExecutarConsulta(SQLFramework.consultaRamoEmpresa);
            return int.Parse(Dtemp.Rows[0]["TipoEmpresa"].ToString());
        }

        /// <summary>
        /// Preenche a comboBox de acordo com a tabela
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="sql"></param>
        /// <param name="displayMember"></param>
        /// <param name="valueMember"></param>
        /// <param name="adicionarSelecione"></param>
        public static void PreencherComboBox(ComboBox comboBox, string nomeTabela, string displayMember, string valueMember, bool adicionarSelecione = true)
        {
            DataTable dt = DBConnection.ExecutarConsulta(string.Format(SQLFramework.PreencheComboBox, valueMember, displayMember, nomeTabela));

            if (adicionarSelecione)
            {
                DataRow dr = dt.NewRow();
                dr[valueMember] = 0;
                dr[displayMember] = "Selecione...";
                dt.Rows.InsertAt(dr, 0);
            }

            comboBox.DataSource = dt;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        /// <summary>
        /// Abre o formulário de pesquisa para acesso aos dados.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="tabelaBD"></param>
        /// <param name="query"></param>
        /// <param name="tabela"></param>
        public static void PesquisaDados(BindingSource binding, string tabelaBD = null, string query = null, DataTable tabela = null)
        {
            Form formAberto = Application.OpenForms["TelaInicial"];

            if (formAberto != null)
            {
                string sql = $@"SELECT * FROM [{tabelaBD}]";

                if (!string.IsNullOrWhiteSpace(query))
                    sql = query;

                if (tabela == null)
                    tabela = DBConnection.ExecutarConsulta(sql);

                // Cria o formulário de pesquisa diretamente via construtor
                Pesquisar formPesquisa = new Pesquisar(tabela);
                formPesquisa.MdiParent = formAberto;

                // Registra um evento para capturar o valor selecionado
                formPesquisa.OnValorSelecionado += (valorSelecionado) =>
                {
                    string filtro = string.IsNullOrEmpty(valorSelecionado)
                        ? string.Empty
                        : $"Id = {valorSelecionado}";

                    binding.Filter = filtro;
                };

                formPesquisa.Show();
            }
        }

        /// <summary>
        /// Cria o evento de enter nos forms
        /// </summary>
        /// <param name="e"></param>
        /// <param name="botao"></param>
        public static void TratarTecla(KeyEventArgs e, Button botao)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botao.PerformClick();
            }
        }
        #endregion

        #region Métodos Privados
        /// <summary>
        /// obtem a chave de segurança
        /// </summary>
        /// <returns></returns>
        private static string ObterChave()
        {
            string nomeBase = DBConnection.conexao != null ? DBConnection.conexao.Database : "DefaultDB";
            return nomeBase.PadRight(32).Substring(0, 32);
        }
        #endregion
    }
}
