using System;
using System.Collections.Generic;
using System.Text;
namespace TP_LP2
{
     public class Pedidos 
    { 
            public string nombre { get; set; }
            public int cantidad { get; set; }
            public DateTime fecha { get; set; }
            public string descripcion { get; set; }
            public string facultad { get; set; }
            public string estado { get; set; } = "PENDIENTE";

    }
}

