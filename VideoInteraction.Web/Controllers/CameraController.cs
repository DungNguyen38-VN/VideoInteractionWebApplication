using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
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
        [HttpPost]
        public IActionResult ImportExcel(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                TempData["Error"] = "Please select a valid Excel file.";
                return RedirectToAction("Index");
            }
            try
            {

                using (var stream = new MemoryStream())
                {
                    file.CopyTo(stream);

                    using (var package = new ExcelPackage(stream))
                    {
                        var worksheet = package.Workbook.Worksheets[0];
                        var rowCount = worksheet.Dimension.Rows;
                        List<Camera> cameras = new List<Camera>();
                        for (int row = 2; row <= rowCount; row++)
                        {
                            var cameraName = worksheet.Cells[row, 1].Value?.ToString();
                            var cameraCode = worksheet.Cells[row, 2].Value?.ToString();
                            var cameraIp = worksheet.Cells[row, 3].Value?.ToString();
                            var l1controlId = worksheet.Cells[row, 4].Value?.ToString();
                            var existedCamera = _unitOfWork.Camera.Get(e => e.CameraCode == cameraCode);
                            if (existedCamera != null)
                            {
                                TempData["error"] = $"相机代号 '{cameraCode}' 已经存在，无法新增";
                                return RedirectToAction("Index");
                            }

                            Camera newCam = new Camera()
                            {
                                Name = cameraName,
                                CameraCode = cameraCode,
                                CameraIp=cameraIp,
                                L1ControlId=int.Parse(l1controlId),
                                CreatedTs = DateTime.Now,
                                
                            };
                            cameras.Add(newCam);
                        }
                        _unitOfWork.Camera.AddRange(cameras);
                        _unitOfWork.Save();
                    }
                }

                //_unitOfWork.Save();
                TempData["Success"] = "Equipment data imported successfully!";


            }
            catch (Exception ex)
            {
                TempData["success"] = $"Import excel error: {ex.Message}";
            }
            return RedirectToAction("Index");
        }
    }
}
