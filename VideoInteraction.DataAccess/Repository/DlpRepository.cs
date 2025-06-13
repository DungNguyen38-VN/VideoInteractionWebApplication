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
using VideoInteraction.Models.HIK;

namespace VideoInteraction.DataAccess.Repository
{
    public class DlpRepository : Repository<Dlp>, IDlpRepository
    {
        private ApplicationDbContext _db;
        public DlpRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(Dlp obj)
        {
            _db.Dlps.Update(obj);
        }
    }
}
