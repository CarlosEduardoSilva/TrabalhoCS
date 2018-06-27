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
    /// Lógica interna para Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
        public Cadastrar()
        {
            InitializeComponent();
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
                CadastroCliente main = new CadastroCliente();
                main.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");
                
            }
        }

        private void btn_CancelarClick(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

    }
}
