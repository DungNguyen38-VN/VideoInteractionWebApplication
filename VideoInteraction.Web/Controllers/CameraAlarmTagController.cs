using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Data;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;
using VideoInteraction.Models.ViewModels;
using VideoInteraction.Utility;

namespace VideoInteraction.Web.Controllers
{
    public class CameraAlarmTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CameraAlarmTagController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index() 
        {
            List<CameraAlarmTag> objCameraAlarmTagList = _unitOfWork.CameraAlarmTag.GetAll(includeProperties:"Camera,AlarmMessage,ShowStringParam").ToList();
            //List<CameraAlarmTag> objCameraAlarmTagList = _unitOfWork.CameraAlarmTag.GetAll().ToList();
            return View(objCameraAlarmTagList);
        }
        public IActionResult Upsert(int? id)
        {
            CameraAlarmTagVM CameraAlarmTagVM = new()
            {
                CameraList = _unitOfWork.Camera.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                AlarmMessageList = _unitOfWork.AlarmMessage.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),  
                ShowStringParamList = _unitOfWork.ShowStringParam.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                CameraAlarmTag = new CameraAlarmTag()
            };
            if (id == null || id == 0)
            {
                //create
                return View(CameraAlarmTagVM);
            }
            else
            {
                //update
                CameraAlarmTagVM.CameraAlarmTag = _unitOfWork.CameraAlarmTag.Get(u=>u.Id==id);
                return View(CameraAlarmTagVM);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(CameraAlarmTagVM CameraAlarmTagVM, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                if (CameraAlarmTagVM.CameraAlarmTag.Id == 0) {
                    _unitOfWork.CameraAlarmTag.Add(CameraAlarmTagVM.CameraAlarmTag);
                }
                else {
                    _unitOfWork.CameraAlarmTag.Update(CameraAlarmTagVM.CameraAlarmTag);
                }

                _unitOfWork.Save();
                
                TempData["success"] = "CameraAlarmTag created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                CameraAlarmTagVM.CameraList = _unitOfWork.Camera.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                CameraAlarmTagVM.AlarmMessageList = _unitOfWork.AlarmMessage.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });   
                CameraAlarmTagVM.ShowStringParamList = _unitOfWork.ShowStringParam.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(CameraAlarmTagVM);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<CameraAlarmTag> objCameraAlarmTagList = _unitOfWork.CameraAlarmTag.GetAll(includeProperties: "Camera,AlarmMessage,ShowStringParam").ToList();
            return Json(new { data = objCameraAlarmTagList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var CameraAlarmTagToBeDeleted = _unitOfWork.CameraAlarmTag.Get(u => u.Id == id);
            if (CameraAlarmTagToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            string CameraAlarmTagPath = @"images\CameraAlarmTags\CameraAlarmTag-" + id;
            string finalPath = Path.Combine(_webHostEnvironment.WebRootPath, CameraAlarmTagPath);

            if (Directory.Exists(finalPath)) {
                string[] filePaths = Directory.GetFiles(finalPath);
                foreach (string filePath in filePaths) {
                    System.IO.File.Delete(filePath);
                }

                Directory.Delete(finalPath);
            }


            _unitOfWork.CameraAlarmTag.Remove(CameraAlarmTagToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
