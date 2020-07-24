using System.ComponentModel.DataAnnotations;

namespace PrimeTime.Models
{
    public class SkillLevel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string Level { get; set; }
        [Required]
        [StringLength(128)]
        public string BeltColor { get; set; }
        [Required]
        [StringLength(4096)]
        public string Description { get; set; }
    }
}
