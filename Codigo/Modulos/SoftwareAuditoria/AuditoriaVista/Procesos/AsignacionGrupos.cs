//Hecho por Abner Sierra
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
//Jonathan Xuyá 0901-18-11371
namespace AuditoriaVista.Procesos
{
    public partial class AsignacionGrupos : Form
    {
        string emp = "tbl_asignacion_grupo";

        ControladorAzael cn = new ControladorAzael();
       
        public AsignacionGrupos()
        {
            InitializeComponent();
        }
        public void actualizardatagriew()
        {
            //le pasamos el parametro de la tabla a consultar
            DataTable dt = cn.llenarTbl(emp);
            dataGridView1.DataSource = dt;

        }
        public void limpiar()
        {

            txt_idAsignacion.Clear();
            txt_idGrupoasignacion.Clear();
            txt_UsuarioAsignacion.Clear();
            txt_estadoasignacion.Clear();
       

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txt_idAsignacion, txt_idGrupoasignacion, txt_UsuarioAsignacion, txt_estadoasignacion};
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro insertado con éxito!!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txt_idAsignacion, txt_idGrupoasignacion, txt_UsuarioAsignacion, txt_estadoasignacion };
            cn.delete(Grupo, dataGridView1);
            actualizardatagriew();
            MessageBox.Show("Registro eliminado con éxito!!");
            limpiar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = { txt_idAsignacion, txt_idGrupoasignacion, txt_UsuarioAsignacion, txt_estadoasignacion };
            cn.delete(Grupo, dataGridView1);
            cn.ingresar(Grupo, dataGridView1);
            actualizardatagriew();
            limpiar();
            MessageBox.Show("Registro modificado con éxito!!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AyudaGrupo grupos = new AyudaGrupo("tbl_grupos", txt_idGrupoasignacion);
            grupos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AyudaUsuario grupos = new AyudaUsuario("tbl_usuariosauditoria", txt_UsuarioAsignacion);
            grupos.Show();
        }

        private void AsignacionGrupos_Load(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void txt_idAsignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Se deben de colocar datos numericos...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_estadoasignacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_estadoasignacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 50 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se pueden colocar valores de 1 y 0", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        String idApp = "3001";
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string rutaAyuda = "../../../../../../../Ayudas/Asignación Grupos/AsignacionGrupos.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "AGrupos.html");
        }
    }
}
