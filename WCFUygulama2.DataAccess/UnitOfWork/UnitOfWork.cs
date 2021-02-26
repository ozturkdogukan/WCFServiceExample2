using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFUygulama2.Data.Database;
using WCFUygulama2.DataAccess.Repository;

namespace WCFUygulama2.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected ticaretEntities _context;
        public UnitOfWork(ticaretEntities context)
        {

            if (context == null)
            {
                context = new ticaretEntities();
            }

            _context = context;
        }
        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_context);
        }
    }
}
