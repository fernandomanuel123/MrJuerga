using System;
using System.ComponentModel.DataAnnotations;

namespace MrJuerga.Entity
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Genero { get; set; }       
        public string Dni { get; set; }
        public string Password { get; set; }
        public string NewPassword{get;set;}

    }
}