using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditoriaVista.Procesos
{
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_actividad = int.Parse(txt_actividad.Text);
            int id_proyecto = int.Parse(txt_proyecto.Text);
            int id_recurso =int.Parse(txt_recurso.Text); 
            int id_prioridad = int.Parse(cb_prioridad.Text);
            int id_grupo = int.Parse(txt_NoGrupo.Text);
            string nombre_actividad = txt_NomActividad.Text;
            DateTime fechaInicio_actividad = dTP_fechaInicio.Value;
            DateTime fechaFinalizacions_actividad = dTP_fechaFinalizar.Value;
            float totalTrabajado_actividad = float.Parse(txt_porcentaje.Text);
            int estado_actividad = int.Parse(cB_estadoActividad.Text);


        }
    }
}
