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
    public partial class HorasMes : Form
    {
        public HorasMes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Empleados empleado = Empleados.listaEmpleados.Find(x => x.NoEmpleado == Convert.ToInt16(textBoxNoEmpleado.Text));
            if(empleado==null)
            {
                MessageBox.Show("Error: No se ha encontrado al empleado");
            }
            else
            {
                empleado.HorasTrabajadas = Convert.ToInt16(textBoxHorasTrabajadas.Text);
                empleado.Mes = textBoxMes.Text;
                Form1.GuardarenTxt2();
                MessageBox.Show("Datos agregados correctamente");

                textBoxHorasTrabajadas.Clear();
                textBoxMes.Clear();
                textBoxNoEmpleado.Clear();
            }
            
        }

        private void HorasMes_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
