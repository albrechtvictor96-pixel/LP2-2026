using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace TP_LP2
{
    public partial class FormGestionUsuarios : Form
    {
        public FormGestionUsuarios()
        {
            InitializeComponent();
            CargarUsuariosEnGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)// Verificar que hay una fila seleccionada
            {
                Usuario usuarioSeleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar al usuario {usuarioSeleccionado.Username}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    List<Usuario> listaActual = (List<Usuario>)dgvUsuarios.DataSource;//traer lista actual de la tabla
                    listaActual.Remove(usuarioSeleccionado);//sacar el usuario seleccionado de la lista
                    //guardar la lista actualizada en el JSON
                    string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
                    string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");
                    try
                    {
                        string jsonActualizado = JsonSerializer.Serialize(listaActual, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(rutaJson, jsonActualizado);
                        CargarUsuariosEnTabla();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
            }
        }

        private void FormGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuariosEnTabla();
        }
        private void CargarUsuariosEnTabla()
        {
            string carpetaUsuarios =
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");

            if (File.Exists(rutaJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaJson);
                    List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
                    dgvUsuarios.DataSource = usuarios;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                    { }

                }
            }
            else
                MessageBox.Show("No se encontró el archivo de usuarios.");
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();//Cerrar el formulario actual de gestión de usuarios
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            List<Usuario> listaActual = (List<Usuario>)dgvUsuarios.DataSource;
            if (listaActual != null)
            {
                string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
                string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");
                try
                {
                    string nuevoJson = JsonSerializer.Serialize(listaActual, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(rutaJson, nuevoJson);
                    MessageBox.Show("Usuarios modificados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar los usuarios: " + ex.Message);
                }
            }
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de registro para agregar un nuevo usuario
            AgregarUsuario pantallaRegistro = new AgregarUsuario();
            // Mostrar el formulario de registro
            pantallaRegistro.ShowDialog();
            // Recargar la tabla de usuarios después de cerrar el formulario de registro
            CargarUsuariosEnTabla();
            CargarUsuariosEnGrilla();
        }
        private void CargarUsuariosEnGrilla()
        {
            string carpetaUsuarios = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "USUARIOS");
            string rutaJson = Path.Combine(carpetaUsuarios, "usuarios.json");
            if (File.Exists(rutaJson))
            {
                try
                {
                    string json = File.ReadAllText(rutaJson);
                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(json);
                        dgvUsuarios.DataSource = usuarios;
                        dgvUsuarios.Update();
                        dgvUsuarios.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los usuarios: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de usuarios.");
            }
        }
    }
}
