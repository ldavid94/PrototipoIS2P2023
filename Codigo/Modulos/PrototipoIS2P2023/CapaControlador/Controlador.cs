using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public int verificarusuario(string usuario, string passward)
        {
            sn.logindatos(usuario, passward);

            return 1;
        }

        public DataTable llenarTblF(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTblFacultades(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void guardarfacultad(string id, string nombre, string estado)
        {
            sn.registrarFacultad(id, nombre, estado);
        }

        public void borrar_facultad(string id_codigo)
        {
            sn.eliminarFacultad(id_codigo);
        }
    }
}
