using Evaluacion1.Form;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Evaluacion1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        private void Agregar_Click(object sender, RoutedEventArgs e) 
        {
            AgregarEquipo agregarEquipo = new AgregarEquipo();
            agregarEquipo.ShowDialog();
        }
        private void Listar_Click(object sender, RoutedEventArgs e) 
        {
            ListarEquipos listarEquipos = new ListarEquipos();
            listarEquipos.ShowDialog();
        }
        private void Acerca_Click(object sender, RoutedEventArgs e) 
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.ShowDialog();
        }
    }
}
