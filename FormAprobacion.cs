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
            CargarDatos();
            MostrarSiguienteEnCola();
            ActualizarListBoxHistorial();
        }

        private void CargarDatos()
        {
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

            if (File.Exists(rutaHistorial))
            {
                try
                {
                    string json = File.ReadAllText(rutaHistorial);
                    var lista = JsonSerializer.Deserialize<List<Pedidos>>(json);
                    if (lista != null)
                    {
                        // Cargamos en la pila respetando el orden
                        pilaHistorial = new Stack<Pedidos>();
                        foreach (var item in lista)
                        {
                            pilaHistorial.Push(item);
                        }
                    }
                }
                catch { }
            }
        }

        private void MostrarSiguienteEnCola()
        {
            if (colaPedidos.Count > 0)
            {
                Pedidos siguiente = colaPedidos.Peek();
                txtAprobNombre.Text = siguiente.Nombre;
                txtAprobDescripcion.Text = siguiente.Descripcion;
                txtAprobCantidad.Text = siguiente.Cantidad.ToString();
            }
            else
            {
                txtAprobNombre.Clear();
                txtAprobDescripcion.Clear();
                txtAprobCantidad.Clear();
            }
        }

        private void BtnAprobar_Click(object sender, EventArgs e)
        {
            ProcesarPedido("APROBADO");
        }

        private void BtnRechazar_Click(object sender, EventArgs e)
        {
            ProcesarPedido("RECHAZADO");
        }

        private void ProcesarPedido(string estado)
        {
            if (colaPedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos pendientes en la cola.", "Aviso");
                return;
            }

            Pedidos pedidoProcesado = colaPedidos.Dequeue();
            pedidoProcesado.Descripcion = $"[{estado}] " + pedidoProcesado.Descripcion;
            pilaHistorial.Push(pedidoProcesado);

            GuardarTodo();

            MessageBox.Show($"Pedido de {pedidoProcesado.Nombre} fue {estado}.", "Éxito");
            MostrarSiguienteEnCola();
            ActualizarListBoxHistorial();
        }

        private void GuardarTodo()
        {
            try
            {
                // Pasamos la cola y la pila a listas para poder serializar sin drama
                var listaCola = new List<Pedidos>(colaPedidos);
                var listaPila = new List<Pedidos>(pilaHistorial);

                File.WriteAllText(rutaCola, JsonSerializer.Serialize(listaCola, new JsonSerializerOptions { WriteIndented = true }));
                File.WriteAllText(rutaHistorial, JsonSerializer.Serialize(listaPila, new JsonSerializerOptions { WriteIndented = true }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void ActualizarListBoxHistorial()
        {
            lstHistorial.Items.Clear();
            foreach (var ped in pilaHistorial)
            {
                lstHistorial.Items.Add($"{ped.Fecha.ToShortDateString()} - {ped.Nombre} - Cant: {ped.Cantidad} ({ped.Descripcion})");
            }
        }
    }
}