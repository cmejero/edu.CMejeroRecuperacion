using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Servicios
{
    /// <summary>
    /// Clase que se encarga de los menus de nuestra aplicacion
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que se encarga de mostrar el menu principal de nuestra aplicacion
        /// </summary>
        /// <returns>devuelve la opcion indicada por el usuario</returns>
        public int menuYSeleccion();
    }
}
