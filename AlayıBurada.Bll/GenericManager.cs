﻿using AlayıBurada.Dal.Abstract;
using AlayıBurada.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AlayıBurada.Bll
{
    public abstract class GenericManager<T> : IGenericService<T> where T:class
    {

        private readonly IGenericRepository<T> genericRepository;

        public GenericManager(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public T Add(T entity)
        {
            return genericRepository.Add(entity); //bll ile dal bağlantısı için
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                genericRepository.Dispose();
            }
        }

        public T Get(int id)
        {
            return genericRepository.Get(id); 
        }

        public List<T> GetAll()
        {
            return genericRepository.GetAll();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return genericRepository.GetAll(predicate);
        }

        public bool Remove(int id)
        {
            return genericRepository.Remove(id);
        }

        public bool Remove(T entity)
        {
            return genericRepository.Remove(entity);
        }

        public T Update(T entity)
        {
            return genericRepository.Update(entity);
        }
    }
}
