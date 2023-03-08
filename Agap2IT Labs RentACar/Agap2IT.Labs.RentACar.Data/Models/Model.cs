using System;
using System.Collections.Generic;

namespace Agap2IT.Labs.RentACar.Data.Models;

public partial class Model
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Car> Cars { get; } = new List<Car>();

    public virtual ICollection<ModelColor> ModelColors { get; } = new List<ModelColor>();
}
