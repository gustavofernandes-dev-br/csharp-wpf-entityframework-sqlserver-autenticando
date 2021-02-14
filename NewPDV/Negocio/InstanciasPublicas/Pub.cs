using NewPDV.Sql;

namespace NewPDV
{
    public static class Pub
    {

        public static string DiretorioSistema { get; set; }
        public static string ArquivoBase { get; set; }
        public static string ArquivoConfig { get; set; }
        public static string ArquivoTema { get; set; }
        public static string PastaConfiguracao { get; set; }
        public static string PastaAuditoria { get; set; }
        public static string PastaErros { get; set; }
        public static bool InDebug { get; set; }
        public static Usuarios UsuarioLogado;
        public static ConexaoSql Conn { get; set; }


    }
}
