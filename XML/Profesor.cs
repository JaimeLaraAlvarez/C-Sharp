using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace Herencia2.Clases
{
    [XmlType("Profesor")]
    [XmlInclude(typeof(Empleado))]
    public class Profesor : Empleado
    {
        private string escolaridad;

        [XmlAttribute("Escolaridad")]
        public string Escolaridad
        {
            get { return escolaridad; }
            set { escolaridad = value; }
        }

        public Profesor(string escolaridad, string nombre, int clave, string direccion, string telefono, string foto) : base (nombre, clave, direccion, telefono, foto)
        {
            Escolaridad = escolaridad;
        }

        public Profesor()
        {
        }

        public override string ToString()
        {
            return "Profesor de nombre " + Nombre + ", Clave: " + Clave + ", Direccion: " + Direccion + ", Telefono: " + Telefono;
        }

    }
}
