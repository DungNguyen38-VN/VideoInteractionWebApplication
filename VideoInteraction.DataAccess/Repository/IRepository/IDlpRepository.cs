using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.Models;
using VideoInteraction.Models.HIK;


namespace VideoInteraction.DataAccess.Repository.IRepository
{
    public interface IDlpRepository : IRepository<Dlp>
    {
        void Update(Dlp obj);
    }
}
