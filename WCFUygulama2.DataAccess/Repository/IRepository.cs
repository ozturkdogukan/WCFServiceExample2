using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WCFUygulama2.DataAccess.Repository
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);

        void Del(T entity);

        void Update(T entity);

        T Get(int id);

        List<T> GetAll();


    }
}
