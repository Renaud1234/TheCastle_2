﻿using System.Linq;
using System.Threading.Tasks;
using TheCastle.Domain.Entities.Base;

namespace TheCastle.Application.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : BaseEntity
    {
        Task Create(TEntity entity);
        Task Delete(int id);
        Task Delete(TEntity entity);
        bool EntityExist(int id);
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetOne(int? id);
        Task Update(TEntity entity);
    }
}