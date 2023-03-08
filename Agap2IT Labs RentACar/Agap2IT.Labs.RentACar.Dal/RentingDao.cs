using Agap2IT.Labs.RentACar.Data.Models;
using Agap2IT.Labs.RentACar.Data.Pocos.Renting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Dal
{
    public class RentingDao
    {
        public async  Task<List<MyFirstPoco>> FindRedCarsRentedByClient(string colorName)
        {
            var context = new Academy202303Context();

            var query = (from rent in context.Rents
                         join car in context.Cars on rent.CarId equals car.Id
                         join color in context.Colors on car.ColorId equals color.Id
                         where color.Name == colorName
                         select new MyFirstPoco
                         {
                             CarId = car.Id,
                             ColorName = color.Name,
                             License = car.License
                         }) ;

            var cars = await query.ToListAsync();
            return cars;
        }

        public async Task<List<Car>> GetCarsRentedByClientId(int id)
        {
            var context = new Academy202303Context();

            var query = (from rent in context.Rents
                         join car in context.Cars on rent.CarId equals car.Id
                         where rent.ClientId == id
                         select car);

            var cars = await query.ToListAsync();

            return cars;
        }
    }
}
