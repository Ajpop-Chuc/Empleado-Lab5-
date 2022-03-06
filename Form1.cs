using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado_L5_
{
    public partial class Form1 : Form
    {
        
        int contadorEmpleados;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            Empleados noEmpleado = Empleados.listaEmpleados.Find(x => x.NoEmpleado == Convert.ToInt16(textBoxNoEmpleado.Text));
            if (noEmpleado != null)
            {
                MessageBox.Show("Error: El noEmpleado: "+noEmpleado.NoEmpleado+" ya esta en uso");
            }
            else
            {
                Empleados empleado = new Empleados();
                empleado.NoEmpleado =Convert.ToInt16(textBoxNoEmpleado.Text);
                empleado.Nombre = textBoxNombre.Text;
                empleado.SueldoHora = Convert.ToDouble(textBoxSuledoHora.Text);
                empleado.HorasTrabajadas = 0;
                empleado.Mes = null;
                Empleados.listaEmpleados.Add(empleado);
                GuardarenTxt1();
                GuardarenTxt2();
                limpiarPantalla();
                MessageBox.Show("Error: Empleado Nuevo Agregado");
            }

        }

        public static void GuardarenTxt1()
        {
            FileStream abrir = new FileStream("Empleados.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var empleado in Empleados.listaEmpleados)
            {
                escribir.WriteLine(empleado.NoEmpleado);
                escribir.WriteLine(empleado.Nombre);
                escribir.WriteLine(empleado.SueldoHora);
            }
            escribir.Close();
            abrir.Close();
        }
        public static void GuardarenTxt2()
        {
            FileStream abrir = new FileStream("Marzo.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter escribir = new StreamWriter(abrir);

            foreach (var empleado in Empleados.listaEmpleados)
            {
                escribir.WriteLine(empleado.NoEmpleado);
                escribir.WriteLine(empleado.HorasTrabajadas);
                escribir.WriteLine(empleado.Mes);
            }
            escribir.Close();
            abrir.Close();
        }

        private void limpiarPantalla()
        {
            textBoxNoEmpleado.Clear();
            textBoxNombre.Clear();
            textBoxSuledoHora.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
