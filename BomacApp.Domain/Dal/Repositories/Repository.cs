using BomacApp.Domain.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BomacApp.Domain.Dal.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private readonly DbContext _context;
        private readonly DbSet<TEntity> DbSet;

        public Repository(DbContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }


        public TEntity Get(int id)
        {

            return DbSet.Find(id);
        }



        public IEnumerable<TEntity> Getall()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList();
        }

        public void Add(TEntity entity)
        {
            DbSet.Add(entity);


        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            DbSet.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            DbSet.Remove(entity);

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            DbSet.RemoveRange(entities);
        }

    }
}
