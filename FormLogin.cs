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

        private void btnIngresar_Click_1(object sender, EventArgs e)//evento que se ejecuta al hacer click en el boton ingresar
        {

            string usuarioIngresado = txtusuario.Text.Trim();
            string passwordIngresada = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(passwordIngresada))
            {
                MessageBox.Show("Por favor, ingrese su usuario y contraseña.", "Campos vacíos");
                return;
            }

            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");// Ruta de la carpeta donde se encuentra el archivo JSON
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");// Ruta completa del archivo JSON

            if (!File.Exists(rutaJson))
            {
                MessageBox.Show("No hay usuarios registrados en el sistema.", "Error");
                return;
            }

            try
            {
                string json = File.ReadAllText(rutaJson); // Leemos el contenido del archivo JSON
                List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json) ?? new List<Usuario>(); // Deserializamos el JSON a una lista de usuarios
                // Buscamos el usuario ingresado en la lista de usuarios
                Usuario usuarioEncontrado = usuarios.FirstOrDefault(u =>
                    u.Username.Equals(usuarioIngresado, StringComparison.OrdinalIgnoreCase) &&
                    u.Password == passwordIngresada
                );

                if (usuarioEncontrado != null)
                {
                    //Guardamos el rol del JSON en nuestra variable común
                    Usuario.RolUsuarioLogueado = usuarioEncontrado.Rol;

                    MessageBox.Show($"¡Bienvenido, {usuarioEncontrado.Nombre} Entrando como {Usuario.RolUsuarioLogueado}.", "Éxito");

                    // Abrimos el menú principal completamente vacío y normal
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

        private void btnMostrarOcultar_Click(object sender, EventArgs e) //boton para mostrar y ocultar contraseña
        {
            if (txtpassword.PasswordChar == '*')//si el passwordchar es *, entonces lo cambiamos a \0 para mostrar la contraseña
            {

                txtpassword.PasswordChar = '\0';

                btnMostrarOcultar.Text = ":)";

            }
            else //si el passwordchar es \0, entonces lo cambiamos a * para ocultar la contraseña
            {
                txtpassword.PasswordChar = '*';
                btnMostrarOcultar.Text = "👁";
            }
        }
        private void FormLogin_Load(object sender, EventArgs e) //evento que se ejecuta al cargar el formulario
        {
            // Establecer el PasswordChar al cargar el formulario
            txtpassword.PasswordChar = '*';

        }
    }
}