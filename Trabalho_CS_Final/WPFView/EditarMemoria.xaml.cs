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
    /// Lógica interna para EditarMemoria.xaml
    /// </summary>
    public partial class EditarMemoria : Window
    {
        private Memoria _memoria;

        public EditarMemoria(Memoria memoria)
        {
            InitializeComponent();
            _memoria = memoria;
            pegarMemoria(_memoria);
        }
    private void BuscarId_Click(object sender, RoutedEventArgs e)
    {

        Memoria ID_Memoria= new Memoria();

        //clienteId.ID_Cliente = txtBuscarId.Text;
    }

    public void pegarMemoria(Memoria _memoria)
    {
        txtNome.Text = _memoria.Nome;
        txtValor.Text = _memoria.Valor.ToString();

    }

    private void btnAtualizar_Click(object sender, RoutedEventArgs e)
    {

        MemoriaController memoriaController = new MemoriaController();
        _memoria.Nome = txtNome.Text;
        _memoria.Valor = decimal.Parse(txtValor.Text);
        memoriaController.Atualizar(_memoria);


        MessageBox.Show("Memoria editada com exito!");

        this.Close();

        }

    }
}
