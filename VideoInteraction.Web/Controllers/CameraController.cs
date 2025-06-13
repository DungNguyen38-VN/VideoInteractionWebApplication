using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
            List<Camera> objCameraList = _unitOfWork.Camera.GetAll(includeProperties: "ShowStringParam").OrderBy(c => c.L1ControlId).ToList();
            return View(objCameraList);
        }

        public IActionResult Create()
        {
            ViewBag.ShowStringParamList = _unitOfWork.ShowStringParam.GetAll()
                .Select(s => new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.Name // hoặc s.Description tùy bạn
                }).ToList();
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
            ViewBag.ShowStringParamList = _unitOfWork.ShowStringParam.GetAll()
    .Select(s => new SelectListItem
    {
        Value = s.Id.ToString(),
        Text = s.Name // hoặc s.Description tùy bạn
    }).ToList();
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
        public IActionResult DownloadVideo(int? id)
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
        public IActionResult DownloadVideo(Camera obj,DateTime startTime, DateTime endTime)
        {
            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    Console.WriteLine($"Field: {state.Key}, Error: {error.ErrorMessage}");
                }
            }

            if (ModelState.IsValid)
            {
                CameraVideoDownload videoDownload = new CameraVideoDownload();
                videoDownload.StartTime = startTime;
                videoDownload.EndTime = endTime;
                videoDownload.Name= obj.CameraCode;
                videoDownload.CreatedTs = DateTime.Now;
                videoDownload.CameraId = obj.Id;
                videoDownload.Flag = 0;
                videoDownload.Type = 0;
                videoDownload.FileName = obj.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");


                _unitOfWork.CameraVideoDownload.Add(videoDownload);
                _unitOfWork.Save();
                TempData["success"] = "Camera download added successfully";
                return RedirectToAction("Index");
            }
            return View();

        }
        //public IActionResult TestAlarm(int? id)
        //{
        //    if (id == null || id == 0)
        //    {
        //        return NotFound();
        //    }
        //    Camera? CameraFromDb = _unitOfWork.Camera.Get(u => u.Id == id);
        //    //Camera? CameraFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
        //    //Camera? CameraFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

        //    if (CameraFromDb == null)
        //    {
        //        return NotFound();
        //    }
            
        //    return View(CameraFromDb);
        //}

        public IActionResult TestAlarm(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Camera? obj = _unitOfWork.Camera.Get(u => u.Id == id);
            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    Console.WriteLine($"Field: {state.Key}, Error: {error.ErrorMessage}");
                }
            }

            if (ModelState.IsValid)
            {
                CameraVideoDownload videoDownload = new CameraVideoDownload();
                videoDownload.StartTime = DateTime.Now;
                videoDownload.EndTime = DateTime.Now.AddMinutes(3);
                videoDownload.Name= obj.CameraCode;
                videoDownload.CreatedTs = DateTime.Now;
                videoDownload.CameraId = obj.Id;
                videoDownload.Flag = 3;
                videoDownload.Type = 1;
                videoDownload.FileName = obj.Name + "_" + DateTime.Now.ToString("yyyyMMddHHmmss");


                _unitOfWork.CameraVideoDownload.Add(videoDownload);
                _unitOfWork.Save();
                TempData["success"] = "Camera download added successfully";
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
                                CameraIp = cameraIp,
                                L1ControlId = int.Parse(l1controlId),
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
        }  [HttpPost]
        public IActionResult ImportUpdateExcel(IFormFile file)
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
                            var cameraCode = worksheet.Cells[row, 1].Value?.ToString();
                            var cameraIp = worksheet.Cells[row, 2].Value?.ToString();
                            var existedCamera = _unitOfWork.Camera.Get(e => e.CameraIp == cameraIp);
                            if (existedCamera == null)
                            {
                                TempData["error"] = $"相机IP '{cameraIp}' 不存在，无法更新";
                            }
                            else
                            {
                                existedCamera.CameraCode = cameraCode;
                                _unitOfWork.Camera.Update(existedCamera);
                            }
                            
                        }
                        _unitOfWork.Save();
                    }
                }

                //_unitOfWork.Save();
                TempData["Success"] = "Camera data update imported successfully!";
            }
            catch (Exception ex)
            {
                TempData["success"] = $"Import excel error: {ex.Message}";
            }
            return RedirectToAction("Index");
        }
    }
}
