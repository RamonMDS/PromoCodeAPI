using PromoCodeAPI.Domain.Entities;
using PromoCodeAPI.Domain.Interfaces;
using PromoCodeAPI.Infra.Context;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PromoCodeAPI.Infra.Data.Repositories
{
    public class PromoCodeRepository<T> : IPromoCodeRepository<T> where T : Entity
    {
        private readonly ContextSqlLite _context;
        public PromoCodeRepository(ContextSqlLite context)
        {
            _context = context;

        }
        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        public IList<T> Select()
        {
            return _context.Set<T>().ToList();
        }

        public T Select(int id)
        {
            return _context.Set<T>().Find(id);
        }

    }
}
