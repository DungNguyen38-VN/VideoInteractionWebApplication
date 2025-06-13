using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.Models;

namespace VideoInteraction.Models.ViewModels
{
    public class CameraVideoDownloadVM
    {
        public CameraVideoDownload CameraVideoDownload { get; set; }

        // Correct usage - calling the static method on the DownloadStatus class
        [ValidateNever]
        public string DownloadStatus { get; set; }
    }
}
