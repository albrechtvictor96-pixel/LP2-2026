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
            MostrarSiguienteEnCola();//muestra el siguiente pedido en la cola
            ActualizarListBoxHistorial();//llena el listbox con el historial de pedidos procesados
            CargarHistorialDesdeJson();//carga el historial desde el archivo JSON
        }

        private void CargarDatos()//carga los datos de la cola de pedidos y el historial desde los archivos JSON, si existen
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

        private void MostrarSiguienteEnCola()//muestra el siguiente pedido en la cola en los campos de texto correspondientes, o los limpia si no hay pedidos pendientes
        {
            if (colaPedidos.Count > 0)
            {
                Pedidos siguiente = colaPedidos.Peek();
                txtAprobNombre.Text = siguiente.nombre;
                txtAprobDescripcion.Text = siguiente.descripcion;
                txtAprobCantidad.Text = siguiente.cantidad.ToString();
            }
            else
            {
                txtAprobNombre.Clear();
                txtAprobDescripcion.Clear();
                txtAprobCantidad.Clear();
            }
        }

        private void BtnAprobar_Click(object sender, EventArgs e)//procesa el pedido actual con estado "APROBADO"
        {
            ProcesarPedido("APROBADO");
        }

        private void BtnRechazar_Click(object sender, EventArgs e)//procesa el pedido actual con estado "RECHAZADO"
        {
            ProcesarPedido("RECHAZADO");
        }

        private void ProcesarPedido(string estado) //procesa el pedido actual, lo mueve a la pila de historial con el estado correspondiente y guarda los cambios en los archivos JSON
        {
            if (colaPedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos pendientes en la cola.", "Aviso");
                return;
            }

            Pedidos pedidoProcesado = colaPedidos.Dequeue();//sacamos el pedido de la cola
            pedidoProcesado.descripcion = estado;//le asignamos el nuevo estado(aprovado o rechazado)
            pilaHistorial.Push(pedidoProcesado);//lo metemos a la pila del historial

            GuardarTodo();
           

            MessageBox.Show($"Pedido de {pedidoProcesado.nombre} fue {estado}.", "Éxito");
            MostrarSiguienteEnCola();
            ActualizarListBoxHistorial();
        }

        private void GuardarTodo()
        {
            try
            {
               var listaCola = new List <Pedidos>(colaPedidos);
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
    }
}