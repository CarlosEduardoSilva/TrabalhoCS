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
    /// Lógica interna para MemoriaCadastro.xaml
    /// </summary>
    public partial class MemoriaCadastro : Window
    {
        public MemoriaCadastro()
        {
            InitializeComponent();
        }

        private void BtnCad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Memoria me = new Memoria();

                me.Nome = txtNome.Text;
                me.Valor = decimal.Parse(txtValor.Text);


                MemoriaController memoria= new MemoriaController();
                memoria.Salvar(me);


                MessageBox.Show("Memoria salva com exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar Memoria (" + ex.Message + ")");
            }


        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
