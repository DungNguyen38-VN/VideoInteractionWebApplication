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
    public class MeasurementUnitRepository : Repository<MeasurementUnit>, IMeasurementUnitRepository
    {
        private ApplicationDbContext _db;
        public MeasurementUnitRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(MeasurementUnit obj)
        {
            _db.MeasurementUnits.Update(obj);
        }
    }
}
