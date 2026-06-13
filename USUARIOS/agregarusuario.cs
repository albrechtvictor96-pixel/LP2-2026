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
            // 1. Capturar datos sacando espacios
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string username = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validamos que elijan un rol en el ComboBox de tu pantalla (image_cff8bb)
            if (cmbRol.SelectedItem == null || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios y seleccione un rol.", "Campos vacíos");
                return;
            }
            string rolSeleccionado = cmbRol.SelectedItem.ToString();

            // 2. Ruta inteligente en la carpeta USUARIOS
            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            List<Usuario> listaUsuarios = new List<Usuario>();

            // 3. Si el archivo ya existe, cargamos los usuarios viejos para no borrarlos
            if (File.Exists(rutaJson))
            {
                try
                {
                    string jsonViejo = File.ReadAllText(rutaJson);
                    if (!string.IsNullOrEmpty(jsonViejo))
                    {
                        listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonViejo) ?? new List<Usuario>();
                    }
                }
                //Si el JSON estaba vacío, corrupto o mal formateado, 
                // reiniciamos la lista vacía para que no tire el cartel de error en la pantalla
                catch (JsonException)
                {
                    listaUsuarios = new List<Usuario>();
                }
            }

            // 4. Creamos el objeto con el ROL incluido
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Username = username,
                Password = password,
                Rol = rolSeleccionado //  Guardamos el rol elegido del combo
            };

            listaUsuarios.Add(nuevoUsuario);

            // 5. Guardamos la lista unificada en el JSON
            try
            {
                string jsonActualizado = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaJson, jsonActualizado);

                MessageBox.Show("¡Usuario registrado con éxito!", "Éxito");

                // Limpiamos los campos
                txtNombre.Clear(); txtApellido.Clear(); txtUsuario.Clear(); txtPassword.Clear();
                cmbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error");
            }
        }

        private void botoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}