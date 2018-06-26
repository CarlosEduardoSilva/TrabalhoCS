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
    /// Lógica interna para EditarFonte.xaml
    /// </summary>
    public partial class EditarFonte : Window
    {
        private Fonte _fonte;
        
        public EditarFonte(Fonte fonte)
        {
            InitializeComponent();
            _fonte = fonte;
            pegarFonte(_fonte);
        }

        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

           Fonte ID_Fonte = new Fonte();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarFonte(Fonte _fonte)
        {
            txtNome.Text = _fonte.Nome;
            txtValor.Text = _fonte.Valor.ToString();

        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

            FonteController fonteController = new FonteController();
            _fonte.Nome = txtNome.Text;
            _fonte.Valor = decimal.Parse(txtValor.Text);
            fonteController.Atualizar(_fonte);

            
            MessageBox.Show("Fonte editada com exito!");

            this.Close();


        }
    }
}
