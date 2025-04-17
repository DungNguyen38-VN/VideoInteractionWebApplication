using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace VideoInteraction.Models
{
    public class ControlWindowTag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Window Tag Name")]
        public string TagName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTs { get; set; } = DateTime.Now;
        public DateTime UpdatedTs { get; set; }= DateTime.Now;
        public int WindowId { get; set; }
        [ForeignKey("WindowId")]
        [ValidateNever]
        public Window Window { get; set; }
    }
}
