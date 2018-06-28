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

namespace WPFView
{
    /// <summary>
    /// Lógica interna para TesteMainWindow.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid)  ;

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:
                    GridMain.Background = Brushes.Aquamarine;
                    ListarClientes listarCl = new ListarClientes();

                    listarCl.Show();

                    break;
                case 1 :
                    GridMain.Background = Brushes.Beige;

                    CadastroCliente clientes = new CadastroCliente();
                    clientes.Show();

                    Principal teste = new Principal();
                    

                    break;
                case 2:
                    GridMain.Background = Brushes.CadetBlue;
                    MainPeca pecas = new MainPeca();
                    pecas.Show();

                    break;
                case 3:
                    GridMain.Background = Brushes.DarkBlue;
                    MainCoputador computadores = new MainCoputador();
                    computadores.Show();

                    break;
                case 4:
                    GridMain.Background = Brushes.Firebrick;
                    
                    
                    break;
                case 5:
                    GridMain.Background = Brushes.Gainsboro;

                    break;
                case 6:
                    GridMain.Background = Brushes.HotPink;

                    break;
                default:
                    break;
            }

        }

        
        private void teste(object sender, RoutedEventArgs e)
        {
            Principal teste = new Principal();
            this.Close();

        }
    }
}
