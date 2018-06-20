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
    /// Lógica interna para Excluir.xaml
    /// </summary>
    public partial class Excluir : Window
    {
        private Cliente _cli;

        public Excluir()
        {
        }

        public Excluir(Cliente cli)
        {
            _cli = cli;
            InitializeComponent();
        }


        public void btnExcluir_Click(object sender, RoutedEventArgs e)
        {
            ClienteController excluirCliente = new ClienteController();

            excluirCliente.Excluir(_cli.ID_Cliente);


            MessageBox.Show("Usuario excluido com exito!");

            this.Close();

        }
    }
}
