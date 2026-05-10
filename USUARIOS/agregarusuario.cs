using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using Json;
using Json.Net;
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
            string rutaArchivo = "Usuarios.Json";
            List<Usuario> listaUsuarios = new List<Usuario>();

            //1 verificamos que el archivo aun no exista en el archivo 
            if (File.Exists(rutaArchivo))
            {
                //2 si el archivo existe, lo leemos y lo deserializamos
                string contenidoArchivo = File.ReadAllText(rutaArchivo);
            }

        }
    }
}
