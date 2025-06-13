using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VideoInteraction.Models.HIK
{
    public class Dlp
    {
        [Key]
        public int DlpId { get; set; }
        public string DlpName { get; set; }
        public string IndexCode { get; set; }
        public int Row { get; set; }
        public int Col { get; set; }
        public string BelongTvwallIndexcode { get; set; }
        public int DlpType { get; set; }
        public int DecoderId { get; set; }
        public int AttachedDeviceNum { get; set; }
        public int CurSceneId { get; set; }
        public string CurSceneName { get; set; }
        public bool LayoutModified { get; set; }
        public int Order { get; set; }
        public int VirtualSplitRow { get; set; }
        public int VirtualSplitCol { get; set; }
        public int VirtualSplitType { get; set; }
        public bool Expection { get; set; }

        [ForeignKey("TvWall")]
        public int TvWallId { get; set; }
        public TvWall TvWall { get; set; }

        public ICollection<Monitor> Monitors { get; set; }
        public ICollection<FloatWnd> FloatWnds { get; set; }
        public ICollection<Group> Groups { get; set; }
    }

}
