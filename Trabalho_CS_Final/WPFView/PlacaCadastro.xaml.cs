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
    /// Lógica interna para PlacaCadastro.xaml
    /// </summary>
    public partial class PlacaCadastro : Window
    {
        public PlacaCadastro()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PlacaMae pm = new PlacaMae();

                pm.Nome = txtNome.Text;
                pm.Valor = decimal.Parse(txtValor.Text);


                PlacaMaeController placa = new PlacaMaeController();
                placa.Salvar(pm);


                MessageBox.Show("Placa Mãe salva com exito!");

            }
            catch (Exception ex )
            {

                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");
            }

            
        }
    }
}
