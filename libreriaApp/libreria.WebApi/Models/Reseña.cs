namespace libreria.WebApi.Models
{
    public class Reseña
    {
        public int Id { get; set; }
        public int Puntuacion { get; set; }    
        public string  Texto { get; set; }
        public int LibroId { get; set; }

    }
}
