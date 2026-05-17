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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

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
            this.Close();
        }
    }
}
