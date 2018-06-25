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
    /// Lógica interna para MainPeca.xaml
    /// </summary>
    public partial class MainPeca : Window
    {
        public MainPeca()
        {
            InitializeComponent();
        }

        private void btnCadastrarPecas_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Cadastrar cadastro = new Cadastrar();
            main.Close();
            //cadastro.Show();


            cadastro.ShowDialog();
            //this.Close();

        }


        private void btnListarPecas_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes listar = new ListarClientes();

            listar.ShowDialog();

        }


        private void btnExcluirPecas_Click(object sender, RoutedEventArgs e)
        {
            ListaExcluir excluir = new ListaExcluir();

            excluir.ShowDialog();

        }
    }
}
