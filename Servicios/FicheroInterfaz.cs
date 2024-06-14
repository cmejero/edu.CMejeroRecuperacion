using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Servicios
{
    /// <summary>
    /// Clase que se encarga de los metodos relacionados con ficheros
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// metodo que se encarga de escribir los fallos y despalzamiento del usuario por el menu
        /// </summary>
        /// <param name="mensaje">mensaje del error o traza de desplazamiento</param>
        public void escribirFicheroLog(string mensaje);
        public void leerFichero();
    }
}
