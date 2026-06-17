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
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Verificar el rol del usuario logueado y mostrar/ocultar botones según corresponda
            string rol = Usuario.RolUsuarioLogueado;
            if (rol == "Administrador")
            {
                btnModuloPedidos.Enabled = true;
                btnModuloAprobacion.Enabled = true;

            }
            else if (rol == "Directivo")
            {
                btnModuloPedidos.Enabled = false;
                btnModuloAprobacion.Enabled = true;
            }
            else if (rol == "Funcionario")
            {
                btnModuloPedidos.Enabled = true;
                btnModuloAprobacion.Enabled = false;
            }

        }
        private void btnModuloPedidos_Click(object sender, EventArgs e)
        {
            RegistroCompras pantallaCompras = new RegistroCompras();
            pantallaCompras.ShowDialog();
        }

        private void btnModuloAprobacion_Click(object sender, EventArgs e)
        {
            FormAprobacion pantallaAprobacion = new FormAprobacion();
            pantallaAprobacion.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormLogin pantallaLogin = new FormLogin();
            pantallaLogin.Show();
            this.Close();
        }
    }
}
