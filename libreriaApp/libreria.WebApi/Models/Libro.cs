namespace libreria.WebApi.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }        
        public string Autor { get; set; } 
        public string AñoPublicacion { get; set; }
        public int UsuarioId { get; set; }
    }
}

