using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditoriaControlador.Grupo2;
using System.Windows.Forms;

namespace AuditoriaVista.Procesos
{
    public partial class AyudaInformeGrupo : Form
    {
        ControladorJason cn = new ControladorJason();
        string table;
        TextBox txtIdGrupo;
        public AyudaInformeGrupo(string tabla, TextBox txtGrupo)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdGrupo = txtGrupo;
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            if (dtgAyudaGrupo.CurrentCell != null)
            {
                txtIdGrupo.Text = dtgAyudaGrupo.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
        }

        private void AyudaInformeGrupo_Load(object sender, EventArgs e)
        {
            cn.llenartablaAyudaInformeGrupo(table, dtgAyudaGrupo);
        }

        private void dtgAyudaGrupo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
