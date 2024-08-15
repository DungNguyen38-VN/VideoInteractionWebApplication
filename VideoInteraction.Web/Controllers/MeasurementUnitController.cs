using Microsoft.AspNetCore.Mvc;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;

namespace VideoInteraction.Web.Controllers
{
    public class MeasurementUnitController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MeasurementUnitController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<MeasurementUnit> objMeasurementUnitList = _unitOfWork.MeasurementUnit.GetAll().ToList();
            return View(objMeasurementUnitList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MeasurementUnit obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.MeasurementUnit.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "MeasurementUnit created successfully";
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
            MeasurementUnit? MeasurementUnitFromDb = _unitOfWork.MeasurementUnit.Get(u => u.Id == id);
            //MeasurementUnit? MeasurementUnitFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //MeasurementUnit? MeasurementUnitFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (MeasurementUnitFromDb == null)
            {
                return NotFound();
            }
            return View(MeasurementUnitFromDb);
        }
        [HttpPost]
        public IActionResult Edit(MeasurementUnit obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.MeasurementUnit.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "MeasurementUnit updated successfully";
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
            MeasurementUnit? MeasurementUnitFromDb = _unitOfWork.MeasurementUnit.Get(u => u.Id == id);

            if (MeasurementUnitFromDb == null)
            {
                return NotFound();
            }
            return View(MeasurementUnitFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            MeasurementUnit? obj = _unitOfWork.MeasurementUnit.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.MeasurementUnit.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "MeasurementUnit deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
