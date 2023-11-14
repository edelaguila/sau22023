using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace AuditoriaModelo.Grupo1
{
    class SentenciaVelvet
    {
        Conexion con = new Conexion();

        public void queryinsertar(string[] valores)
        {
            string sql = "INSERT INTO tbl_recursos (pk_id_recurso, fk_id_encargado, nombre_recurso," +
            " cantidad_recurso, fk_id_unidad, costo_recurso, estado_recurso) VALUES (" + valores+   " );";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch { 
            }



        }

    }
}
