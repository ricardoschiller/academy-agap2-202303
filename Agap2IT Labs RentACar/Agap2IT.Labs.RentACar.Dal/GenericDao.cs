using Agap2IT.Labs.RentACar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Dal
{
    public class GenericDao
    {
        public void Add<T>(T entity) where T: class
        {
            var context = new Academy202303Context();

            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update<T>(T entity) where T: class
        {
            var context = new Academy202303Context();

            context.Set<T>().Update(entity);
            context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            var context = new Academy202303Context();

            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Get<T>(int id) where T : class
        {
            var context = new Academy202303Context();
            return context.Set<T>().Find(id);
        }

        public List<T> GetAll<T>() where T : class
        {
            var context = new Academy202303Context();
            return context.Set<T>().ToList();
        }
    }
}
