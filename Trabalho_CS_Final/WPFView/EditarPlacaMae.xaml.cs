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
    /// Lógica interna para EditarPlacaMae.xaml
    /// </summary>
    public partial class EditarPlacaMae : Window
    {
        private PlacaMae _placa;
        public EditarPlacaMae(PlacaMae placa)
        {
            InitializeComponent();
            _placa= placa;
            pegarPlaca(_placa);
        }
        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            PlacaMae ID_Placa = new PlacaMae();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarPlaca(PlacaMae _placa)
        {
            txtNome.Text = _placa.Nome;
            txtValor.Text = _placa.Valor.ToString();

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

            PlacaMaeController placaController = new PlacaMaeController();
            _placa.Nome = txtNome.Text;
            _placa.Valor = decimal.Parse(txtValor.Text);
            placaController.Atualizar(_placa);


            MessageBox.Show("Placa Mãe editada com exito!");

            this.Close();


        }
    }
}
