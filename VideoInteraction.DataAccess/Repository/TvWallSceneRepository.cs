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
    public class TvWallSceneRepository : Repository<TvWallScene>, ITvWallSceneRepository
    {
        private ApplicationDbContext _db;
        public TvWallSceneRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(TvWallScene obj)
        {
            _db.TvWallScenes.Update(obj);
        }
    }
}
