using System;
using System.Collections.Generic;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Nif { get; set; } = null!;

    public string? Cellphone { get; set; }

    public string Address { get; set; } = null!;

    public string LicenseNumber { get; set; } = null!;

    public virtual ICollection<Rent> Rents { get; } = new List<Rent>();
}
