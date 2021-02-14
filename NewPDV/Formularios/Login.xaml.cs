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
using System.Windows.Shapes;

namespace NewPDV.Formularios
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        Window formPrincipal;
        bool Aguardar = false;
        public Login(Window form)
        {
            InitializeComponent();
            formPrincipal = form;
            formPrincipal.Hide();
            this.Show();
            TxtUsuario.Focus();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // formPrincipal.Show();
        }


        private void TxtUsuario_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (TxtUsuario.Text == "")
                {
                    return;
                }

                Usuarios us = new Usuarios();
                if (!us.ValidarUsuario(TxtUsuario.Text, "", us))
                {
                    MessageBox.Show("Usuário inválido");
                    TxtUsuario.Text = "";
                    TxtUsuario.Focus();
                }
                else
                {
                    Aguardar = true;
                    TxtSenha.Focus();
                }
            }


        }
        private bool ValidarUsuario()
        {
            Usuarios us = new Usuarios();
            if (!us.ValidarUsuario(TxtUsuario.Text, TxtSenha.Password, us))
            {
                MessageBox.Show("Usuário ou senha incorretos");
                TxtSenha.Focus();
                return false;
            }
            else
            {
                this.Close();
                formPrincipal.Show();
                return true;
            }

        }


        private void BtnEntrar_Click(object sender, RoutedEventArgs e)
        {
            ValidarUsuario();
        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (!Aguardar)
                    ValidarUsuario();
                else
                    Aguardar = false;
            }
        }
    }
}
