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

        string connectionString = "Dsn=Risko"; // Reemplaza con tu configuración ODBC

        public Recursos()
        {
            InitializeComponent();
        }

        private void LlenarComboBox()
        {
            // Asegurar de que cbxEstado esté vacío antes de agregar las opciones.
            cbxEstado.Items.Clear();

            // Agregar las opciones de estado al ComboBox.
            cbxEstado.Items.Add("Activa");
            cbxEstado.Items.Add("Inactiva");

            // Cadena de conexión ODBC
            string connectionString = "Dsn=Risko"; // Reemplaza con tu configuración ODBC

            // Llenar el ComboBox cbxEncargado
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                // Consulta para seleccionar los nombres de los usuarios
                string query = "SELECT nombre_usuarioAuditoria FROM tbl_usuariosAuditoria WHERE estado_usuarioAuditoria = 1";

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        // Asegúrate de que cbxEncargado esté vacío antes de agregar las opciones.
                        cbxEncargado.Items.Clear();

                        // Agrega los nombres de los usuarios al ComboBox
                        while (reader.Read())
                        {
                            cbxEncargado.Items.Add(reader["nombre_usuarioAuditoria"].ToString());
                        }
                    }
                }

                // Consulta para seleccionar los nombres de las unidades
                string query1 = "SELECT nombre_unidad FROM tbl_unidades WHERE estado_unidad = 1";

                using (OdbcCommand command = new OdbcCommand(query1, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        // Asegúrate de que cbxUnidad esté vacío antes de agregar las opciones.
                        cbxUnidad.Items.Clear();

                        // Agrega los nombres de las unidades al ComboBox
                        while (reader.Read())
                        {
                            cbxUnidad.Items.Add(reader["nombre_unidad"].ToString());
                        }
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "2103";
            TextBox[] Grupotextbox = { txt_idRecurso, txt_encargadoRecurso, txt_nombreRecurso, txt_cantidadRecurso, txt_unidadRecurso, txt_costoRecurso, txtEstadoRecurso };
            TextBox[] Idtextbox = { txt_idRecurso, txt_encargadoRecurso };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Risko");
        }

        private void Recursos_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstado.SelectedItem != null)
            {
                // Obtener el valor seleccionado en el ComboBox y asignarlo a txtEstado
                string estadoSeleccionado = cbxEstado.SelectedItem.ToString();
                if (estadoSeleccionado == "Activa")
                {
                    txtEstadoRecurso.Text = "1";
                }
                else if (estadoSeleccionado == "Inactiva")
                {
                    txtEstadoRecurso.Text = "0";
                }
                else
                {
                    // Si no se selecciona "Activa" ni "Inactiva", dejar txtEstado vacío
                    txtEstadoRecurso.Text = string.Empty;
                }
            }
        }

        private int ObtenerIdUsuarioAuditoria(string nombreUsuario)
        {
            int idUsuario = 0;

            // Realizar la consulta SQL para obtener el ID del usuario en función del nombre
            string connectionString = "DSN=Risko"; // Reemplaza con tu configuración ODBC

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT pk_id_usurioAuditoria FROM tbl_usuariosAuditoria WHERE nombre_usuarioAuditoria = ?";

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("nombreUsuario", nombreUsuario);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        idUsuario = Convert.ToInt32(result);
                    }
                }
            }

            return idUsuario;
        }

        private int ObtenerIdUnidad(string nombreUnidad)
        {
            int idUnidad = 0;

            // Realizar la consulta SQL para obtener el ID de la unidad en función del nombre
            string connectionString = "DSN=Risko"; // Reemplaza con tu configuración ODBC

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT pk_id_unidad FROM tbl_unidades WHERE nombre_unidad = ?";

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("nombreUnidad", nombreUnidad);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        idUnidad = Convert.ToInt32(result);
                    }
                }
            }

            return idUnidad;
        }

        private void cbxEncargado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el ComboBox no está vacío
            if (cbxEncargado.SelectedItem != null)
            {
                // Obtener el valor seleccionado en el ComboBox y asignarlo a txtMedida
                txt_encargadoRecurso.Text = ObtenerIdUsuarioAuditoria(cbxEncargado.Text).ToString();
            }
        }

        private void cbxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el ComboBox no está vacío
            if (cbxUnidad.SelectedItem != null)
            {
                // Obtener el valor seleccionado en el ComboBox y asignarlo a txtMedida
                txt_unidadRecurso.Text = ObtenerIdUnidad(cbxUnidad.Text).ToString();
            }
        }
    }
}
