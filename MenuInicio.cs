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
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
            Empleados.cargarListaEmpleadosdeTxt();
        }

        private void MenuInicio_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VisualizarEmpleados formulario = new VisualizarEmpleados();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HorasMes formulario = new HorasMes();
            formulario.Show();
        }
    }
}
