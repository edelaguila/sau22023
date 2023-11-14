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
    public partial class Grupos : Form
    {
        string emp = "tbl_grupos";
        ControladorGeorge cn = new ControladorGeorge();
        public Grupos()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Form2
            AyudaGrupos grupos = new AyudaGrupos("tbl_usuariosauditoria", txtEncargado);

            // Mostrar Form2 utilizando Show (no bloquea Form1)
            grupos.Show();
        }
        public void actualizardatagriew()
        {
            //le pasamos el parametro de la tabla a consultar
            DataTable dt = cn.llenarTbl(emp);
            dtgGrupos.DataSource = dt;

        }
        public void limpiar()
        {
        
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtEncargado.Clear();
            cbEstado.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
            txtEstado.Clear();
            txtFechaCreacio.Clear();

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = {txtId, txtFechaCreacio,txtNombre,txtDescripcion, txtEncargado,txtEstado};
    
            cn.ingresar(Grupo, dtgGrupos);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro insertado con éxito!!");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txtId, txtFechaCreacio, txtNombre, txtDescripcion, txtEncargado, txtEstado };
            cn.delete(Grupo, dtgGrupos);
            cn.ingresar(Grupo, dtgGrupos);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro modificado con éxito!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txtId, txtFechaCreacio, txtNombre, txtDescripcion, txtEncargado, txtEstado };
            cn.delete(Grupo, dtgGrupos);
            actualizardatagriew();
            MessageBox.Show("Registro eliminado con éxito!!");
            limpiar();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice seleccionado en el ComboBox
            int selectedIndex = cbEstado.SelectedIndex;

            // Asignar el valor seleccionado del ComboBox al TextBox
            txtEstado.Text = selectedIndex.ToString();

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacio.Text = dtpFecha.Value.ToString("yyyy-MM-dd");
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            actualizardatagriew();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
