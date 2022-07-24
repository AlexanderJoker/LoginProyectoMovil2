using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProyecto.Models
{
    public class ObjUsuario
    {
        public int id { get; set; }
        public String imagen { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String usuario { get; set; }
        public String genero { get; set; }
        public DateTime fecha { get; set; }
        public String correo { get; set; }
        public String contra { get; set; }
        public int telefono { get; set; }
        public String ciudad { get; set; }
    }    
}
