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
    public partial class Prioridades : Form
    {
        public Prioridades()
        {
            InitializeComponent();
        }

        private void Prioridades_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2006";
            TextBox[] Grupotextbox = { txt_id, txt_nombre, txt_descripcion, txt_estado};
            TextBox[] Idtextbox = { txt_id, txt_nombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Risko");
        }
    }
}
