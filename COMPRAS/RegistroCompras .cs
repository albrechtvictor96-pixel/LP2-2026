using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace TP_LP2
{
    public partial class RegistroCompras : Form
    {
        public RegistroCompras()
        {
            InitializeComponent();
        }
        private Queue<Pedidos> solicitudes = new Queue<Pedidos>();
        private string rutaJson = Path.Combine(Application.StartupPath, "compras.json");

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Validacion de entradas
            if (string.IsNullOrWhiteSpace(txtFacultad.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            //validacion de cantidad
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero positivo).");
                return;
            }
            //Creacion de nuevo pedido
            Pedidos nuevoPedido = new Pedidos
            {
                facultad = txtFacultad.Text,
                producto = cantidad,
                descripcion = txtDescripcion.Text,
                data = dtpFecha.Value,
                cantidad = txtCantidad.Text
            };
            solicitudes.Enqueue(nuevoPedido);//Agrega el nuevo pedido a la cola
            GuardarEnJson();//Guarda la cola actualizada en el archivo JSON
            MessageBox.Show("Pedido registrado exitosamente.");
            LimpiarCampos();//Limpia los campos para el siguiente registro
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (solicitudes.Count == 0)
            {
                MessageBox.Show("No hay pedidos para editar.");
                return;
            }
            Pedidos primerPedido = solicitudes.Peek(); // Obtiene el primer pedido sin eliminarlo
            //cargar los datos del primer pedido en los campos de texto para su edición
            txtNombre.Text = primerPedido.descripcion; // Asumiendo que el nombre del producto se almacena en la descripción
            txtCantidad.Text = primerPedido.cantidad; // Asumiendo que la cantidad se almacena en el campo cantidad
            txtDescripcion.Text = primerPedido.descripcion; // Asumiendo que la descripción se almacena en el campo descripción
            txtFacultad.Text = primerPedido.facultad; // Asumiendo que la facultad se almacena en el campo facultad
            dtpFecha.Value = primerPedido.data; // Asumiendo que la fecha se almacena en el campo data
            MessageBox.Show("Edite los campos y haga clic en 'Registrar' para actualizar el pedido.");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (solicitudes.Count == 0)
            {
                MessageBox.Show("No hay pedidos para eliminar.");
                return;
            }
            Pedidos pedidoAtendido = solicitudes.Dequeue(); // Elimina el primer pedido de la cola
            GuardarEnJson();// Guarda la cola actualizada en el archivo JSON
            MessageBox.Show("Pedido atendido y eliminado de la lista.");
        }
        private void GuardarEnJson()
        {
            try
            {
                string json = System.Text.Json.JsonSerializer.Serialize(solicitudes);
                File.WriteAllText(rutaJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en JSON: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtFacultad.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            dtpFecha.Value = DateTime.Now;
        }
    }

}