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
    /// Lógica interna para ProcessadorCadastro.xaml
    /// </summary>
    public partial class ProcessadorCadastro : Window
    {
        public ProcessadorCadastro()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Processador pro = new Processador();

                pro.Nome = txtNome.Text;
                pro.Valor = decimal.Parse(txtValor.Text);


                ProcessadorController processador = new ProcessadorController();
                processador.Salvar(pro);


                MessageBox.Show("Procesador salvo com exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o processador (" + ex.Message + ")");
            }


        }
    }
}
