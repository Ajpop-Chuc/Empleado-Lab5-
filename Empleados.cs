using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado_L5_
{
    internal class Empleados
    {
        int noEmpleado;
        string nombre;
        double sueldoHora;
        int horasTrabajadas;
        string mes;

        public static List<Empleados> listaEmpleados = new List<Empleados>();
        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double SueldoHora { get => sueldoHora; set => sueldoHora = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public string Mes { get => mes; set => mes = value; }

        public static void cargarListaEmpleadosdeTxt()
        {
            FileStream stream = new FileStream("Empleados.txt", FileMode.Open, FileAccess.Read);
            FileStream stream2 = new FileStream("Marzo.txt", FileMode.Open, FileAccess.Read);
            StreamReader leer = new StreamReader(stream);
            StreamReader leer2 = new StreamReader(stream2);
            while (leer.Peek() > -1)
            {
                Empleados DatosEmpleado = new Empleados();
                DatosEmpleado.NoEmpleado = Convert.ToInt16(leer.ReadLine());
                DatosEmpleado.Nombre = leer.ReadLine();
                DatosEmpleado.SueldoHora = Convert.ToDouble(leer.ReadLine());
                DatosEmpleado.NoEmpleado = Convert.ToInt16(leer2.ReadLine());
                DatosEmpleado.HorasTrabajadas = Convert.ToInt16(leer2.ReadLine());
                DatosEmpleado.Mes = leer2.ReadLine();
                listaEmpleados.Add(DatosEmpleado);
            }
            leer.Close();
            stream.Close();
            leer2.Close();
            stream2.Close();
        }
    }
}
