using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Mant_facultades : Form
    {
        public Mant_facultades()
        {
            InitializeComponent();
            actualizardvg();
        }

        Controlador sn = new Controlador();
        String tabla = "facultades";

        
        public void actualizardvg()
        {
            DataTable dt = sn.llenarTblF(tabla);
            tbl_Facultades.DataSource = dt;
        }

        public void cleanTextbox()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtEstados.Text = "";
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sn.guardarfacultad(txtCodigo.Text, txtNombre.Text, txtEstados.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cleanTextbox();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sn.borrar_facultad(txtCodigo.Text);
            actualizardvg();
            cleanTextbox();
        }

        private void tbl_Facultades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tbl_Facultades.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = tbl_Facultades.CurrentRow.Cells[1].Value.ToString();
            txtEstados.Text = tbl_Facultades.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
