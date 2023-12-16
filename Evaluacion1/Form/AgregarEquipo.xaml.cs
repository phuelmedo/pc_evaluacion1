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
    /// Lógica de interacción para AgregarEquipo.xaml
    /// </summary>
    public partial class AgregarEquipo : Window
    {
        public AgregarEquipo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombreEquipo = tbNombreEquipo.Text;
            int cantidadJugadores = Convert.ToInt32(tbCantJugadores.Text);
            string nombreDt = tbNombreDt.Text;
            string tipoEquipo = tbTipoEquipo.Text;
            string capitanEquipo = tbCapitanEquipo.Text;
            bool tieneSub21 = (cbTiene21.IsChecked.Value) ? true : false;

            Class.Equipo equipo = new Class.Equipo(nombreEquipo, cantidadJugadores, nombreDt, tipoEquipo, capitanEquipo, tieneSub21);

            Class.EquipoCollection.ListaEquipos.Add(equipo);
            this.Close();
        }

        private static Regex s_regex = new Regex("[^0-9]+");
        private void CheckTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = s_regex.IsMatch(e.Text);
        }
    }
}
