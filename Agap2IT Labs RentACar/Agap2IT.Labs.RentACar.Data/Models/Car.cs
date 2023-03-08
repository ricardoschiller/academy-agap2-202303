using System;
using System.Collections.Generic;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class Car
{
    public int Id { get; set; }

    public int ModelId { get; set; }

    public string License { get; set; } = null!;

    public string Brand { get; set; } = null!;

    public int ColorId { get; set; }

    public DateTime BuildDate { get; set; }

    public string Observations { get; set; }

    public virtual Color Color { get; set; } = null!;

    public virtual Model Model { get; set; } = null!;

    public virtual ICollection<Rent> Rents { get; } = new List<Rent>();
}
