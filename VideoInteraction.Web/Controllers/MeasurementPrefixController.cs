using Microsoft.AspNetCore.Mvc;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;

namespace VideoInteraction.Web.Controllers
{
    public class MeasurementPrefixController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MeasurementPrefixController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<MeasurementPrefix> objMeasurementPrefixList = _unitOfWork.MeasurementPrefix.GetAll().ToList();
            return View(objMeasurementPrefixList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MeasurementPrefix obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.MeasurementPrefix.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "MeasurementPrefix created successfully";
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
            MeasurementPrefix? MeasurementPrefixFromDb = _unitOfWork.MeasurementPrefix.Get(u => u.Id == id);
            //MeasurementPrefix? MeasurementPrefixFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
            //MeasurementPrefix? MeasurementPrefixFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

            if (MeasurementPrefixFromDb == null)
            {
                return NotFound();
            }
            return View(MeasurementPrefixFromDb);
        }
        [HttpPost]
        public IActionResult Edit(MeasurementPrefix obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.MeasurementPrefix.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "MeasurementPrefix updated successfully";
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
            MeasurementPrefix? MeasurementPrefixFromDb = _unitOfWork.MeasurementPrefix.Get(u => u.Id == id);

            if (MeasurementPrefixFromDb == null)
            {
                return NotFound();
            }
            return View(MeasurementPrefixFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            MeasurementPrefix? obj = _unitOfWork.MeasurementPrefix.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.MeasurementPrefix.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "MeasurementPrefix deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
