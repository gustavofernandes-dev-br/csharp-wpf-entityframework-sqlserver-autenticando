using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;



namespace NewPDV.Formularios
{
    /// <summary>
    /// Lógica interna para wpfConfiguracoes.xaml
    /// </summary>
    public partial class wpfConfiguracoes : Window
    {
        public wpfConfiguracoes()
        {
            InitializeComponent();
            this.MouseDown += delegate { DragMove(); };
            TrocaTela(EnumTela.principal);
        }

        enum EnumTela
        {
            principal = 1,
            gridTema = 2
        }

      
        private void Button_maximizar(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }

        private void Button_minimizar(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void btnFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            TrocaTela(EnumTela.principal);
            Formularios.wpfUsuarios us = new Formularios.wpfUsuarios();
            us.Show();
        }

        private void btnTema_Click(object sender, RoutedEventArgs e)
        {
            TrocaTela(EnumTela.gridTema);
        }
        private void TrocaTela(EnumTela tela)
        {
            gridTema.Visibility = Visibility.Hidden;

            gridTema.Visibility = tela.Equals(EnumTela.gridTema) ? Visibility.Visible : Visibility.Hidden;

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var buttoncor = ((Button)sender).Background;
            string CorTema = buttoncor.ToString();
            var buttonTag = ((Button)sender).Tag;            
            Tema tema = new Tema();
            tema.CorTema = CorTema;
            if (buttonTag != null)
            {
                tema.CorTexto = buttonTag.ToString() == null ? "" : buttonTag.ToString();
            }
            tema.MudarTema();

            InitializeComponent();
        }

        private void btnteste_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnFonteMenos_Click(object sender, RoutedEventArgs e)
        {
            lblTamanhoFonte.FontSize = lblTamanhoFonte.FontSize - 2;
            Tema tema = new Tema();
            tema.TextoTamanho = lblTamanhoFonte.FontSize;
            tema.MudarTema();
        }

        private void btnFonteMais_Click(object sender, RoutedEventArgs e)
        {
            lblTamanhoFonte.FontSize = lblTamanhoFonte.FontSize + 2;
            Tema tema = new Tema();
            tema.TextoTamanho = lblTamanhoFonte.FontSize;
            tema.MudarTema();
        }

        private void LabelFont(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var font = ((Label)sender).FontFamily;
            Tema tema = new Tema();
            tema.TextoFonte = font.ToString();
            tema.MudarTema();

        }
    }
}
