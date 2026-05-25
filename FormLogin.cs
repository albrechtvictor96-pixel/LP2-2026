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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtusuario.Text.Trim();
            string passwordIngresada = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Misma ruta inteligente
            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No hay usuarios registrados. Regístrate primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string json = File.ReadAllText(rutaJson);
                List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

                Usuario usuarioEncontrado = usuarios.FirstOrDefault(u =>
                    u.Username.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == passwordIngresada);

                if (usuarioEncontrado != null)
                {
                    MessageBox.Show($"¡Bienvenido, {usuarioEncontrado.Nombre}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btningresar_Click_1(object sender, EventArgs e)
        {
            string usuarioIngresado = txtusuario.Text.Trim();
            string passwordIngresada = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ruta inteligente
            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No hay usuarios registrados. Regístrate primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string json = File.ReadAllText(rutaJson);
                List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>();

                Usuario usuarioEncontrado = usuarios.FirstOrDefault(u =>
                    u.Username.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == passwordIngresada);

                if (usuarioEncontrado != null)
                {
                    MessageBox.Show($"¡Bienvenido, {usuarioEncontrado.Nombre}!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenuPrincipal menu = new FormMenuPrincipal();
                    this.Hide(); // Esconde la pantalla de Login para que no moleste
                    menu.ShowDialog(); // Muestra el Menú Principal
                    this.Close(); // Cierra definitivamente el Login al salir del menú
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            TP_LP2.FormGestionUsuarios formGestion = new TP_LP2.FormGestionUsuarios();
            formGestion.Show();
            this.Hide();
        }
    }
}