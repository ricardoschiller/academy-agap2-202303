using Agap2IT.Labs.RentACar.Dal;
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
    public class RentingBO
    {
        public async Task<OpResult> RegisterCarRent(Client client, Car car)
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted;
            transactionOptions.Timeout = TimeSpan.FromMinutes(1);

            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
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

                    transactionScope.Complete();
                    return new OpResult();
                }
            }
            catch(Exception ex)
            {
                return new OpResult(ex);
            }
        }

        public async Task<OpResult<Client>> GetClientById(int id)
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted;
            transactionOptions.Timeout = TimeSpan.FromMinutes(1);

            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    var dao = new GenericDao();

                    var result = await dao.Get<Client>(id);

                    transactionScope.Complete();

                    return new OpResult<Client>(result);
                }
            }
            catch (Exception ex)
            {
                return new OpResult<Client>(ex);
            }
        }
    }
}
