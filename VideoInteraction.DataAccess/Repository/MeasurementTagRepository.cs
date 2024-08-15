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
    public class MeasurementTagRepository : Repository<MeasurementTag>, IMeasurementTagRepository
    {
        private ApplicationDbContext _db;
        public MeasurementTagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(MeasurementTag obj)
        {
            var objFromDb = _db.MeasurementTags.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.DisplayOrder = obj.DisplayOrder;
                objFromDb.MeasureTagName = obj.MeasureTagName;
                objFromDb.TagDescription = obj.TagDescription;
                objFromDb.CameraId = obj.CameraId;
                objFromDb.MeasurementUnitId = obj.MeasurementUnitId;
                objFromDb.MeasurementPrefixId = obj.MeasurementPrefixId;
                objFromDb.UpdatedTs = DateTime.Now;
            }
        }
    }
}
