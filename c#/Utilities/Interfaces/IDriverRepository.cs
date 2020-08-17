﻿using System.Collections.Generic;
using eticketing_mvc.ModelDTOs;
using eticketing_mvc.Models;

namespace eticketing_mvc.Utilities.Interfaces
{
    public interface IDriverRepository : IGenericRepository<Driver, DriverDto>
    {
        IEnumerable<DriverDto> GetAllDrivers();
    }
}
