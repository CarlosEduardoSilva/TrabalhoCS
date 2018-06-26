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
    /// Lógica interna para EditarHd.xaml
    /// </summary>
    public partial class EditarHd : Window
    {

        private HD _hd; 

        public EditarHd(HD hd)
        {
            InitializeComponent();
            _hd = hd;
            pegarHd(_hd);


        }

        private void BuscarId_Click(object sender, RoutedEventArgs e)
        {

            HD ID_HD = new HD();

            //clienteId.ID_Cliente = txtBuscarId.Text;
        }

        public void pegarHd(HD _hd)
        {
            txtNome.Text = _hd.Nome;
            txtValor.Text = _hd.Valor.ToString();           
           
        }

        private void btnAtualizar_Click(object sender, RoutedEventArgs e)
        {

            HDController hdController = new HDController();
            _hd.Nome = txtNome.Text;
            _hd.Valor = decimal.Parse(txtValor.Text);
            hdController.Atualizar(_hd);
            

            MessageBox.Show("HD editado com exito!");

            this.Close();


        }


    }
}
