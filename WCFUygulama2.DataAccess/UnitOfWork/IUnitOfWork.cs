using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFUygulama2.DataAccess.Repository;

namespace WCFUygulama2.DataAccess.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<T> GetRepository<T>() where T : class;

        int Complete();


    }
}
