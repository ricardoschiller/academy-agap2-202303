using Agap2IT.Labs.RentACar.Data.Models;
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
