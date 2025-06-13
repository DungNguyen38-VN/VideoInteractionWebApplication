using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.Models.DTO;
using VideoInteraction.Models.HIK;

namespace VideoInteraction.Models.ViewModels
{
    public class TvWallSceneVM
    {
        public List<TvWallSceneDto> TvWallScenes { get; set; }
        public List<Dlp> Dlps { get; set; }
        public int? SelectedDlpId { get; set; }
    }
}
