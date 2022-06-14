﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TramSchedule.Data.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Delete(T entity);

        IEnumerable<T> GetAll();

        T Get(int id);

        public void Save();
    }
}