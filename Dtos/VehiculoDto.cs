using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Dtos
{
    /// <summary>
    /// Clase con la plantilla para crear datos sobre vehiculos
    /// </summary>
    internal class VehiculoDto
    {
        long idVehiculo;
        string matricula = "aaaaa";
        DateTime fechaMatriculacion = new DateTime(1999, 1, 31);

        public VehiculoDto()
        {
        }

        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FechaMatriculacion { get => fechaMatriculacion; set => fechaMatriculacion = value; }
    }
}
