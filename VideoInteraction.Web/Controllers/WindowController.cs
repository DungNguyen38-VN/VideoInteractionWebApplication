using Microsoft.AspNetCore.Mvc;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;

namespace VideoInteraction.Web.Controllers
{
    public class WindowController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public WindowController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Window> objWindowList = _unitOfWork.Window.GetAll().ToList();
            return View(objWindowList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Window obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Window.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Window created successfully";
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
            Window? WindowFromDb = _unitOfWork.Window.Get(u => u.Id == id);
            //Window? WindowFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //Window? WindowFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (WindowFromDb == null)
            {
                return NotFound();
            }
            return View(WindowFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Window obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Window.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Window updated successfully";
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
            Window? WindowFromDb = _unitOfWork.Window.Get(u => u.Id == id);

            if (WindowFromDb == null)
            {
                return NotFound();
            }
            return View(WindowFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Window? obj = _unitOfWork.Window.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Window.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Window deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
