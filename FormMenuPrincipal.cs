using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP_LP2.COMPRAS
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnModuloPedidos_Click(object sender, EventArgs e)
        {
            RegistroCompras pantallaCompras = new RegistroCompras();
            pantallaCompras.ShowDialog();
        }

        private void btnModuloAprovacion_Click(object sender, EventArgs e)
        {
            FormAprobacion pantallaAprobacion = new FormAprobacion();
            pantallaAprobacion.ShowDialog();
        }
    }
}
