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
    /// Lógica interna para PlacaListar.xaml
    /// </summary>
    public partial class PlacaListar : Window
    {
        public PlacaListar()
        {
            InitializeComponent();
        }

        private void Listar_Loaded(object sender, RoutedEventArgs e)
        {
            PlacaMaeController placaList = new PlacaMaeController();
            DgListPlaca.ItemsSource = placaList.BuscarTodos();

        }

        private void select_listar(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            PlacaMae placa = (PlacaMae)dg.Items[dg.SelectedIndex];

            EditarPlacaMae edit = new EditarPlacaMae(placa);


            edit.Show();

            this.Close();
        }
    }
}
