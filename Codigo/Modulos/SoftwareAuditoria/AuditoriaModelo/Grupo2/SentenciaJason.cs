using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace AuditoriaModelo.Grupo2
{
    public class SentenciaJason
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "select * from " + tabla + " ; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }


        public OdbcDataAdapter llenartabla2(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenartablaAyudaInformeActividad(string tabla)
        {
            string sql = "select pk_id_actividad AS 'ID', nombre_actividad AS 'Nombre', estado_actividad AS 'Estado' from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenartablaAyudaInformeGrupo(string tabla)
        {
            string sql = "select pk_id_asignacion_grupo AS 'ID', nombre_grupo AS 'Nombre', estado_grupo AS 'Estado' from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public void insertar(string dato, string tipo, string tabla)
        {
            try
            {
                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Console.WriteLine("Operacion correcta ");
            }
            catch (Exception e)
            {

            }
        }

        public void eliminar(int clave, string campo, string tabla)
        {
            try
            {
                string sql = "delete from " + tabla + " where " + campo + "=" + clave + ";";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                Console.WriteLine("Operacion correcta ");
            }
            catch (Exception e)
            {

            }

        }
    }
}
