namespace Examen_2_Progra_3.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum EstadoTarea { Pendiente, EnProgreso, Completada }
    public enum Dificultad { Facil, Media, Dificil }
    public class Tarea
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(200, MinimumLength = 5)]
        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaLimite { get; set; }

        [Required]
        public EstadoTarea Estado { get; set; } = EstadoTarea.Pendiente;

        [Required]
        public Dificultad Dificultad { get; set; } = Dificultad.Media;

        // Tiempo estimado en horas
        [Range(0, 1000)]
        public double TiempoEstimadoHoras { get; set; }

        // FK a Meta
        public int MetaId { get; set; }
        public Meta Meta { get; set; } = default!;
    }
}
