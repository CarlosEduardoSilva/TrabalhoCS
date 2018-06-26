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
    /// Lógica interna para ProcessadorListar.xaml
    /// </summary>
    public partial class ProcessadorListar : Window
    {
        public ProcessadorListar()
        {
            InitializeComponent();
        }

        private void Processador_Listar(object sender, RoutedEventArgs e)
        {
            ProcessadorController proc = new ProcessadorController();
            DgProc.ItemsSource = proc.BuscarTodos();
            

        }

        public void Selection_Processador(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            Processador proc = (Processador)dg.Items[dg.SelectedIndex];

            EditarProcessador edit = new EditarProcessador(proc);


            edit.Show();

            this.Close();
        }
    }
}
