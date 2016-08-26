namespace ProgramistaNorthwind.EF.Repository
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;

    public abstract class BaseRepository<T>
        where T: class
    {
        protected NorthwindContext Context { get; set; }

        public BaseRepository(NorthwindContext context)
        {
            Context = context;
        }


        public ICollection<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        //public T Get(int id)
        //{
        //    return Context.Set<T>().Find(id);
        //}

        //public async Task<T> GetAsync(int id)
        //{
        //    return await Context.Set<T>().FindAsync(id);
        //}

        public T Find(Expression<Func<T, bool>> match)
        {
            return Context.Set<T>().SingleOrDefault(match);
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await Context.Set<T>().SingleOrDefaultAsync(match);
        }

        public ICollection<T> FindAll(Expression<Func<T, bool>> match)
        {
            return Context.Set<T>().Where(match).ToList();
        }

        public async Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await Context.Set<T>().Where(match).ToListAsync();
        }

        public T Add(T t)
        {
            Context.Set<T>().Add(t);
            Context.SaveChanges();
            return t;
        }

        public async Task<T> AddAsync(T t)
        {
            Context.Set<T>().Add(t);
            await Context.SaveChangesAsync();
            return t;
        }

        //public T Update(T updated, int key)
        //{
        //    if (updated == null)
        //        return null;

        //    T existing = Context.Set<T>().Find(key);
        //    if (existing != null)
        //    {
        //        Context.Entry(existing).CurrentValues.SetValues(updated);
        //        Context.SaveChanges();
        //    }
        //    return existing;
        //}

        //public async Task<T> UpdateAsync(T updated, int key)
        //{
        //    if (updated == null)
        //        return null;

        //    T existing = await Context.Set<T>().FindAsync(key);
        //    if (existing != null)
        //    {
        //        Context.Entry(existing).CurrentValues.SetValues(updated);
        //        await Context.SaveChangesAsync();
        //    }
        //    return existing;
        //}

        public void Delete(T t)
        {
            Context.Set<T>().Remove(t);
            Context.SaveChanges();
        }

        public async Task<int> DeleteAsync(T t)
        {
            Context.Set<T>().Remove(t);
            return await Context.SaveChangesAsync();
        }

        public int Count()
        {
            return Context.Set<T>().Count();
        }

        public async Task<int> CountAsync()
        {
            return await Context.Set<T>().CountAsync();
        }

    }
}
