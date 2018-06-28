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
    /// Lógica interna para ListaExcluir.xaml
    /// </summary>
    public partial class ListaClienteExcluir : Window
    {
        public ListaClienteExcluir()
        {
            InitializeComponent();


        }
        private void ClienteLoaded(object sender, RoutedEventArgs e)
        {
            ClienteController clienteController = new ClienteController();
            dgExClientes.ItemsSource = clienteController.BuscarTodos();

        }

        public void dgExClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Cliente cli = (Cliente)dg.Items[dg.SelectedIndex];

            ExcluirCliente excluir = new ExcluirCliente(cli);


            excluir.Show();

            this.Close();



        }

       
        
    }

}
