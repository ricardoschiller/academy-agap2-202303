using Agap2IT.Labs.RentACar.Data.Models;
using Agap2IT.Labs.RentACar.Data.Pocos.Renting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Business
{
    public class RentingSpecialBO : IRentingBO
    {
        public async Task<OpResult<ClientPoco>> GetClientById(int id)
        {
            Console.WriteLine("Get client by id called");
            return new OpResult<ClientPoco>(new Exception());
        }

        public async Task<OpResult> RegisterCarRent(Client client, Car car)
        {
            Console.WriteLine("Register car rent called");
            return new OpResult();
        }
    }
}
