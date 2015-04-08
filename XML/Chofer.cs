using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;

namespace Herencia2.Clases
{
    [XmlType("Chofer")]
    [XmlInclude(typeof(Empleado))]
    public class Chofer : Empleado
    {
        private char _licencia;

        [XmlAttribute("Licencia")]
        public char Licencia
        {
            get { return _licencia; }
            set { _licencia = value; }
        }
        

        public Chofer (char licencia, string nombre, int clave, string direccion, string telefono, string foto) : base (nombre, clave, direccion, telefono, foto)
        {
            Licencia = licencia;
        }

        public Chofer()
        {
        }

        public override string ToString()
        {
            return "Chofer tipo " + Licencia;
        }
    }
}