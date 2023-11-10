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
//Jonathan Xuyá 0901-18-11371
namespace AuditoriaVista.Procesos
{
    public partial class Informes : Form
    {
        string emp = "tbl_informes";
        ControladorJason cn = new ControladorJason();
        public Informes()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Form2
            AyudaInformeGrupo grupos = new AyudaInformeGrupo("tbl_grupos", txtGrupo);

            // Mostrar Form2 utilizando Show (no bloquea Form1)
            grupos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Ayudainformes
            AyudaInformeActividad informes = new AyudaInformeActividad("tbl_actividades", txtActividad);

            // Mostrar Ayudainformes utilizando Show (no bloquea informes)
            informes.Show();
        }

        public void actualizardatagriew()
        {
            //le pasamos el parametro de la tabla a consultar
            DataTable dt = cn.llenarTbl(emp);
            dtgInforme.DataSource = dt;

        }
        public void limpiar()
        {

            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtActividad.Clear();
            txtGrupo.Clear();
            txtFechaCreacion.Clear();
            txtFechaFin.Clear();
            txtEstado.Clear();
            cbEstado.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

        }

        private void Informes_Load(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txtId, txtNombre, txtDescripcion, txtActividad, txtGrupo, txtFechaCreacion, txtFechaFin, txtEstado };

            cn.ingresar(Grupo, dtgInforme);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro insertado con éxito!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txtId, txtNombre, txtDescripcion, txtActividad, txtGrupo, txtFechaCreacion, txtFechaFin, txtEstado };
            cn.delete(Grupo, dtgInforme);
            actualizardatagriew();
            MessageBox.Show("Registro eliminado con éxito!!");
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txtId, txtNombre, txtDescripcion, txtActividad, txtGrupo, txtFechaCreacion, txtFechaFin, txtEstado };
            cn.delete(Grupo, dtgInforme);
            cn.ingresar(Grupo, dtgInforme);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro modificado con éxito!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacion.Text = dtpFechaInicio.Value.ToString("yyyy-MM-dd");
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            txtFechaFin.Text = dtpFechaFin.Value.ToString("yyyy-MM-dd");
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice seleccionado en el ComboBox
            int selectedIndex = cbEstado.SelectedIndex;

            // Asignar el valor seleccionado del ComboBox al TextBox
            txtEstado.Text = selectedIndex.ToString();
        }

        private void dtgInforme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string rutaAyuda = "../../../../../../../Ayudas/Asignación Grupos/AsignacionGrupos.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "AGrupos.html");
        }
    }
}
