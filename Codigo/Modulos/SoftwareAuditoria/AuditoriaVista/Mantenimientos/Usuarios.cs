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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();

    
        }



        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1001";
            TextBox[] Grupotextbox = { txt_idUsuario, txt_nombreUsuario, txt_apellidoUsuario, txt_correoUsuario, txt_userUsuario,txt_passUsuario, txt_estado};
            TextBox[] Idtextbox = { txt_idUsuario, txt_nombreUsuario };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Risko");
        }
    }
}
