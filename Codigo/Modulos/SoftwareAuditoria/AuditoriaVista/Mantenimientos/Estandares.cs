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
    public partial class Estandares : Form
    {
        public Estandares()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3101";
            TextBox[] Grupotextbox = { txt_idEstandar, txt_nombreEstandar, txt_normaEstandar, txt_estadoEstandar };
            TextBox[] Idtextbox = { txt_idEstandar, txt_nombreEstandar };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Risko");
        }
    }
}
