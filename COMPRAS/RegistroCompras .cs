using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
namespace TP_LP2
{
    public partial class RegistroCompras : Form
    {
        public RegistroCompras()
        {
            InitializeComponent();
            CargarDesdeJson();
 
        }
        
        private bool esNuevo = true;// Variable para controlar si estamos editando un pedido existente o registrando uno nuevo
        private string idPedidoEditando = ""; // Variable para almacenar el ID del pedido que se está editando (si es el caso)
        private Queue<Pedidos> solicitudes = new Queue<Pedidos>();
        private string rutaJson = Path.Combine(Application.StartupPath, "compras.json");

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // 1. Validacion de entradas 
            if (string.IsNullOrWhiteSpace(cmbFacultad.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // 2. Validacion de cantidad 
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida (número entero positivo).");
                return;
            }

            // // 3. Decidir si se crea uno nuevo o se edita el actual
            if (esNuevo)
            {
                // CAMINO A: PEDIDO NUEVO
                Pedidos nuevoPedido = new Pedidos
                {
                    facultad = cmbFacultad.Text,
                    nombre = txtNombre.Text,
                    descripcion = txtDescripcion.Text,
                    fecha = dtpFecha.Value,
                    cantidad = cantidad,
                    estado = "Pendiente"
                };
                // C# le asigna automáticamente el Guid.NewGuid() de Solicitud.cs

                solicitudes.Enqueue(nuevoPedido);
            }
            else
            {
                // --- CAMINO B: EDICIÓN DE UN PEDIDO (No agrega filas, modifica en la cola) ---
                // Convertimos temporalmente a lista para buscar y modificar el Guid guardado
                var listaTemporal = new List<Pedidos>(solicitudes);
                Pedidos pedidoExistente = listaTemporal.Find(p => p.id == idPedidoEditando);

                if (pedidoExistente != null)
                {
                    pedidoExistente.facultad = cmbFacultad.Text;
                    pedidoExistente.nombre = txtNombre.Text;
                    pedidoExistente.descripcion = txtDescripcion.Text;
                    pedidoExistente.fecha = dtpFecha.Value;
                    pedidoExistente.cantidad = cantidad;
                }

                // Reconstruimos la cola original con los datos modificados
                solicitudes = new Queue<Pedidos>(listaTemporal);
            }

            // 4. Guardar la cola actualizada en el archivo JSON
            try
            {
                var listaParaGuardar = new List<Pedidos>(solicitudes);
                var opciones = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
                string jsonTexto = System.Text.Json.JsonSerializer.Serialize(listaParaGuardar, opciones);

                string rutaDestino = Path.Combine(Application.StartupPath, "compras.json");
                File.WriteAllText(rutaDestino, jsonTexto);

                MessageBox.Show("Operación procesada con éxito y guardada en el archivo.", "Éxito");

                // 5. Limpiamos los cuadros y reseteamos variables de control
                cmbFacultad.SelectedIndex = -1;
                txtNombre.Clear();
                txtDescripcion.Clear();
                txtCantidad.Clear();

                esNuevo = true;
                idPedidoEditando = "";
                btnRegistrar.Text = "Registrar Pedido";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar en el JSON: " + ex.Message, "Error");
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (solicitudes.Count == 0)
            {
                MessageBox.Show("No hay pedidos para editar.");
                return;
            }
            Pedidos primerPedido = solicitudes.Peek(); // Obtiene el primer pedido sin eliminarlo
            esNuevo = false; // Indicamos que ahora estamos editando un pedido existente
            idPedidoEditando = primerPedido.id; // En este caso, siempre editaremos el primer pedido (índice 0 en la cola)
            //cargar los datos del primer pedido en los campos de texto para su edición
            txtNombre.Text = primerPedido.nombre; // Asumiendo que el nombre del producto se almacena en la descripción
            txtCantidad.Text = primerPedido.cantidad.ToString(); // Asumiendo que la cantidad se almacena en el campo cantidad
            txtDescripcion.Text = primerPedido.descripcion; // Asumiendo que la descripción se almacena en el campo descripción
            cmbFacultad.Text = primerPedido.facultad; // Asumiendo que la facultad se almacena en el campo facultad
            dtpFecha.Value = primerPedido.fecha; // Asumiendo que la fecha se almacena en el campo data
            MessageBox.Show("Edite los campos y haga clic en 'Registrar' para actualizar el pedido.");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos si hay pedidos cargados en la cola para poder eliminar
            if (solicitudes.Count == 0)
            {
                MessageBox.Show("No hay ningún pedido en pantalla para eliminar.", "Atención");
                return;
            }
            Pedidos pedidoActual = solicitudes.Peek(); // Obtenemos el pedido actual sin eliminarlo para mostrar su ID en la confirmación
            // Cartel de confirmación doble para evitar clicks accidentales en el botón de eliminar
            DialogResult confirmar = MessageBox.Show("¿Estás absolutamente seguro de que querés ELIMINAR el ultimo pedido? Esta acción no se puede deshacer.",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

            if (confirmar == DialogResult.No)
            {
                return; // Si el usuario tocó el botón por error y le da a "No", el programa no hace nada
            }

            // 3. Pasamos la cola a una lista temporal para poder buscar y remover por ID 
            var listaTemporal = new List<Pedidos>(solicitudes);

            // Buscamos el pedido en la lista que coincida con el Guid del pedido en pantalla
            Pedidos aEliminar = listaTemporal.Find(p => p.id == pedidoActual.id);

            if (aEliminar != null)
            {
                // 4. Lo removemos de la lista en memoria
                listaTemporal.Remove(aEliminar);

                // 5. Reconstruimos tu cola original con los elementos restantes
                solicitudes = new Queue<Pedidos>(listaTemporal);

                // 6. Guardamos la cola limpia de vuelta en el archivo compras.json
                try
                {
                    var opciones = new System.Text.Json.JsonSerializerOptions { WriteIndented = true };
                    string jsonTexto = System.Text.Json.JsonSerializer.Serialize(listaTemporal, opciones);

                    string rutaDestino = Path.Combine(Application.StartupPath, "compras.json");
                    File.WriteAllText(rutaDestino, jsonTexto);

                    MessageBox.Show("Pedido eliminado con éxito.", "Éxito");

                    // 7. Limpiamos por completo los TextBox para que la pantalla no quede con datos viejos
                    cmbFacultad.SelectedIndex = -1;
                    txtNombre.Clear();
                    txtDescripcion.Clear();
                    txtCantidad.Clear();

                    // 8. Opcional: Si tenés una función que vuelve a hacer Peek() para mostrar el siguiente pedido en cola, la llamás acá.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al intentar actualizar el archivo JSON: " + ex.Message, "Error");
                }
            }
        }
        private void GuardarEnJson()
        {
            try
            {
                var listaParaGuardar = new List<Pedidos>(solicitudes); // Convierte la cola a una lista para guardarla en JSON
                string json = System.Text.Json.JsonSerializer.Serialize(listaParaGuardar, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en JSON: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            cmbFacultad.SelectedIndex = -1;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            dtpFecha.Value = DateTime.Now;
        }
        private void CargarDesdeJson()
        {
            try
            {
                if (File.Exists(rutaJson))
                {
                    string json = File.ReadAllText(rutaJson);
                    var listaCargada = System.Text.Json.JsonSerializer.Deserialize<List<Pedidos>>(json);
                    if (listaCargada != null)
                    {
                        solicitudes = new Queue<Pedidos>(listaCargada); // Carga la lista en la cola
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar desde JSON: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra la ventana actual y vuelve a la pantalla anterior
        }
    }

}