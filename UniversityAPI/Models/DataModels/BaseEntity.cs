using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedOn { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
    }
}
