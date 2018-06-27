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
    /// Lógica interna para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        
        private void Btn_Cadastro_Click(object sender, RoutedEventArgs e)
        {
            Principal pri = new Principal();
            MainWindow cad = new MainWindow();

            cad.ShowDialog();
            pri.Close();

        }

        private void Btn_Pecas_Click(object sender, RoutedEventArgs e)
        {
            MainPeca pec = new MainPeca();

            pec.ShowDialog();


        }

        private void Btn_Computador_Click(object sender, RoutedEventArgs e)
        {
            MainCoputador com = new MainCoputador();

            com.ShowDialog();

        }

        private void Teste_click(object sender, RoutedEventArgs e)
        {
            TesteMainWindow teste = new TesteMainWindow();

            teste.Show();
        }
    }
}
