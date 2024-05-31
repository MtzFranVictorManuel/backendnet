namespace backend.Models
{
    public class PeliculaDTO
    {
        public int? PeliculaId { get; set; }
        public required string Titulo { get; set; }
        public string Sinopsis { get; set; } = "Sin titulo";
        public string Anio { get; set; }
        public string Poster { get; set; } = "N/A";
        public int[]? Categorias { get; set; }
    }
}