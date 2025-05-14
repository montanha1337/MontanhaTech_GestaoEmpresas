using MontanhaTech_GestaoEmpresas.Framework;
using System;

namespace MontanhaTech_GestaoEmpresas
{
    public class CamadaEspecifica
    {
        PadraoRetorno padraoRetorno = new PadraoRetorno();
        public PadraoRetorno CriaCamadaPadrao()
        {
            try
            {
                int TipoEmpresa = Ferramenta.RetornaTipoEmpresa();

                switch (TipoEmpresa)
                {
                    case 1: // Oficina
                        padraoRetorno = Oficina();
                        break;
                    case 2: // Loja Varejo
                        //padraoRetorno = LojaVarejo();
                        break;
                    case 3: // Loja Informática
                        //padraoRetorno = LojaInformatica();
                        break;
                    default:
                        break;
                }

                if (!padraoRetorno.Sucesso)
                    throw new Exception(padraoRetorno.Mensagem);

                return padraoRetorno;
            } catch (Exception E)
            {
                new PadraoRetorno().ApresentaErroTela(E.Message);
                return padraoRetorno;
            }
        }

        /// <summary>
        /// Inclui as tabelas de oficina utilizadas para o ramo oficina.
        /// </summary>
        /// <returns></returns>
        public PadraoRetorno Oficina()
        {
            padraoRetorno = CadastroClienteMotos();

            //if (padraoRetorno.Sucesso)
            //    padraoRetorno = DBConnection.CriaCampo(tabela, "User", TipoCampo.Texto);

            //if (padraoRetorno.Sucesso)
            //    padraoRetorno = DBConnection.CriaCampo(tabela, "Password", TipoCampo.TextoLongo);

            //if (padraoRetorno.Sucesso)
            //    padraoRetorno = DBConnection.CriaCampo(tabela, "Active", TipoCampo.Bool);

            return padraoRetorno;
        }

        /// <summary>
        /// Tabela de motos
        /// </summary>
        /// <returns></returns>
        public PadraoRetorno CadastroClienteMotos()
        {
            string tabela = "MCMT";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            if (padraoRetorno.Sucesso)
                padraoRetorno = DBConnection.CriaCampo(tabela, "Modelo", TipoCampo.Texto);

            if (padraoRetorno.Sucesso)
                padraoRetorno = DBConnection.CriaCampo(tabela, "Placa", TipoCampo.TextoLongo);

            if (padraoRetorno.Sucesso)
                padraoRetorno = DBConnection.CriaCampo(tabela, "Ativo", TipoCampo.Bool);

            if (padraoRetorno.Sucesso)
                padraoRetorno = DBConnection.CriaCampo(tabela, "IdCliente", TipoCampo.Numero,255, "MCLI");

            return padraoRetorno;
        }
    }
}
