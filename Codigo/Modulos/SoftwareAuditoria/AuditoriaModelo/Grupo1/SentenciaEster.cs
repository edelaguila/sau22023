using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace AuditoriaModelo.Grupo1
{
    public class SentenciaEster
    {
        Conexion con = new Conexion();

        public List<string> ObtenerNombresMedidas(string connectionString)
        {
            List<string> nombresMedidas = new List<string>();

            string query = "SELECT nombre_medida FROM tbl_medidas";

            using (OdbcCommand command = new OdbcCommand(query, con.conexion()))
            {
                using (OdbcDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nombresMedidas.Add(reader["nombre_medida"].ToString());
                    }
                }
            }

            return nombresMedidas;
        }
    }
}
