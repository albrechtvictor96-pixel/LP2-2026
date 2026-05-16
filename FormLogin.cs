using System;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
namespace TP_LP2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtusuario.Text.Trim();
            string passwordIngresada = txtpassword.Text.Trim();

            // 1. Validar campos vacíos de inmediato
            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MessageBox.Show("Por favor, ingrese un usuario y contraseña válidos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Definir la ruta del JSON
            string rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../USUARIOS/usuarios.json");

            // Si el archivo NO existe, avisamos y salimos. Así evitamos que el código se vaya a la derecha.
            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No se encontró el archivo de base de datos 'usuarios.json'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Si llegamos aquí, el archivo existe. Ejecutamos la lectura de forma limpia.
            try
            {
                string json = File.ReadAllText(rutaJson);
                List<TP_LP2.Usuario> usuarios = JsonSerializer.Deserialize<List<TP_LP2.Usuario>>(json);

                // Buscamos el usuario (con 'Password' que ya te funcionó)
                var usuarioEncontrado = usuarios.Find(u => u.Nombre.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase) && u.Password == passwordIngresada);

                if (usuarioEncontrado == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Si el usuario es correcto:
                MessageBox.Show($"¡Bienvenido, {usuarioEncontrado.Nombre}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Aquí puedes abrir tu pantalla principal (Home) cuando quieras:
                // Home pantallaHome = new Home();
                // pantallaHome.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}