﻿using Agap2IT.Labs.RentACar.Dal;
using Agap2IT.Labs.RentACar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Agap2IT.Labs.RentACar.Business
{
    public class RentingBO : DefaultTemplateBO
    {
        public async Task<OpResult> RegisterCarRent(Client client, Car car)
        {
            return await DefaultBOTemplate(async () =>
            {
                var dao = new GenericDao();
                await dao.Add(client);

                var rent = new Rent
                {
                    CarId = car.Id,
                    ClientId = client.Id,
                    StartDate = DateTime.UtcNow,
                };

                await dao.Add(rent);
            });

        }

        public async Task<OpResult<Client>> GetClientById(int id)
        {

            return await DefaultBOTemplate<Client>(async () =>
            {
                var dao = new GenericDao();
                var result = await dao.Get<Client>(id);
                return result;
            });

        }
    }
}
