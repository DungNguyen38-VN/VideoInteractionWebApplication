using Microsoft.AspNetCore.Mvc;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;

namespace VideoInteraction.Web.Controllers
{
    public class CameraController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CameraController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Camera> objCameraList = _unitOfWork.Camera.GetAll().ToList();
            return View(objCameraList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Camera obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Camera.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Camera created successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Camera? CameraFromDb = _unitOfWork.Camera.Get(u => u.Id == id);
            //Camera? CameraFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Camera? CameraFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (CameraFromDb == null)
            {
                return NotFound();
            }
            return View(CameraFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Camera obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Camera.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Camera updated successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Camera? CameraFromDb = _unitOfWork.Camera.Get(u => u.Id == id);

            if (CameraFromDb == null)
            {
                return NotFound();
            }
            return View(CameraFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Camera? obj = _unitOfWork.Camera.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Camera.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Camera deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
