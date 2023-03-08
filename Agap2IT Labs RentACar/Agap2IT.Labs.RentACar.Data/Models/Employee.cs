using System;
using System.Collections.Generic;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Nif { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Login { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public Guid Salt { get; set; }
}
