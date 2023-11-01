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

namespace AuditoriaVista.Mantenimientos
{
    public partial class AyudaGrupos : Form
    {
        ControladorGeorge cn = new ControladorGeorge();
        string table;
        TextBox txtIdEncargado;
        public AyudaGrupos(string tabla, TextBox txtEncargado)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdEncargado = txtEncargado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dtgAyudaGrupos.CurrentCell != null)
            {
                txtIdEncargado.Text = dtgAyudaGrupos.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }

        }

        private void AyudaGrupos_Load(object sender, EventArgs e)
        {
            cn.llenartabla2(table, dtgAyudaGrupos);
        }
    }
}
