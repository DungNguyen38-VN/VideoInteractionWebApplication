using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.DataAccess.Data;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;


namespace VideoInteraction.DataAccess.Repository
{
    public class CameraVideoDownloadRepository : Repository<CameraVideoDownload>, ICameraVideoDownloadRepository
    {
        private ApplicationDbContext _db;
        public CameraVideoDownloadRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CameraVideoDownload obj)
        {
            var objFromDb = _db.CameraVideoDownloads.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.StartTime = obj.StartTime;
                objFromDb.EndTime = obj.EndTime;
                objFromDb.CameraId = obj.CameraId;
                objFromDb.Flag = obj.Flag;
                objFromDb.CreatedTs = DateTime.Now;
                objFromDb.FileName = obj.FileName;
            }
        }
    }
}
