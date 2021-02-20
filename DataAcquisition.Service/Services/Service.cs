﻿using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcquisition.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IUnitOfWork UnitOfWork;
        private readonly IRepository<T> _repository;

        public Service(IUnitOfWork unitOfWork, IRepository<T> repository)
        {
            UnitOfWork = unitOfWork;
            _repository = repository;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await UnitOfWork.CommitAsync();

            return entity;
        }

        public async Task<List<T>> AddRangeAsync(List<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await UnitOfWork.CommitAsync();

            return entities;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Remove(T entity)
        {
            _repository.Remove(entity);
            UnitOfWork.Commit();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            UnitOfWork.Commit();
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.SingleOrDefaultAsync(predicate);
        }

        public T Update(T entity)
        {
            var updatedEntity = _repository.Update(entity);
            UnitOfWork.Commit();

            return updatedEntity;
        }

        public async Task<IEnumerable<T>> WhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await _repository.WhereAsync(predicate);
        }
    }
}