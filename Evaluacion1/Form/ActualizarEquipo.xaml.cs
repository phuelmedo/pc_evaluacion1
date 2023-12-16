using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para ActualizarEquipo.xaml
    /// </summary>
    public partial class ActualizarEquipo : Window
    {
        Class.Equipo Equipo = new Class.Equipo();
        public ActualizarEquipo(Class.Equipo equipo)
        {
            InitializeComponent();
            Equipo = equipo;
            CargarDatosEquipo();
        }

        private void ButtonActualizar_Click(object sender, RoutedEventArgs e)
        {
            Class.Equipo equipoTemporal = new();
            equipoTemporal.NombreEquipo = tbModNombreEquipo.Text;
            equipoTemporal.CantidadJugadores = Convert.ToInt32(tbModCantJugadores.Text);
            equipoTemporal.NombreDT = tbModNombreDt.Text;
            equipoTemporal.TipoEquipo = tbModTipoEquipo.Text;
            equipoTemporal.CapitanEquipo = tbModCapitanEquipo.Text;
            equipoTemporal.TieneSub21 = (cbModTiene21.IsChecked.Value) ? true : false;

            int index = Class.EquipoCollection.ListaEquipos.IndexOf(this.Equipo);
            Class.EquipoCollection.ListaEquipos.RemoveAt(index);
            Class.EquipoCollection.ListaEquipos.Insert(index, equipoTemporal);
            this.Close();
        }

        private void CargarDatosEquipo()
        {
            tbModNombreEquipo.Text = this.Equipo.NombreEquipo;
            tbModCantJugadores.Text = this.Equipo.CantidadJugadores.ToString();
            tbModNombreDt.Text = this.Equipo.NombreDT;
            tbModTipoEquipo.Text = this.Equipo.TipoEquipo;
            tbModCapitanEquipo.Text = this.Equipo.CapitanEquipo;
            cbModTiene21.IsChecked = (this.Equipo.TieneSub21) ? true : false;
        }

        private static Regex s_regex = new Regex("[^0-9]+");
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
