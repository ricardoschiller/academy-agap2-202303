using Agap2IT.Labs.RentACar.Data.Models;
using Agap2IT.Labs.RentACar.Data.Pocos.Renting;

namespace Agap2IT.Labs.RentACar.Business
{
    public interface IRentingBO
    {
        Task<OpResult<ClientPoco>> GetClientById(int id);
        Task<OpResult> RegisterCarRent(Client client, Car car);
    }
}