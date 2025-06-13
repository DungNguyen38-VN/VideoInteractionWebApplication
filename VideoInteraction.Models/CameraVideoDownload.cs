using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace VideoInteraction.Models
{
    public class CameraVideoDownload
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Camera Code")]
        public string Name { get; set; }
        [Required]
        public DateTime StartTime { get; set; } 
        [Required]
        public DateTime EndTime { get; set; }
        public int Flag { get; set; }

        ///0-未开始下载， 1-下载中，2- 结束下载
        public int? Type { get; set; }

        ///0-正常下载， 1-报警下载
        public string FileName { get; set; }
        public DateTime CreatedTs { get; set; } = DateTime.Now;
        public int CameraId { get; set; }
        [ForeignKey("CameraId")]
        [ValidateNever]
        public Camera Camera { get; set; }
    }
}
