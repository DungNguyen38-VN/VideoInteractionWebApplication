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
        public ICameraControlTagRepository CameraControlTag { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Camera = new CameraRepository(_db);
            CameraControlTag = new CameraControlTagRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
