using System;
using System.Collections.Generic;
using System.Text;
namespace TP_LP2
{
     public class Pedidos 
    { 
            public string nombre { get; set; }// Nombre del producto solicitado
        public int cantidad { get; set; }  // Cantidad de productos solicitados
        public DateTime fecha { get; set; }// Fecha en la que se realiza el pedido
        public string descripcion { get; set; }// Descripción del pedido
        public string facultad { get; set; }// Facultad a la que pertenece el pedido
        public string estado { get; set; } = "Pendiente";// Estado inicial del pedido
        public string id { get; set; } = Guid.NewGuid().ToString(); // Genera un ID único para cada pedido

    }
}

