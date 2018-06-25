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
    /// Lógica interna para FonteCadastro.xaml
    /// </summary>
    public partial class FonteCadastro : Window
    {
        public FonteCadastro()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Fonte fo = new Fonte();

                fo.Nome = txtNome.Text;
                fo.Valor = decimal.Parse(txtValor.Text);


                FonteController fonte = new FonteController();
                fonte.Salvar(fo);


                MessageBox.Show("Fonte salva com exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar Fonte (" + ex.Message + ")");
            }


        }

    }
}
