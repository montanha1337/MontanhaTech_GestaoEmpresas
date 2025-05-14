using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MontanhaTech_GestaoEmpresas
{
    public class Mensalmente
    {
        public async Task RotinaMensal()
        {
            try
            {
                DBConnection.ObterConexao(); // Abre a conexão com o banco

                await AtualizarMunicipiosAsync();
                await AtualizarUFMensalAsync();
                //AtualizarCFOPMensalExcel();
            } catch (Exception C)
            {
                new PadraoRetorno().ApresentaErroTela(@"Erro ao acionar rotina mensal: " + C.Message);
            } finally
            {
                DBConnection.FecharConexao(); // Garante o fechamento da conexão
            }
        }

        /// <summary>
        /// Atualiza a Tabela de minicipios
        /// </summary>
        private async Task AtualizarMunicipiosAsync()
        {
            DataTable ultimaAtualizacao = DBConnection.ExecutarConsulta(string.Format(SQLServMensal.consultaUltimaAtualizacao, "MMUN"));

            if (ultimaAtualizacao.Rows.Count > 0)
            {
                DateTime dataUltima = Convert.ToDateTime(ultimaAtualizacao.Rows[0]["DataUltimaAtualizacao"]);
                if (dataUltima.Month == DateTime.Today.Month && dataUltima.Year == DateTime.Today.Year)
                    return;
            }

            HttpClient http = new HttpClient();
            string json = await http.GetStringAsync("https://servicodados.ibge.gov.br/api/v1/localidades/municipios");
            JsonDocument doc = JsonDocument.Parse(json);

            foreach (JsonElement elem in doc.RootElement.EnumerateArray())
            {
                int id = elem.GetProperty("id").GetInt32();
                string nome = elem.GetProperty("nome").GetString();
                string uf = elem.GetProperty("microrregiao")
                                 .GetProperty("mesorregiao")
                                 .GetProperty("UF")
                                 .GetProperty("sigla").GetString();

                Dictionary<string, object> condicoes = new Dictionary<string, object>
        {
            { "CodigoIBGE", id }
        };

                Dictionary<string, object> novosDados = new Dictionary<string, object>
        {
            { "Nome", nome },
            { "UF", uf }
        };

                PadraoRetorno diferente = DBConnection.VerificarDiferencaRegistro("MMUN", condicoes, novosDados);

                if (!diferente.Sucesso)
                {
                    List<(string campo, object valor)> dados = new List<(string campo, object valor)>
            {
                ("CodigoIBGE", id),
                ("Nome", nome),
                ("UF", uf)
            };

                    DBConnection.InserirOuAtualizarRegistro("MMUN", dados);
                }
            }

            List<(string campo, object valor)> dadosControle = new List<(string campo, object valor)>
    {
        ("NomeTabela", "MMUN"),
        ("DataUltimaAtualizacao", DateTime.Now)
    };

            DBConnection.InserirOuAtualizarRegistro("ControleAtualizacao", dadosControle);

            doc.Dispose();
            http.Dispose();
        }


        /// <summary>
        /// Atualiza a tabela de Estado
        /// </summary>
        private async Task AtualizarUFMensalAsync()
        {
            DataTable ultimaAtualizacao = DBConnection.ExecutarConsulta(string.Format(SQLServMensal.consultaUltimaAtualizacao, "MOUF"));

            if (ultimaAtualizacao.Rows.Count > 0)
            {
                DateTime dataUltima = Convert.ToDateTime(ultimaAtualizacao.Rows[0]["DataUltimaAtualizacao"]);
                if (dataUltima.Month == DateTime.Today.Month && dataUltima.Year == DateTime.Today.Year)
                    return;
            }

            HttpClient http = new HttpClient();
            string json = await http.GetStringAsync("https://servicodados.ibge.gov.br/api/v1/localidades/estados");

            JsonDocument doc = JsonDocument.Parse(json);
            foreach (JsonElement elem in doc.RootElement.EnumerateArray())
            {
                int id = elem.GetProperty("id").GetInt32();
                string nome = elem.GetProperty("nome").GetString();

                Dictionary<string, object> condicoes = new Dictionary<string, object>
        {
            { "Codigo", id }
        };

                PadraoRetorno existente = DBConnection.VerificarDiferencaRegistro("MOUF", condicoes, new Dictionary<string, object> {
            { "Nome", nome }
        });

                if (!existente.Sucesso)
                {
                    List<(string campo, object valor)> dados = new List<(string campo, object valor)>
            {
                ("Codigo", id),
                ("Nome", nome)
            };

                    DBConnection.InserirOuAtualizarRegistro("MOUF", dados);
                }
            }

            List<(string campo, object valor)> dadosControle = new List<(string campo, object valor)>
    {
        ("NomeTabela", "MOUF"),
        ("DataUltimaAtualizacao", DateTime.Now)
    };

            DBConnection.InserirOuAtualizarRegistro("ControleAtualizacao", dadosControle);

            doc.Dispose();
            http.Dispose();
        }


        /// <summary>
        /// Atualiza a tabela de CFOP
        /// </summary>
        public void AtualizarCFOPMensalExcel()
        {
            byte[] arquivoExcel = Properties.Resources.CFOP_xlsx;

            DataTable ultimaAtualizacao = DBConnection.ExecutarConsulta(string.Format(SQLServMensal.consultaUltimaAtualizacao, "CFOP"));

            if (ultimaAtualizacao.Rows.Count > 0)
            {
                DateTime dataUltima = Convert.ToDateTime(ultimaAtualizacao.Rows[0]["DataUltimaAtualizacao"]);
                if (dataUltima.Month == DateTime.Today.Month && dataUltima.Year == DateTime.Today.Year)
                {
                    return;
                }
            }

            using (MemoryStream stream = new MemoryStream(arquivoExcel))
            using (ExcelPackage package = new ExcelPackage(stream))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string codigoCFOP = worksheet.Cells[row, 1].Text.Trim();
                    string descricaoCFOP = worksheet.Cells[row, 2].Text.Trim();

                    Dictionary<string, object> condicoes = new Dictionary<string, object>
            {
                { "Codigo", codigoCFOP }
            };

                    Dictionary<string, object> novosDados = new Dictionary<string, object>
            {
                { "Codigo", codigoCFOP },
                { "Descricao", descricaoCFOP }
            };

                    if (!DBConnection.VerificarDiferencaRegistro("CFOP", condicoes, novosDados).Sucesso)
                    {
                        continue;
                    }

                    List<(string campo, object valor)> dados = new List<(string campo, object valor)>
            {
                ("Codigo", codigoCFOP),
                ("Descricao", descricaoCFOP)
            };

                    DBConnection.InserirOuAtualizarRegistro("CFOP", dados);
                }
            }

            List<(string campo, object valor)> dadosControle = new List<(string campo, object valor)>
    {
        ("NomeTabela", "CFOP"),
        ("DataUltimaAtualizacao", DateTime.Now)
    };

            DBConnection.InserirOuAtualizarRegistro("ControleAtualizacao", dadosControle);
        }


    }

    /// <summary>
    /// Apresenta os dados de municipio para atualizar.
    /// </summary>
    public class MunicipioIBGE
        {
            public int id { get; set; }
            public string nome { get; set; }
            public string uf { get; set; }
        }
    }
