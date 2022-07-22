using DataAccessLayer.Abstract;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T>  _object;

        public Repository()
        {
            _object = c.Set<T>();
        }
        public int delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T Get(int id)
        {
            return _object.Find(id);
        }

        public int insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int update(T p)
        {
            return c.SaveChanges();
        }
    }
}
