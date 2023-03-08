using Agap2IT.Labs.RentACar.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Dal
{
    public class GenericDao
    {
        public async Task Add<T>(T entity) where T: class
        {
            var context = new Academy202303Context();

            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update<T>(T entity) where T: class
        {
            var context = new Academy202303Context();

            context.Set<T>().Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete<T>(T entity) where T : class
        {
            var context = new Academy202303Context();

            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<T> Get<T>(int id) where T : class
        {
            var context = new Academy202303Context();
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> GetAll<T>() where T : class
        {
            var context = new Academy202303Context();
            return await context.Set<T>().ToListAsync();
        }
    }
}
