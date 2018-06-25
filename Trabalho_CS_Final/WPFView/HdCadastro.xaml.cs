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
    /// Lógica interna para HdCadastro.xaml
    /// </summary>
    public partial class HdCadastro : Window
    {
        public HdCadastro()
        {
            InitializeComponent();
        }
        private void BtnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HD hd = new HD();

                hd.Nome = txtNome.Text;
                hd.Valor = decimal.Parse(txtValor.Text);


                HDController hde = new HDController();
                hde.Salvar(hd);


                MessageBox.Show("HD salvo com exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar HD (" + ex.Message + ")");
            }


        }


    }
}
