using MySql.Data.MySqlClient;
using PatriciaVillarrealGymManagement.Models.database;
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

namespace PatriciaVillarrealGymManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            connection db = new connection();
            MySqlConnection conn = db.StartConnection();

            
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conexión a la base de datos exitosa");

         
                db.EndConnection();
            }
            else
            {
                MessageBox.Show("Error: La conexión a la base de datos falló");
            }
        }
    }
}
