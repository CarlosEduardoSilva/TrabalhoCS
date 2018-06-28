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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFView
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientes_Click(object sender, RoutedEventArgs e)
        {
            CadastroCliente main = new CadastroCliente();
            Cadastrar cadastro = new Cadastrar();
            main.Close();
            //cadastro.Show();

            
            cadastro.ShowDialog();
            //this.Close();

        }


        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes listar = new ListarClientes();
            
            listar.ShowDialog();

        }


        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            ListaClienteExcluir excluir = new ListaClienteExcluir();

            excluir.ShowDialog();

        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.Nome = txtNome.Text;
                cliente.Login = txtLogin.Text;
                cliente.Email = txtEmail.Text;
                cliente.Senha = txtSenha.Text;

                ClienteController clienteController = new ClienteController();
                clienteController.Salvar(cliente);

                MessageBox.Show("Usuario salvo com exito!");

                this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");

            }
           
        }

        private void btnPrincipal(object sender, RoutedEventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
        }

        private void btnEditarClientes_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes listar = new ListarClientes();

            listar.ShowDialog();

        }
    }
}
