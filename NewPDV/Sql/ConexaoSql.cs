using System;
using System.Data.SqlClient;
using Util;


namespace NewPDV.Sql
{
    public enum enumTransacao
    {
        Begin,
        Commit,
        Roolback
    }
    public class ConexaoSql
    {
        public SqlConnection Conexao { get; set; }
        public SqlTransaction Transacao { get; set; }

        static public bool TransacaoVerifica { get; set; }
        public DadosBase DadosBanco { get; set; }
        public string StringConexao { get; set; }

        public void DescriptografiaSenha()
        {
            Criptografia crip = new Criptografia();
            DadosBanco.SenhaDescriptografada = crip.Decrypt(DadosBanco.Senha);
        }

        public static string RetornarConexaoEntity()
        {
            //string providerName = "System.Data.SqlClient";
            
            /*
            string serverName = Pub.Conn.DadosBanco.Servidor;
            string databaseName = Pub.Conn.DadosBanco.Banco;
            string user = Pub.Conn.DadosBanco.Usuario;
            string senha = Pub.Conn.DadosBanco.SenhaDescriptografada;
            */
            
                      
            string serverName = @"GUSTAVO-PC";
            string databaseName = "new";
            string user = "sa";
            string senha = "inter#system";
            
            

            SqlConnectionStringBuilder sqlBuilder =
                new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.UserID = user;
            sqlBuilder.Password = senha;
            sqlBuilder.PersistSecurityInfo = true;
            sqlBuilder.MultipleActiveResultSets = true;
            sqlBuilder.ApplicationName = "EntityFramework";
            sqlBuilder.MultipleActiveResultSets = true;
            return sqlBuilder.ToString();
        }

        static public bool GerarConexao(string servidor, string usuario, string senha, string banco, int timeOut)
        {
            Pub.Conn.Conexao = new SqlConnection(ConexaoSql.GerarStringConexao(servidor, usuario, senha, banco, timeOut));
            return true;
        }

        static public void AbrirConexao()
        {
            try
            {
                if (Pub.Conn.Conexao.State != System.Data.ConnectionState.Open)
                    Pub.Conn.Conexao.Open();

            }
            catch (Exception ex)
            {
                string sErro = ex.Message.ToLower();
                throw ex;
            }
        }


        static public void Fechar()
        {
            if (!TransacaoVerifica)
                if (Pub.Conn.Conexao.State != System.Data.ConnectionState.Closed)
                    Pub.Conn.Conexao.Close();
        }

        public static string GerarStringConexao(string servidor, string usuario, string senha, string banco, int timeOut)
        {
            string sTimeOut = "";
            if (timeOut != 0)
                sTimeOut = "Connect Timeout=" + timeOut.ToString() + ";";

            return @"Data Source=" + servidor +
                    ";Initial Catalog=" + banco +
                    ";Persist Security Info=True;User ID=" + usuario +
                    ";Password=" + senha +
                    ";MultipleActiveResultSets=True;" + sTimeOut;

        }
    }
}

