using System;

namespace MontanhaTech_GestaoEmpresas
{
    public class CamadaPadrao
    {
        PadraoRetorno padraoRetorno = new PadraoRetorno();
        private string msgErro;
        private bool tabelacriada;

        public PadraoRetorno CriaCamadaPadrao()
        {
            try
            {
                msgErro += Login().Mensagem;
                msgErro += CadastroEmpresa().Mensagem;
                msgErro += CadastroItem().Mensagem;
                msgErro += CadastroCliente().Mensagem;
                msgErro += CadastroNotaFiscal_Cabecalho().Mensagem;
                msgErro += CadastroNotaFiscal_Itens().Mensagem;
                msgErro += CadastroCFOP().Mensagem;
                msgErro += CadastroTributacao().Mensagem;
                msgErro += CadastroUF().Mensagem;
                msgErro += CadastroMunicipio().Mensagem;
                msgErro += CadastroTabelaControle().Mensagem;
                msgErro += CadastroFornecedor().Mensagem;
                msgErro += CadastroConsultor().Mensagem;
                msgErro += CadastroConsultorFornecedor().Mensagem;

                if (!padraoRetorno.Sucesso)
                    throw new Exception(msgErro);

                return padraoRetorno;
            } catch (Exception E)
            {
                new PadraoRetorno().ApresentaErroTela(E.Message);

                return padraoRetorno;
            }
        }

