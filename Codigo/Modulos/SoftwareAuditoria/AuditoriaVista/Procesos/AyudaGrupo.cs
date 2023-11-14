using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuditoriaControlador.Grupo3;


namespace AuditoriaVista.Procesos
{
    public partial class AyudaGrupo : Form
    {
        ControladorAzael cn = new ControladorAzael();
        string table;
        TextBox txtIdEncargado;
        public AyudaGrupo(string tabla, TextBox txtEncargado)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdEncargado = txtEncargado;
        }

        private void dtgAyudaGrupos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AyudaGrupo_Load(object sender, EventArgs e)
        {
            cn.llenartabla2(table, dtgAyudaGrupos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtgAyudaGrupos.CurrentCell != null)
            {
                txtIdEncargado.Text = dtgAyudaGrupos.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }
    }
}
