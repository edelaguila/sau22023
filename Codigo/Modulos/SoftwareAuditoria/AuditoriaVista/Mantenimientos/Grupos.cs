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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Form2
            AyudaGrupos grupos = new AyudaGrupos();

            // Mostrar Form2 utilizando Show (no bloquea Form1)
            grupos.Show();
        }
    }
}
