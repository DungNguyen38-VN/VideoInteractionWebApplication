using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Diagnostics;
using VideoInteraction.DataAccess.Repository;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;
using VideoInteraction.Models.ViewModels;
using X.PagedList;
using X.PagedList.Extensions;

namespace VideoInteraction.Web.Controllers
{
    public class CameraVideoDownloadController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        public CameraVideoDownloadController(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }
        //public IActionResult Index(string searchTerm, int? page)
        //{
        //    int pageSize = 10;
        //    int pageNumber = page ?? 1;

        //    var downloads = _unitOfWork.CameraVideoDownload
        //        .GetAll(includeProperties: "Camera")
        //        .AsQueryable();

        //    if (!string.IsNullOrWhiteSpace(searchTerm))
        //    {
        //        searchTerm = searchTerm.ToLower();
        //        downloads = downloads.Where(x =>
        //            (!string.IsNullOrEmpty(x.Name) && x.Name.ToLower().Contains(searchTerm)) ||
        //            (!string.IsNullOrEmpty(x.Camera.Name) && x.Camera.Name.ToLower().Contains(searchTerm)));
        //    }

        //    var pagedList = downloads
        //        .OrderByDescending(d => d.Id)
        //        .ToPagedList(pageNumber, pageSize);

        //    ViewBag.SearchTerm = searchTerm;
        //    return View(pagedList);
        //}
        public IActionResult Index(string searchTerm, int? page)
        {
            int pageSize = 10;
            int pageNumber = page ?? 1;

            // Get base query
            var downloadsQuery = _unitOfWork.CameraVideoDownload
                .GetAll(includeProperties: "Camera")
                .AsQueryable();

            // Apply search filter if needed
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();
                downloadsQuery = downloadsQuery.Where(x =>
                    (!string.IsNullOrEmpty(x.Name) && x.Name.ToLower().Contains(searchTerm)) ||
                    (!string.IsNullOrEmpty(x.Camera.Name) && x.Camera.Name.ToLower().Contains(searchTerm)));
            }

            // Order and paginate
            var pagedDownloads = downloadsQuery
                .OrderByDescending(d => d.Id)
                .ToPagedList(pageNumber, pageSize);

            // Convert to ViewModel
            var viewModels = pagedDownloads.Select(d => new CameraVideoDownloadVM
            {
                CameraVideoDownload = d,
                DownloadStatus = DownloadStatus.GetStatusString(d.Flag) // Your method to determine status
            }).ToList();

            // Create a static paged list for the view models
            var pagedViewModels = new StaticPagedList<CameraVideoDownloadVM>(
                viewModels,
                pagedDownloads.GetMetaData()
            );

            ViewBag.SearchTerm = searchTerm;
            return View(pagedViewModels);
        }


        public IActionResult LinkageVideoDir(int id)
        {
            var video = _unitOfWork.CameraVideoDownload.Get(u => u.Id == id);
            if (video == null || string.IsNullOrEmpty(video.FileName))
            {
                TempData["error"] = "Video info not found!";
                return RedirectToAction("Index");
            }

            try
            {
                string basePath = _configuration["VideoRecordLoc"]; // e.g., "D:/record/REC/"
                string fileName = video.FileName;

                if (!fileName.EndsWith(".mp4", StringComparison.OrdinalIgnoreCase))
                {
                    fileName += ".mp4";
                }

                string fullPath = Path.Combine(basePath.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar), fileName);

                if (!System.IO.File.Exists(fullPath))
                {
                    TempData["error"] = "Video file not found!";
                    return RedirectToAction("Index");
                }

                var fileBytes = System.IO.File.ReadAllBytes(fullPath);
                var contentType = "video/mp4";
                var downloadName = Path.GetFileName(fullPath);

                return File(fileBytes, contentType, downloadName);
            }
            catch (Exception ex)
            {
                TempData["error"] = "Failed to prepare video download: " + ex.Message;
                return RedirectToAction("Index");
            }
        }


    }
}
