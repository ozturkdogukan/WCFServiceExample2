using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFUygulama2.Data.Database;
using System.Threading.Tasks;

namespace WCFUygulama2.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected ticaretEntities _context;

        public Repository(ticaretEntities context)
        {
            if (context == null)
            {
                context = new ticaretEntities();
            }
            _context = context;
        }

        // Singleton Pattern : Uygulamanın tek context veya tek connection üzerinden 
        // işlem yapmasının sağlandığı tasarım desenidir.


        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            try
            {
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
                
        }

        public void Del(T entity)
        {
            _context.Set<T>().Remove(entity);
            try
            {
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
