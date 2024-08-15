﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInteraction.Models;

namespace VideoInteraction.DataAccess.Repository.IRepository
{
    public interface ICameraControlTagRepository : IRepository<CameraControlTag>
    {
        void Update(CameraControlTag obj);
    }
}