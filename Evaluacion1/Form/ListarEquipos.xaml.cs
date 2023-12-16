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

namespace Evaluacion1.Form
{
    /// <summary>
    /// Lógica de interacción para ListarEquipos.xaml
    /// </summary>
    public partial class ListarEquipos : Window
    {
        private Class.Equipo equipoSeleccionadoActual;
        public ListarEquipos()
        {
            InitializeComponent();
            lvEquipos.ItemsSource = Class.EquipoCollection.ListaEquipos;
        }
        private void lvEquipos_Seleccion(object sender, SelectionChangedEventArgs e)
        {
            equipoSeleccionadoActual = lvEquipos.SelectedItem as Class.Equipo;
        }
        public void EliminarButton_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject depObj = (DependencyObject)e.OriginalSource;

            while (depObj != null && !(depObj is ListViewItem))
            {
                depObj = VisualTreeHelper.GetParent(depObj);
            }

            if (depObj is ListViewItem item)
            {
                item.IsSelected = true;
            
                var equipoSeleccionado = item.DataContext as Class.Equipo;
                Class.EquipoCollection.ListaEquipos.Remove(equipoSeleccionado);
                lvEquipos.Items.Refresh();
            }
        }
        public void ModificarButton_Click(object sender, RoutedEventArgs e)
        {
            DependencyObject depObj = (DependencyObject)e.OriginalSource;

            while (depObj != null && !(depObj is ListViewItem))
            {
                depObj = VisualTreeHelper.GetParent(depObj);
            }

            if (depObj is ListViewItem item)
            {
                item.IsSelected = true;

                var equipoSeleccionado = item.DataContext as Class.Equipo;
                ActualizarEquipo actualizar = new ActualizarEquipo(equipoSeleccionado);
                actualizar.ShowDialog();
                lvEquipos.Items.Refresh();
            }
        }
    }
}
