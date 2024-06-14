using edu.CMejeroRecuperacion.Controladores;
using edu.CMejeroRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Servicios
{
    /// <summary>
    /// Clase que implementa la operativa interfaz
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {

        public void darAltaPropietario()
        {


            PropietarioDto propietario = new PropietarioDto();

            string dni;
            propietario.Id = crearId();
            bool verificar = false;
            do
            {
                Console.WriteLine("Introduzca el Dni");
                dni = Console.ReadLine();
                if (dni.Length == 9)
                {
                    verificar = true;

                }

            } while (dni.Length != 9);

            if (verificar == true)
            {

                propietario.Dni = dni;
            }


            Program.listaPropietarios.Add(propietario);

            Console.WriteLine(propietario.ToString("-"));
        }

        public void numerosHistoricos()
        {

            VehiculoDto vehiculo = new VehiculoDto();

            DateTime fecha = vehiculo.FechaMatriculacion;
            string formato = fecha.ToString("dd-MM-yyyy");
            DateTime fechaVehiculo = DateTime.Parse(formato);

            DateTime fechaHoy = DateTime.Today;
            string formato2 = fechaHoy.ToString("dd-MM-yyyy");
            DateTime fechaActual = DateTime.Parse(formato2);



            TimeSpan diferencia = fechaActual - fechaVehiculo;

            int dias = diferencia.Days;


            int anyos = dias / (12 * 30);



            foreach (VehiculoDto vehiculoDto in Program.listaVehiculos)
            {
                if (anyos > 25) {

                    Console.WriteLine(String.Concat("N. Historicos: "), Program.listaVehiculos.Count);


                }








            }



            /// <summary>
            /// Metodo que se encarga de generar un nuevo id
            /// </summary>
            /// <returns>devuelve un long con el valor del nuevo id</returns>
            private long crearId()
            {
                long nuevoId;
                int tamanioLista = Program.listaPropietarios.Count;

                if (tamanioLista > 0)
                {
                    nuevoId = Program.listaPropietarios[tamanioLista - 1].Id + 1;
                }
                else
                {
                    nuevoId = 1;
                }
                return nuevoId;

            }
        }
    }
}

