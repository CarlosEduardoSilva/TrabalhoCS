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
    /// Lógica interna para FonteListar.xaml
    /// </summary>
    public partial class FonteListar : Window
    {
        public FonteListar()
        {
            InitializeComponent();
        }

        private void Fonte_Listar(object sender, RoutedEventArgs e)
        {
            FonteController fon = new FonteController();
            DgFonte.ItemsSource = fon.BuscarTodos();


        }

        public void Selection_Fonte(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Fonte fon = (Fonte)dg.Items[dg.SelectedIndex];

            EditarFonte edit = new EditarFonte(fon);


            edit.Show();

            this.Close();


        }
    }
}
