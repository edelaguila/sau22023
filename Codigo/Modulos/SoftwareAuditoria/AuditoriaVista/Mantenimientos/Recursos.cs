using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;




namespace AuditoriaVista.Mantenimientos
{
    public partial class Recursos : Form
    {
        string table = "tbl_recursos";

        public OdbcConnection conexion()
        {

            OdbcConnection conn = new OdbcConnection("Dsn=Risko");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }



        public Recursos()
        {
            InitializeComponent();
            cargarencargado();
        }


        private void cargarencargado()
        {
            cbxEncargado.DataSource = null;
            cbxEncargado.Items.Clear();

            
            string sql = "SELECT pk_id_usurioAuditoria, nombre_usuarioAuditoria FROM tbl_usuariosauditoria ORDER BY nombre_usuarioAuditoria ASC ";


            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion());
                OdbcDataAdapter dt = new OdbcDataAdapter(cmd);
                DataTable table = new DataTable();
                dt.Fill(table);

                cbxEncargado.ValueMember = "pk_id_usurioAuditoria";
                cbxEncargado.DisplayMember = "nombre_usuarioAuditoria";
                cbxEncargado.DataSource = table;


            }
            catch(OdbcException ex)
            {
                MessageBox.Show("Error al cargar categorías " + ex.Message);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idencargado = int.Parse(cbxEncargado.SelectedValue.ToString());
            string id = idencargado.ToString();
            txt_encargadoRecurso.Text = id;

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_idRecurso, txt_encargadoRecurso, txt_nombreRecurso, txt_cantidadRecurso, txt_unidadRecurso, txt_costoRecurso, txt_estadoRecurso };
            TextBox[] Idtextbox = { txt_idRecurso, txt_encargadoRecurso };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Risko");
        }

        private void Recursos_Load(object sender, EventArgs e)
        {

        }
    }
}
