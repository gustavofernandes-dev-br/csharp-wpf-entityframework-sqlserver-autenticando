using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewPDV
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {

            InitializeComponent();
            try
            {
                Inicializacao inicia = new Inicializacao();
                inicia.Inicializar();
                Formularios.Login log = new Formularios.Login(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Formularios.Login log = new Formularios.Login(this);

            }
            finally
            {
                
            }

        }

        private void btnClientes_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Formularios.wpfCliente cli = new Formularios.wpfCliente();
            cli.Show();
        }

        private void btnConfig_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Formularios.wpfConfiguracoes wpf = new Formularios.wpfConfiguracoes();
            wpf.Show();
        }
    }
}
