using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.Class
{
    public class Equipo
    {
        public Equipo() { }
        public Equipo(string nombreEquipo, int cantidadJugadores, string nombreDT, string tipoEquipo, string capitanEquipo, bool tieneSub21)
        {
            NombreEquipo = nombreEquipo;
            CantidadJugadores = cantidadJugadores;
            NombreDT = nombreDT;
            TipoEquipo = tipoEquipo;
            CapitanEquipo = capitanEquipo;
            TieneSub21 = tieneSub21;
        }
        public string NombreEquipo { get; set; } = null!;
        public int CantidadJugadores { get; set; }
        public string NombreDT { get; set; } = null!;
        public string TipoEquipo { get; set; } = null!;
        public string CapitanEquipo { get; set; } = null!;
        public bool TieneSub21 { get; set; }
    }
}
