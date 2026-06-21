using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace TP_LP2
{
    public partial class FormAprobacion : Form
    {
        private string rutaCola = Path.Combine(Application.StartupPath, "compras.json");
        private string rutaHistorial = Path.Combine(Application.StartupPath, "historial.json");

        private Queue<Pedidos> colaPedidos = new Queue<Pedidos>();
        private Stack<Pedidos> pilaHistorial = new Stack<Pedidos>();

        public FormAprobacion()
        {
            InitializeComponent();
            CargarDatos();//lee archivos de compras json
            ActualizarGridPendientes();//actualiza el datagridview con los pedidos pendientes en la cola
            ActualizarListBoxHistorial();//llena el listbox con el historial de pedidos procesado
        }

        private void CargarDatos()//carga los datos de la cola de pedidos y el historial desde los archivos JSON, si existen
        {
            // 1. Cargamos la cola de pedidos pendientes
            if (File.Exists(rutaCola))
            {
                try
                {
                    string json = File.ReadAllText(rutaCola);
                    var lista = JsonSerializer.Deserialize<List<Pedidos>>(json);
                    if (lista != null) colaPedidos = new Queue<Pedidos>(lista);
                }
                catch { }
            }

            // 2. Cargamos el historial delegando la función para evitar duplicados
            CargarHistorialDesdeJson();
        }
        private void ActualizarGridPendientes()
        {
            dgvPendientes.DataSource = null;
            if (colaPedidos != null && colaPedidos.Count > 0)
            {
                var listaPendientes = new List<Pedidos>(colaPedidos);
                dgvPendientes.DataSource = listaPendientes;
                if (dgvPendientes.Columns["nombre"] != null) dgvPendientes.Columns["nombre"].HeaderText = "Solicitante";
                if (dgvPendientes.Columns["cantidad"] != null) dgvPendientes.Columns["cantidad"].HeaderText = "Cantidad";
                if (dgvPendientes.Columns["descripcion"] != null) dgvPendientes.Columns["descripcion"].HeaderText = "Descripción";
                if (dgvPendientes.Columns["facultad"] != null) dgvPendientes.Columns["facultad"].HeaderText = "Facultad";
                if (dgvPendientes.Columns["fecha"] != null) dgvPendientes.Columns["fecha"].HeaderText = "Fecha";
                if (dgvPendientes.Columns["estado"] != null) dgvPendientes.Columns["estado"].HeaderText = "Estado";

            }
            else
            {
                dgvPendientes.DataSource = null;
            }
        }
        private void ProcesarPedido(string estado) //procesa el pedido actual, lo mueve a la pila de historial con el estado correspondiente y guarda los cambios en los archivos JSON
        {
            if (colaPedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos pendientes en la cola.", "Aviso");
                return;
            }

            Pedidos pedidoProcesado = colaPedidos.Dequeue();//sacamos el pedido de la cola
            pedidoProcesado.estado = estado;//le asignamos el nuevo estado(aprovado o rechazado)
            pilaHistorial.Push(pedidoProcesado);//lo metemos a la pila del historial

            GuardarTodo();

            MessageBox.Show($"Pedido de {pedidoProcesado.nombre} fue {estado}.", "Éxito");
            ActualizarGridPendientes();//Después de procesar el pedido, actualizamos el datagridview para reflejar los cambios en la cola de pedidos pendientes
            ActualizarListBoxHistorial();//y actualizamos el listbox para mostrar el nuevo pedido procesado en el historial
        }

        private void GuardarTodo()
        {
            try
            {
                var listaCola = new List<Pedidos>(colaPedidos);
                string jsonCola = JsonSerializer.Serialize(listaCola, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaCola, jsonCola);
                var listaHistorial = pilaHistorial.ToArray();
                Array.Reverse(listaHistorial); // Invertimos para guardar en orden correcto
                string jsonHistorial = JsonSerializer.Serialize(listaHistorial, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(rutaHistorial, jsonHistorial);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void ActualizarListBoxHistorial()//actualiza el listbox con el historial de pedidos procesados, mostrando la fecha, nombre, cantidad y descripción de cada pedido
        {
            lstHistorial.Items.Clear();
            foreach (var ped in pilaHistorial)
            {
                lstHistorial.Items.Add($"[{ped.estado} {ped.fecha:dd/MM/yyyy}] {ped.nombre} - {ped.cantidad} unidades - {ped.descripcion}");
            }
        }
        private void CargarHistorialDesdeJson() //carga el historial desde el archivo JSON, asegurando que se mantenga el orden correcto en la pila
        {
            string rutaHistorial = Path.Combine(Application.StartupPath, "historial.json");
            if (File.Exists(rutaHistorial))
            {
                try
                {
                    string json = File.ReadAllText(rutaHistorial);
                    var lista = System.Text.Json.JsonSerializer.Deserialize<List<Pedidos>>(json);
                    if (lista != null)
                    {
                        // Invertimos la lista para que al meterla a la pila mantenga el orden original LIFO
                        lista.Reverse();
                        pilaHistorial = new Stack<Pedidos>(lista);
                    }
                }
                catch { }
            }
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            ProcesarPedido("Aprobado");
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            ProcesarPedido("Rechazado");
        }

        private void btnDeshacerAprovacion_Click(object sender, EventArgs e)//Deshacer la ultima aprovacion, moviendo el pedido del historial de vuelta a la cola de pedidos pendientes, y actualizando los archivos JSON
        {
            if (pilaHistorial.Count == 0)
            {
                MessageBox.Show("No hay acciones para deshacer.", "Aviso");
                return;
            }

            Pedidos ultimoProcesado = pilaHistorial.Peek();//obtenemos el último pedido procesado sin sacarlo de la pila
            if (ultimoProcesado.estado != "Aprobado")
            {
                MessageBox.Show("Solo se pueden deshacer aprobaciones.", "Aviso");//si el último pedido procesado no fue aprobado, mostramos un mensaje de aviso y no hacemos nada
                return;
            }
            pilaHistorial.Pop();//sacamos el pedido de la pila del historial
            ultimoProcesado.estado = "Pendiente";//lo marcamos como pendiente para que vuelva a aparecer en la cola
            colaPedidos.Enqueue(ultimoProcesado);//lo metemos de nuevo a la cola de pedidos pendientes
            GuardarTodo();
            MessageBox.Show($"Se ha deshecho la última acción. Pedido de {ultimoProcesado.nombre} vuelve a estar pendiente.", "Éxito");
            ActualizarGridPendientes();
            ActualizarListBoxHistorial();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();//Cierra la ventana actual y vuelve a la pantalla anterior
        }
    }
}