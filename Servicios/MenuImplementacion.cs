using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Servicios
{
    /// <summary>
    /// Clase que implementa el menu interfaz
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuYSeleccion()
        {
            int opcionUsuario;

            Console.WriteLine("######################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Menu de historicos");
            Console.WriteLine("2. Alta nuevo propietario");
            Console.WriteLine("######################");

            opcionUsuario = Convert.ToInt32(Console.ReadLine());

            return opcionUsuario;


        }
    }
}
