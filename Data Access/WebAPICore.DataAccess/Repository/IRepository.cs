using System.Collections.Generic; 
using System;
using WebAPICore.DataModel.Models;

namespace WebAPICore.DataAccess.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
         IEnumerable<T> GetAll();
         T Get(Guid Id);
         void Insert(T entity);
         void Update(T entity);
         void Delete(T entity);
    }
}