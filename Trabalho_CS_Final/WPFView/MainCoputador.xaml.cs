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
    /// Lógica interna para MainCoputador.xaml
    /// </summary>
    public partial class MainCoputador : Window
        

    {

        Computador pc = new Computador();
        public MainCoputador()
        {
            InitializeComponent();
        }

        private void Listar_Loaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void select_listar(object sender, SelectionChangedEventArgs e)
        {
           
        }
    }
}
