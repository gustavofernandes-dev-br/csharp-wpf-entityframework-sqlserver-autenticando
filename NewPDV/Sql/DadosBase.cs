namespace NewPDV.Sql
{
    public class DadosBase
    {
        public string Servidor { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
        public int TimeOut { get; set; }
        public string SenhaDescriptografada { get; set; }
    }
}
