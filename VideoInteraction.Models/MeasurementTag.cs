using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace VideoInteraction.Models
{
    public class MeasurementTag
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Measurement Tag Name")]
        public string MeasureTagName { get; set; }
        public string? TagDescription { get; set; }
        public DateTime CreatedTs { get; set; } = DateTime.Now;
        public DateTime UpdatedTs { get; set; }= DateTime.Now;
        public int CameraId { get; set; }
        [ForeignKey("CameraId")]
        [ValidateNever]
        public Camera  Camera { get; set; }
        public int MeasurementUnitId { get; set; }
        [ForeignKey("MeasurementUnitId")]
        [ValidateNever]
        public MeasurementUnit   MeasurementUnit { get; set; } 
        public int MeasurementPrefixId { get; set; }
        [ForeignKey("MeasurementPrefixId")]
        [ValidateNever]
        public MeasurementPrefix  MeasurementPrefix { get; set; }
    }
}
