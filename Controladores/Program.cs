using edu.CMejeroRecuperacion.Dtos;
using edu.CMejeroRecuperacion.Servicios;

namespace edu.CMejeroRecuperacion.Controladores
{
    /// <summary>
    /// CLase principal de nuestra aplicacion
    /// </summary>
    internal class Program
    {

        static public string rutaFichero = "C:\\Users\\Carlos\\source\\repos\\edu.CMejero\\Logs\\";
        static public string rutaFicheroDatos = "C:\\Users\\Carlos\\source\\repos\\edu.CMejero\\datosIniciales.txt";
        static public string rutaFicheroLog = String.Concat(rutaFichero, Utiles.Util.nombreFicheroLog()) ;


        static public List<VehiculoDto> listaVehiculos = new List<VehiculoDto>() ;
        static public List<PropietarioDto> listaPropietarios = new List<PropietarioDto>() ;

        /// <summary>
        /// Metodo principal de entrada de nuestra aplicacion
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();
            FicheroInterfaz fi = new FicheroImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();

            int opcionUsuario;
            bool cerrarMenu = false;
            fi.leerFichero();
            do {
                try
                {

                    opcionUsuario = mi.menuYSeleccion();

                    switch (opcionUsuario) {

                        case 0:
                            Console.WriteLine("Has seleccionado cerrar menu");
                            fi.escribirFicheroLog("Has seleccionado cerrar menu");
                            cerrarMenu= true;
                            break;

                        case 1:

                            Console.WriteLine("Has seleccionado numero de historicos");
                            fi.escribirFicheroLog("Has seleccionado numero de historicos");
                            oi.numerosHistoricos();
                            break;

                        case 2:
                            Console.WriteLine("Has seleccionado alta nuevo propietario");
                            fi.escribirFicheroLog("Has seleccionado alta nuevo propietario");
                            oi.darAltaPropietario();
                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada es incorrecta");
                            fi.escribirFicheroLog("La opcion seleccionada es incorrecta");
                            break;


                    }


                }
                catch (Exception ex) {
                    Console.WriteLine("Se ha producido un error, intentelo más tarde");
                    fi.escribirFicheroLog(String.Concat("Se ha producido un error: ", ex.Message));

                }
            
            
                     
            }while(!cerrarMenu);




        }
    }
}
