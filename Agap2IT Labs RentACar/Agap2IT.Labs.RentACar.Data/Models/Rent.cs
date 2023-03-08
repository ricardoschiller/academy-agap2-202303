using System;
using System.Collections.Generic;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class Rent
{
    public int Id { get; set; }

    public int CarId { get; set; }

    public int ClientId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? FinishDate { get; set; }

    public decimal? Price { get; set; }

    public virtual Car Car { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;
}
