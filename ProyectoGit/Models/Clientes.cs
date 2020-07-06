using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoGit.Models
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public String Cedula{ get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
    }
}
