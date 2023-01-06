using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(80)]
        public string Name { get; set; } = string.Empty;

        [Required, StringLength(100)]
        public string ShortDescription { get; set; } = string.Empty;

        [StringLength(300)]
        public string? LongDescription { get; set; }

        [Required, StringLength(100)]
        public string ObjectivePublic { get; set; } = string.Empty;

        [Required, StringLength(300)]
        public string Objectives { get; set; } = string.Empty;

        [Required, StringLength(400)]
        public string Requirements { get; set; } = string.Empty;

        [Required, StringLength(12)]
        public List<Niveles>? Levels { get; set; }

    }

    public enum Niveles
    {
        [Description("Básico")]
        Basico,

        [Description("Intermedio")]
        Intermedio,

        [Description("Avanzado")]
        Avanzado
    }
}
