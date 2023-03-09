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
    public class DefaultTemplateBO
    {
        public async Task<OpResult> DefaultTemplateBO(Action)
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted;
            transactionOptions.Timeout = TimeSpan.FromMinutes(1);

            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                return new OpResult(ex);
            }
        }
    }
}

