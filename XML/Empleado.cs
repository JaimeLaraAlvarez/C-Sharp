using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;


namespace Herencia2.Clases
{
    [XmlRoot("Empleado")]
    [XmlInclude(typeof(Empleado))]
    public class Empleado
    {
        private string nombre;
        private int clave;
        private string direccion;
        private string telefono;
        private string foto;

        [XmlAttribute("Nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [XmlAttribute("Clave")]
        public int Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        [XmlAttribute("Direccion")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [XmlAttribute("Telefono")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [XmlAttribute("Foto")]
        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        //Constructor
        public Empleado(string nombre, int clave, string direccion, string telefono, string foto)
        {
            Nombre = nombre;
            Clave = clave;
            Direccion = direccion;
            Telefono = telefono;
            Foto = foto;
        }

        public Empleado()
        { 
        }
    }
}