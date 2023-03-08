using System;
using System.Collections.Generic;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class ModelColor
{
    public int Id { get; set; }

    public int ModelId { get; set; }

    public int ColorId { get; set; }

    public virtual Color Color { get; set; } = null!;

    public virtual Model Model { get; set; } = null!;
}
