using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;
using VideoInteraction.Models.ViewModels;

namespace VideoInteraction.Web.Controllers
{
    public class CameraControlTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CameraControlTagController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index() 
        {
            List<CameraControlTag> objCameraControlTagList = _unitOfWork.CameraControlTag.GetAll(includeProperties:"Camera").ToList();
            //List<CameraControlTag> objCameraControlTagList = _unitOfWork.CameraControlTag.GetAll().ToList();
            return View(objCameraControlTagList);
        }

        public IActionResult Upsert(int? id)
        {
            CameraControlTagVM CameraControlTagVM = new()
            {
                CameraList = _unitOfWork.Camera.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                CameraControlTag = new CameraControlTag()
            };
            if (id == null || id == 0)
            {
                //create
                return View(CameraControlTagVM);
            }
            else
            {
                //update
                CameraControlTagVM.CameraControlTag = _unitOfWork.CameraControlTag.Get(u=>u.Id==id);
                return View(CameraControlTagVM);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(CameraControlTagVM CameraControlTagVM, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                if (CameraControlTagVM.CameraControlTag.Id == 0) {
                    _unitOfWork.CameraControlTag.Add(CameraControlTagVM.CameraControlTag);
                }
                else {
                    _unitOfWork.CameraControlTag.Update(CameraControlTagVM.CameraControlTag);
                }

                _unitOfWork.Save();
                
                TempData["success"] = "CameraControlTag created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                CameraControlTagVM.CameraList = _unitOfWork.Camera.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(CameraControlTagVM);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CameraControlTag> objCameraControlTagList = _unitOfWork.CameraControlTag.GetAll(includeProperties: "Camera").ToList();
            return Json(new { data = objCameraControlTagList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var CameraControlTagToBeDeleted = _unitOfWork.CameraControlTag.Get(u => u.Id == id);
            if (CameraControlTagToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            string CameraControlTagPath = @"images\CameraControlTags\CameraControlTag-" + id;
            string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, CameraControlTagPath);

            if (Directory.Exists(finalPath)) {
                string[] filePaths = Directory.GetFiles(finalPath);
                foreach (string filePath in filePaths) {
                    System.IO.File.Delete(filePath);
                }

                Directory.Delete(finalPath);
            }


            _unitOfWork.CameraControlTag.Remove(CameraControlTagToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
