using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;

namespace VideoInteraction.Web.Controllers
{
    public class ShowStringParamController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ShowStringParamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<ShowStringParam> objShowStringParamList = _unitOfWork.ShowStringParam.GetAll().ToList();
            return View(objShowStringParamList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ShowStringParam obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ShowStringParam.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "ShowStringParam created successfully";
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
            ShowStringParam? ShowStringParamFromDb = _unitOfWork.ShowStringParam.Get(u => u.Id == id);
            //ShowStringParam? ShowStringParamFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //ShowStringParam? ShowStringParamFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (ShowStringParamFromDb == null)
            {
                return NotFound();
            }
            return View(ShowStringParamFromDb);
        }
        [HttpPost]
        public IActionResult Edit(ShowStringParam obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ShowStringParam.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "ShowStringParam updated successfully";
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
            ShowStringParam? ShowStringParamFromDb = _unitOfWork.ShowStringParam.Get(u => u.Id == id);

            if (ShowStringParamFromDb == null)
            {
                return NotFound();
            }
            return View(ShowStringParamFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            ShowStringParam? obj = _unitOfWork.ShowStringParam.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.ShowStringParam.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "ShowStringParam deleted successfully";
            return RedirectToAction("Index");
        }

    }
}
