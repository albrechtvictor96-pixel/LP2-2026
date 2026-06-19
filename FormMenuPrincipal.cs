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
                btnModuloPedidos.Enabled = true;// Habilitar el botón de módulo de pedidos para el rol de Administrador
                btnModuloAprobacion.Enabled = true;// Habilitar el botón de módulo de aprobación para el rol de Administrador
                btnGestionarUsuarios.Enabled = true;// Habilitar el botón de gestionar usuarios para el rol de Administrador

            }
            else if (rol == "Directivo")
            {
                btnModuloPedidos.Enabled = false;// Deshabilitar el botón de módulo de pedidos para el rol de Directivo
                btnModuloAprobacion.Enabled = true;// Habilitar el botón de módulo de aprobación para el rol de Directivo
                btnGestionarUsuarios.Enabled = false;// Deshabilitar el botón de gestionar usuarios para el rol de Directivo
            }
            else if (rol == "Funcionario")
            {
                btnModuloPedidos.Enabled = true;// Habilitar el botón de módulo de pedidos para el rol de Funcionario
                btnModuloAprobacion.Enabled = false;// Deshabilitar el botón de módulo de aprobación para el rol de Funcionario
                btnGestionarUsuarios.Enabled = false;// Deshabilitar el botón de gestionar usuarios para el rol de Funcionario
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
        // Botón para gestionar usuarios, solo visible para el rol de Administrador
        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios pantallaGestionUsuarios = new FormGestionUsuarios();
            pantallaGestionUsuarios.ShowDialog(); 
        }
    }
}
