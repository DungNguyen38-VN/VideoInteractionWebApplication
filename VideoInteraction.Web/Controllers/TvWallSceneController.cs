using Microsoft.AspNetCore.Mvc;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;
using VideoInteraction.Models.DTO;
using VideoInteraction.Models.ViewModels;

namespace VideoInteraction.Web.Controllers
{
    public class TvWallSceneController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly TvWallApiCaller _tvWallApiCaller;
        public TvWallSceneController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            //_tvWallApiCaller = tvWallApiCaller;
        }
        public IActionResult Index(int? dlpId)
        {
            List<TvWallScene> scenes = new List<TvWallScene>();
            if (dlpId.HasValue)
            {
                scenes = _unitOfWork.TvWallScene.GetAll().Where(x=>x.BelongDlpId==dlpId).ToList();
            }
            else
            {
                scenes = _unitOfWork.TvWallScene.GetAll().ToList();
            }
            var dlps = _unitOfWork.Dlp.GetAll().ToList();

            // Gán tên DLP tương ứng cho từng scene
            var sceneVMs = scenes.Select(scene => new TvWallSceneDto
            {
                Id = scene.Id,
                TvWallId = scene.TvWallId,
                SceneId = scene.SceneId,
                SceneName = scene.SceneName,
                IsDefault = scene.IsDefault,
                SceneOrder = scene.SceneOrder,
                BelongDlpId = scene.BelongDlpId,
                IsDeviceScene = scene.IsDeviceScene,
                GroupId = scene.GroupId,
                IsCurr = scene.IsCurr,
                IsActive = scene.IsActive,
                DlpName = dlps.FirstOrDefault(d => d.DlpId == scene.BelongDlpId)?.DlpName
            }).ToList();

            var vm = new TvWallSceneVM
            {
                TvWallScenes = sceneVMs,
                Dlps = dlps,
                SelectedDlpId = dlpId
            };

            return View(vm);
        }


        public IActionResult LinkageActive(int id, int? dlpId)
        {
            var tvWallScene = _unitOfWork.TvWallScene.Get(x => x.Id == id);
            if (tvWallScene != null)
            {
                tvWallScene.IsActive = true;
                _unitOfWork.TvWallScene.Update(tvWallScene);
                _unitOfWork.Save();
            }
            // Redirect về Index, giữ nguyên dlpId (nếu có)
            return RedirectToAction("Index", new { dlpId = dlpId });
        }

        public IActionResult LinkageInactive(int id, int? dlpId)
        {
            var tvWallScene = _unitOfWork.TvWallScene.Get(x => x.Id == id);
            if (tvWallScene != null)
            {
                tvWallScene.IsActive = false;
                _unitOfWork.TvWallScene.Update(tvWallScene);
                _unitOfWork.Save();
            }
            // Redirect về Index, giữ nguyên dlpId (nếu có)
            return RedirectToAction("Index", new { dlpId = dlpId });
        }


    }
}
