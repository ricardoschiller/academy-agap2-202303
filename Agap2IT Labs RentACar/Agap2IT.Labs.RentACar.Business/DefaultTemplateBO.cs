using System.Transactions;

namespace Agap2IT.Labs.RentACar.Business
{
    public class DefaultTemplateBO
    {
        public async Task<OpResult<T>> DefaultBOTemplate<T>(Func<Task<T>> genericFunc)
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted;
            transactionOptions.Timeout = TimeSpan.FromMinutes(1);

            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    var result = await genericFunc();
                    return new OpResult<T>(result);
                }
            }
            catch (Exception ex)
            {
                return new OpResult<T>(ex);
            }
        }

        public async Task<OpResult> DefaultBOTemplate(Func<Task> genericFunc)
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = IsolationLevel.ReadCommitted;
            transactionOptions.Timeout = TimeSpan.FromMinutes(1);

            try
            {
                using (var transactionScope = new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled))
                {
                    await genericFunc();

                    transactionScope.Complete();

                    return new OpResult();
                }
            }
            catch (Exception ex)
            {
                return new OpResult(ex);
            }
        }
    }
}

