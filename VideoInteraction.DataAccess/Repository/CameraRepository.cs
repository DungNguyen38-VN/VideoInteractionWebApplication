using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.DataAccess.Data;
using VideoInteraction.DataAccess.Repository.IRepository;
using VideoInteraction.Models;
using VideoInteraction.DataAccess.Repository;

namespace VideoInteraction.DataAccess.Repository
{
    public class CameraRepository : Repository<Camera>, ICameraRepository
    {
        private ApplicationDbContext _db;
        public CameraRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(Camera obj)
        {
            _db.Cameras.Update(obj);
        }
    }
}
