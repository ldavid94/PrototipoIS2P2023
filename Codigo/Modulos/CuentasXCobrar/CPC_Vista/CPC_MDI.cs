﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Vista
{
    public partial class CPC_MDI : Form
    {
        public CPC_MDI()
        {
            InitializeComponent();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_moneda mant_Moneda = new Mant_moneda();
            mant_Moneda.MdiParent = this;
            mant_Moneda.Show();
        }

        private void tipoDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_tipoPago mant_TipoPago = new Mant_tipoPago();
            mant_TipoPago.MdiParent = this;
            mant_TipoPago.Show();
        }
    }
}
