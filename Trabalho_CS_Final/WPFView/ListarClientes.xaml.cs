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
    /// Lógica interna para Listar.xaml
    /// </summary>
    public partial class ListarClientes : Window
    {
        public ListarClientes()
        {
            InitializeComponent();
        }


        private void Window_loaded(object sender, RoutedEventArgs e)
        {
            ClienteController clienteController = new ClienteController();
            dgCliente.ItemsSource = clienteController.BuscarTodos();

        }

        private void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Cliente cli = (Cliente)dg.Items[dg.SelectedIndex];
        }



    }
}
