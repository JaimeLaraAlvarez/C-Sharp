using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections;

namespace Herencia2.Clases
{
    static class Datos
    {
        static private List<Empleado> empleados = new List<Empleado>();

        public static int Size
        {
            get { return empleados.Count; }
        }

        public static void addEmpleado(Empleado nuevoEmpleado)
        {
            empleados.Add(nuevoEmpleado);
            generarXML();
        }

        public static Empleado getEmpleado(int indice)
        {
            return empleados[indice];
        }

        /*Almacena todos los empleados de List<Empleado> empleados 
         * en un archivo XML */
        public static void generarXML()
        {
            //El archivo en caso de existir se sobreescribe
            FileStream escritor = new FileStream("datos.xml", FileMode.Create);
            //Tipos de datos con los que vamos a trabajar
            Type[] tiposEmpleados = { typeof(Profesor), typeof(Chofer) };
            //Serializador
            XmlSerializer serializer = new XmlSerializer(empleados.GetType(), tiposEmpleados );
            //Almacenamos los empleados en el archivo
            serializer.Serialize(escritor, empleados);
            //Cerramos el archivo
            escritor.Close();
        }

        public static void cargarDatos()
        {
            //Si el archivo datos.xml existe
            if (File.Exists("datos.xml"))
            {
                //Abrimos el archivo
                FileStream lector = new FileStream("datos.xml", FileMode.Open);
                //Definimos los tipos de datos que se van a leer
                Type[] tiposEmpleados = { typeof(Profesor), typeof(Chofer) };
                //Definimos el serializador
                XmlSerializer serializer = new XmlSerializer(empleados.GetType(), tiposEmpleados );
                //pasamos a la lista de empleados los elementos almacenados en el archivo
                empleados = (List<Empleado>)serializer.Deserialize(lector);
                //Cerramos el archivo
                lector.Close();
            }
        }
    }
}