using System;
using System.Collections.Generic;
using System.Text;

namespace TP_LP2
{
    public class Usuario
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public string Cedula { get; set; } = string.Empty;
        public static string RolUsuarioLogueado { get; set; } = string.Empty; // Variable común para almacenar el rol del usuario logueado
    }
}
