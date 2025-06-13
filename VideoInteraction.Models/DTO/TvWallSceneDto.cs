using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models.DTO
{
    public class TvWallSceneDto
    {
        public int Id { get; set; }
        public int TvWallId { get; set; }
   
        public int SceneId { get; set; }
        public string SceneName { get; set; }
        public bool IsDefault { get; set; }
        public int SceneOrder { get; set; }
        public int BelongDlpId { get; set; }
        public bool IsDeviceScene { get; set; }
        public int GroupId { get; set; }
        public bool IsCurr { get; set; }
        public bool IsActive { get; set; }
        public string DlpName { get; set; } // thêm tên DLP
    }

}
