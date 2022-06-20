using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(entity);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return sqlContext.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                return sqlContext.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(entity);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                sqlContext.Entry(entity).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}