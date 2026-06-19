using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using TP_LP2.COMPRAS;

namespace TP_LP2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            string usuarioIngresado = txtusuario.Text.Trim();
            string passwordIngresada = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos vacíos");
                return;
            }

            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No hay usuarios registrados en el sistema.", "Error");
                return;
            }

            try
            {
                string json = File.ReadAllText(rutaJson);
                List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

                Usuario usuarioEncontrado = usuarios.FirstOrDefault(u =>
                    u.Username.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == passwordIngresada
                );

                if (usuarioEncontrado != null)
                {
                    // 🚀 ASIGNACIÓN DIRECTA: Guardamos el rol del JSON en nuestra variable común
                    Usuario.RolUsuarioLogueado = usuarioEncontrado.Rol;

                    MessageBox.Show($"¡Bienvenido, {usuarioEncontrado.Nombre}! Entrando como {Usuario.RolUsuarioLogueado}.", "Éxito");

                    // Abrimos el menú principal completamente vacío y normal, como a vos te gusta
                    FormMenuPrincipal menu = new FormMenuPrincipal();
                    menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error");
            }
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            TP_LP2.FormGestionUsuarios formGestion = new TP_LP2.FormGestionUsuarios();
            formGestion.Show();
            this.Hide();
        }

        private void btnMostrarOcultar_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {

                txtpassword.PasswordChar = '\0';

                btnMostrarOcultar.Text = ":)";

            }
            else
            {
                txtpassword.PasswordChar = '*';
                btnMostrarOcultar.Text = "👁";
            }
        }
    }
}