        public PadraoRetorno Login()
        {
            string tabela = "MUSR";
            tabelacriada = DBConnection.CriarTabela(tabela).Sucesso;

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "User", TipoCampo.Texto);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Password", TipoCampo.TextoLongo);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Active", TipoCampo.Bool);

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroEmpresa()
        {
            string tabela = "MEMP";

            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CNPJ", TipoCampo.Texto);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "NomeEmpresa", TipoCampo.Texto);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Logo", TipoCampo.Imagem);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CaminhoLogo", TipoCampo.TextoLongo);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "TipoEmpresa", TipoCampo.Numero);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "RazaoSocial", TipoCampo.Texto, 100);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "InscrEstadual", TipoCampo.Texto, 20);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "InscrMunicipal", TipoCampo.Texto, 20);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CNAE", TipoCampo.Texto, 10);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CRT", TipoCampo.Numero, 1);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "TipoContribICMS", TipoCampo.Numero, 1);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "EmailNFe", TipoCampo.Texto, 150);

            // Endereço
            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Logradouro", TipoCampo.Texto, 100);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Numero", TipoCampo.Texto, 10);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Complemento", TipoCampo.Texto, 50);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Bairro", TipoCampo.Texto, 50);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Municipio", TipoCampo.Texto, 60);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CodIBGEMunicipio", TipoCampo.Texto, 10);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "UF", TipoCampo.Texto, 2);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CEP", TipoCampo.Texto, 8);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Pais", TipoCampo.Texto, 60);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CodPais", TipoCampo.Texto, 4);

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroItem()
        {
            string tabela = "MITM";

            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Descricao", TipoCampo.Texto, 120);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Codigo", TipoCampo.Texto, 20); // Código interno

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CodigoBarras", TipoCampo.Texto, 14);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "NCM", TipoCampo.Texto, 8); // Nomenclatura Comum Mercosul

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CFOP", TipoCampo.Texto, 4); // Código Fiscal de Operações

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CST", TipoCampo.Texto, 3); // CST ICMS

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CSOSN", TipoCampo.Texto, 3); // Para Simples Nacional

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CST_PIS", TipoCampo.Texto, 2);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CST_COFINS", TipoCampo.Texto, 2);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Unidade", TipoCampo.Texto, 6); // Ex: UN, KG

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "PrecoUnitario", TipoCampo.Decimal);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaICMS", TipoCampo.Decimal);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaPIS", TipoCampo.Decimal);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaCOFINS", TipoCampo.Decimal);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "OrigemMercadoria", TipoCampo.Numero); // 0 a 8

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "ExTIPI", TipoCampo.Texto, 3); // opcional p/ NCM

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CodigoANP", TipoCampo.Texto, 9); // se combustível

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Ativo", TipoCampo.Bool);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "DataCadastro", TipoCampo.DataHora);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "QuantidadeDep1", TipoCampo.Decimal);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "QuantidadeDep2", TipoCampo.Decimal);

            padraoRetorno.Mensagem = msgErro;

            return padraoRetorno;
        }

        public PadraoRetorno CadastroCliente()
        {
            string tabela = "MCLI";

            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "RazaoSocial", TipoCampo.Texto, 100);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "NomeFantasia", TipoCampo.Texto, 100);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CNPJ_CPF", TipoCampo.Texto, 14); // CNPJ ou CPF

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "TipoPessoa", TipoCampo.Texto, 1); // F=Física, J=Jurídica

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "InscrEstadual", TipoCampo.Texto, 20); // Pode ser ISENTO

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "InscrMunicipal", TipoCampo.Texto, 20);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Email", TipoCampo.Texto, 150);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Telefone", TipoCampo.Texto, 15);

            // Endereço
            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Logradouro", TipoCampo.Texto, 100);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Numero", TipoCampo.Texto, 10);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Complemento", TipoCampo.Texto, 50);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Bairro", TipoCampo.Texto, 50);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Municipio", TipoCampo.Texto, 60);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CodIBGEMunicipio", TipoCampo.Texto, 10);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "UF", TipoCampo.Texto, 2);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CEP", TipoCampo.Texto, 8);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Pais", TipoCampo.Texto, 60);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "CodPais", TipoCampo.Texto, 4);

            // Controle
            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "DataCadastro", TipoCampo.DataHora);

            if (tabelacriada)
                msgErro += DBConnection.CriaCampo(tabela, "Ativo", TipoCampo.Bool);


            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroNotaFiscal_Cabecalho()
        {
            string tabela = "MNFS";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "Numero", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "Serie", TipoCampo.Texto, 3);
                msgErro += DBConnection.CriaCampo(tabela, "Modelo", TipoCampo.Texto, 2);
                msgErro += DBConnection.CriaCampo(tabela, "TipoOperacao", TipoCampo.Numero, 1);
                msgErro += DBConnection.CriaCampo(tabela, "DataEmissao", TipoCampo.DataHora);
                msgErro += DBConnection.CriaCampo(tabela, "DataSaidaEntrada", TipoCampo.DataHora);
                msgErro += DBConnection.CriaCampo(tabela, "ID_Cliente", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "ID_Empresa", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "ValorTotal", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "BaseICMS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorICMS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "BasePIS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorPIS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "BaseCOFINS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorCOFINS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ChaveNFe", TipoCampo.Texto, 44);
                msgErro += DBConnection.CriaCampo(tabela, "Protocolo", TipoCampo.Texto, 20);
                msgErro += DBConnection.CriaCampo(tabela, "StatusNFe", TipoCampo.Texto, 1);
                msgErro += DBConnection.CriaCampo(tabela, "Justificativa", TipoCampo.TextoLongo);
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroNotaFiscal_Itens()
        {
            string tabela = "NFS1";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "ID_NF", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "ID_Produto", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "Quantidade", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorUnitario", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorTotal", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "NCM", TipoCampo.Texto, 10);
                msgErro += DBConnection.CriaCampo(tabela, "CFOP", TipoCampo.Texto, 4);
                msgErro += DBConnection.CriaCampo(tabela, "CST", TipoCampo.Texto, 3);
                msgErro += DBConnection.CriaCampo(tabela, "CSOSN", TipoCampo.Texto, 3);
                msgErro += DBConnection.CriaCampo(tabela, "CST_PIS", TipoCampo.Texto, 2);
                msgErro += DBConnection.CriaCampo(tabela, "CST_COFINS", TipoCampo.Texto, 2);
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaICMS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaPIS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaCOFINS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorICMS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorPIS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorCOFINS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "Origem", TipoCampo.Texto, 1);
                msgErro += DBConnection.CriaCampo(tabela, "Unidade", TipoCampo.Texto, 6);
                msgErro += DBConnection.CriaCampo(tabela, "CodigoANP", TipoCampo.Texto, 9);
                msgErro += DBConnection.CriaCampo(tabela, "ExTIPI", TipoCampo.Texto, 2);
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroCFOP()
        {
            string tabela = "CFOP";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "Codigo", TipoCampo.Texto, 4);
                msgErro += DBConnection.CriaCampo(tabela, "Descricao", TipoCampo.Texto, 60);
                msgErro += DBConnection.CriaCampo(tabela, "Tipo", TipoCampo.Texto, 1); // E = Entrada, S = Saída
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroTributacao()
        {
            string tabela = "MTRB";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "ID_Produto", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "ID_Cliente", TipoCampo.Numero);
                msgErro += DBConnection.CriaCampo(tabela, "CFOP", TipoCampo.Texto, 4);
                msgErro += DBConnection.CriaCampo(tabela, "CST", TipoCampo.Texto, 3);
                msgErro += DBConnection.CriaCampo(tabela, "CSOSN", TipoCampo.Texto, 3);
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaICMS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaPIS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "AliquotaCOFINS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorICMS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorPIS", TipoCampo.Decimal);
                msgErro += DBConnection.CriaCampo(tabela, "ValorCOFINS", TipoCampo.Decimal);
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroUF()
        {
            string tabela = "MOUF";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "Codigo", TipoCampo.Texto, 2); // Código IBGE
                msgErro += DBConnection.CriaCampo(tabela, "Nome", TipoCampo.Texto, 60);  // Nome da UF
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroMunicipio()
        {
            string tabela = "MMUN";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "CodigoIBGE", TipoCampo.Texto, 7); // Código IBGE do município
                msgErro += DBConnection.CriaCampo(tabela, "Nome", TipoCampo.Texto, 100);    // Nome do município
                msgErro += DBConnection.CriaCampo(tabela, "UF", TipoCampo.Texto, 2);         // Sigla da UF
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroTabelaControle()
        {
            string tabela = "MCTR";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "NomeTabela", TipoCampo.Texto, 50);
                msgErro += DBConnection.CriaCampo(tabela, "DataUltimaAtualizacao", TipoCampo.DataHora);
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroFornecedor()
        {
            string tabela = "MFOR";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "CNPJ", TipoCampo.Texto, 14); // CNPJ do fornecedor
                msgErro += DBConnection.CriaCampo(tabela, "RazaoSocial", TipoCampo.Texto, 100); // Razão social
                msgErro += DBConnection.CriaCampo(tabela, "NomeFantasia", TipoCampo.Texto, 100); // Nome fantasia
                msgErro += DBConnection.CriaCampo(tabela, "InscricaoEstadual", TipoCampo.Texto, 20); // Inscrição estadual
                msgErro += DBConnection.CriaCampo(tabela, "InscricaoMunicipal", TipoCampo.Texto, 20); // Inscrição municipal
                msgErro += DBConnection.CriaCampo(tabela, "Telefone", TipoCampo.Texto, 15); // Telefone
                msgErro += DBConnection.CriaCampo(tabela, "Email", TipoCampo.Texto, 150); // E-mail
                msgErro += DBConnection.CriaCampo(tabela, "Endereco", TipoCampo.Texto, 100); // Endereço
                msgErro += DBConnection.CriaCampo(tabela, "Numero", TipoCampo.Texto, 10); // Número do endereço
                msgErro += DBConnection.CriaCampo(tabela, "Complemento", TipoCampo.Texto, 50); // Complemento
                msgErro += DBConnection.CriaCampo(tabela, "Bairro", TipoCampo.Texto, 50); // Bairro
                msgErro += DBConnection.CriaCampo(tabela, "Cidade", TipoCampo.Texto, 60); // Cidade
                msgErro += DBConnection.CriaCampo(tabela, "Estado", TipoCampo.Texto, 2); // Estado
                msgErro += DBConnection.CriaCampo(tabela, "CEP", TipoCampo.Texto, 8); // CEP
                msgErro += DBConnection.CriaCampo(tabela, "Pais", TipoCampo.Texto, 60); // País
                msgErro += DBConnection.CriaCampo(tabela, "CodPais", TipoCampo.Texto, 4); // Código do País
                msgErro += DBConnection.CriaCampo(tabela, "Tipo", TipoCampo.Texto, 4); // Fornecedor / Transportadora
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroConsultor()
        {
            string tabela = "MCON";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "ConsultorID", TipoCampo.Numero); // ID único do consultor
                msgErro += DBConnection.CriaCampo(tabela, "Nome", TipoCampo.Texto, 100); // Nome do consultor
                msgErro += DBConnection.CriaCampo(tabela, "Telefone", TipoCampo.Texto, 15); // Telefone de contato
                msgErro += DBConnection.CriaCampo(tabela, "Email", TipoCampo.Texto, 150); // E-mail de contato
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }

        public PadraoRetorno CadastroConsultorFornecedor()
        {
            string tabela = "MOCF";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (tabelacriada)
            {
                msgErro += DBConnection.CriaCampo(tabela, "ConsultorID", TipoCampo.Numero); // ID do consultor
                msgErro += DBConnection.CriaCampo(tabela, "FornecedorID", TipoCampo.Numero); // ID do fornecedor
                msgErro += DBConnection.CriaCampo(tabela, "DataAssociacao", TipoCampo.DataHora); // Data em que o consultor começou a representar o fornecedor
            }

            if (!padraoRetorno.Sucesso)
                throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }
    }
}
