using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TareaCrud.Clases.Archivos;
using TareaCrud.Clases.Conexiones;

namespace TareaCrud
{
    public partial class FormularioWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivoExternoSQL()
        {
            string fuente = @"C:\Users\alumno\Desktop\crudDB.csv";
            ClsArchivos ar = new ClsArchivos();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int Numerolinea = 0;

            ClsConexionSQL cn = new ClsConexionSQL();

            foreach (string linea in ArregloNotas)
            {
                //obtener datos
                String[] datos = linea.Split(';');
                if (Numerolinea > 0)
                {
                    sentencia_sql = sentencia_sql + $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }
                Numerolinea++;
            }

            cn.EjecutaSQLDirecto(sentencia_sql);
        }

        private void cargarArchivoExternoMySql()
        {
            string fuente = @"C:\Users\alumno\Desktop\crudDB.csv";
            ClsArchivos ar = new ClsArchivos();
            //obtner todo el archivo, linea por linea dentro de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int Numerolinea = 0;

            ClsConexionMySQL cn = new ClsConexionMySQL();

            foreach (string linea in ArregloNotas)
            {
                //obtener datos
                String[] datos = linea.Split(';');
                if (Numerolinea > 0)
                {
                    sentencia_sql = sentencia_sql + $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n ";
                }
                Numerolinea++;
            }

            cn.EjecutaSQLDirecto(sentencia_sql);
        }

        protected void ButtonSQL_Click(object sender, EventArgs e)
        {
            cargarArchivoExternoSQL();
        }

        protected void ButtonMySql_Click(object sender, EventArgs e)
        {
            cargarArchivoExternoMySql();
        }
    }
}