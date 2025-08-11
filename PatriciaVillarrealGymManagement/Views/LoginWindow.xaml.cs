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

namespace PatriciaVillarrealGymManagement.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Password;

            if (usuario == "admin" && contrasena == "123")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close(); // Cierra la ventana de login
            }
            else
            {
                txtMensajeError.Text = "Usuario o contraseña incorrectos.";
                txtMensajeError.Visibility = Visibility.Visible;
            }
        }

    }
}
