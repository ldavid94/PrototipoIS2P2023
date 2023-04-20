using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Text;
using CapaVista;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();
        public void logindatos(string usuario, string passward)
        {
            string tabla_usuarios = "usuarios";

            string sql = "select * from " + tabla_usuarios + " where Nombre_usuario = '" + usuario + "' and Contraseña = '" + passward + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("passward", passward);
                cmd.ExecuteNonQuery();
                OdbcDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    MessageBox.Show("Bienvenido, " + usuario + ".");
                    Mant_facultades ini = new Mant_facultades();
                    ini.Show();
                    Login frm = new Login();
                    frm.Close();

                }
                else
                {
                    MessageBox.Show("Error, Usuario o contraseña son incorrectas " + usuario + ".");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        public OdbcDataAdapter llenarTblFacultades(string tabla)
        {
            string sql = "select * from " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public void registrarFacultad(string id, string nombre, string estado)
        {
            string sql = "insert into facultades values ('" + id + "','" + nombre + "','" + estado +"');";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("El Almacen se guardo con éxito");
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        public void eliminarFacultad(string id_facultad)
        {
            try
            {
                string sql = "delete from facultades where codigo_facultad = " + id_facultad + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("La facultad se elimino con éxito");
               

            }
            catch (Exception ex)
            {
               MessageBox.Show("La facultad no se elimino" + ex);
                
            }
        }
    }
}

