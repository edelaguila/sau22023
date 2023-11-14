using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
namespace AuditoriaModelo.Grupo3
{
    public class SentenciaAzael
    {
        Conexion con = new Conexion();

        // obtener datos de una tabla CAPA MODELO

        //Consulta la BD y dichos datos estarán en un data table
        //Consultamos la tabla que nos han pasado como parametro y lo guardamos en una variable dataTable y la retornamos(lo que obtenga de la consulta que estamos haciendo)
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
