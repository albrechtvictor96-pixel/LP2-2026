using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;
namespace TP_LP2
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void botonok_Click(object sender, EventArgs e)
        {
            string rutaArchivo = "Usuarios.json";
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                // 1. Leer existentes
                if (File.Exists(rutaArchivo))
                {
                    string contenido = File.ReadAllText(rutaArchivo);
                    if (!string.IsNullOrWhiteSpace(contenido))
                    {
                        listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(contenido);
                    }
                }
                // 2. Crear el objeto con TODAS las propiedades de tu clase
                Usuario nuevo = new Usuario()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Username = txtUsuario.Text,
                    Password = txtPassword.Text
                };
                // 3. Agregar y Guardar
                listaUsuarios.Add(nuevo);
                string jsonString = JsonSerializer.Serialize(listaUsuarios, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaArchivo, jsonString);

                MessageBox.Show("¡Usuario registrado con éxito!");

                // Limpiar los campos para el siguiente registro
                txtNombre.Clear();
                txtApellido.Clear();
                txtUsuario.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }
    }
}
