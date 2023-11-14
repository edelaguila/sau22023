using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AuditoriaVista
{
    public partial class MDIAuditoria : Form
    {
        public MDIAuditoria()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Usuarios usuarios = new Mantenimientos.Usuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Empresas empresas = new Mantenimientos.Empresas();
            empresas.MdiParent = this;
            empresas.Show();
        }

        private void estandaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Estandares estandares = new Mantenimientos.Estandares();
            estandares.MdiParent = this;
            estandares.Show();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Medidas medidas = new Mantenimientos.Medidas();
            medidas.MdiParent = this;
            medidas.Show();
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Unidades unidades = new Mantenimientos.Unidades();
            unidades.MdiParent = this;
            unidades.Show();
        }

        private void prioridadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Prioridades prioridades = new Mantenimientos.Prioridades();
            prioridades.MdiParent = this;
            prioridades.Show();
        }

        private void proyectosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Proyectos proyectos = new Mantenimientos.Proyectos();
            proyectos.MdiParent = this;
            proyectos.Show();
        }

        private void recurossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Recursos recursos = new Mantenimientos.Recursos();
            recursos.MdiParent = this;
            recursos.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimientos.Grupos grupos = new Mantenimientos.Grupos();
            grupos.MdiParent = this;
            grupos.Show();
        }

        private void asignaciónGruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.AsignacionGrupos asignacion = new Procesos.AsignacionGrupos();
            asignacion.MdiParent = this;
            asignacion.Show();
        }

        private void actividadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Procesos.Actividades actividades = new Procesos.Actividades();
            actividades.MdiParent = this;
            actividades.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.Informes informes = new Procesos.Informes();
            informes.MdiParent = this;
            informes.Show();
        }

        private void rubricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Procesos.Rubricas rubricas = new Procesos.Rubricas();
            rubricas.MdiParent = this;
            rubricas.Show();
        }
    }
}
