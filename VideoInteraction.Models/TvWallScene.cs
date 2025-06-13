using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace VideoInteraction.Models
{
    using System.ComponentModel.DataAnnotations;

    public class TvWallScene
    {
        [Key]
        public int Id { get; set; } // Primary key (auto-increment by default)

        public int TvWallId { get; set; }

        public int SceneId { get; set; }

        [Required]
        [MaxLength(100)] 
        public string SceneName { get; set; }

        public bool IsDefault { get; set; }

        public int SceneOrder { get; set; }

        public int BelongDlpId { get; set; }

        public bool IsDeviceScene { get; set; }

        public int GroupId { get; set; }
        public bool IsCurr { get; set; }
        public bool IsActive { get; set; }
    }


}
