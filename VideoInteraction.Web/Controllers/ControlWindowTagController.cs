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
    public class ControlWindowTagController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ControlWindowTagController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index() 
        {
            List<ControlWindowTag> objControlWindowTagList = _unitOfWork.ControlWindowTag.GetAll(includeProperties:"Window").ToList();
            return View(objControlWindowTagList);
        }
        public IActionResult Upsert(int? id)
        {
            ControlWindowTagVM ControlWindowTagVM = new()
            {
                WindowList = _unitOfWork.Window.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                ControlWindowTag = new ControlWindowTag()
            };
            if (id == null || id == 0)
            {
                //create
                return View(ControlWindowTagVM);
            }
            else
            {
                //update
                ControlWindowTagVM.ControlWindowTag = _unitOfWork.ControlWindowTag.Get(u=>u.Id==id);
                return View(ControlWindowTagVM);
            }
            
        }
        [HttpPost]
        public IActionResult Upsert(ControlWindowTagVM ControlWindowTagVM, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                if (ControlWindowTagVM.ControlWindowTag.Id == 0) {
                    _unitOfWork.ControlWindowTag.Add(ControlWindowTagVM.ControlWindowTag);
                }
                else {
                    _unitOfWork.ControlWindowTag.Update(ControlWindowTagVM.ControlWindowTag);
                }

                _unitOfWork.Save();
                
                TempData["success"] = "CameraControlTag created/updated successfully";
                return RedirectToAction("Index");
            }
            else
            {
                ControlWindowTagVM.WindowList = _unitOfWork.Window.GetAll().Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                });
                return View(ControlWindowTagVM);
            }
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ControlWindowTag> objControlWindowTagList = _unitOfWork.ControlWindowTag.GetAll(includeProperties: "Window").ToList();
            return Json(new { data = objControlWindowTagList });
        }


        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var ControlWindowTagToBeDeleted = _unitOfWork.ControlWindowTag.Get(u => u.Id == id);
            if (ControlWindowTagToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.ControlWindowTag.Remove(ControlWindowTagToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}
