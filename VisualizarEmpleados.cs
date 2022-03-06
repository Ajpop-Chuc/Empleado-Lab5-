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
    public partial class VisualizarEmpleados : Form
    {
        public VisualizarEmpleados()
        {
            InitializeComponent();
            visualizarEmpleados();
        }

        private void btnVisualizarEmpleados_Click(object sender, EventArgs e)
        {
            Sueldo forrmulario = new Sueldo();
            forrmulario.Show();
        }
        private void visualizarEmpleados()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            dataGridView1.DataSource = Empleados.listaEmpleados;
            dataGridView1.Refresh();
        }

        private void VisualizarEmpleados_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
