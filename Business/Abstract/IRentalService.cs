﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IBaseService<Rental>
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
        IDataResult<Rental> GetIdByRentalDetails(int carId, int customerId, DateTime rentStartDate, DateTime rentEndDate, DateTime? ReturnDate);
       
    }
}
