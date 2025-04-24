using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace MontanhaTech_GestaoEmpresas.Framework
{
    public class Ferramenta
    {
        /// <summary>
        /// obtem a chave de segurança
        /// </summary>
        /// <returns></returns>
        private static string ObterChave()
        {
            string nomeBase = DBConnection.conexao != null ? DBConnection.conexao.Database : "DefaultDB";
            return nomeBase.PadRight(32).Substring(0, 32);
        }

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
        public static void InsereTema()
        {
            KryptonManager manager = new KryptonManager();
            manager.GlobalPaletteMode = PaletteModeManager.SparkleBlue;
        }
    }
}
