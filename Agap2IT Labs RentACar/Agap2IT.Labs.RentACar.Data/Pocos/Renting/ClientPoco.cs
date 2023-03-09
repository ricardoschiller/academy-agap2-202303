using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agap2IT.Labs.RentACar.Data.Pocos.Renting
{
    public class ClientPoco
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Nif { get; set; } = null!;

        public string LicenseNumber { get; set; } = null!;
    }
}
