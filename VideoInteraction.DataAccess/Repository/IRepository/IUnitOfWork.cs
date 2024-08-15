using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoInteraction.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICameraRepository Camera { get; }
        ICameraControlTagRepository CameraControlTag { get; }
        void Save();
    }
}
