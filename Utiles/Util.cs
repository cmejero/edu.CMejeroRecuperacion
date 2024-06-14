using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Utiles
{
    /// <summary>
    /// Clase que contiene los metodos que se usarán más de una vez dentro de nuestra aplicación
    /// </summary>
    internal static class Util
    {
        /// <summary>
        /// Metodo que se ebcarga de crear el nombre del fichero log
        /// </summary>
        /// <returns></returns>
        public static string nombreFicheroLog()
        {


            string nombreCompleto = "";


            try
            {
                DateTime fecha = DateTime.Today;

                string fechaString = fecha.ToString("ddMMyyyy");

                nombreCompleto = String.Concat("log-", fechaString, ".txt");

                

            }
           
            
            catch (Exception ex) {
                Console.WriteLine("Se ha producido un error, intentelo más tarde");

                    

            }
             return nombreCompleto;
            





        }
    }
}
