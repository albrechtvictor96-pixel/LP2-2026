using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TP_LP2
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Capturar datos de tus TextBox
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string username = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Crear el objeto
            Usuario nuevoUsuario = new Usuario()
            {
                Nombre = nombre,
                Apellido = apellido,
                Username = username,
                Password = password
            };

            // 3. Ruta Inteligente (Crea la carpeta sola donde se ejecuta el programa)
            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            if (!Directory.Exists(carpetaUsuarios))
            {
                Directory.CreateDirectory(carpetaUsuarios);
            }

            List<Usuario> listaUsuarios = new List<Usuario>();

            if (File.Exists(rutaJson))
            {
                try
                {
                    string jsonExistente = File.ReadAllText(rutaJson);
                    if (!string.IsNullOrEmpty(jsonExistente))
                    {
                        listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonExistente) ?? new List<Usuario>();
                    }
                }
                catch (Exception)
                {
                    listaUsuarios = new List<Usuario>();
                }
            }

            listaUsuarios.Add(nuevoUsuario);

            // 4. Grabar en el disco duro
            string jsonActualizado = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaJson, jsonActualizado);

            MessageBox.Show("¡Usuario registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 5. Ir al Login automáticamente
            FormLogin ventanaLogin = new FormLogin();
            ventanaLogin.Show();
            this.Hide();
        }

        private void botoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}