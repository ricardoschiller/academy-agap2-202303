using Agap2IT.Labs.RentACar.Business;
using Agap2IT.Labs.RentACar.Data.Models;
using Agap2IT.Labs.RentACar.Data.Pocos.Renting;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Agap2IT.Labs.RentACar.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentingController : ControllerBase
    {

        private IRentingBO _rentingBO;

        public RentingController(IRentingBO rentingBO)
        {
            _rentingBO = rentingBO;
        }


        [HttpGet("GetClientById")]
        public async Task<ActionResult> GetClientById(int clientId)
        {
            var opResult = await _rentingBO.GetClientById(clientId);

            if(opResult.HasSucceeded)
            {
                return Ok(opResult.Result);
            }
            else
            {
                return NotFound($"Client id {clientId} not found");
            }
        }


        [HttpPost("RegisterCarRent")]
        public async Task<ActionResult> RegisterCarRent(RegisterCarRentPoco poco)
        {

            var opResult = await _rentingBO.RegisterCarRent(poco.Client, poco.Car);

            if(opResult.HasSucceeded)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
