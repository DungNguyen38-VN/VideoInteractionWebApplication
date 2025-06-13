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
    public class CameraAlarmTagRepository : Repository<CameraAlarmTag>, ICameraAlarmTagRepository
    {
        private ApplicationDbContext _db;
        public CameraAlarmTagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CameraAlarmTag obj)
        {
            var objFromDb = _db.CameraAlarmTags.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.TagName = obj.TagName;
                objFromDb.Description = obj.Description;
                objFromDb.CameraId = obj.CameraId;
                objFromDb.AlarmMessageId = obj.AlarmMessageId;
                objFromDb.ShowStringParamId = obj.ShowStringParamId;
                objFromDb.UpdatedTs = DateTime.Now;
            }
        }
    }
}
