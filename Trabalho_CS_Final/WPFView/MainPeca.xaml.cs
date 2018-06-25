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

        private void btnPlaca_Click(object sender, RoutedEventArgs e)
        {
            PlacaCadastro pla = new PlacaCadastro();
            pla.Show();


        }


        private void btnProcessador_Click(object sender, RoutedEventArgs e)
        {
            ProcessadorCadastro pro = new ProcessadorCadastro();

            pro.ShowDialog();

        }


        private void btnHd_Click(object sender, RoutedEventArgs e)
        {
            HdCadastro hd = new HdCadastro();

            hd.ShowDialog();

        }

        private void btnFonte_Click(object sender, RoutedEventArgs e)
        {
            FonteCadastro fon = new FonteCadastro();
            fon.Show();


        }

        private void btnMemoria_Click(object sender, RoutedEventArgs e)
        {
            MemoriaCadastro mem = new MemoriaCadastro();
            mem.Show();


        }

        private void btnPlacaListar_Click(object sender, RoutedEventArgs e)
        {
            PlacaListar lis = new PlacaListar();
            lis.Show();


        }
        private void btnProcessadorListar_Click(object sender, RoutedEventArgs e)
        {
            ProcessadorListar lis = new ProcessadorListar();
            lis.Show();


        }
        private void btnHdListar_Click(object sender, RoutedEventArgs e)
        {
            HDListar hd = new HDListar();
            hd.Show();


        }
        private void btnFonteListar_Click(object sender, RoutedEventArgs e)
        {
            FonteListar fon = new FonteListar();
            fon.Show();


        }
        private void btnMemoriaListar_Click(object sender, RoutedEventArgs e)
        {
            MemoriaListar mem = new MemoriaListar();
            mem.Show();


        }
    }
}
