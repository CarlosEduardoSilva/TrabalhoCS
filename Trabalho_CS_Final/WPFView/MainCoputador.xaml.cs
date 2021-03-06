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
    /// Lógica interna para MainCoputador.xaml
    /// </summary>
    public partial class MainCoputador : Window

    {
        private readonly PlacaMaeController placaMaeController = new PlacaMaeController();
        private readonly ProcessadorController processadorController = new ProcessadorController();
        private readonly HDController hdController = new HDController();
        private readonly MemoriaController memoriaController = new MemoriaController();
        private readonly FonteController fonteController = new FonteController();

        public MainCoputador()
        {
            InitializeComponent();
            ComboBoxPlacaMae.ItemsSource = placaMaeController.BuscarTodos();
            ComboBoxProcessador.ItemsSource = processadorController.BuscarTodos();
            ComboBoxHd.ItemsSource = hdController.BuscarTodos();
            ComboBoxMemoria.ItemsSource = memoriaController.BuscarTodos();
            ComboBoxFonte.ItemsSource = fonteController.BuscarTodos();
        }

        private void Listar_Loaded(object sender, RoutedEventArgs e)
        {


        }


        private void btnMontar_Click(object sender, RoutedEventArgs e)
        {

            try
            {   
                Computador pc = new Computador();
                pc.PlacamaeID = int.Parse(ComboBoxPlacaMae.SelectedValue.ToString());
                pc.ProcessadorID = int.Parse(ComboBoxProcessador.SelectedValue.ToString());
                // Tamo ferrado
                pc.HDID = int.Parse(ComboBoxHd.SelectedValue.ToString());
                pc.MemoriaID = int.Parse(ComboBoxMemoria.SelectedValue.ToString());
                pc.FonteID = int.Parse(ComboBoxMemoria.SelectedValue.ToString());


                ComputadorController montarPC = new ComputadorController();

                montarPC.Salvar(pc);


                MessageBox.Show("Computador salvo com exito!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar computador (" + ex.Message + ")");

            }


        }

        private void Listar_Computador(object sender, RoutedEventArgs e)
        {

            ListarComputador listarComputador = new ListarComputador();

            listarComputador.Show();


        }
    }
}
