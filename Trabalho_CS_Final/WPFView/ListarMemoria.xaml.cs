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
    /// Lógica interna para MemoriaListar.xaml
    /// </summary>
    public partial class ListarMemoria : Window
    {
        public ListarMemoria()
        {
            InitializeComponent();
        }

        private void Memoria_Listar(object sender, RoutedEventArgs e)
        {
            MemoriaController mem = new MemoriaController();
            DgMemoria.ItemsSource = mem.BuscarTodos();


        }

        public void Selection_Memoria(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Memoria mem = (Memoria)dg.Items[dg.SelectedIndex];

            EditarMemoria edit = new EditarMemoria(mem);


            edit.Show();

            this.Close();
        }
    }
}
