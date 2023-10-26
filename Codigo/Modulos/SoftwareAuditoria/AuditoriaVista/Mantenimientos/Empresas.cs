using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuditoriaVista.Mantenimientos
{
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        public string activo = "";
        public string inactivo = "";
        public string inter = "";

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2000";
            TextBox[] Grupotextbox = { txtId,txtNombre,txtDireccion,txtTelefono,txtCorreo,txtFecha,txtEstado};
            TextBox[] Idtextbox = { txtId, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dtgEmpresa;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dtgEmpresa, Grupotextbox, "Risko");
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            inter = Convert.ToString(cbEstado.SelectedItem);
            if (inter == "Activo")
            {
                activo = "1";
                txtEstado.Text = activo;
            }
            else
            {
                inactivo = "0";
                txtEstado.Text = inactivo;
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            // Obtén la fecha y hora del DateTimePicker como una cadena formateada y asignarla a variable

            txtFecha.Text = dtpFecha.Value.ToString("yyyy-MM-dd");

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
