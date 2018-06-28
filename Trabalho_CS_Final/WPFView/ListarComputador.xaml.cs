using Controllers;
using Models;
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
    /// Lógica interna para ListarComputador.xaml
    /// </summary>
    public partial class ListarComputador : Window
    {
        public ListarComputador()
        {
            InitializeComponent();
        }

        

        private void ListaDeComputador(object sender, RoutedEventArgs e)
        {
            ComputadorController computadorController = new ComputadorController();
            dgComputador.ItemsSource = computadorController.BuscarTodos();
        }

        private void Selection_Computador(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);
            Computador cli = (Computador)dg.Items[dg.SelectedIndex];

        }
    }
}
