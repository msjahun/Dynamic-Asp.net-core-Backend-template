﻿using Dau.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dau.Data.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Delete(T entity);
        T GetById(int id);
        void Insert(T entity);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Update(T entity);
    }
}