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
    public class WindowRepository : Repository<Window>, IWindowRepository
    {
        private ApplicationDbContext _db;
        public WindowRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        
        public void Update(Window obj)
        {
            _db.Windows.Update(obj);
        }
    }
}
