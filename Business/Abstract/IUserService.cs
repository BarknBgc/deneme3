﻿using System;
using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();

        IDataResult<User> GetById(int userId);

        IResult Add(User user);

        IResult Delete(User user);

        IResult Update(User user);

        IDataResult<User> GetByMail(string email);

        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}

