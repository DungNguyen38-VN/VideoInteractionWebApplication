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
    public class ControlWindowTagRepository : Repository<ControlWindowTag>, IControlWindowTagRepository
    {
        private ApplicationDbContext _db;
        public ControlWindowTagRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ControlWindowTag obj)
        {
            var objFromDb = _db.ControlWindowTags.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.TagName = obj.TagName;
                objFromDb.Description = obj.Description;
                objFromDb.WindowId = obj.WindowId;
                objFromDb.UpdatedTs = DateTime.Now;
            }
        }
    }
}
