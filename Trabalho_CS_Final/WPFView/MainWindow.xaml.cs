﻿using System;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            Cadastrar cadastro = new Cadastrar();
            main.Close();
            cadastro.Show();

        }

        
        private void btnListarClientes_Click(object sender, RoutedEventArgs e)
        {
            ListarClientes listar = new ListarClientes();
            
            listar.ShowDialog();

        }


    }
}
