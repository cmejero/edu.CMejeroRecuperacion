using edu.CMejeroRecuperacion.Controladores;
using edu.CMejeroRecuperacion.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Servicios
{
    /// <summary>
    /// Clase que se encarga de implementar a fichero interfaz
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {

        public void escribirFicheroLog(string mensaje)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(Program.rutaFicheroLog);

                sw.WriteLine(mensaje);





            }
            catch (IOException io)
            {

                Console.WriteLine("Se ha producido un error, intentelo más tarde");

            }
            finally
            {
                if (sw != null)
                {

                    sw.Close();
                }
            }
        }

        public void leerFichero()
        {

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(Program.rutaFicheroDatos);

                string lineas = "";

                while((lineas = sr.ReadLine()) != null)
                {
                    string[] linea = lineas.Split(":");

                    VehiculoDto vehiculo = new VehiculoDto();
                    vehiculo.IdVehiculo = crearIdVehiculo();
                    vehiculo.Matricula = linea[0];
                    string matricula = linea[1];
                    DateTime fechaM = DateTime.Parse(matricula);
                    vehiculo.FechaMatriculacion = fechaM;

                    Program.listaVehiculos.Add(vehiculo);   

                   
                    long idVehiculo = crearIdPropietarios();
                    string matricula2 = linea[0];
                    string dni = linea[2];
                    string fechaCompraDias = linea[3];
                    string fechaCompraMeses = linea[4];
                    string fechaCompraAnyos = linea[5];
                    int dias = int.Parse(fechaCompraDias);
                    int meses = int.Parse(fechaCompraMeses);
                    int anyos = int.Parse(fechaCompraAnyos);
                   
                    PropietarioDto propietario = new PropietarioDto(idVehiculo,dni,matricula, dias,meses, anyos);


                    
                    
                    
                    Program.listaPropietarios.Add(propietario);







                }






            }
            catch (IOException io)
            {
                Console.WriteLine("Se ha producido un error, intentelo más tarde");
                escribirFicheroLog(String.Concat("Se ha producido un error: ", io.Message));

            }
            finally {

                if (sr != null) { sr.Close(); }
            }
        }

        /// <summary>
        /// Metodo que se encarga de crear un id para vehiculos
        /// </summary>
        /// <returns></returns>
        private long crearIdVehiculo()
        {
            long nuevoId;
            int tamanioLista = Program.listaVehiculos.Count;

            if (tamanioLista > 0)
            {
                nuevoId = Program.listaVehiculos[tamanioLista - 1].IdVehiculo + 1;
            }
            else
            {
                nuevoId = 1;
            }
            return nuevoId;

        }

        /// <summary>
        /// Metodo que se encarga de crear un id para propietarios
        /// </summary>
        /// <returns></returns>
        private long crearIdPropietarios()
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
