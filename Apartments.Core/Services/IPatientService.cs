﻿using Apartments.Entitise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartments.Core.Services
{
    public interface IPatientService
    {
        public List<patient> GetList();
    }
}
