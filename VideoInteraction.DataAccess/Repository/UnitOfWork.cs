using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.DataAccess.Data;
using VideoInteraction.DataAccess.Repository;
using VideoInteraction.DataAccess.Repository.IRepository;
namespace VideoInteraction.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public ICameraRepository Camera { get; private set; }
        public IWindowRepository  Window { get; private set; }
        public ICameraControlTagRepository CameraControlTag { get; private set; }
        public IMeasurementUnitRepository MeasurementUnit { get; private set; }
        public IMeasurementPrefixRepository MeasurementPrefix { get; private set; }
        public IMeasurementTagRepository MeasurementTag { get; private set; }
        public IControlWindowTagRepository ControlWindowTag { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Camera = new CameraRepository(_db);
            Window = new WindowRepository(_db);
            CameraControlTag = new CameraControlTagRepository(_db);
            MeasurementUnit = new MeasurementUnitRepository(_db);
            MeasurementPrefix = new MeasurementPrefixRepository(_db);
            MeasurementTag = new MeasurementTagRepository(_db);
            ControlWindowTag = new ControlWindowTagRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
