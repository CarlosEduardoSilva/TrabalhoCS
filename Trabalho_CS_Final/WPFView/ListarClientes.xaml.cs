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
    public partial class ListarClientes : Window
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void EditarClienteLoaded(object sender, RoutedEventArgs e)
        {
            ClienteController clienteController = new ClienteController();
            dgClientes.ItemsSource = clienteController.BuscarTodos();
        }



        public void dgClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Cliente cli = (Cliente)dg.Items[dg.SelectedIndex];

            EditarCliente editar = new EditarCliente(cli);

           
            editar.Show();

            this.Close();

            

        }

       
    }


}
