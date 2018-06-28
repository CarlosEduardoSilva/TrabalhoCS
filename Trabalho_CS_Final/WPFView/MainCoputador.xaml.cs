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
            Computador pc = new Computador();
            pc.PlacaMae = placaMaeController.Buscar(int.Parse(ComboBoxPlacaMae.SelectedValue.ToString()));

            new ComputadorController().Salvar(pc);

        }
    }
}
