namespace MontanhaTech_GestaoEmpresas
{
    public class SQLServMensal
    {
        public static string consultaUltimaAtualizacao = @"SELECT TOP 1 DataUltimaAtualizacao
                                                           FROM [MCTR]
                                                           WHERE NomeTabela = '{0}'
                                                           ORDER BY DataUltimaAtualizacao DESC; ";
    }
}
