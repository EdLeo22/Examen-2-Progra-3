namespace Examen_2_Progra_3.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public enum CategoriaMeta { DesarrolloPersonal, Carrera, Salud, Finanzas, Relaciones, Otros }
    public enum Prioridad { Baja, Media, Alta }
    public enum EstadoMeta { NoIniciada, EnProgreso, Completada, Abandonada }
    public class Meta
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100, MinimumLength = 5)]
        public string Titulo { get; set; }

        public string? Descripcion { get; set; }

        [Required]
        public CategoriaMeta Categoria { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;

        public DateTime? FechaLimite { get; set; }

        [Required]
        public Prioridad Prioridad { get; set; } = Prioridad.Media;

        [Required]
        public EstadoMeta Estado { get; set; } = EstadoMeta.NoIniciada;

        // Relación 1-N
        public ICollection<Tarea>? Tareas { get; set; }
    }
}
