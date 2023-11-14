using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuditoriaControlador.Grupo2;

namespace AuditoriaVista.Procesos
{
    public partial class AyudaInformeActividad : Form
    {
        ControladorJason cn = new ControladorJason();
        string table;
        TextBox txtIdActividad;
        public AyudaInformeActividad(string tabla, TextBox txtActividad)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdActividad = txtActividad;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtgAyudaActividad.CurrentCell != null)
            {
                txtIdActividad.Text = dtgAyudaActividad.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void AyudaInformeActividad_Load(object sender, EventArgs e)
        {
            cn.llenartablaAyudaInformeActividad(table, dtgAyudaActividad);
        }

        private void dtgAyudaActividad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
