using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.CMejeroRecuperacion.Dtos
{
    /// <summary>
    /// Clase con la plantilla para crear los propietarios
    /// </summary>
    internal class PropietarioDto
    {

        long id;
        string dni = "aaaaa";
        DateTime fchCompra = new DateTime(1999, 1, 31);
        string matricula = "aaaaa";
        bool esHistorico = false;
        int dias = 0;
        int meses = 0;
        int anyos = 0;

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public bool EsHistorico { get => esHistorico; set => esHistorico = value; }
        public int Dias { get => dias; set => dias = value; }
        public int Meses { get => meses; set => meses = value; }
        public int Anyos { get => anyos; set => anyos = value; }

       

       

        public PropietarioDto()
        {
        }

        public PropietarioDto(long id, string dni,  string matricula, int dias, int meses, int anyos)
        {
            this.id = id;
            this.dni = dni;
            this.fchCompra = new DateTime(anyos,meses,dias);
            this.matricula = matricula;
            this.esHistorico = esHistorico;
            this.dias = dias;
            this.meses = meses;
            this.anyos = anyos;
        }

        override
             public string ToString()
        {
            string fechaString = fchCompra.ToString("dd-MM-yyyy");
            string historicoString = esHistorico.ToString();

            string toString = String.Concat(id, ";", dni, ";", fechaString, ";", matricula, ";", historicoString);
            return toString;
        }



            public string ToString( string caracter)
        {

            string toString = String.Concat("Nuevo propietario: ", id, " ", caracter, " ", dni);
            return toString;
        }
    }
}
