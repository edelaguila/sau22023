using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using AuditoriaModelo.Grupo2;

namespace AuditoriaControlador.Grupo2
{
    public class ControladorJason
    {
        SentenciaJason sn = new SentenciaJason();
        public DataTable llenarTbl(string tabla)
        {
            //llenamos nuestro dataTable, entre consulta y el datagridview

            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            //la llenamos con los datos obtenidos
            dt.Fill(table);
            return table;
        }

        public void llenartabla2(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla2(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void llenartablaAyudaInformeGrupo(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartablaAyudaInformeGrupo(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        public void llenartablaAyudaInformeActividad(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartablaAyudaInformeActividad(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        public void ingresar(TextBox[] textbox, DataGridView tabla)//Crea cadenas de datos para la insercion
        {
            try
            {
                string dato = " ";
                string tipo = " ";
                for (int x = 0; x < textbox.Length; x++)
                {

                    if (x == textbox.Length - 1)
                    {
                        dato += "'" + textbox[x].Text + "'";
                        tipo += textbox[x].Tag.ToString();
                    }
                    else
                    {
                        dato += "'" + textbox[x].Text + "',";
                        tipo += textbox[x].Tag.ToString() + ",";
                    }

                }

                sn.insertar(dato, tipo, tabla.Tag.ToString());

            }

            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

        }

        public void delete(TextBox[] textbox, DataGridView tabla)
        {
            try
            {
                string campo = textbox[0].Tag.ToString();
                int clave = int.Parse(textbox[0].Text);
                sn.eliminar(clave, campo, tabla.Tag.ToString());



            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e);
            }

        }
    }
}
