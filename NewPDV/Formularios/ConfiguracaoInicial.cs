using System;
using System.Windows.Forms;
using Util;
using NewPDV.Sql;

namespace NewPDV.Formularios
{
    public partial class ConfiguracaoInicial : Form
    {
        public ConfiguracaoInicial()
        {
            InitializeComponent();
        }

        private bool VerificaD()
        {
            if (txtServidor.Text == "")
            {
                MessageBox.Show("faltando dados");
                return false;
            }
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("faltando dados");
                return false;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("faltando dados");
                return false;
            }
            if (cmbBancoDados.Text == "")
            {
                MessageBox.Show("faltando dados");
                return false;
            }
            return true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!VerificaD())
            {
                return;
            }

            Criptografia crip = new Criptografia();
            XMLSerializar serializar = new XMLSerializar();
            DadosBase bas = new DadosBase();
            bas.Servidor = txtServidor.Text.Trim();
            bas.Usuario = txtUsuario.Text.Trim();
            bas.Senha = crip.Encrypt(txtSenha.Text.Trim());
            bas.Banco = cmbBancoDados.Text.Trim();

            XMLSerializar ser = new XMLSerializar();
            ser.Serializar(bas, Pub.ArquivoBase);



            string sDados;
            sDados = txtServidor.Text.Trim();
            sDados += "|";
            sDados += txtUsuario.Text.Trim();
            sDados += "|";
            sDados += txtSenha.Text.Trim();
            sDados += "|";
            sDados += cmbBancoDados.Text.Trim();

            //StreamWriter sw = new StreamWriter(VariaveisPublicas.pDadosSistema.ArquivoBase);
            //sDados = Criptografia.Encryptar(sDados);
            //sw.Write(sDados);
            //sw.Close();
            this.Close();
        }
    }
}
