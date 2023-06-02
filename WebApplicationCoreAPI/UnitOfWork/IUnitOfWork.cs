﻿using UnitOfWork.DataAccess.Interface;
using UnitOfWork.DataAccess.Repository;

namespace WebApplicationCoreAPI.UnitOfWork
{
    public interface IUnitOfWork
    {
        //ProductRepository _products { get; }

       public IEmployeerRepository _employeer { get; }
        int Save();
    }
}
