﻿using Controllers;
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
    /// Lógica interna para HDListar.xaml
    /// </summary>
    public partial class ListarHd : Window
    {
        public ListarHd()
        {
            InitializeComponent();
        }

        private void HD_Listar(object sender, RoutedEventArgs e)
        {
            HDController hd= new HDController();
            DgHd.ItemsSource = hd.BuscarTodos();

        }

        private void Selection_Hd(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = ((DataGrid)sender);

            HD hd = (HD)dg.Items[dg.SelectedIndex];

            EditarHd edit= new EditarHd(hd);


            edit.Show();

            this.Close();
        }

        
    }
}
