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

        private void btnAgregar_Click(object sender, EventArgs e)//Boton de agregar usuario
        {
            // Capturar datos sacando espacios
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string username = txtUsuario.Text.Trim();
            string password = txtPassword.Text.Trim();
            string cedula = txtCedula.Text.Trim();
            // Validamos que elijan un rol en el ComboBox de tu pantalla 
            if (cmbRol.SelectedItem == null || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(cedula))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios y seleccione un rol.", "Campos vacíos");
                return;
            }
            string rolSeleccionado = cmbRol.SelectedItem.ToString();// Guardamos el rol elegido del combo

            //  Ruta inteligente en la carpeta USUARIOS
            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            List<Usuario> listaUsuarios = new List<Usuario>();

            // Si el archivo ya existe, cargamos los usuarios viejos para no borrarlos
            if (File.Exists(rutaJson))
            {
                try
                {
                    string jsonViejo = File.ReadAllText(rutaJson); // Leemos el contenido del archivo JSON existente
                    if (!string.IsNullOrEmpty(jsonViejo)) // Verificamos que el contenido no esté vacío
                    {
                        // Deserializamos el JSON existente a la lista de usuarios
                        listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonViejo) ?? new List<Usuario>(); 
                    }
                }
                //Si el JSON estaba vacío, corrupto o mal formateado, 
                catch (JsonException)
                {
                    listaUsuarios = new List<Usuario>(); // Reiniciamos la lista si hay un error de deserialización
                }
            }

            // Creamos un nuevo objeto Usuario con los datos capturados
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                Apellido = apellido,
                Username = username,
                Password = password,
                Rol = rolSeleccionado,
                Cedula = cedula
            };

            listaUsuarios.Add(nuevoUsuario); // Agregamos el nuevo usuario a la lista

            // Guardamos la lista unificada en el JSON
            try
            {
                string jsonActualizado = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaJson, jsonActualizado);

                MessageBox.Show("¡Usuario registrado con éxito!", "Éxito");

                // Limpiamos los campos
                txtNombre.Clear(); txtApellido.Clear(); txtUsuario.Clear(); txtPassword.Clear(); txtCedula.Clear();
                cmbRol.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error");
            }
        }

        private void botoncancel_Click(object sender, EventArgs e)
        {
            //borramos los campos y cerramos la ventana
            this.Close();
        }
    }
}