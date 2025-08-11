using PatriciaVillarrealGymManagement.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace PatriciaVillarrealGymManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // 1. Instancia y muestra la pantalla de carga.
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();

            base.OnStartup(e);

            // 2. Inicia una tarea en un hilo secundario para no bloquear la UI.
            Task.Run(() =>
            {
                // **Aquí se ejecuta tu lógica de inicialización.**
                // Por ejemplo, cargar datos, conectar a la base de datos, etc.
                // Reemplaza esto con tu código real.
                Thread.Sleep(2000); // Simula 3 segundos de carga.

                // 3. Cuando la tarea termine, regresa al hilo principal (UI) para abrir la ventana.
                // Dispatcher.Invoke asegura que el código se ejecute en el hilo correcto.
                this.Dispatcher.Invoke(() =>
                {
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.Show();
                    splashScreen.Close();
                });
            });
        }
    }
}
