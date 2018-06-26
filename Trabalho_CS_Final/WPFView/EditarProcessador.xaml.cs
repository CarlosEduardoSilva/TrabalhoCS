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
    /// Lógica interna para EditarProcessador.xaml
    /// </summary>
    public partial class EditarProcessador : Window
    {
        private Processador _processador;

        public EditarProcessador(Processador processador)
        {
            InitializeComponent();
            _processador = processador;
            pegarProcessador(_processador);
        }
        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            Processador ID_Processador = new Processador();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarProcessador(Processador _processador)
        {
            txtNome.Text = _processador.Nome;
            txtValor.Text = _processador.Valor.ToString();

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

            ProcessadorController processadorController = new ProcessadorController();
            _processador.Nome = txtNome.Text;
            _processador.Valor = decimal.Parse(txtValor.Text);
            processadorController.Atualizar(_processador);


            MessageBox.Show("Processador editado com exito!");

            this.Close();


        }
    }

}
