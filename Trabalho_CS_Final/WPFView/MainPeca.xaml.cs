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
    /// Lógica interna para MainPeca.xaml
    /// </summary>
    public partial class MainPeca : Window
    {
        public MainPeca()
        {
            InitializeComponent();
        }
              

        private void BtnCadMae_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PlacaMae pm = new PlacaMae();

                pm.Nome = txtNome.Text;
                pm.Valor = decimal.Parse(txtValor.Text);


                PlacaMaeController placa = new PlacaMaeController();
                placa.Salvar(pm);


                MessageBox.Show("Placa Mãe salva com exito!");
               


            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar o usuário (" + ex.Message + ")");
            }
        }

        private void BtnCadPro_Click(object sender, RoutedEventArgs e)
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

        private void BtnCadHd_Click(object sender, RoutedEventArgs e)
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

        private void BtnCadMem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Memoria me = new Memoria();

                me.Nome = txtNome.Text;
                me.Valor = decimal.Parse(txtValor.Text);


                MemoriaController memoria = new MemoriaController();
                memoria.Salvar(me);


                MessageBox.Show("Memoria salva com exito!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao salvar Memoria (" + ex.Message + ")");
            }
        }

        private void BtnCadFon_Click(object sender, RoutedEventArgs e)
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

        private void BtnLisMae_Click(object sender, RoutedEventArgs e)
        {
            ListarPlacaMae listarPlacaMae = new ListarPlacaMae();
            listarPlacaMae.Show();
        }

        private void BtnLisPro_Click(object sender, RoutedEventArgs e)
        {
            ListarProcessador listarProcessador = new ListarProcessador();

            listarProcessador.Show();
        }

        private void BtnLisHd_Click(object sender, RoutedEventArgs e)
        {
            ListarHd listarHd = new ListarHd();
            listarHd.Show();
        }

        private void BtnLisMem_Click(object sender, RoutedEventArgs e)
        {
            ListarMemoria listarMemoria = new ListarMemoria();
            listarMemoria.Show();
        }

        private void BtnLisFon_Click(object sender, RoutedEventArgs e)
        {
            ListarFonte listarFonte = new ListarFonte();
            listarFonte.Show();

        }
    }
}
