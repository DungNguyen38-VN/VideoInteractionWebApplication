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
    public class CameraControlTagRepository : Repository<CameraControlTag>, ICameraControlTagRepository
    {
        private ApplicationDbContext _db;
        public CameraControlTagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CameraControlTag obj)
        {
            var objFromDb = _db.CameraControlTags.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.TagName = obj.TagName;
                objFromDb.Description = obj.Description;
                objFromDb.CameraId = obj.CameraId;
                objFromDb.UpdatedTs = DateTime.Now;
            }
        }
    }
}
