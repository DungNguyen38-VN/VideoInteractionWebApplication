using Microsoft.AspNetCore.Mvc;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;

namespace VideoInteraction.Web.Controllers
{
    public class AlarmMessageController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public AlarmMessageController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<AlarmMessage> objAlarmMessageList = _unitOfWork.AlarmMessage.GetAll().ToList();
            return View(objAlarmMessageList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(AlarmMessage obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.AlarmMessage.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "AlarmMessage created successfully";
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
            AlarmMessage? AlarmMessageFromDb = _unitOfWork.AlarmMessage.Get(u => u.Id == id);

            if (AlarmMessageFromDb == null)
            {
                return NotFound();
            }
            return View(AlarmMessageFromDb);
        }
        [HttpPost]
        public IActionResult Edit(AlarmMessage obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.AlarmMessage.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "AlarmMessage updated successfully";
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
            AlarmMessage? AlarmMessageFromDb = _unitOfWork.AlarmMessage.Get(u => u.Id == id);

            if (AlarmMessageFromDb == null)
            {
                return NotFound();
            }
            return View(AlarmMessageFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            AlarmMessage? obj = _unitOfWork.AlarmMessage.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.AlarmMessage.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "AlarmMessage deleted successfully";
            return RedirectToAction("Index");
        }

    }
}
