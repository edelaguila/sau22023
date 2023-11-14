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

namespace AuditoriaVista.Mantenimientos
{
    public partial class Proyectos : Form
    {
        string emp = "tbl_proyectos";

        ControladorJosue cn = new ControladorJosue();
        public Proyectos()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {

            DataTable dt = cn.llenarTbl(emp);
            dataGridView1.DataSource = dt;

        }
        public void limpiar()
        {

            txt_idproyecto.Clear();
            txt_idempresa.Clear();
            txt_idestandar.Clear();
            txt_nombreproyecto.Clear();
            txt_estadoproyecto.Clear();
            dtpFecha.Value = DateTime.Now;
            dateTimePicker1.Value = DateTime.Now;
            txtFechaCreacio.Clear();
            txtfechafinalizacion.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* AyudaEstandar grupos = new AyudaEstandar("tbl_estandares", txt_idestandar);
            grupos.Show();*/
        }

        private void Proyectos_Load(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacio.Text = dtpFecha.Value.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtfechafinalizacion.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* AyudaEmpresa grupos = new AyudaEmpresa("tbl_empresas", txt_idempresa);
            grupos.Show();*/
        }

        private void txt_idestandar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txt_idproyecto, txt_idempresa, txt_idestandar, txt_nombreproyecto, txtFechaCreacio, txtfechafinalizacion, txt_estadoproyecto };
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro insertado con éxito!!");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txt_idproyecto, txt_idempresa, txt_idestandar, txt_nombreproyecto, txtFechaCreacio, txtfechafinalizacion, txt_estadoproyecto };
            cn.delete(Grupo, dataGridView1);
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro modificado con éxito!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txt_idproyecto, txt_idempresa, txt_idestandar, txt_nombreproyecto, txtFechaCreacio, txtfechafinalizacion, txt_estadoproyecto };
            cn.delete(Grupo, dataGridView1);
            actualizardatagriew();
            MessageBox.Show("Registro eliminado con éxito!!");
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
