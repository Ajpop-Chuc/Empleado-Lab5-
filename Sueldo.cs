using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado_L5_
{
    public partial class Sueldo : Form
    {
        public Sueldo()
        {
            InitializeComponent();

            foreach (var noEmpleado in Empleados.listaEmpleados)
            {
                cBoxNoEmpleados.Items.Add(noEmpleado.NoEmpleado);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldoaPagar = 0;
            Empleados empleado = Empleados.listaEmpleados.Find(x => x.NoEmpleado == Convert.ToInt16(cBoxNoEmpleados.Text));
            if (empleado == null)
            {
                MessageBox.Show("Error: No se ha encontrado al empleado");
            }
            else
            {
                sueldoaPagar = empleado.SueldoHora * empleado.HorasTrabajadas;
                MessageBox.Show("Empleado:"+empleado.Nombre+"\n"+"Suldo a pagar:"+sueldoaPagar);
            }
        }

        private void Sueldo_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
