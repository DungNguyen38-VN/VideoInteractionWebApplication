using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.Models.HIK
{
    public class FloatWnd
    {
        [Key]
        public int Id { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Layer { get; set; }
        public int DevId { get; set; }
        public int SubwndNum { get; set; }
        public int DecoderId { get; set; }
        public int Wndpos { get; set; }
        public int WndId { get; set; }
        public string Uri { get; set; }
        public string AttachedUri { get; set; }
        public bool Enlarged { get; set; }
        public bool FullLarged { get; set; }
        public int OpenwndMode { get; set; }
        public int DlpRow { get; set; }
        public int DlpCol { get; set; }
        public bool IsJoint { get; set; }
        public int DeviceWallNo { get; set; }
        public string LedWndIndexcode { get; set; }
        public int LockStatus { get; set; }

        [ForeignKey("Dlp")]
        public int DlpId { get; set; }
        public Dlp Dlp { get; set; }

        public ICollection<Wnd> WndList { get; set; }
    }

}
