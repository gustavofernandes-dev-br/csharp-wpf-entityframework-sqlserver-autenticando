using System.Windows;
using System;
using System.Linq;
using System.Drawing;
//using Windows.UI.ViewManagement;

namespace NewPDV.Formularios
{


    /// <summary>
    /// Lógica interna para wpfUsuarios.xaml
    /// </summary>
    public partial class wpfUsuarios : Window
    {
        enumAcao acao;

        public wpfUsuarios()
        {
            InitializeComponent();
            TrocarTela(enumTela.ePesquisa);
            //var title = applica   
        }        

        private void EncherGrid()
        {
            var dc = new NewPDV.Model();
            gridUsuario.ItemsSource = dc.TabUsuarios.ToList();
        }      
        private void BtnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            EncherGrid();
        }

        private void TrocarTela(enumTela tela)
        {
            quaDados.Visibility = Visibility.Collapsed;
            quaPesquisa.Visibility = Visibility.Collapsed;
            if (tela == enumTela.eDados)
            {
                quaDados.Visibility = Visibility.Visible;
            }
            if (tela == enumTela.ePesquisa)
            {
                quaPesquisa.Visibility = Visibility.Visible;
            }
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GridAlterar_Click(object sender, RoutedEventArgs e)
        {            
            if ((Usuarios)gridUsuario.SelectedItem != null)
            { 
                Usuarios us = (Usuarios)gridUsuario.SelectedItem;
                MessageBox.Show(us.USU_USUARIO);
            }
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            TrocarTela(enumTela.ePesquisa);
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            TrocarTela(enumTela.ePesquisa);
        }

        private void btnIncluir_Click(object sender, RoutedEventArgs e)
        {
            acao = enumAcao.eIncluir;
            TrocarTela(enumTela.eDados);
        }

        private void btnAlterar_Click(object sender, RoutedEventArgs e)
        {
            acao = enumAcao.eAlterar;
            TrocarTela(enumTela.eDados);
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            acao = enumAcao.eConsultar;
            TrocarTela(enumTela.eDados);
        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            acao = enumAcao.eExcluir;
           
        }
    }
}
