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
    public class MeasurementTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public MeasurementTagController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index() 
        {
            List<MeasurementTag> objMeasurementTagList = _unitOfWork.MeasurementTag.GetAll(includeProperties: "Camera,MeasurementUnit,MeasurementPrefix").ToList();
            //List<MeasurementTag> objMeasurementTagList = _unitOfWork.MeasurementTag.GetAll().ToList();
            return View(objMeasurementTagList);
        }

        public IActionResult Upsert(int? id)
        {
            MeasurementTagVM MeasurementTagVM = new()
            {
                CameraList = _unitOfWork.Camera.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                MeasurementUnitList = _unitOfWork.MeasurementUnit.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }), 
                MeasurementPrefixList = _unitOfWork.MeasurementPrefix.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                MeasurementTag = new MeasurementTag()
            };
            if (id == null || id == 0)
            {
                //create
                return View(MeasurementTagVM);
            }
            else
            {
                //update
                MeasurementTagVM.MeasurementTag = _unitOfWork.MeasurementTag.Get(u=>u.Id==id);
                return View(MeasurementTagVM);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(MeasurementTagVM MeasurementTagVM, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                if (MeasurementTagVM.MeasurementTag.Id == 0) {
                    _unitOfWork.MeasurementTag.Add(MeasurementTagVM.MeasurementTag);
                }
                else {
                    _unitOfWork.MeasurementTag.Update(MeasurementTagVM.MeasurementTag);
                }

                _unitOfWork.Save();
                
                TempData["success"] = "MeasurementTag created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                MeasurementTagVM.CameraList = _unitOfWork.Camera.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }); 
                MeasurementTagVM.MeasurementUnitList = _unitOfWork.MeasurementUnit.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });    
                MeasurementTagVM.MeasurementPrefixList = _unitOfWork.MeasurementPrefix.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(MeasurementTagVM);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<MeasurementTag> objMeasurementTagList = _unitOfWork.MeasurementTag.GetAll(includeProperties: "Camera,MeasurementUnit,MeasurementPrefix").ToList();
            return Json(new { data = objMeasurementTagList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var MeasurementTagToBeDeleted = _unitOfWork.MeasurementTag.Get(u => u.Id == id);
            if (MeasurementTagToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            string MeasurementTagPath = @"images\MeasurementTags\MeasurementTag-" + id;
            string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, MeasurementTagPath);

            if (Directory.Exists(finalPath)) {
                string[] filePaths = Directory.GetFiles(finalPath);
                foreach (string filePath in filePaths) {
                    System.IO.File.Delete(filePath);
                }

                Directory.Delete(finalPath);
            }


            _unitOfWork.MeasurementTag.Remove(MeasurementTagToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
