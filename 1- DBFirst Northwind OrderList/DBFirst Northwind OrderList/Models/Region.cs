using System;
using System.Collections.Generic;

namespace Enes_Kurt_Odev___24._04._2023.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
