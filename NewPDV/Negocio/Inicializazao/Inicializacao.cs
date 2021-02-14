using System;
using System.IO;
using System.Windows;
using Util;
using NewPDV.Sql;

namespace NewPDV
{
    public class Inicializacao
    {
        public void Inicializar()
        {
            //DIRETÓRIO DO SISTEMA            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Pub.DiretorioSistema = @"C:\NEWPDV\";
            }
            else
            {
                Pub.DiretorioSistema = AppDomain.CurrentDomain.BaseDirectory.ToString();
            }

            Pub.PastaConfiguracao = Pub.DiretorioSistema + @"CONFIGURACOES\";
            Pub.PastaAuditoria = Pub.DiretorioSistema + @"AUDITORIA\";
            Pub.PastaErros = Pub.DiretorioSistema + @"ERROS\";
            Pub.ArquivoBase = Pub.PastaConfiguracao + @"BASE.XML";
            Pub.ArquivoConfig = Pub.PastaConfiguracao + @"CONFIG.XML";
            Pub.ArquivoTema = Path.Combine(Pub.PastaConfiguracao, "TEMA.XML");

            ArquivosEPastas Aep = new ArquivosEPastas();
            Aep.VerificarDiretorio(Pub.PastaConfiguracao);
            Aep.VerificarDiretorio(Pub.PastaAuditoria);
            Aep.VerificarDiretorio(Pub.PastaErros);
            Aep = null;

            if (System.Diagnostics.Debugger.IsAttached)
            { Pub.InDebug = true; }
            else { Pub.InDebug = false; }

            //Verificar se sistema esta configurado
            while (!File.Exists(Pub.ArquivoBase))
            {
                MessageBox.Show("Não foram encontradas configurações iniciais para o sistema");
                Formularios.ConfiguracaoInicial conf = new Formularios.ConfiguracaoInicial();
                conf.ShowDialog();
            }

            
            XMLSerializar xml = new XMLSerializar();
            Pub.Conn = new ConexaoSql();
            Pub.Conn.DadosBanco = new DadosBase();
            Pub.Conn.DadosBanco = (DadosBase)xml.Deserializar(Pub.Conn.DadosBanco, Pub.ArquivoBase);
            Pub.Conn.DescriptografiaSenha();


            xml = null;

            Tema tema = new Tema();
            tema.PegarTemaNoArquivo();

            ConexaoSql.GerarConexao(Pub.Conn.DadosBanco.Servidor, Pub.Conn.DadosBanco.Usuario,
               Pub.Conn.DadosBanco.SenhaDescriptografada, Pub.Conn.DadosBanco.Banco, 0);
            //ConexaoSql.AbrirConexao();
            //CriarTabelas criar = new CriarTabelas();
            

        


        }
    }
}
