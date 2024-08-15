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
    public class MeasurementPrefixRepository : Repository<MeasurementPrefix>, IMeasurementPrefixRepository
    {
        private ApplicationDbContext _db;
        public MeasurementPrefixRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(MeasurementPrefix obj)
        {
            _db.measurementPrefixes.Update(obj);
        }
    }
}
