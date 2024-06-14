using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Servicios
{
    /// <summary>
    /// Clase que se encarga de la oprativa de la aplicacion
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de dar de alta a un nuevo propietario
        /// </summary>
        public void darAltaPropietario();

        /// <summary>
        /// Metodo que se encarga de mostrar por pantalla los vehiculos historicos
        /// </summary>
        public void numerosHistoricos();
    }
}
