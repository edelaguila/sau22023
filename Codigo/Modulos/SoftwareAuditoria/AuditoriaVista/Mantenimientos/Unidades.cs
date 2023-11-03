//Realizado por Ester López
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
    public partial class Unidades : Form
    {
        public Unidades()
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

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                // Consulta para seleccionar los nombres de las medidas con estado igual a 1
                string query = "SELECT nombre_medida FROM tbl_medidas WHERE estado_medida = 1";

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    using (OdbcDataReader reader = command.ExecuteReader())
                    {
                        // Asegúrate de que cbxMedidas esté vacío antes de agregar las opciones.
                        cbxMedidas.Items.Clear();

                        // Agrega los nombres de las medidas al ComboBox
                        while (reader.Read())
                        {
                            cbxMedidas.Items.Add(reader["nombre_medida"].ToString());
                        }
                    }
                }
            }
        }

        private void Unidades_Load(object sender, EventArgs e)
        {
            LlenarComboBox();


        }

        private int ObtenerIdMedida(string nombreMedida)
        {
            // Consulta para obtener el ID de la medida basado en su nombre
            int idMedida = 0;

            string connectionString = "Dsn=Risko"; // Reemplaza con tu configuración ODBC

            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT pk_id_medida FROM tbl_medidas WHERE nombre_medida = ?";

                using (OdbcCommand command = new OdbcCommand(query, connection))
                {
                    command.Parameters.AddWithValue("nombreMedida", nombreMedida);

                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        idMedida = Convert.ToInt32(result);
                    }
                }
            }

            return idMedida;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void cbxMedidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica si el ComboBox no está vacío
            if (cbxMedidas.SelectedItem != null)
            {
                // Obtener el valor seleccionado en el ComboBox y asignarlo a txtMedida
                txtMedida.Text = ObtenerIdMedida(cbxMedidas.Text).ToString();
            }

        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstado.SelectedItem != null)
            {
                // Obtener el valor seleccionado en el ComboBox y asignarlo a txtEstado
                string estadoSeleccionado = cbxEstado.SelectedItem.ToString();
                if (estadoSeleccionado == "Activa")
                {
                    txtEstado.Text = "1";
                }
                else if (estadoSeleccionado == "Inactiva")
                {
                    txtEstado.Text = "0";
                }
                else
                {
                    // Si no se selecciona "Activa" ni "Inactiva", dejar txtEstado vacío
                    txtEstado.Text = string.Empty;
                }
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1000";
            TextBox[] Grupotextbox = { txt_idUnidad, txtMedida, txtNombreUnidad, txtDescripcionUnidad, txtEstado};
            TextBox[] Idtextbox = { txt_idUnidad, txtMedida };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Risko");
        }
    }
}
