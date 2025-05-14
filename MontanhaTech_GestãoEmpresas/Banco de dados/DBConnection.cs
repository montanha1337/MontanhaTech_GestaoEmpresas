using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MontanhaTech_GestaoEmpresas
{
    public class DBConnection
    {
        #region Variavel
        public static SqlConnection conexao;
        private PadraoRetorno padraoRetorno;
        #endregion

        #region Conexão
        /// <summary>
        /// Realiza a conexão com o SQL Server
        /// </summary>
        /// <returns></returns>
        public static SqlConnection ObterConexao()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ConexaoPadrao"].ConnectionString;
            conexao = new SqlConnection(connStr);
            conexao.Open();
            return conexao;
        }

        /// <summary>
        /// Realiza teste de conexão com banco de dados
        /// </summary>
        /// <returns></returns>
        public static bool TestarConexao()
        {
            return conexao != null && conexao.State == System.Data.ConnectionState.Open;
        }

        /// <summary>
        /// Fecha a conexão ativa
        /// </summary>
        public static void FecharConexao()
        {
            if (conexao != null && conexao.State != ConnectionState.Closed)
            {
                conexao.Close();
                conexao.Dispose();
                conexao = null;
            }
        }
        #endregion

        #region Alteração banco de dados

        /// <summary>
        /// Adiciona tabela a base de dados
        /// </summary>
        /// <param name="nomeTabela"></param>
        public static PadraoRetorno CriarTabela(string nomeTabela)
        {
            try
            {
                string sql = $@"IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{nomeTabela}')
                            BEGIN
                                CREATE TABLE {nomeTabela} (Id INT PRIMARY KEY IDENTITY)
                            END";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.ExecuteNonQuery();
                }

                return new PadraoRetorno()
                {
                    Sucesso = true,
                    Mensagem = $@"Sucesso ao incluir a tabela {nomeTabela}."
                };

            } catch (Exception E)
            {
                return new PadraoRetorno()
                {
                    Sucesso = false,
                    Mensagem = E.Message
                };
            }
        }

        /// <summary>
        /// Adiciona campo a tabela
        /// </summary>
        /// <param name="nomeTabela"></param>
        /// <param name="nomeCampo"></param>
        /// <param name="tipoPadrao"></param>
        /// <exception cref="ArgumentException"></exception>
        public static PadraoRetorno CriaCampo(string nomeTabela, string nomeCampo, TipoCampo tipoPadrao, int tamanho = 255, string tabelaReferencia = null)
        {
            PadraoRetorno padraoRetorno = new PadraoRetorno();

            try
            {
                string tipoSql;

                switch (tipoPadrao)
                {
                    case TipoCampo.Texto:
                        tipoSql = $"NVARCHAR({tamanho})";
                        break;
                    case TipoCampo.TextoLongo:
                        tipoSql = "NVARCHAR(MAX)";
                        break;
                    case TipoCampo.Numero:
                        tipoSql = "INT";
                        break;
                    case TipoCampo.Decimal:
                        tipoSql = "DECIMAL(18,2)";
                        break;
                    case TipoCampo.Data:
                        tipoSql = "DATETIME";
                        break;
                    case TipoCampo.Bool:
                        tipoSql = "BIT";
                        break;
                    case TipoCampo.Imagem:
                        tipoSql = "VARBINARY(MAX)";
                        break;
                    case TipoCampo.DataHora:
                        tipoSql = "DATETIME";
                        break;
                    default:
                        throw new ArgumentException("Tipo não reconhecido.");
                }

                // Verifica se o campo já existe
                string sqlVerifica = $@"
        SELECT DATA_TYPE + 
               ISNULL('(' + CAST(CHARACTER_MAXIMUM_LENGTH AS VARCHAR) + ')', '') AS Tipo
        FROM INFORMATION_SCHEMA.COLUMNS 
        WHERE TABLE_NAME = '{nomeTabela}' 
          AND COLUMN_NAME = '{nomeCampo}'";

                string tipoExistente = null;

                using (SqlCommand cmdVerifica = new SqlCommand(sqlVerifica, conexao))
                using (SqlDataReader reader = cmdVerifica.ExecuteReader())
                {
                    if (reader.Read())
                        tipoExistente = reader.GetString(0).Replace("(-1)", "(MAX)");
                }

                if (!string.IsNullOrEmpty(tipoExistente))
                {
                    if (tipoExistente.Equals(tipoSql, StringComparison.OrdinalIgnoreCase))
                    {
                        return new PadraoRetorno()
                        {
                            Sucesso = true,
                            Mensagem = $@"O campo {nomeCampo} já existe com o mesmo tipo."
                        };
                    } else
                    {
                        return new PadraoRetorno()
                        {
                            Sucesso = false,
                            Mensagem = $@"O campo {nomeCampo} já existe com tipo diferente: {tipoExistente}."
                        };
                    }
                }

                // Cria o campo
                string sql = $@"ALTER TABLE {nomeTabela} ADD [{nomeCampo}] {tipoSql}";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.ExecuteNonQuery();
                }

                // Se houver tabela de referência, cria o relacionamento (chave estrangeira)
                if (!string.IsNullOrEmpty(tabelaReferencia))
                {
                    string nomeConstraint = $"FK_{nomeTabela}_{nomeCampo}";

                    string sqlFk = $@"
            ALTER TABLE {nomeTabela}
            ADD CONSTRAINT {nomeConstraint}
            FOREIGN KEY([{nomeCampo}])
            REFERENCES {tabelaReferencia}(Id)";

                    using (SqlCommand cmdFk = new SqlCommand(sqlFk, conexao))
                    {
                        cmdFk.ExecuteNonQuery();
                    }
                }

                return new PadraoRetorno()
                {
                    Sucesso = true,
                    Mensagem = $@"Sucesso ao incluir o campo {nomeCampo}" + (string.IsNullOrEmpty(tabelaReferencia) ? "." : " e criar a associação.")
                };
            } catch (Exception E)
            {
                return new PadraoRetorno()
                {
                    Sucesso = false,
                    Mensagem = E.Message
                };
            }
        }

        #endregion

        #region Alteração Registro

        /// <summary>
        /// Realiza Consultas no banco
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable ExecutarConsulta(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                return tabela;
            }
        }

        /// <summary>
        /// analisa se existe registro no banco de dados
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool ExisteRegistro(string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conexao))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                return reader.HasRows;
            }
        }
        public static PadraoRetorno VerificarDiferencaRegistro(string tabela, Dictionary<string, object> condicoes, Dictionary<string, object> novosDados)
        {
            PadraoRetorno retorno = new PadraoRetorno();

            // Monta a cláusula WHERE
            List<string> filtros = new List<string>();
            foreach (KeyValuePair<string, object> item in condicoes)
            {
                filtros.Add($"{item.Key} = '{item.Value}'");
            }

            string whereClause = string.Join(" AND ", filtros);
            string query = $"SELECT * FROM {tabela} WHERE {whereClause}";

            DataTable resultado = ExecutarConsulta(query);

            if (resultado.Rows.Count == 0)
            {
                retorno.Sucesso = false; // Registro não existe, precisa inserir
                retorno.Mensagem = "Registro não encontrado.";
                return retorno;
            }

            DataRow linha = resultado.Rows[0];
            foreach (KeyValuePair<string, object> dado in novosDados)
            {
                string valorAtual = linha[dado.Key]?.ToString()?.Trim();
                string valorNovo = dado.Value?.ToString()?.Trim();

                if (!string.Equals(valorAtual, valorNovo, StringComparison.OrdinalIgnoreCase))
                {
                    retorno.Sucesso = false; // Existe diferença, precisa atualizar
                    retorno.Mensagem = $"Campo '{dado.Key}' diferente.";
                    return retorno;
                }
            }

            retorno.Sucesso = true; // Dados iguais, não precisa atualizar
            retorno.Mensagem = "Registro já está atualizado.";
            return retorno;
        }



        /// <summary>
        /// Insere Registros a partir de uma lista.
        /// </summary>
        /// <param name="nomeTabela"></param>
        /// <param name="camposEValores"></param>
        /// <returns></returns>
        public static PadraoRetorno InserirOuAtualizarRegistro(string nomeTabela, List<(string campo, object valor)> camposEValores)
        {
            PadraoRetorno retorno = new PadraoRetorno();

            try
            {
                var idCampo = camposEValores.FirstOrDefault(c => c.campo.Equals("Id", StringComparison.OrdinalIgnoreCase));
                bool idInformado = idCampo.valor != null && idCampo.valor != DBNull.Value;

                bool registroExiste;

                if (idInformado)
                {
                    string sqlCheck = $"SELECT COUNT(1) FROM {nomeTabela} WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(sqlCheck, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Id", idCampo.valor);
                        registroExiste = (int)cmd.ExecuteScalar() > 0;
                    }
                } else
                {
                    registroExiste = false;
                }

                if (registroExiste)
                {
                    string setSql = string.Join(", ", camposEValores.Where(c => c.campo != "Id").Select(c => $"[{c.campo}] = @{c.campo}"));
                    string sqlUpdate = $"UPDATE {nomeTabela} SET {setSql}" + (idInformado ? " WHERE [Id] = @Id" : "");

                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conexao))
                    {
                        foreach (var campoValor in camposEValores.Where(c => c.campo != "Id"))
                            cmd.Parameters.AddWithValue($"@{campoValor.campo}", campoValor.valor ?? DBNull.Value);

                        if (idInformado)
                            cmd.Parameters.AddWithValue("@Id", idCampo.valor);

                        cmd.ExecuteNonQuery();
                    }

                    retorno.Sucesso = true;
                    retorno.Mensagem = "Registro atualizado com sucesso.";
                } else
                {
                    var camposSemId = camposEValores.Where(c => !c.campo.Equals("Id", StringComparison.OrdinalIgnoreCase)).ToList();
                    string camposSql = string.Join("], [", camposSemId.Select(c => c.campo));
                    string parametrosSql = string.Join(", ", camposSemId.Select((_, i) => $"@param{i}"));

                    string sqlInsert = $"INSERT INTO {nomeTabela} ([{camposSql}]) VALUES ({parametrosSql})";

                    using (SqlCommand cmd = new SqlCommand(sqlInsert, conexao))
                    {
                        for (int i = 0; i < camposSemId.Count; i++)
                            cmd.Parameters.AddWithValue($"@param{i}", camposSemId[i].valor ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }

                    retorno.Sucesso = true;
                    retorno.Mensagem = "Registro inserido com sucesso.";
                }
            } catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return retorno;
        }

        public PadraoRetorno VerificarExistencia(string tabela, Dictionary<string, string> camposValores)
        {
            padraoRetorno = new PadraoRetorno();

            // Constrói a parte da cláusula WHERE da query dinamicamente com base no Dictionary
            string query = $"SELECT COUNT(1) FROM {tabela} WHERE ";

            var conditions = new List<string>();
            foreach (var campoValor in camposValores)
            {
                // Adiciona cada campo e valor à condição da query
                conditions.Add($"{campoValor.Key} = '{campoValor.Value}'");
            }

            query += string.Join(" AND ", conditions); // Junta as condições com 'AND'

            // Executa a consulta
            var resultado = ExecutarConsulta(query);

            // Verifica se há resultados
            if (resultado.Rows.Count > 0)
            {
                padraoRetorno.Sucesso = true;
                padraoRetorno.Mensagem = "Associação já existe.";
            } else
            {
                padraoRetorno.Sucesso = false;
                padraoRetorno.Mensagem = "Associação não encontrada.";
            }

            return padraoRetorno;
        }

        /// <summary>
        /// Deleta Registros de acordo com a lista de campos enviados.
        /// </summary>
        /// <param name="nomeTabela"></param>
        /// <param name="camposEValores"></param>
        /// <returns></returns>
        public static PadraoRetorno DeletarRegistro(string nomeTabela, List<(string campo, object valor)> camposEValores)
        {
            PadraoRetorno retorno = new PadraoRetorno();

            try
            {
                if (camposEValores.Count == 0)
                    throw new Exception("A lista de campos e valores não pode ser vazia.");

                // Montando a string da cláusula WHERE
                string whereSql = string.Join(" AND ", camposEValores.Select((c, i) => $"{c.campo} = @param{i}"));

                // Preparando o comando SQL
                string sql = $"DELETE FROM {nomeTabela} WHERE {whereSql}";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    // Adicionando os parâmetros de valores
                    for (int i = 0; i < camposEValores.Count; i++)
                    {
                        cmd.Parameters.AddWithValue($"@param{i}", camposEValores[i].valor ?? DBNull.Value);
                    }

                    cmd.ExecuteNonQuery();
                }

                retorno.Sucesso = true;
                retorno.Mensagem = "Registro(s) deletado(s) com sucesso.";
            } catch (Exception ex)
            {
                retorno.Sucesso = false;
                retorno.Mensagem = ex.Message;
            }

            return retorno;
        }

        public PadraoRetorno AssociarTabelas(string tabelaAssociacao, string campoID1, string campoID2, int id1, int id2, DateTime? dataAssociacao = null)
        {
            padraoRetorno = new PadraoRetorno();

            // Verifica se a associação já existe// Criando um dicionário com os campos e valores a serem verificados
            Dictionary<string, string> camposValores = new Dictionary<string, string>
                                    {
                                        { campoID1, $"{id1}" },
                                        { campoID2, $"{id2}" }
                                    };

            // Chama a função de verificação de existência passando o dicionário de campos e valores
            var existeAssociacao = VerificarExistencia(tabelaAssociacao, camposValores);
            if (existeAssociacao.Sucesso)
            {
                padraoRetorno.Sucesso = true;
                return padraoRetorno;
            }

            // Se não existir, faz a inserção na tabela de associação
            var dados = new List<(string campo, object valor)>
            {
                ($"{campoID1}", id1),
                ($"{campoID1}", id2),
                ("DataAssociacao", dataAssociacao ?? DateTime.Now) // Caso não forneça uma data, será usada a data e hora atual)
            };

            padraoRetorno = InserirOuAtualizarRegistro(tabelaAssociacao, dados);

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        #endregion
    }

    #region ENUM
    public enum TipoCampo
    {
        Texto,
        TextoLongo,
        Numero,
        Decimal,
        Data,
        Bool,
        Imagem,
        DataHora
    }
    #endregion
}
