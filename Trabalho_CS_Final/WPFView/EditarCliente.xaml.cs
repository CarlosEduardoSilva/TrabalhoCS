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
    /// Lógica interna para Editar.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        private Cliente _cli;

        public EditarCliente(Cliente cli)
        {
            InitializeComponent();
            _cli = cli;
            pegarCli(_cli);
        }

        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            Cliente clienteId = new Cliente();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarCli(Cliente _cli)
        {
            txtNome.Text =  _cli.Nome;
            txtLogin.Text = _cli.Login;
            txtEmail.Text = _cli.Email;
            txtSenha.Text = _cli.Senha;

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

            ClienteController clienteController = new ClienteController();
            _cli.Nome = txtNome.Text;
            _cli.Login = txtLogin.Text;
            _cli.Email = txtEmail.Text;
            _cli.Senha = txtSenha.Text;
            clienteController.Atualizar(_cli);

            MessageBox.Show("Usuario editado com exito!");

            this.Close();


        }

        
    }


    

}
