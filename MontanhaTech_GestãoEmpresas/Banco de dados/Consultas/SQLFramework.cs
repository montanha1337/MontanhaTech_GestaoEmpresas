namespace MontanhaTech_GestaoEmpresas
{
    public class SQLFramework
    {
        public static string consultaRamoEmpresa = @"
                    SELECT TipoEmpresa
                    FROM [MEMP]";

        public static string PreencheComboBox = @"SELECT {0}
                            , {1} 
                       FROM {2}";
    }
}
