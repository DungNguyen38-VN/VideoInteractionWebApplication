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
        IWindowRepository Window { get; }
        ICameraControlTagRepository CameraControlTag { get; }
        IMeasurementUnitRepository MeasurementUnit { get; }
        IMeasurementPrefixRepository MeasurementPrefix { get; }
        IMeasurementTagRepository MeasurementTag { get; }
        void Save();
    }
}
