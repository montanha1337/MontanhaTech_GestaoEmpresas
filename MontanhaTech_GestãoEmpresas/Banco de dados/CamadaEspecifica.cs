using System;

namespace MontanhaTech_GestaoEmpresas.Banco_de_dados
{
    public class CamadaEspecifica
    {
        PadraoRetorno padraoRetorno = new PadraoRetorno();
        public PadraoRetorno CriaCamadaPadrao()
        {
            try
            {
                //padraoRetorno = Oficina();

                //if (padraoRetorno.Sucesso)
                //    padraoRetorno = CadastroEmpresa();

                if (!padraoRetorno.Sucesso)
                    throw new Exception(padraoRetorno.Mensagem);

                return padraoRetorno;
            } catch (Exception E)
            {
                new PadraoRetorno().ApresentaErroTela(E.Message);
                return padraoRetorno;
            }
        }

        public PadraoRetorno Oficina()
        {
            string tabela = "MOFC";
            padraoRetorno = DBConnection.CriarTabela(tabela);

            //if (padraoRetorno.Sucesso)
            //    padraoRetorno = DBConnection.CriaCampo(tabela, "User", TipoCampo.Texto);

            //if (padraoRetorno.Sucesso)
            //    padraoRetorno = DBConnection.CriaCampo(tabela, "Password", TipoCampo.TextoLongo);

            //if (padraoRetorno.Sucesso)
            //    padraoRetorno = DBConnection.CriaCampo(tabela, "Active", TipoCampo.Bool);

            //if (!padraoRetorno.Sucesso)
            //    throw new Exception(padraoRetorno.Mensagem);

            return padraoRetorno;
        }
    }
}
