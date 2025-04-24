namespace MontanhaTech_GestaoEmpresas
{
    public class SQLLogin
    {
        public static string consultaUsuario = @"SELECT 1 
                                                 FROM [MUSR] 
                                                 WHERE [User] = '{0}' ";

        public static string consultaUsuarioESenha = @"SELECT 1 
                                                       FROM [MUSR] 
                                                       WHERE [Active] = '1' 
                                                       AND [User] = '{0}'
                                                       AND [Password] = '{1}'";

    }
}
