﻿using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAcquisition.Core.Interfaces.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public IEnumerable<T> Where(Expression<System.Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public async Task<IEnumerable<T>> GetAllUsersByOrganizationIdAsync(int id)
        {
            return await _dbSet.ToListAsync();
        }

        public void Remove(T entity)
        {
            _dbSet.Remove((entity));
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange((entities));
        }

        public async Task<T> SingleOrDefaultAsync(Expression<System.Func<T, bool>> predicate)
        {
            return await _dbSet.SingleOrDefaultAsync(predicate);
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }
    }
}