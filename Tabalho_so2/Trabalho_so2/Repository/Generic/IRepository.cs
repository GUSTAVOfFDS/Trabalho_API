﻿using Tabalho_so2.Model;
using Tabalho_so2.Model.Base;
using System.Collections.Generic;

namespace Tabalho_so2.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
