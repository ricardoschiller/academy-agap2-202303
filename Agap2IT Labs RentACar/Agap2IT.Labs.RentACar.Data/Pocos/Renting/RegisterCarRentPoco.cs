using Agap2IT.Labs.RentACar.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Data.Pocos.Renting
{
    public class RegisterCarRentPoco
    {
        public Client Client { get; set; }
        public Car Car { get; set; }
    }
}
